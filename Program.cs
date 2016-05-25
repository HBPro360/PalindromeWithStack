using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Char> st = new Stack<Char>();
            Console.Write("Enter Word:");
            string word = Console.ReadLine();
            for(int i = 0; i< word.Length; i++)
            {
                st.Push(word[i]);
            }
            string newWord = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                newWord += st.Pop();
                //newWord = newWord + st.Pop();
            }
            if (word.ToLower() == newWord.ToLower())
            {
                Console.WriteLine(newWord + " is a Palindrome.");
            }
            else
            {
                Console.WriteLine(newWord + " is NOT a Palindrome.");
            }
            Console.Write("\n\nPress Enter to continue.....");
            Console.ReadLine();

        }
    }
}
