using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : Swap Of Two Numbers");
            Console.WriteLine("Enter A Option");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch(Option)
            {
                case 1:
                    SwapNumbers swapNumbers = new SwapNumbers();
                    swapNumbers.Numbers();
                    break;
            }
            Console.ReadLine();
        }
    }
}
