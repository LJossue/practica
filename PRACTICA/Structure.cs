using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA
{
    internal class Structure
    {
        public static void Main(string[] args)
        {
            Data data = new Data();
            Console.WriteLine("Insert the document: ");
            data.setDocument(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nInsert the First Name: ");
            data.setFirstName(Console.ReadLine());
            Console.WriteLine("\nInsert the Last Name: ");
            data.setLastName(Console.ReadLine());
            Console.WriteLine("\nInsert the Salary: ");
            data.setSalary(int.Parse(Console.ReadLine()));
            Console.WriteLine("\nInsert the Worked days: ");
            data.setWorkedDays(int.Parse(Console.ReadLine()));
            Console.WriteLine("\n----------------------------------------\n" + data.ToString());
            data.BaseSalary();
        }
    }
}
