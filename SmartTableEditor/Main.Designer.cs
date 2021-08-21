
namespace SmartTableEditor
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.pictureBoxLogoCenter = new System.Windows.Forms.PictureBox();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.btnFullResize = new System.Windows.Forms.Button();
            this.btnShowColors = new System.Windows.Forms.Button();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.panelShowTable = new System.Windows.Forms.Panel();
            this.panelRigth = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelShowColors = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBoxLogoTop = new System.Windows.Forms.PictureBox();
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCenter)).BeginInit();
            this.panelShowTable.SuspendLayout();
            this.panelRigth.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelRigth);
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1392, 732);
            this.panelMain.TabIndex = 0;
            // 
            // pictureBoxLogoCenter
            // 
            this.pictureBoxLogoCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoCenter.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoCenter.Name = "pictureBoxLogoCenter";
            this.pictureBoxLogoCenter.Size = new System.Drawing.Size(1192, 692);
            this.pictureBoxLogoCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogoCenter.TabIndex = 0;
            this.pictureBoxLogoCenter.TabStop = false;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(59)))), ((int)(((byte)(84)))));
            this.btnCreateTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateTable.FlatAppearance.BorderSize = 0;
            this.btnCreateTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnCreateTable.Location = new System.Drawing.Point(0, 0);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCreateTable.Size = new System.Drawing.Size(200, 50);
            this.btnCreateTable.TabIndex = 1;
            this.btnCreateTable.Text = "Создание таблиц";
            this.btnCreateTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateTable.UseVisualStyleBackColor = false;
            this.btnCreateTable.Click += new System.EventHandler(this.btnCreateTable_Click);
            // 
            // btnFullResize
            // 
            this.btnFullResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnFullResize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullResize.FlatAppearance.BorderSize = 0;
            this.btnFullResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullResize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnFullResize.Location = new System.Drawing.Point(1242, 0);
            this.btnFullResize.Name = "btnFullResize";
            this.btnFullResize.Size = new System.Drawing.Size(50, 40);
            this.btnFullResize.TabIndex = 7;
            this.btnFullResize.Text = "☐";
            this.btnFullResize.UseVisualStyleBackColor = false;
            this.btnFullResize.Visible = false;
            this.btnFullResize.Click += new System.EventHandler(this.btnFullResize_Click);
            // 
            // btnShowColors
            // 
            this.btnShowColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnShowColors.FlatAppearance.BorderSize = 0;
            this.btnShowColors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowColors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnShowColors.Location = new System.Drawing.Point(0, 632);
            this.btnShowColors.Name = "btnShowColors";
            this.btnShowColors.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShowColors.Size = new System.Drawing.Size(200, 50);
            this.btnShowColors.TabIndex = 5;
            this.btnShowColors.Text = "Палитра";
            this.btnShowColors.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowColors.UseVisualStyleBackColor = true;
            this.btnShowColors.Click += new System.EventHandler(this.btnShowColors_Click);
            // 
            // btnShowTable
            // 
            this.btnShowTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShowTable.FlatAppearance.BorderSize = 0;
            this.btnShowTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnShowTable.Location = new System.Drawing.Point(0, 0);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnShowTable.Size = new System.Drawing.Size(200, 50);
            this.btnShowTable.TabIndex = 2;
            this.btnShowTable.Text = "Таблица";
            this.btnShowTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowTable.UseVisualStyleBackColor = true;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnFull
            // 
            this.btnFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnFull.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFull.FlatAppearance.BorderSize = 0;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnFull.Location = new System.Drawing.Point(1292, 0);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(50, 40);
            this.btnFull.TabIndex = 6;
            this.btnFull.Text = "☐";
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnFull_Click);
            // 
            // panelShowTable
            // 
            this.panelShowTable.Controls.Add(this.btnCreateTable);
            this.panelShowTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowTable.Location = new System.Drawing.Point(0, 50);
            this.panelShowTable.Name = "panelShowTable";
            this.panelShowTable.Size = new System.Drawing.Size(200, 92);
            this.panelShowTable.TabIndex = 3;
            this.panelShowTable.Visible = false;
            // 
            // panelRigth
            // 
            this.panelRigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.panelRigth.Controls.Add(this.pictureBoxLogoCenter);
            this.panelRigth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRigth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.panelRigth.Location = new System.Drawing.Point(200, 40);
            this.panelRigth.Name = "panelRigth";
            this.panelRigth.Size = new System.Drawing.Size(1192, 692);
            this.panelRigth.TabIndex = 8;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnShowColors);
            this.panelLeft.Controls.Add(this.panelShowColors);
            this.panelLeft.Controls.Add(this.panelShowTable);
            this.panelLeft.Controls.Add(this.btnShowTable);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 692);
            this.panelLeft.TabIndex = 7;
            // 
            // panelShowColors
            // 
            this.panelShowColors.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShowColors.Location = new System.Drawing.Point(0, 682);
            this.panelShowColors.Name = "panelShowColors";
            this.panelShowColors.Size = new System.Drawing.Size(200, 10);
            this.panelShowColors.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.pictureBoxLogoTop);
            this.panelTop.Controls.Add(this.btnCollapse);
            this.panelTop.Controls.Add(this.btnFullResize);
            this.panelTop.Controls.Add(this.btnFull);
            this.panelTop.Controls.Add(this.btnExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1392, 40);
            this.panelTop.TabIndex = 6;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTab_MouseDown);
            // 
            // pictureBoxLogoTop
            // 
            this.pictureBoxLogoTop.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxLogoTop.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoTop.Name = "pictureBoxLogoTop";
            this.pictureBoxLogoTop.Padding = new System.Windows.Forms.Padding(5, 4, 0, 0);
            this.pictureBoxLogoTop.Size = new System.Drawing.Size(64, 40);
            this.pictureBoxLogoTop.TabIndex = 9;
            this.pictureBoxLogoTop.TabStop = false;
            // 
            // btnCollapse
            // 
            this.btnCollapse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnCollapse.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCollapse.FlatAppearance.BorderSize = 0;
            this.btnCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollapse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnCollapse.Location = new System.Drawing.Point(1192, 0);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(50, 40);
            this.btnCollapse.TabIndex = 8;
            this.btnCollapse.Text = "—";
            this.btnCollapse.UseVisualStyleBackColor = false;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnExit.Location = new System.Drawing.Point(1342, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 40);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1392, 732);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoCenter)).EndInit();
            this.panelShowTable.ResumeLayout(false);
            this.panelRigth.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelRigth;
        private System.Windows.Forms.PictureBox pictureBoxLogoCenter;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button btnShowColors;
        private System.Windows.Forms.Panel panelShowColors;
        private System.Windows.Forms.Panel panelShowTable;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.PictureBox pictureBoxLogoTop;
        private System.Windows.Forms.Button btnCollapse;
        private System.Windows.Forms.Button btnFullResize;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.Button btnExit;
    }
}

