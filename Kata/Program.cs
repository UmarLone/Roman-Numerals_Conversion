using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Kata
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {  
                Start:
                

                
                

                    // Declare an interface instance.
                    RomanNumeral obj = new RomanNumeral();
                    int num;
                    Console.WriteLine("Please enter a Number and then press Enter ");
                    num = Convert.ToInt32(Console.ReadLine());
                    if (num <1 || num >3999)
                    {
                        Console.WriteLine("the Only supported numbers are between 1 and 3999");
                    }
                   
                    
                    else
                    {
                  Console.WriteLine("You entered the number {0} which equals {1} in Roman numerals.", num, obj.Generate(num));
                        //Console.ReadLine();
                  goto Start;
                    } 
             
  
            }
            catch
            {

            }
        }
    }
}
