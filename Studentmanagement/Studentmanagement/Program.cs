using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentmanagement
{
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static int newid = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n Student Management System");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Choose your option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": addstudent(); break;
                    case "2": viewstudent(); break;
                    case "3": searchstudent(); break;
                    case "4": Deletestudent(); break;
                    case "5": Console.WriteLine(" Exit"); return;
                    default: Console.WriteLine("Invalid Option."); break;

                }
            }
        }



        static void addstudent()
        {
            Console.Write("Enter your name: ");
            String name = Console.ReadLine();

            Console.Write("Enter your email: ");
            string email = Console.ReadLine();

            Console.Write("Enter your course: ");
            string course = Console.ReadLine();

            Student newstudent = new Student
            {
                id = newid,
                Name = name,
                Email = email,
                Course = course
            };


            students.Add(newstudent);
            newid++;

            Console.WriteLine("Student reg successful ");
        }

        static void viewstudent()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("Student not found!!");
                return;

            }

            Console.WriteLine("\n  ---All student----- ");

            foreach (Student item in students)
            {
                Console.WriteLine($"ID:{item.id}," +
                    $" Name : {item.Name}" +
                    $" Email : {item.Email}" +
                    $" Course : {item.Course}");



            }
        }

        static void searchstudent()
        {
            Console.Write("Enter your student ID: ");
            int id = int.Parse(Console.ReadLine());

            Student found = null;

            foreach (Student item in students)
            {
                if (item.id == id)
                {
                    found = item; break;
                }

            }
            if (found == null)
            {
                Console.WriteLine("ID not found \n Please kindly register again");
            }
            else
            {
                Console.WriteLine($"ID:{found.id}," +
               $"  Name : {found.Name}," +
               $"  Email : {found.Email}," +
               $"  Course : {found.Course}.");

            }
        }

        static void Deletestudent()
        {
            Console.Write("Enter your ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            Student toDelete = null;

            foreach (Student item in students)
            {
                if (item.id == id)
                {
                    toDelete = item; break;
                }
            }

            if (toDelete == null)
            {
                Console.WriteLine(" ID not found");
            }

            else
            {
                students.Remove(toDelete);

                Console.WriteLine("Deleted Successfully");
            }
        }

        class Student
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string Course { get; set; }

            
        }
    }
}

