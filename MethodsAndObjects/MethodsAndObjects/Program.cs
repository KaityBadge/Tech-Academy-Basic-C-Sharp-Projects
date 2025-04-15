using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //////    SECTION 4:  USING LAMBDA EXPRESSIONS  ///
            // instantiates and initializes Employee objects
            Employee emp1 = new Employee { Id = "1", FirstName = "Joe", LastName = "Smith" };
            Employee emp2 = new Employee { Id = "2", FirstName = "Jane", LastName = "Brewer" };
            Employee emp3 = new Employee { Id = "3", FirstName = "Paul", LastName = "Armstrong" };
            Employee emp4 = new Employee { Id = "4", FirstName = "Bill", LastName = "Burns" };
            Employee emp5 = new Employee { Id = "5", FirstName = "Grace", LastName = "Haynes" };
            Employee emp6 = new Employee { Id = "6", FirstName = "Tilly", LastName = "Mathews" };
            Employee emp7 = new Employee { Id = "7", FirstName = "Joe", LastName = "Rogers" };
            Employee emp8 = new Employee { Id = "8", FirstName = "Jimmy", LastName = "Hendrix" };
            Employee emp9 = new Employee { Id = "9", FirstName = "Carly", LastName = "Jones" };
            Employee emp10 = new Employee { Id = "10", FirstName = "Santana", LastName = "Trout" };

            //creates a new list of all employees
            List<Employee> employees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8, emp9, emp10 };

            Console.WriteLine("All Employees: \n"); 

            //uses a foreach loop to get all employees from the list of employees
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", Employee ID: " + employee.Id);
            }

            Console.WriteLine("\nUsing a foreach loop to get all employees with the first name Joe: \n");

            //Uses foreach loop to get all employees with the first name "Joe" from the list of employees
            //for each employee in the list of employees
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe") //if the employee's first name is Joe
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName); //prints the employee's first and last name to the console
                }
            }

            Console.WriteLine("\n Using a lambda expression to get all employees with first name Joe: \n");

            //Uses a lambda expression to get all employees with the first name "Joe" from the list of employees
            //creates a new list of employees called employeeNamedJoe
            //Takes the list of employees and finds WHERE the FirstName is "Joe" and adds them to the new list
            var employeeNamedJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            //foreach employee in the new list of employees called employeeNamedJoe
            foreach (var employee in employeeNamedJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName); //prints the employee's first and last name to the console
            }

            Console.WriteLine("\n Using lambda expression to get all employees with ID greater than 5 : \n");

            //Uses a lambda expression to make a a list of all employees with an Id greater than 5
            var employeeIdGreaterThan5 = employees.Where(x => Convert.ToInt32(x.Id) > 5).ToList();

            foreach (var employee in employeeIdGreaterThan5)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName + ", Employee ID: " + employee.Id); //prints the employee's first and last name to the console
            }






            //////    SECTION 3:  GENERIC TYPE PARAMETERS ///

            ////instantiates an employee object "employee1" with type string as its generic parameter
            //Employee<string> employee1 = new Employee<string>();
            ////assigns a list of strings as the property value of "Things" and initializes it
            //employee1.Things = new List<string>() { "Uniform", "Pager", "Nametag" };

            ////instantiates an employee object "employee2" with type int as its generic parameter
            //Employee<int> employee2 = new Employee<int>();
            ////assigns a list of integers as the property value of "Things" and initializes it
            //employee2.Things = new List<int>() { 2, 4, 6 };

            ////This loop prints all of the Things for employee1 to the console
            //foreach (var thing in employee1.Things)
            //{
            //    Console.WriteLine("Employee 1 has : " + thing);
            //}

            ////this loop prints all of the Things for employee2 to the console
            //foreach (var thing in employee2.Things)
            //{
            //    Console.WriteLine("Employee 2 has: " + thing);
            //}




            /////    SECTION 2 FOCUSES ON OPERATOR OVERLOADING WITH COMPARISON OPERATORS ///
            ////instantiate and initialize an employee object {assigns values to properties}
            //Employee employee1 = new Employee { Id = 1, FirstName = "Quinn", LastName = "Badgley"};
            //Employee employee2 = new Employee { Id = 2, FirstName = "Sammy", LastName = "Jones" };


            ////compare the two employee objects using the overloaded == and != operators
            //bool areEqual = employee1 == employee2; //this means false
            //bool areNotEqual = employee1 != employee2; //this means true 


            //Console.WriteLine("Are employee1 and employee2 equal? " + areEqual);
            //Console.WriteLine("employee1 and employee2 are NOT equal? " + areNotEqual);
            //Console.ReadLine();



            /////   SECTION 1 IS COMMENTED OUT BECAUSE I WANT TO TRY USING OPERATOR OVERLOADING WITHOUT INHERITANCE   /////
            ////instantiate and initialize an employee object
            //Employee employee = new Employee();
            //employee.FirstName = "Sample";
            //employee.LastName = "Student";

            ////call the SayName method on the employee object
            //employee.SayName();

            ////uses polymorphism to create an object of the IQuittable interface
            ////polymorphism is when a derived (inherited) class is used as a base class
            ////so the Employee class is being used as a base class for the IQuittable interface
            ////this makes the new employee object an IQuittable object (any employee object can quit)
            //IQuittable quittable = new Employee();

            ////call the Quit method on the IQuittable object
            //quittable.Quit();

            Console.ReadLine();
        }
    }
}