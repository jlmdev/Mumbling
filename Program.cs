using System;

namespace Mumbling
{
    class Program
    {
        static String Accum(string s)
        {
            var output = "";
            for (var index = 0; index < s.Length; index++)
            {
                var character = s[index];
                var characterString = character.ToString();
                for (var counter = 0; counter <= index; counter++)
                {
                    if (counter == 0)
                    {
                        output += characterString.ToUpper();
                    }
                    else
                    {
                        output += characterString.ToLower();
                    }
                }
                if (index != (s.Length - 1))
                {
                    output += "-";
                }
            }
            return output;
        }
        static void Main(string[] args)
        {
            var result = Accum("abcd");
            Console.WriteLine($"{result}");
            Console.ReadLine();
        }


    }
}
