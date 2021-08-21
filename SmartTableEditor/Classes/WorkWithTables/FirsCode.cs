using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor.Classes
{
    class FirsCode : ITable
    {
        public void CreateTable(TextBox textBox, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) | string.IsNullOrWhiteSpace(textBox.Text))
                return;

            richTextBox.AppendText($"public class {textBox.Text}{Environment.NewLine}");
            richTextBox.AppendText("{");
        }

        public void CreateField(TextBox textBox, RichTextBox richTextBox, ComboBox comboBox)
        {
            if (string.IsNullOrEmpty(textBox.Text) | string.IsNullOrWhiteSpace(textBox.Text) | string.IsNullOrEmpty(comboBox.Text) | string.IsNullOrWhiteSpace(comboBox.Text))
                return;

            richTextBox.AppendText(Environment.NewLine + "    public " + comboBox.Text + " " + textBox.Text + " { get; set; }");

            comboBox.Text = "";
        }

        public void CloseTable(RichTextBox richTextBox)
        {
            // Добавляю пробел, чтобы в конце спарсить добавление связи
            string line = Environment.NewLine + "} " + Environment.NewLine + Environment.NewLine;

            richTextBox.AppendText(line);
        }
    }
}
