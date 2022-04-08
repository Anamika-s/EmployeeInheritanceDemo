using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class PartTimeEmployee  : Employee
    {
       
        string project;
        string duration;
        public PartTimeEmployee() : base() { }
        
        public PartTimeEmployee(int id, string name , string address
            , string project ,string duration) :
            base(id, name , address)
        {
            
            this.project = project;
            this.duration = duration;
        }
        //public void GetPartTimeEmployeeDetails()
        //{
           public void GetDetails()
        {
            id = 100;
            base.GetDetails();
            Console.WriteLine("Enter Project");
            project = Console.ReadLine();
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();
        }

        //public void DisplayPartTimeEmployeeDetails()
        //{
             public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Project is {project}");
            Console.WriteLine($"Duration is {duration}");
        }
    }
}
