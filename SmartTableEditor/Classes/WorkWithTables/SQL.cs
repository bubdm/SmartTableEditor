using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor.Classes
{
    class SQL : ITable
    {
        public void CreateTable(TextBox textBox, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) | string.IsNullOrWhiteSpace(textBox.Text))
                return;

            richTextBox.AppendText($"CREATE TABLE {textBox.Text} (");
        }

        public void CreateField(TextBox textBox, RichTextBox richTextBox, ComboBox comboBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) | string.IsNullOrWhiteSpace(textBox.Text) | string.IsNullOrEmpty(comboBox.Text) | string.IsNullOrWhiteSpace(comboBox.Text))
                return;

            StringBuilder stringBuilder = new StringBuilder(70);


            richTextBox.AppendText($"{Environment.NewLine}   {textBox.Text} {comboBox.Text.ToUpper()} {stringBuilder},");

            comboBox.Text = "";
        }

        public void CloseTable(RichTextBox richTextBox)
        {
            string line = $"{richTextBox.Text.Remove(richTextBox.Text.Length - 1, 1)}{Environment.NewLine}){Environment.NewLine}{Environment.NewLine}";

            richTextBox.Text = line;
        }
    }
}
