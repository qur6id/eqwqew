using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    
    public class Employee
    {
    
        public string FullName;
        public decimal Salary;

        public void Show()
        {
            Console.WriteLine("Данные о служащем:");
            Console.WriteLine($"ФИО:     {FullName}");
            Console.WriteLine($"Зарплата: {Salary} руб.");
        }

        public decimal GetAnnualSalary()
        {
            return Salary * 12;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
         
            Employee employee = new Employee();

            
            employee.FullName = "Иванов";
            employee.Salary = 63500;
            employee.Show();
            decimal annualSalary = employee.GetAnnualSalary();
            Console.WriteLine();
            Console.WriteLine($"Годовая зарплата: {annualSalary} руб.");

            Console.WriteLine();
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}