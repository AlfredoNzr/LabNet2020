using System;

namespace ExceptionPractice.CrossCutting.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string CrazyCamelCase(this string phrase)
        {
            string result = "";
            for (int i = 0; i <= phrase.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    result = result + Convert.ToString(char.ToUpper(phrase[i]));
                }
                else
                {
                    result = result + Convert.ToString(char.ToLower(phrase[i]));
                }

            }
            return result;
        }
    }
}
