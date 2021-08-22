using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTableEditor.Classes
{
    class SyntaxHighlighting
    {
        // Цвет по умолчанию
        private readonly Color def = Color.FromArgb(215, 220, 226);

        private void ForeachList(RichTextBox richTextBox,string[] list, Color color)
        {
            foreach (var item in list)
            {
                var matches = Regex.Matches(richTextBox.Text, $@"\b{item}\b");
                foreach (var match in matches.Cast<Match>())
                {
                    richTextBox.Select(match.Index, match.Length);
                    richTextBox.SelectionColor = color;
                }
            }
        }

        public void Highlighting(RichTextBox richTextBox,
                                 string[] collectionOne,
                                 Color first)
        {
            int currentSelStart = richTextBox.SelectionStart;
            int currentSelLength = richTextBox.SelectionLength;

            richTextBox.SelectAll();
            richTextBox.SelectionColor = def;

            ForeachList(richTextBox, collectionOne, first);

            richTextBox.Select(currentSelStart, currentSelLength);
            richTextBox.SelectionColor = def;
        }

        public void Highlighting(RichTextBox richTextBox,
                                 string[] collectionOne,
                                 string[] collectionTwo,
                                 Color first,
                                 Color second)
        {
            int currentSelStart = richTextBox.SelectionStart;
            int currentSelLength = richTextBox.SelectionLength;

            richTextBox.SelectAll();
            richTextBox.SelectionColor = def;

            ForeachList(richTextBox, collectionOne, first);
            ForeachList(richTextBox, collectionTwo, second);

            richTextBox.Select(currentSelStart, currentSelLength);
            richTextBox.SelectionColor = def;
        }

        public void Highlighting(RichTextBox richTextBox,
                                 string[] collectionOne,
                                 string[] collectionTwo,
                                 string[] collectionThree,
                                 Color first,
                                 Color second,
                                 Color third)
        {
            int currentSelStart = richTextBox.SelectionStart;
            int currentSelLength = richTextBox.SelectionLength;

            richTextBox.SelectAll();
            richTextBox.SelectionColor = def;

            ForeachList(richTextBox, collectionOne, first);
            ForeachList(richTextBox, collectionTwo, second);
            ForeachList(richTextBox, collectionThree, third);

            richTextBox.Select(currentSelStart, currentSelLength);
            richTextBox.SelectionColor = def;
        }
    }
}
