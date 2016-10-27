 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    public class Translator
    {
        public string Substring { get; private set; }

        public string Translate(string wordToTranslate)
        {

            wordToTranslate = wordToTranslate.ToLower();
            string firstLetter = "";
            if (wordToTranslate.StartsWith("a") || wordToTranslate.StartsWith("e") || wordToTranslate.StartsWith("i") || wordToTranslate.StartsWith("o") || wordToTranslate.StartsWith("u"))

            {
                firstLetter = wordToTranslate.Substring(0, 1);
                return wordToTranslate + "way";
            }
            else
            {
                int indexoffirstvowel = 1;
                string Letteratindex = wordToTranslate.Substring(indexoffirstvowel, 1);


                while
                    (!(Letteratindex == "a" || Letteratindex == "e" || Letteratindex == "i" || Letteratindex == "o" || Letteratindex == "u"))
                  {
                    indexoffirstvowel++;
                    Letteratindex = wordToTranslate.Substring(indexoffirstvowel, 1);
                }

                return (wordToTranslate.Substring(indexoffirstvowel) + wordToTranslate.Substring(0, indexoffirstvowel) + "ay");

            }
        }
    }
}