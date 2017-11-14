using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //A= pi * r * r ; pi is 3.14  r is the radius

            // Radius type is float and Area type is double
            while (true)
            {
                Console.WriteLine("Enter a radius: ");
                float r = float.Parse(Console.ReadLine());
                double area = Math.PI * r * r;

                string AreaString = string.Format("The The area of a circle with radius {0} is:{1}", r, area);
           
                // Bonus one & Two: add validation and loop 

                if (r <= 0)

                { 
                    Console.WriteLine("Please Enter grater than 0");
                    continue;
                }

                else
                {
                    Console.WriteLine(AreaString);
                    Console.ReadLine();
                    break;
                }
            }
          
        }
    }

}
