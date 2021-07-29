using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prjThirdApplication
{
    // Query Syntax
    // from <range variable> in ienumerable<T> or iquerable<T> Collection
    // Standard Query Operators
    // select or group by operator <result formation>

    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        internal Student(int RollNo, string Name, string City, string Gender,int Age)
        {
            this.RollNo = RollNo;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
            this.Age = Age;
        }

    }
    class LINQ_Example
    {
        static void Main()
        {
            string[] book = { "English", "Maths", "Science", "Hindi" };

            // LINQ : Query Syntax
            // display all books
            var result = from b in book
                         select b;
            foreach(var b in result)
            {
                Console.WriteLine("Books: {0}", b);
            }
            Console.WriteLine("----------------------------");

            // display books that contain 'a'
            var booka = from b in book
                        where b.Contains('a')
                        select b;

            //Method Syntax
            var m1 = book.Where(s => s.Contains('a'));

            foreach (var b in booka)
            {
                Console.WriteLine("Books that contain 'a': {0}", b);
            }
            Console.WriteLine("----------------------------");

            int[] Marks = { 90, 78, 67, 99, 100 };
            // Min and Max Marks
            Console.WriteLine("Minimum Marks: {0}", Marks.Min());
            Console.WriteLine("Maximum Marks: {0}", Marks.Max());
            Console.WriteLine("----------------------------");

            // display marks between 70 and 100
            var marks = from m in Marks
                        where m > 70 && m <= 100
                        select m;
            //Method Syntax
            var m2 = Marks.Where(mark => mark > 70 && mark <= 100);

            foreach (var m in marks)
            {
                Console.WriteLine("Marks between 70 and 100: {0}", m);
            }
            Console.WriteLine("----------------------------");

            // Count number of marks between 70 and 100
            var marksc = (from m in Marks
                          where m > 70 && m <= 100
                          select m).Count();
            Console.WriteLine("Number of marks between 70 and 100: {0}", marksc);
            Console.WriteLine("----------------------------");

            List<Student> student = new List<Student>()
            {
                new Student(1001, "Shraddha", "Mumbai", "Female",24),
                new Student(1002, "John", "Chennai", "Male",22),
                new Student(1003, "Roshni", "Bangalore", "Female",20)
            };

            //Method Syntax
            //display max age of student
            var stu = student.Max(stud => stud.Age);


            // display name and city where city is chennai
            var stucity = from s in student
                          where s.City == "Chennai"
                          select s;
            // OR
            var stucity1 = from s in student
                          where s.City == "Chennai"
                          select new { s.Name, s.City };
            foreach (var s in stucity1)
            {
                Console.WriteLine("Name: {0} || City: {1}", s.Name,s.City);
            }
            Console.WriteLine("----------------------------");

            // order the student info based on gender
            var stuorder = from s in student
                           orderby s.Gender, s.City
                           select s;
            foreach (var s in stuorder)
            {
                Console.WriteLine("Name: {0} || City: {1} || Gender: {2}", s.Name, s.City, s.Gender);
            }
            Console.WriteLine("----------------------------");

            //groupby number of males and female
            var stumf = from s in student
                        group s by s.Gender;
            foreach (var s in stumf)
            {
                Console.WriteLine(s.Key + " " + s.Count());
            }
        }
    }
}
