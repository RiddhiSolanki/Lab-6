using Lab_6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTranslator
{
    class Program
    {
        static void Main(string[] args) {
            string keepGoing = "y";
            do
            {
                Console.WriteLine("Welcome to the Pig latin Translator.Enter a line to be translated");
                string ans = Console.ReadLine();

                Translator brad = new Translator();
                string sword = brad.Translate(ans);
                Console.WriteLine(sword);

                    Console.WriteLine("continue y/n");
                    keepGoing = Console.ReadLine();
            }

            while (keepGoing=="y");
            

          
        }
    }
}
