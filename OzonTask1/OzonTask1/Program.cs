using System;
using System.Text;

namespace OzonTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get me string!");
          var inputString =   Console.ReadLine();
            Console.WriteLine(ModifyString(inputString));
        }

        public static string ModifyString(string inputString)
        {
           // char[] bigLetters = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();

            var words = inputString.Split(" ");
            var newWords = "";
            foreach (var word in words)
            {

                char[] letters = word.ToCharArray();
                //foreach (var bigL in bigLetters)
                //{
                    if (char.IsUpper(letters[0]))
                    {
                        letters[0] = char.ToUpper(letters[0]);
                    }
                //}
                // var newWord = letters.ToString();
                newWords += new string(letters) + " ";

            }
            return newWords;
        }
    }

}
