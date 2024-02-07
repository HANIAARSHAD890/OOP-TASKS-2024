using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
   public class Program
    {
        static void Main(string[] args)
        {

            game shiritori = new game();
            string input = "";
            int wordcount = 0;
   

    

            Console.WriteLine("GAME PLAY");
            // declaring object
           while (!shiritori.gameover)
            {
                Console.WriteLine("Enter a word ");
                input = Console.ReadLine();
                play(shiritori.words,ref shiritori.gameover, input, ref wordcount);
               /* Console.WriteLine("Enter a word ");
                input = Console.ReadLine();
                play(shiritori.words, ref shiritori.gameover, input, ref wordcount);
                restart(shiritori.words, ref shiritori.gameover, ref wordcount);*/


            }
            Console.WriteLine("GAME OVER !");
                Console.WriteLine(shiritori.gameover);

       


        }
        static string restart(List<string> words,ref  bool gameover,ref int wordcount)

        {
            gameover = false;
            words.Clear();
            wordcount = 0;
            return "restarted";
        }
        static bool play(List<string> words, ref bool gameover, string input, ref int wordcount)
        {
            if (!words.Contains(input))
            {
                if ((wordcount == 0) || (words[wordcount - 1][(words[wordcount - 1].Length) - 1] == input[0]))
                {
                    words.Add(input);
                    wordcount++;
                    return true;
                }
                else
                {
                    gameover = true;
                    return true;
                }

            }
            else
            {
                gameover = true;
                return true;
            }




        }
    }
}
