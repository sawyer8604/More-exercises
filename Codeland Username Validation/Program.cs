using System;

namespace Codeland_Username_Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // keep this function call here
            Console.WriteLine(CodelandUsernameValidation(Console.ReadLine()));
           
        }
        public static bool CodelandUsernameValidation(string str)
        {


            // code goes here  

            if (!(str.Length >= 4 && str.Length <= 25))
            {
                return false;
            }

            if (!(char.IsLetter(str[0]) && str[str.Length - 1] != '_'))
            {
                return false;
            }

            foreach (var letter in str)
            {
                if (!(char.IsLetterOrDigit(letter) || (letter =='_')))
                {

                    return false;

                }
            }

            return true;
                        

        }
    }
}
