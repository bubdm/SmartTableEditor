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
        public void CreateTable(string feild, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(feild) | string.IsNullOrWhiteSpace(feild))
                return;

            richTextBox.AppendText($"CREATE TABLE {feild} (");
        }

        public void CreateField(string name, string type, RichTextBox richTextBox)
        {
            if (string.IsNullOrEmpty(name) | string.IsNullOrWhiteSpace(name)
                | string.IsNullOrEmpty(type) | string.IsNullOrWhiteSpace(type))
                return;

            StringBuilder stringBuilder = new StringBuilder(70);


            richTextBox.AppendText($"{Environment.NewLine}   {name} {type.ToUpper()} {stringBuilder},");
        }

        public void CloseTable(RichTextBox richTextBox)
        {
            string line = $"{richTextBox.Text.Remove(richTextBox.Text.Length - 1, 1)}{Environment.NewLine}){Environment.NewLine}{Environment.NewLine}";

            richTextBox.Text = line;
        }
    }
}
