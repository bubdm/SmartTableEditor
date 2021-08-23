using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor.Classes.WriteToJSONFile
{
    interface IJSON
    {
        void Read(ref List<Table> tables);
        void Read(ref List<Feilds> feilds);
        void Write(ref List<Table> tables);
        void Write(ref List<Feilds> feilds);
    }
}
