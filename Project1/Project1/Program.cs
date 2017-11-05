using System;

namespace Project1
{
    class Program
    {
        static void Main()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();  //reads user input
            width = double.Parse(widthString);
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height ) * 3.25 ;
            glassArea = 2 * (width* height ) ;
            Console.WriteLine( "The length of the wood is " +
            woodLength + " feet" ) ;
            Console.WriteLine( "The area of the glass is " +
            glassArea + " square metres" ) ;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
        
    }
}
