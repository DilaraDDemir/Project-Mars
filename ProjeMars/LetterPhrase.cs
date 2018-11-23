using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeMars
{
    class LetterPhrase
    {
        DirectionOfTheRobots dir = new DirectionOfTheRobots();
        public String phrase;

        public string Phrase { get => phrase; set => phrase = value; }

        public void drawRobotsWays(String phrase)
        {
            do
            {
                Console.WriteLine("Robotun gideceği harf katarını giriniz, harf katarında sadece 'L', 'M' ve 'R' harflerini kullanın :");
                phrase = Console.ReadLine();
                char[] charOfThePhrase = phrase.ToCharArray();

                for (int i = 0; i < phrase.Length; i++)
                {
                    if (charOfThePhrase[i] != 'L' && charOfThePhrase[i] != 'R' && charOfThePhrase[i] != 'M')
                    {
                        Console.WriteLine("Harf katarında sadece 'L', 'M' ve 'R' harflerini büyük yazabilirsiniz !!!");
                        Console.WriteLine("Girmiş olduğunuz harf katarı yanlış karakter içermektedir, tekrar giriniz : ");
                        phrase = Console.ReadLine();
                        charOfThePhrase = phrase.ToCharArray();

                      
                       
                    }



                }
            } while (!phrase.Contains("L") && !phrase.Contains("R") && !phrase.Contains("M"));

        }

    }


}
