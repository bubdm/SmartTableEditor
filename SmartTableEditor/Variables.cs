using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTableEditor
{
     class Variables
    {
        /* Общие свойства */
        public static readonly Color ColorDarkBlue = Color.FromArgb(29, 36, 51);
        public static readonly Color ColorWhite = Color.FromArgb(215,220,226);

        /* Форма Main */
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static int Top { get; set; }
        public static int Left { get; set; }

        /* Форма CreateTable */
        public static string[] ListTypes = { "string", "int", "datetime", "List" };

    }
}
