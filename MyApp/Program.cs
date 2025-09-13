using System;
using TextOperations;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer analyzer = new TextAnalyzer();
            string text = "привет мир как дела";
            int vowelCount = analyzer.CountVowels(text);
            string capitalizedText = analyzer.CapitalizeWords(text);

            Console.WriteLine($"Original Text: {text}");
            Console.WriteLine($"Vowel Count: {vowelCount}");
            Console.WriteLine($"Capitalized Text: {capitalizedText}");
        }
    }
}

