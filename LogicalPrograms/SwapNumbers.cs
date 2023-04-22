using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class SwapNumbers
    {
        public void Numbers()
        {
            Console.WriteLine("Enter First Number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" After Swapping The First Number is {SecondNumber} ");
            Console.WriteLine($" After Swapping The Second Number is {FirstNumber} ");
        }
    }
}
