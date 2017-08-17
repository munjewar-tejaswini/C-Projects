using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveVovel
{
    class ClassRemoveVovel
    {
        //char[] vovels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        public void MethodRemoveVovel(string word)
        {
            var letters = new HashSet<char>(word);
            letters.ExceptWith("AaEeIiOoUu");

            Console.WriteLine("String after removing Vowels:");
            foreach (char loopvar in letters)
            {
                Console.Write(loopvar);
            }

        }
    }
}
