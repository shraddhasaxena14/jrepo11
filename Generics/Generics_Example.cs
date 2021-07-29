using System;
using System.Collections.Generic;
using System.Text;

namespace prjThirdApplication
{
    class Person
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        internal Person(int ID, string name, string city)
        {
            this.ID = ID;
            this.name = name;
            this.city = city;
        }
    }
    class Generics_Example
    {
        static void List_Example()
        {
            List<string> fruits = new List<string>();
            fruits.Add("Apple");
            fruits.Add("Mango");
            fruits.Add("Banana");

            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);
            // fruits.Add(10) //Type safe - error

            List<string> vegetables = new List<string>();
            vegetables.Add("Carrot");
            vegetables.Add("Beetroot");
            vegetables.AddRange(fruits);  // Adding one list to another

            foreach (var f in fruits)
            {
                Console.WriteLine("Fruits: {0}", f);
            }
            Console.WriteLine("----------------------------------");
            foreach (var v in vegetables)
            {
                Console.WriteLine("Vegetables: {0}", v);
            }
        }

        static void Dictionary_Example()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Yashvi");
            dt.Add(2, "Alex");
            dt.Add(3, "Laura");

            foreach(KeyValuePair<int,string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        static void Stack_Example()
        {
            Stack<int> st = new Stack<int>();
            st.Push(10);
            st.Push(20);
            st.Push(30);
            st.Push(40);

            foreach(var stack in st)
            {
                Console.WriteLine("Stack: {0}", stack);
            }
            st.Pop();
            Console.WriteLine("\n1st Pop\n");
            foreach (var stack in st)
            {
                Console.WriteLine("Stack: {0}", stack);
            }
            Console.WriteLine("\nStack Peek: {0}", st.Peek());
        }

        static void SortedList_Example()
        {
            SortedDictionary<int, string> sd = new SortedDictionary<int, string>();
            sd.Add(1, "Yashvi");
            sd.Add(2, "Alex");
            sd.Add(3, "Laura");
            
            foreach (KeyValuePair<int, string> skp in sd)
            {
                Console.WriteLine(skp.Key + " " + skp.Value);
            }
        }

        static void Queue_Example()
        {
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);
            qu.Enqueue(40);

            foreach (var queue in qu)
            {
                Console.WriteLine("Queue: {0}", queue);
            }
        }

        static void Main()
        {
            List_Example();
            Console.WriteLine("----------------------------");
            Dictionary_Example();
            Console.WriteLine("----------------------------");
            Stack_Example();
            Console.WriteLine("----------------------------");
            SortedList_Example();
            Console.WriteLine("----------------------------");
            Queue_Example();
            Console.WriteLine("----------------------------");
            Console.WriteLine("----------------------------");

            List<Person> person = new List<Person>();
            person.Add(new Person(1, "Yashvi", "Mumbai"));
            person.Add(new Person(2, "Alex", "Chennai"));
            person.Add(new Person(3, "Laura", "Bangalore"));

            foreach(Person p in person)
            {
                //Console.WriteLine("Person: {0}", p); // wrong way, no output
                Console.WriteLine("ID: {0} || Name: {1} || City: {2}", p.ID, p.name, p.city);
            }
        }
    }
}
