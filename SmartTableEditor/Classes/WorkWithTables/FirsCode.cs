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
        public void CreateTable(string feild, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(feild) | string.IsNullOrWhiteSpace(feild))
                return;

            richTextBox.AppendText($"public class {feild}{Environment.NewLine}");
            richTextBox.AppendText("{");
        }

        public void CreateField(string name, string type, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(name) | string.IsNullOrWhiteSpace(name)
                | string.IsNullOrEmpty(type) | string.IsNullOrWhiteSpace(type))
                return;

            richTextBox.AppendText(Environment.NewLine + "    public " + type + " " + name + " { get; set; }");
        }

        public void CloseTable(RichTextBox richTextBox)
        {
            // Добавляю пробел, чтобы в конце спарсить добавление связи
            string line = Environment.NewLine + "} " + Environment.NewLine + Environment.NewLine;

            richTextBox.AppendText(line);
        }
    }
}
