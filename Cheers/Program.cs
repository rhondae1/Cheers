using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there, I'm only a week leate on this assignment.  The coding Gods hate me and have caused my computer to break. I will not be deterred.  What's your name?");
            string name = Console.ReadLine();
            System.Console.WriteLine("Hi " + name);
            foreach (char letter in name.ToLower())

            {
                if (Char.IsLetter(letter))
                {
                    string mnemonic = "halfnorsemix";
                    string article = "a";
                    if (mnemonic.Contains(letter))

                    {
                        article = "an";
                    }
                        { System.Console.WriteLine("Give me " + article + "..." + letter);
                        }
                    }
                }
            }
        }
    }
    
