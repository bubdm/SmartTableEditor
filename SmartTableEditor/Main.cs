using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            Variables.Width = Width;
            Variables.Height = Height;
            Variables.Top = Top;
            Variables.Left = Left;

            Width = Screen.PrimaryScreen.Bounds.Size.Width;
            Height = Screen.PrimaryScreen.Bounds.Size.Height;
            Top = 0;
            Left = 0;

            btnFull.Visible = false;
            btnFullResize.Visible = true;
        }

        private void btnFullResize_Click(object sender, EventArgs e)
        {
            Width = Variables.Width;
            Height = Variables.Height;
            Top = Variables.Top;
            Left = Variables.Left;

            btnFull.Visible = true;
            btnFullResize.Visible = false;
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        void CustomizeDesign()
        {
            /* Подгон высоты каждой панели под кол-во кнопок */
            int btnHeight = 50;

            foreach (Panel item in panelLeft.Controls.OfType<Panel>())
            {
                item.Height = item.Controls.Count * btnHeight;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            /* При загрузке создает папки, если они отсутсвуют */
            System.IO.Directory.CreateDirectory("Resource/Settings");
            System.IO.Directory.CreateDirectory("Resource/Tables");
            System.IO.Directory.CreateDirectory("Resource/Scripts");
            CustomizeDesign();
        }

        #region Перемещение окна
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();

        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        private void panelTab_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        #endregion

        #region Кнопка для изменения размера окна
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------RECTANGULO 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));
            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);
            region.Exclude(sizeGripRectangle);
            this.panelMain.Region = region;
            this.Invalidate();
        }
        //----------------COLOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(255, 191, 76)); //255, 191, 76
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);
            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.FromArgb(29, 36, 51), sizeGripRectangle);// 29, 36, 51
        }
        #endregion

        private Form activeForm = null;
        // Открытие формы внутри формы
        private void OpenChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.BackColor = Color.FromArgb(29,36,51);
            childForm.Font = this.Font;
            childForm.ForeColor = Color.FromArgb(215,220,226);
            panelRigth.Controls.Add(childForm);
            panelRigth.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        void HideSubMenu()
        {
            foreach (Panel item in panelLeft.Controls.OfType<Panel>())
            {
                if (item.Visible)
                    item.Visible = false;
            }
        }

        void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            ShowSubMenu(panelShowTable);
        }

        private void btnShowColors_Click(object sender, EventArgs e)
        {// Подгрузка и отрисовка цветов с файла
            //string[] str_colors = File.ReadAllLines("Resource/Settings/Colors.txt");

            //for (int i = 1; i < str_colors.Length; i++)
            //{
            //    string[] _ = str_colors[i].Split(' ');
            //    this.BackColor = ColorTranslator.FromHtml(_[0]);
            //}
             
            // myForm.BackColor =  ColorTranslator.FromHtml("#626262");
            ShowSubMenu(panelShowColors);
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            OpenChildFormInPanel(new CreateTable());
            HideSubMenu();
        }
    }
}
