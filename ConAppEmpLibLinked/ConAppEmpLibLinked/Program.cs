using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using EmpLib;

namespace ConAppEmpLibLinked
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose operation");
            Console.WriteLine("1.Show 2.Register");
            int op=int.Parse(Console.ReadLine());
            EmpHandler empHandler = new EmpHandler();
            if (op == 1)
            {
                empHandler.Display();
            }
            else if (op == 2)
            {
                empHandler.Register();
                Console.WriteLine("Details After Registration");
                empHandler.Display();
            }
            else
            {
                {
                    Console.WriteLine("Invalid operation choice!!!");
                }
            }
            Console.ReadKey();
        }
    }
}
