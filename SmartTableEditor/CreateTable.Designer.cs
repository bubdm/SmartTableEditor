
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGenerateScript = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.btnCloseTable = new System.Windows.Forms.Button();
            this.btnAddField = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxTable = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.panelWorkArea = new System.Windows.Forms.Panel();
            this.btnSQL = new System.Windows.Forms.Button();
            this.btnFC = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelWorkArea);
            this.panelMain.Controls.Add(this.panel3);
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1058, 765);
            this.panelMain.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(28)))), ((int)(((byte)(40)))));
            this.panelTop.Controls.Add(this.btnFC);
            this.panelTop.Controls.Add(this.btnSQL);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1058, 40);
            this.panelTop.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGenerateScript);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 58);
            this.panel3.TabIndex = 25;
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
            this.btnGenerateScript.TabIndex = 18;
            this.btnGenerateScript.Text = "Сформировать";
            this.btnGenerateScript.UseVisualStyleBackColor = false;
            this.btnGenerateScript.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxField);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBoxType);
            this.panel2.Controls.Add(this.btnCloseTable);
            this.panel2.Controls.Add(this.btnAddField);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1058, 114);
            this.panel2.TabIndex = 24;
            this.panel2.Visible = false;
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
            this.textBoxField.TabIndex = 13;
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
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(137, 39);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(461, 26);
            this.comboBoxType.TabIndex = 14;
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
            this.btnCloseTable.TabIndex = 16;
            this.btnCloseTable.Text = "Закрыть таблицу";
            this.btnCloseTable.UseVisualStyleBackColor = false;
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
            this.btnAddField.TabIndex = 15;
            this.btnAddField.Text = "Добавить";
            this.btnAddField.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxTable);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 32);
            this.panel1.TabIndex = 23;
            // 
            // textBoxTable
            // 
            this.textBoxTable.Location = new System.Drawing.Point(137, 3);
            this.textBoxTable.Name = "textBoxTable";
            this.textBoxTable.Size = new System.Drawing.Size(355, 26);
            this.textBoxTable.TabIndex = 14;
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
            this.btnAddTable.TabIndex = 15;
            this.btnAddTable.Text = "ОК";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // panelWorkArea
            // 
            this.panelWorkArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWorkArea.Location = new System.Drawing.Point(0, 244);
            this.panelWorkArea.Name = "panelWorkArea";
            this.panelWorkArea.Size = new System.Drawing.Size(1058, 521);
            this.panelWorkArea.TabIndex = 26;
            // 
            // btnSQL
            // 
            this.btnSQL.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSQL.FlatAppearance.BorderSize = 0;
            this.btnSQL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnSQL.Location = new System.Drawing.Point(0, 0);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(60, 40);
            this.btnSQL.TabIndex = 0;
            this.btnSQL.Text = "SQL";
            this.btnSQL.UseVisualStyleBackColor = true;
            // 
            // btnFC
            // 
            this.btnFC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFC.FlatAppearance.BorderSize = 0;
            this.btnFC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(76)))));
            this.btnFC.Location = new System.Drawing.Point(60, 0);
            this.btnFC.Name = "btnFC";
            this.btnFC.Size = new System.Drawing.Size(60, 40);
            this.btnFC.TabIndex = 1;
            this.btnFC.Text = "FC";
            this.btnFC.UseVisualStyleBackColor = true;
            // 
            // CreateTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1058, 765);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(220)))), ((int)(((byte)(226)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateTable";
            this.Text = "CreateTable";
            this.Load += new System.EventHandler(this.CreateTable_Load);
            this.panelMain.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGenerateScript;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button btnCloseTable;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Panel panelWorkArea;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.Button btnFC;
    }
}