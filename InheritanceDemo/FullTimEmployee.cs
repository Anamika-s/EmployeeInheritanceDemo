using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class FullTimeEmployee : Employee
    {
       

            string dept;
            string manager;
        public FullTimeEmployee()  { }
        public FullTimeEmployee(int id, string name, string address, string dept, string manager)
            : base (id, name,address)
        {
            this.manager = manager;
            this.dept = dept;
        }
            //public void GetFullTimeEmployeeDetails()
            //{
            public void GetDetails()
        {
            base.GetDetails();

                Console.WriteLine("Enter Department");
                dept = Console.ReadLine();
                Console.WriteLine("Enter Manager");
               manager = Console.ReadLine();
            }

            //public void DisplayFullTimeEmployeeDetails()
            //{
            public void DisplayDetails()
        {
            base.DisplayDetails();

                Console.WriteLine($"Department is {dept}");
                Console.WriteLine($"Manager is {manager}");
            }
        }
    }

