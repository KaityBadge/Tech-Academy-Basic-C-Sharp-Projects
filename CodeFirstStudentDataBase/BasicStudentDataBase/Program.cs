using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirstStudentDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var dbContext = new StudentContext())
            {
                //create and save a new student
                Console.WriteLine("Enter the new student's first name:");
                var StudentFirstName = Console.ReadLine();

                Console.WriteLine("Enter the new student's last name:");
                var StudentLastName = Console.ReadLine();

                var student = new Student { FirstName = StudentFirstName, LastName = StudentLastName };
                dbContext.Students.Add(student);
                dbContext.SaveChanges();

                Console.WriteLine("Student saved successfully!");

                //Displays all students
                var queryStudents = from s in dbContext.Students
                                    orderby s.LastName
                                    select s;

                Console.WriteLine("All students in the database:");
                foreach(var s in queryStudents)
                {
                    Console.WriteLine(s.FirstName + " " + s.LastName);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();

            }

        }
        public class Student
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public virtual List<Instructor> Instructors { get; set; }
        }
        public class Instructor
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public virtual List<Student> Students { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
        }

    }
}