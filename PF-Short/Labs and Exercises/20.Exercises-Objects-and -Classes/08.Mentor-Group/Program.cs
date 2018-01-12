using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _08.Mentor_Group
{
    class Student
    {
        public string Name { get; set; }
        public List<string> DateAtended { get; set; }
        public List<string> Comments { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Student> studentsInfo = new Dictionary<string, Student>();
            while (true)
            {
                Student student = new Student();
                string input = Console.ReadLine();
                if (input == "end of dates") { break; }
                string[] split = input.Split(' ', ',');
                string name = split[0];
                List<string> dates = split.Skip(1).ToList();
                student.Name = name;
                if (!studentsInfo.ContainsKey(name))
                {
                    student.DateAtended = dates;
                    studentsInfo.Add(name, student);
                }
                else
                {

                    studentsInfo[name].DateAtended.AddRange(dates);
                }

            }
            while (true)
            {
                Student student = new Student();
                string input = Console.ReadLine();
                if (input == "end of comments") { break; }
                string[] split = input.Split('-');
                string name = split[0];
                string comment = split[1];
                if (!studentsInfo.ContainsKey(name)) { continue; }
                if (studentsInfo[name].Comments == null)
                {

                    studentsInfo[name].Comments = new List<string>();
                    studentsInfo[name].Comments.Add(comment);
                }
                else
                {
                    studentsInfo[name].Comments.Add(comment);
                }
            }
            
            foreach (Student stud in studentsInfo.Values.OrderBy(x=>x.Name))
            {
                Console.WriteLine(stud.Name);
                Console.WriteLine("Comments:");
                if (stud.Comments != null)
                {
                    foreach (var comm in stud.Comments)
                    {
                        Console.WriteLine($"- {comm}");
                    }
                    
                }
                Console.WriteLine("Dates attended:");
                foreach (var date in stud.DateAtended.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {date}");
                }                            
            }
        }
    }
}
