using SmartTableEditor.Classes.WorkWithTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor
{
    public partial class CreateTable : Form
    {
        public CreateTable()
        {
            InitializeComponent();
        }

        private void CreateTable_Load(object sender, EventArgs e)
        {
            panelTop.Width = 23;
            foreach (Button item in panelTop.Controls.Cast<Button>())
            {
                item.Width = item.Text.Count() * 30;
            }
        }

        void ShowPanels()
        {
            panel2.Visible = true;
            btnGenerateScript.Visible = true;

            panel1.Visible = false;
            textBoxField.Focus();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            ShowPanels();
            //var call_table = new WorkWithTables(_Enum.SQL);
            //call_table.workWithTables.CreateTable(textBoxTable, richTextBoxResultSQL);
        }
    }
}
