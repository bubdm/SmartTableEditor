using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor.Classes.WriteToJSONFile
{
    // Класс для авто-подстановки типов
    public class Feilds
    {
        public Feilds(string nameFeild, string value)
        {
            NameFeild = nameFeild;
            Value = value;
        }

        public string NameFeild { get; set; }
        public string Value { get; set; }

    }
}
