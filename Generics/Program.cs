using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics
{
    /*Query Syntax
     * from <range variable> in ienumerable<T> or iquerable<T> Collection
     * standard query operators
     * select or group by operator <result formation>
     */
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }

        internal Student(int Rollno,string Name,string City,string Gender)
        {
            this.Rollno = Rollno;
            this.Name = Name;
            this.City = City;
            this.Gender = Gender;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] book = { "English", "Tamil", "Maths", "Science" };
            //LINQ: Query Syntax
            var result = from b in book
                         select b;
            foreach(var bname in result)
            {
                Console.WriteLine(bname);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Display the book name that contains 'a'");
            //display the book name that contains 'a'
            var r = from bookname in book
                    where bookname.Contains('a')
                    select bookname;
            foreach(var bname in r)
            {
                Console.WriteLine(bname);
            }
            int[] Marks = { 90, 78, 67, 99, 100 };
            Console.WriteLine("Minimum marks: {0}", Marks.Min());
            Console.WriteLine("Maximum Marks:{0}", Marks.Max());
            //marks btw 70 to 100
            var r1 = from m in Marks
                     where m > 70 && m <= 100
                     select m;
            foreach(var marks in r1)
            {
                Console.WriteLine(marks);
            }

            //Count No of marks btw 70 and 100

            var r2 = (from m in Marks
                      where m > 70 && m <= 100
                      select m).Count();
            Console.WriteLine("No of marks btw 70 and 100:{0}", r2);
            List<Student> stu = new List<Student>()
            {
                new Student(1001,"Janaka","Trichy","female"),
                new Student(1002,"Ravi","Chennai","Male")
            };
        }
    }
}
