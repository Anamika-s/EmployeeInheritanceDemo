﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee
    {
        protected int id;
        string name;
        string address;
        public Employee() { }
        public Employee (int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter ID");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter ADdress");
            address = Console.ReadLine();
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}");
            Console.WriteLine($"Name is {name}");
            Console.WriteLine($"Address is {address}");
        }








    }
}
