using System;
using System.Collections.Generic;
using System.Text;

namespace prjThirdApplication
{
    //Generic Class
    class Sample<T>
    {
        T Name, City;
        internal Sample(T Name, T City)
        {
            this.Name = Name;
            this.City = City;
        }

        //Normal method
        internal void Add(int x, int y)
        {
            Console.WriteLine("Add: {0}", (x + y));
        }

        //Generic Method ---> <T>
        internal void Swap<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} and Y is {1}", x, y);
        }
    }

    //Generic Constraint
    // where T : struct ------> value type
    // where T : class ------> reference type
    // where T : new ------> default parameter constraint
    // where T : <interface name> ------> value type

    class Student<T> where T : struct
    {

    }

    class Generics_ClassMethod
    {
        static void Main()
        {
            Sample<string> sample = new Sample<string>("Anu","Chennai");
            sample.Swap<int>(6, 8);
            sample.Swap<string>("Hello", "World");
            sample.Add(6, 8);

            // Struct Constraint 
            // Error because student class will accept only struct value(Value type)
            // Student<string> student = new Student<string>();

            Student<int> student = new Student<int>();
        }
    }
}
