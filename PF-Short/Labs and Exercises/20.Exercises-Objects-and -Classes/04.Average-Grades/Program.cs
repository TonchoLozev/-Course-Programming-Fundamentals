using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade()
        {
            return Grades.Average();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            List<KeyValuePair<string, double>> results = new List<KeyValuePair<string, double>>();
            int loops = int.Parse(Console.ReadLine());
            for (int i = 0; i < loops; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                student.Name = input[0];
                var skipper = input.Skip(1).ToList();
                student.Grades = new List<double>();
                for (int j = 0; j < skipper.Count; j++)
                {
                    student.Grades.Add(double.Parse(skipper[j]));
                }
                results.Add(new KeyValuePair<string, double>(student.Name, student.AverageGrade()));

            }
            foreach (var stud in results.OrderBy(x => x.Key).ThenByDescending(x => x.Value).Where(x => x.Value >= 5.00))
            {
                Console.WriteLine($"{stud.Key} -> {stud.Value:F2}");
            }

        }
    }
}
