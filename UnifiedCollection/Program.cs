using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };
            var allStudents = GetAllStudents(classes);
            Console.WriteLine(string.Join(" ", allStudents));
        }

        
        /// <summary>
        /// Collect students in unified collection
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        static string[] GetAllStudents(Classroom[] classes)
        {
            List<string> allStudents = new List<string>();
            Classroom names = new Classroom();
            foreach (var c in classes)
            {
                var studentsClassRoom = names.Students.Concat(c.Students);
                allStudents.AddRange(studentsClassRoom);
            }
            return allStudents.ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}