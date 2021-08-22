using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor.Classes.WorkWithTables
{
    public enum SelectArh { SQL, FC };

    public class WorkWithTables
    {
        public ITable Table;

        public WorkWithTables(SelectArh val)
        {
            if (val == SelectArh.SQL)
                Table = new SQL();
            else if (val == SelectArh.FC)
                Table = new FirsCode();
        }
    }
}
