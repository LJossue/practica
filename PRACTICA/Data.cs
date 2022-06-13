using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA
{
    internal class Data
    {
        public int Document;
        public string FirstName;
        public string LastName;
        public double Salary;
        public int WorkedDays;

        public Data(int document, string firstname, string lastname, double salary, int workeddays)
        {
            Document = document;
            FirstName = firstname;
            LastName = lastname;
            Salary = salary;
            WorkedDays = workeddays;
        }
        public Data()
        {
        }
        public void setDocument(int Document)
        {
            this.Document = Document;
        }
        public int getDocument()
        {
            return Document;
        }

        public void setFirstName(string firstname)
        {
            this.FirstName = firstname;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public void setLastName(string lastname)
        {
            this.LastName = lastname;
        }

        public string getLastName()
        {
            return LastName;
        }

        public void setSalary(int salary)
        {
            this.Salary = salary;
        }

        public double getSalary()
        {
            return Salary;
        }

        public void setWorkedDays(int workeddays)

        {
            this.WorkedDays = workeddays;
        }

        public int getWorkedDays()
        {
            return WorkedDays;
        }

        public override string ToString()
        {
           
            return $"Document: {Document} \nFirst Name: {FirstName} \nLast Name: {LastName} \nSalary: {Salary} \nWorked Days: {WorkedDays}";
        }
        public void BaseSalary()
        {
           double PayPerDay = (Salary / 30);
            double BaseSalary = (PayPerDay * WorkedDays);
            double Health = ((BaseSalary * 0.04) / WorkedDays);
            double Pension = ((BaseSalary * 0.04) / WorkedDays);
            double SalaryDiscount = (BaseSalary  - Health - Pension);
            double TransportPerDay = (117172 /30);
            double Transport = (TransportPerDay * WorkedDays);
            Console.WriteLine("The Base salary of the employee is: " + BaseSalary);
            Console.WriteLine("The Discounts are: \nHealth: " + Health + "\nPension: " + Pension);

            if (Salary <= 2000000)
            {
                Console.WriteLine("Adding the transport subisidy, the net salary is: " + (SalaryDiscount + Transport));
            }
            else
            {
                Console.WriteLine("The Salary is: " + SalaryDiscount);
            }

        }
        public void Incomes()
        {

        }
    }
}
