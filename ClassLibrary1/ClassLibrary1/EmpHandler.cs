using EmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class EmpHandler
    {
        public static List<ClassEmp> ListEmps = new List<ClassEmp>()
        {
            new ClassEmp{ Id=1,Name="Sam",Salary=98000.90,Doj=new DateTime(day:24,month:11,year:2021)},
             new ClassEmp{ Id=2,Name="Gaurav",Salary=76000.90,Doj=new DateTime(day:24,month:10,year:2020)},
              new ClassEmp{ Id=3,Name="Dipesh",Salary=75000.90,Doj=new DateTime(day:25,month:12,year:2019)},
               new ClassEmp{ Id=4,Name="Vini",Salary=82000.90,Doj=new DateTime(day:24,month:11,year:2021)},
                new ClassEmp{ Id=9,Name="Rohit",Salary=81000.90,Doj=new DateTime(day:14,month:11,year:2021)},
                 new ClassEmp{ Id=10,Name="Raj",Salary=89000.90,Doj=new DateTime(day:04,month:03,year:2023)},


        };
        public void Display()
        {
            foreach(var  emp in ListEmps)
            {
                Console.WriteLine("ID: \t \t"+emp.Id);
                Console.WriteLine("Name: \t \t" + emp.Name);
                Console.WriteLine("Salary: \t \t" + emp.Salary);
                Console.WriteLine("Date of Joining: \t \t" + emp.Doj.ToShortDateString());
            }
        }
        public void Register()
        {
            Console.WriteLine("Enter Emnployee Id");
            int id=int.Parse(Console.ReadLine());
            if(ListEmps.Exists(e => e.Id==id))
            {
                Console.WriteLine("This Employee Already exist!!!");
            }
            else
            {
                ClassEmp emp = new ClassEmp();
                emp.Id= id;
                Console.WriteLine("Enter Employee name");
                emp.Name=Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                emp.Salary=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Employee Date of Joining");
                emp.Doj=DateTime.Parse(Console.ReadLine());
                ListEmps.Add(emp);
                Console.WriteLine("New Employee Registration Success!!!");
            }
        }
    }
}
