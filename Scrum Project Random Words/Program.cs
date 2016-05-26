using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Scrum_Project_Random_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a streamwriter file


            //create string array //come up random words
            string[] randomize = { "shrinkage", "ice ice baby", "snowman", "frost bite", "shoveling", "igloo", "yeti", "snowcone", "Elsa", "dead body", "leg lamp", "frozen margarita", "alaska", "north pole", "Santa", "bubble coat", "snowboard", "white" };

            Random random = new Random();

            StringBuilder sf = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                sf.Append(randomize[random.Next(randomize.Length)]);
                sf.Append(" ");

            }
            StreamWriter coldWords = new StreamWriter("frozen.txt");
            using (coldWords)
            {
                coldWords.WriteLine(sf);
            }
            StreamReader winter = new StreamReader("frozen.txt");
            using (winter)
            {
                Console.WriteLine(winter.ReadLine());
            }

        }
    }
}

