using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyrillicShift
{
    public class CyrillicShiftConverter
    {
        private static readonly Dictionary<char, char> latinToCyrillic = new Dictionary<char, char>
        {
            {'q', 'ф'}, {'w', 'ы'}, {'e', 'в'}, {'r', 'а'}, {'t', 'п'},
            {'y', 'р'}, {'u', 'о'}, {'i', 'л'}, {'o', 'д'}, {'p', 'ж'},
            {'я', '2'}, {'x', '3'}, {'c', '4'}, {'m', '5'},
            {'и', '6'}, {'т', '7'}, {'ь', '8'}, {'б', '9'}, {'ю', '0'},
            {'g', ' '}
        };

        private static readonly Dictionary<char, char> cyrillicToLatin = new Dictionary<char, char>
        {
            {'ф', 'q'}, {'ы', 'w'}, {'в', 'e'}, {'а', 'r'}, {'п', 't'},
            {'р', 'y'}, {'о', 'u'}, {'л', 'i'}, {'д', 'o'}, {'ж', 'p'},
            {'2', 'я'}, {'3', 'x'}, {'4', 'c'}, {'5', 'm'},
            {'6', 'и'}, {'7', 'т'}, {'8', 'ь'}, {'9', 'б'}, {'0', 'ю'},
            {' ', 'g'}
        };

        public static string EncodeToCyrillic(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();

            foreach (char c in input.ToLower())
            {
                if (latinToCyrillic.ContainsKey(c))
                {
                    result.Append(latinToCyrillic[c]);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        public static string DecodeToLatin(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (cyrillicToLatin.ContainsKey(c))
                {
                    result.Append(cyrillicToLatin[c]);
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}
