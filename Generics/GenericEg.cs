using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Person
    {
        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }

        internal Person(int id, string name, string city)
        {
            this.id = id;
            this.name = name;
            this.city = city;
        }
    }
    class GenericEg
    {
        static void ListEg()
        {
            //typesafe
            List<string> fruits = new List<string>();
            fruits.Add("Mango");
            fruits.Add("Apple");
            fruits.Add("Orange");
            fruits.Insert(1, "Pineapple");
            fruits.RemoveAt(3);
            // fruits.Add(10); //Typesafe

            List<string> Vegetables = new List<string>();
            Vegetables.Add("Carrot");
            Vegetables.Add("Beetroot");
            Vegetables.AddRange(fruits); //adding onelist anotherlist

            foreach (var list in fruits)
            {
                Console.WriteLine("Fruits:{0}", list);
            }

            Console.WriteLine("Vegetables");

            foreach (var list in Vegetables)
            {
                Console.WriteLine("Vegetables:{0}", list);
            }
        }

        //key value pair

        static void DictionaryEg()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "Java");
            dt.Add(2, "Networks");
            dt.Add(3, "AI");
            foreach (KeyValuePair<int, string> kp in dt)
            {
                Console.WriteLine(kp.Key + " " + kp.Value);
            }
        }

        static void StackEg()
        {
            //Push,Pop,Peek,Contains,Clear--Methods
            Stack<int> st = new Stack<int>();
            st.Push(40);
            st.Push(30);
            st.Push(10);
            st.Push(50);

            foreach (var stack in st)
            {
                Console.WriteLine(stack);
            }

            st.Pop();
            Console.WriteLine("After 1 pop");
            foreach (var stack in st)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine("Peek:{0}", st.Peek());
        }

        //SortedList,Queue--Do it by yousetlf

        //Generic Method
        //<T>

        internal void Swap<T>(T x, T y)
        {
            T temp;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("X is {0} || Y is {1}", x, y);
        }
  


        static void Main()
        {
            ListEg();
            Console.WriteLine("Person Details");
            Console.WriteLine("----------------------");
            List<Person> person = new List<Person>();
            person.Add(new Person(1, "Sai", "Pune"));
            person.Add(new Person(1, "Ram", "Mumbai"));
            person.Add(new Person(1, "Geetha", "Pune"));

            foreach(Person p in person)
            {
                Console.WriteLine("ID:{0} || Name:{1} || City{2}", p.id, p.name, p.city);
            }
            Console.WriteLine("------------------------------");
            DictionaryEg();
            Console.WriteLine("------------------------------");
            StackEg();
        }
    }
 
}
