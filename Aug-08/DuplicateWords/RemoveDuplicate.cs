using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateWords
{
    class RemoveDuplicate
    {
        public void RemoveDuplicates(string Str)
        {
            List<string> duplicates= new List<string>();
            List<string> word = new List<string>(Str.Split(' '));

            for(int i=0; i<word.Count; i++)
            {
                for(int j=i+1; j<word.Count; j++)
                {
                    if (word[i] == word[j])
                    {
                        duplicates.Add(word[i]);
                        word.RemoveAt(j);
                        j--;
                    }
                }
                
            }

        foreach(var loopvar in word)
            {
                Console.WriteLine(loopvar);
            }

        }

    }
}
