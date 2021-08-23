using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor.Classes.WriteToJSONFile
{
    public class JSON
    {
        public JSON(string path)
        {
            Path = path;
        }

        private string Path { get; set; }

        public void Read(ref List<Table> tables)
        {
            if (!File.Exists(Path))
                return;
            tables = JsonConvert.DeserializeObject<List<Table>>(File.ReadAllText(Path));
        }

        public void Write(ref List<Table> tables)
        {
            string json = JsonConvert.SerializeObject(tables);
            File.WriteAllText(Path, json);
        }

        public void Read(ref List<Feilds> feilds)
        {
            if (!File.Exists(Path))
                return;
            feilds = JsonConvert.DeserializeObject<List<Feilds>>(File.ReadAllText(Path));
        }

        public void Write(ref List<Feilds> feilds)
        {
            string json = JsonConvert.SerializeObject(feilds);
            File.WriteAllText(Path, json);
        }
    }
}
