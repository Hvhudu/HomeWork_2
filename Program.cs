using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HomeWork2.Models;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            EmployeeModel employee2 = new EmployeeModel("Oleg", "Dmitriev", "2004.07.24", 1, 1007);
            
            int res = DataLayers.DL.Employee.Update(employee2);
            
            Console.WriteLine($"Изменена  {res} строка"); ;
            
        }
    }
}
