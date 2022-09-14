using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace PractiseAssignmnets
{
    internal class RetrieveData
    {
        public class Student
        {
            public int StudentID { get; set; }
            public string SName { get; set; }
            public int Age { get; set; }
            public string Grade { get; set; }
        }

        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines(@"C:\MPHASIS LEARNING ACADEMY\s.txt");

            List<Student> list = new List<Student>();
            foreach (string student in lines)
            {

                Student s = new Student();
                string[] splitdata = student.Split(' ');
                s.StudentID = Convert.ToInt32(splitdata[0]);
                s.SName = splitdata[1];
                s.Age = Convert.ToInt32(splitdata[2]);
                s.Grade = splitdata[3];
                list.Add(s);
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Sorted List");
            Console.ForegroundColor = ConsoleColor.White;
            var SortedList = list.OrderBy(s => s.SName);

            Console.WriteLine();
            foreach (var item in SortedList)
            {


                Console.WriteLine("StudentID      : " + item.StudentID);
                Console.WriteLine("Student's Name : " + item.SName);
                Console.WriteLine("Age            : " + item.Age);
                Console.WriteLine("Grade          : " + item.Grade);
                Console.WriteLine();

            }
            Console.WriteLine("================================================");
            Console.WriteLine("Enter student's name to be searched:");
            string name = Console.ReadLine();

            var search = list.FindAll(f => f.SName == name);
            foreach (var item in search)
            {

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Student ID     : " + item.StudentID);
                Console.WriteLine("Student's Name : " + item.SName);
                Console.WriteLine("Age            : " + item.Age);
                Console.WriteLine("Grade          : " + item.Grade);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

            }

            Console.ReadLine();
        }
    }
}
