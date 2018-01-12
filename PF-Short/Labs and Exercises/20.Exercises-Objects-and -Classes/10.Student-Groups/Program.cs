using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _10.Student_Groups
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
    public class Town
    {
        public string Name { get; set; }
        public int SeatCount { get; set; }
        public List<Student> Students { get; set; }
    }
    public class Group
    {
        public Town Town { get; set; }
        public List<Student> Students { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ReadTownAndStudents();
        }
        static List<Town> ReadTownAndStudents()
        {
            var towns = new List<Town>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End") { break; }
                if(input.Contains("=>"))
                {
                    Town townObject = new Town();
                    var split = input.Split(new char[] { '=', '>' },StringSplitOptions.RemoveEmptyEntries);
                    string[] seats = split[1].Trim().Split();
                    townObject.Name = split[0].Trim();
                    townObject.SeatCount = int.Parse(seats[0].Trim());
                    townObject.Students = new List<Student>();
                    towns.Add(townObject);
                }
                else
                {
                    Student studentObject = new Student();                                        

                    string[] splitInput = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                    studentObject.Name = splitInput[0].Trim();
                    studentObject.Email = splitInput[1].Trim();
                    studentObject.RegistrationDate = DateTime.ParseExact(splitInput[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    towns[towns.Count-1].Students.Add(studentObject);
                }
            }
            return towns;
        }
    }
}
