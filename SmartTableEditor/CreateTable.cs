﻿using SmartTableEditor.Classes;
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
        // Класс для генерации таблиц
        public class Table
        {
            public Table(string name)
            {
                Name = name;
                Fields = new Dictionary<string, string>();
            }

            public string Name { get; set; }
            public Dictionary<string,string> Fields { get; set; }
        }
        private List<Table> _tables = new List<Table>();

        public CreateTable()
        {
            InitializeComponent();
        }

        #region Отдельные методы
        void ShowPanels()
        {
            panel2.Visible = true;
            btnGenerateScript.Visible = true;

            panel1.Visible = false;
            textBoxField.Focus();
        }

        void HidePanels()
        {
            panel2.Visible = false;

            if (string.IsNullOrEmpty(richTextBoxClasses.Text) | string.IsNullOrWhiteSpace(richTextBoxClasses.Text))
                btnGenerateScript.Visible = false;
            else
                btnGenerateScript.Visible = true;

            panel1.Visible = true;
            textBoxTable.Clear();
            textBoxTable.Focus();
        }

        // Обновление rich при каждом добавалении элемента в класс Table
        void UpdateAreaClasses()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in _tables)
            {
                stringBuilder.AppendLine(item.Name);
                if (item.Fields is null)
                    break;
                foreach (var item_2 in item.Fields)
                {
                    stringBuilder.AppendLine($"  {item_2.Key} {item_2.Value}");
                }
                stringBuilder.AppendLine();
            }
            richTextBoxClasses.Text = stringBuilder.ToString();
        }
        #endregion


        private void CreateTable_Load(object sender, EventArgs e)
        {
            foreach (Button item in panelTop.Controls.Cast<Button>())
            {
                item.Width = item.Text.Count() * 30;
            }
            textBoxTable.Focus();
        }


        private void btnAddTable_Click(object sender, EventArgs e)
        {
            ShowPanels();
            _tables.Add(new Table(textBoxTable.Text));
            //var call_table = new WorkWithTables(SelectArh.SQL);
            //call_table.Table.CreateTable(textBoxTable, richTextBoxResultSQL);
            UpdateAreaClasses();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxField.Text) | string.IsNullOrWhiteSpace(textBoxField.Text) | string.IsNullOrEmpty(textBoxType.Text) | string.IsNullOrWhiteSpace(textBoxType.Text))
                return;

            // try&catch для повторяющих значений
            try
            {
                // Поиск таблиц для заполнния полей
                _tables.FirstOrDefault(c => c.Name == textBoxTable.Text).Fields.Add(textBoxField.Text, textBoxType.Text);
            }
            catch (Exception)
            {  }
            textBoxType.Clear();
            textBoxField.Clear();
            textBoxField.Focus();
            UpdateAreaClasses();
        }

        private void btnCloseTable_Click(object sender, EventArgs e)
        {
            HidePanels();
            UpdateAreaClasses();
        }


        #region Подсветка синтаксиса
        private protected SyntaxHighlighting Syntax = new SyntaxHighlighting();
        private void richTextBoxClasses_TextChanged(object sender, EventArgs e)
        {
            string[] collectionGold = { "string", "int", "datetime", "List"};

            Syntax.Highlighting(richTextBoxClasses,
                collectionGold,
                Color.FromArgb(255, 191, 76)
                );
        }
        #endregion

    }
}
