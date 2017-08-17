using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class LargestString
    {
        public void FindLargest(string Str)
        {
            List<string> word = new List<string>(Str.Split(' '));
            int max = word[0].Length;
            string newStr = Str;

            for (int i = 0; i < word.Count; i++)
            {
                for (int j = i + 1; j < word.Count; j++)
                {
                    if (word[j].Length>max)
                    {
                        max = word[j].Length;
                        newStr = word[j];
                        j--;
                    }
                }

            }

            Console.WriteLine("Largest Word: {0}", newStr);
        }

    }
    
}



        