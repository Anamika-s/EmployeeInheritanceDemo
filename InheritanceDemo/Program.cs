using System;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Empoyee Object");
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();

            Console.WriteLine("PartTime Employee");
            PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            partTimeEmployee.GetDetails();
            //partTimeEmployee.GetPartTimeEmployeeDetails();
            partTimeEmployee.DisplayDetails();
            //partTimeEmployee.DisplayPartTimeEmployeeDetails();

            Console.WriteLine("FullTime Employee");
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();
            fullTimeEmployee.GetDetails();
           // fullTimeEmployee.GetFullTimeEmployeeDetails();
            fullTimeEmployee.DisplayDetails();
            //fullTimeEmployee.DisplayFullTimeEmployeeDetails();
            PartTimeEmployee part = new PartTimeEmployee(101, "Ajay", "Delhi"
                , "Training", "2 months");
         
        }
    }
}
