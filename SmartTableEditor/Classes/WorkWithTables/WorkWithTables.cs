using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor.Classes.WorkWithTables
{
    public enum _Enum { SQL, FC };

    public class WorkWithTables
    {
        public ITable workWithTables;

        public WorkWithTables(_Enum val)
        {
            if (val == _Enum.SQL)
                workWithTables = new SQL();
            else if (val == _Enum.FC)
                workWithTables = new FirsCode();
        }
    }
}
