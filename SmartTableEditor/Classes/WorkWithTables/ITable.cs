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
        void CreateTable(string feild, RichTextBox richTextBox);
        void CreateField(string name, string type, RichTextBox richTextBox);
        void CloseTable(RichTextBox richTextBox);
    }
}
