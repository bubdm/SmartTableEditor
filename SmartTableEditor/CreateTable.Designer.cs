
namespace SmartTableEditor
{
    partial class CreateTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panelClasses = new System.Windows.Forms.Panel();
            this.richTextBoxClasses = new System.Windows.Forms.RichTextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelClasses.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelLeft);
            this.panelMain.Controls.Add(this.panelClasses);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1058, 765);
            this.panelMain.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.panelWorkArea);
            this.panelLeft.Controls.Add(this.panel3);
            this.panelLeft.Controls.Add(this.panel2);
            this.panelLeft.Controls.Add(this.panel1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(858, 725);
            this.panelLeft.TabIndex = 28;
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(0, 204);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(858, 521);
            this.panelWorkArea.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerateScript);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(858, 58);
            this.panel3.TabIndex = 28;
            // 
            // btnGenerateScript
            // 
            this.btnGenerateScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnGenerateScript.FlatAppearance.BorderSize = 0;
            this.btnGenerateScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateScript.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnGenerateScript.Location = new System.Drawing.Point(16, 7);
            this.btnGenerateScript.Name = "btnGenerateScript";
            this.btnGenerateScript.Size = new System.Drawing.Size(582, 40);
            this.btnGenerateScript.TabIndex = 6;
            this.btnGenerateScript.Text = "Сформировать";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Visible = false;
            this.btnGenerateScript.Click += new System.EventHandler(this.btnGenerateScript_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnCloseTable);
            this.panel2.Controls.Add(this.btnAddField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 114);
            this.panel2.TabIndex = 27;
            this.panel2.Visible = false;
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(137, 38);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(461, 26);
            this.textBoxType.TabIndex = 3;
            this.textBoxType.Enter += new System.EventHandler(this.textBoxType_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Тип данных";
            // 
            // textBoxField
            // 
            this.textBoxField.Location = new System.Drawing.Point(137, 6);
            this.textBoxField.Name = "textBoxField";
            this.textBoxField.Size = new System.Drawing.Size(461, 26);
            this.textBoxField.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Имя поля";
            // 
            // btnCloseTable
            // 
            this.btnCloseTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnCloseTable.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseTable.FlatAppearance.BorderSize = 0;
            this.btnCloseTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnCloseTable.Location = new System.Drawing.Point(313, 71);
            this.btnCloseTable.Name = "btnCloseTable";
            this.btnCloseTable.Size = new System.Drawing.Size(285, 40);
            this.btnCloseTable.TabIndex = 5;
            this.btnCloseTable.Text = "Закрыть таблицу";
            this.btnCloseTable.UseVisualStyleBackColor = false;
            this.btnCloseTable.Click += new System.EventHandler(this.btnCloseTable_Click);
            // 
            // btnAddField
            // 
            this.btnAddField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddField.FlatAppearance.BorderSize = 0;
            this.btnAddField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddField.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddField.Location = new System.Drawing.Point(16, 71);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(285, 40);
            this.btnAddField.TabIndex = 4;
            this.btnAddField.Text = "Добавить";
            this.btnAddField.UseVisualStyleBackColor = false;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 32);
            this.panel1.TabIndex = 26;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(137, 3);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(355, 26);
            this.textBoxTable.TabIndex = 0;
            this.textBoxTable.Text = "Пациент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Имя таблицы";
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.btnAddTable.FlatAppearance.BorderSize = 0;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAddTable.Location = new System.Drawing.Point(498, 3);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(100, 26);
            this.btnAddTable.TabIndex = 1;
            this.btnAddTable.Text = "ОК";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panelClasses
            // 
            this.panelClasses.Controls.Add(this.richTextBoxClasses);
            this.panelClasses.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelClasses.Location = new System.Drawing.Point(858, 40);
            this.panelClasses.Name = "panelClasses";
            this.panelClasses.Size = new System.Drawing.Size(200, 725);
            this.panelClasses.TabIndex = 27;
            // 
            // richTextBoxClasses
            // 
            this.richTextBoxClasses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.richTextBoxClasses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxClasses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxClasses.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBoxClasses.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxClasses.Name = "richTextBoxClasses";
            this.richTextBoxClasses.Size = new System.Drawing.Size(200, 725);
            this.richTextBoxClasses.TabIndex = 0;
            this.richTextBoxClasses.Text = "";
            this.richTextBoxClasses.TextChanged += new System.EventHandler(this.richTextBoxClasses_TextChanged);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.panelTop.Controls.Add(this.btnSQL);
            this.panelTop.Controls.Add(this.btnFC);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1058, 40);
            this.panelTop.TabIndex = 1;
            // 
            // btnSQL
            // 
            this.btnSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSQL.FlatAppearance.BorderSize = 0;
            this.btnSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnSQL.Location = new System.Drawing.Point(60, 0);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(60, 40);
            this.btnSQL.TabIndex = 8;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // btnFC
            // 
            this.btnFC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFC.FlatAppearance.BorderSize = 0;
            this.btnFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnFC.Location = new System.Drawing.Point(0, 0);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(60, 40);
            this.btnFC.TabIndex = 7;
            this.btnFC.Text = "FC";
            this.btnFC.UseVisualStyleBackColor = true;
            this.btnFC.Click += new System.EventHandler(this.btnFC_Click);
            // 
            // CreateTable
            // 
            this.AcceptButton = this.btnAddField;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.CancelButton = this.btnCloseTable;
            this.ClientSize = new System.Drawing.Size(1058, 765);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTable";
            this.Text = "CreateTable";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            this.Leave += new System.EventHandler(this.CreateTable_Leave);
            this.panelMain.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelClasses.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnFC;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Panel panelClasses;
        private System.Windows.Forms.RichTextBox richTextBoxClasses;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.TextBox textBoxType;
    }
}