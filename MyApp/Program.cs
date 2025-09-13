
using TextOperations;
using Newtonsoft.Json;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextAnalyzer analyzer = new TextAnalyzer();
            Console.Write("Enter text: ");
            string text = Console.ReadLine() ?? string.Empty;
  
            int vowelCount = analyzer.CountVowels(text);
            string capitalizedText = analyzer.CapitalizeWords(text);

            var result = new
            {
                OriginalText = text,
                VowelCount = vowelCount,
                CapitalizedText = capitalizedText
            };

            string jsonResult = JsonConvert.SerializeObject(result, Formatting.Indented);

            Console.WriteLine("JSON Result:");
            Console.WriteLine(jsonResult);
        }
    }
}

