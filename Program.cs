﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string gender;
            double salary;
            DateTime doj;

            Console.WriteLine("Enter the ID :");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter the Salary");
            salary = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the DOJ:");
            doj = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("ID\t"+"Name\t"+"Gender\t"+"Date of Joining");

            Console.WriteLine("---------------------------------------------");

            Console.WriteLine( id +"\t"+ name +"\t"+ gender +"\t "+ doj+"\n");

            double taxRate = 0.15;
            if (salary > 90000)
            {
                taxRate = 0.30;
            }

            double taxAmount = salary * taxRate;

            Console.WriteLine("You have to pay: " + taxAmount);
          
            Console.ReadKey();

        }
    }
}
