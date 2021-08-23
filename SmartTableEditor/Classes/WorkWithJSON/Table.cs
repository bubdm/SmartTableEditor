using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor.Classes.WriteToJSONFile
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
        public Dictionary<string, string> Fields { get; set; }

    }
}
