using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Justen Neeley";
            string myLocation = "Idaho";
            /*display name an location variables*/
            Console.WriteLine($"My name is: {myName} ");
            Console.WriteLine($"I am in: {myLocation}");

            /*display today's date*/
            Console.WriteLine("Today's date is: " + DateTime.Today.Date.ToShortDateString());
            /* create TimeSpan for days til christmas*/
            TimeSpan tilChristmas = (DateTime.Parse("December 25, 2019") - DateTime.Now);

            Console.WriteLine("The number of days til Christmas is: " + tilChristmas.ToString("dd"));

            double width, height, woodLength, glassArea; string widthString, heightString;
            Console.Write("Please enter the Width in Meters: ");
            widthString = Console.ReadLine(); width = double.Parse(widthString);
            Console.Write("Please enter the Length in Meters: ");
            heightString = Console.ReadLine(); height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet"); Console.WriteLine("The area of the glass is " + glassArea + " square metres");
            Console.ReadKey();
        }
    }
}
