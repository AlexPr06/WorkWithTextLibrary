//using System;
//using System.Linq;
using System.Text.RegularExpressions;

namespace TextOperations
{
    public class TextAnalyzer
    {
        public int CountVowels(string input)
        {
            if (string.IsNullOrEmpty(input)) return 0;

            string vowels = "aeiouAEIOUаеєиіїоуюяАЕЄИІЇОУЮЯаеёиоуыэюяАЕЁИОУЫЭЮЯ";
            return input.Count(ch => vowels.Contains(ch));
        }

        public string CapitalizeWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return input;

            return Regex.Replace(input.ToLower(), @"\b\w", m => m.Value.ToUpper());
        }
    }
}
