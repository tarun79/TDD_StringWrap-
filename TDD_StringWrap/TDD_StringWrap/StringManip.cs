using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_StringWrap
{
    class StringManip
    {
        public String WrapMyString(string input, int colmax)
        {
            if (input == null)
                return null;

            StringBuilder outString = new StringBuilder();
            StringBuilder row_string = new StringBuilder();
            string[] wordsInString = input.Split(' ');

            if (wordsInString[0].Length < colmax)
                row_string.Append(wordsInString[0]);
            else
                return "Column size is too small";

            for (var i = 1; i < wordsInString.Length; i++)
            {
                if (row_string.Length + wordsInString[i].Length <= colmax - 1)
                {
                    row_string.Append(" ");
                    row_string.Append(wordsInString[i]);
                }
                else
                {
                    row_string.Append("\n");
                    outString.Append(row_string);
                    row_string.Clear();
                    row_string.Append(wordsInString[i]);
                }
            }

            outString.Append(row_string);

            return outString.ToString(); 
        }
    }
}
