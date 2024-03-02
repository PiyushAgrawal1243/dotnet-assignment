
using System.Globalization;
using System.Text;

namespace ConvertToPascaCase
{
    public class ConvertStringToPascal
    {
        public static string ConvertToPascal(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                result.Append(textInfo.ToTitleCase(word.ToLower()));
            }

            return result.ToString().Replace(" ", "");
        }
    }

}
