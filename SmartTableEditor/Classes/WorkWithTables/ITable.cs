using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor.Classes
{
    public interface ITable
    {
        void CreateTable(TextBox textBox, RichTextBox richTextBox);
        void CreateField(TextBox textBox, RichTextBox richTextBox, ComboBox comboBox);
        void CloseTable(RichTextBox richTextBox);
    }
}
