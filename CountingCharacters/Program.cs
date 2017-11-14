using System;
using System.Collections.Generic;
using System.Linq;
//using System IO;
namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string Text = @"Lorem ipsum dolor sit amet, 
                            consectetur adipiscing elit. Nunc accumsan sem ut ligula
                            scelerisque sollicitudin. Ut at sagittis augue.
                            Praesent quis rhoncus justo. Aliquam erat volutpat. 
                            Donec sit amet suscipit metus, non lobortis massa. 
                            Vestibulum augue ex, dapibus ac suscipit vel, 
                            volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //Console.WriteLine("Please enter your text;");
           
           // string Text = File.ReadAllText("myText.txt");
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            

            foreach (char c in Text)

            {
                if(!char.IsLetter(c))
                {
                    continue;
                }
                if (charCount.ContainsKey(c))
                {
                    //Pull it out of the dictionary
                    var value = charCount[c];
                    //Add one to it
                    value++;
                    //Save it back to the dictionary
                    charCount[c] = value; 

                    // charCount[c]++;  simple version
                }
                else
                {
                    //Add it with the value 1
                    charCount.Add(c, 1);
                }
            }
            foreach (var keyValuePair in charCount)
            {
                char c = keyValuePair.Key;
                int value = keyValuePair.Value;
               
                //PRINT IT OUT
                Console.WriteLine(c.ToString() + ":" + value.ToString());
                //Consoke.WriteLine(string.Format("{0};{1}", c, value)); option 1
                //Console.WriteLine(string("{0};{1}", c, value)); option2 

            }
            Console.ReadLine().ToLower();// Lowercase print
        }
    }
}
