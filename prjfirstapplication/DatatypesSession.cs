using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplicaion
{
   
    class DatatypesSession
    {
        void Types()
        {
            String name;
            int age;
            float salary = 67900.89f;
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Console.Read();
            Console.WriteLine("Name:{0} && Age{1} && Salary{2}", name, age, salary);
        }
        void TypeConversion()
        {
            int num = 100;
            float petrol = num;
            double diesel = petrol;
            Console.WriteLine("Implicit type conversion: {0}", diesel);
        }

        void BoxingandUnboxing()
        {
            //converting value types to reference types is called boxing
            int salary = 20000;
            Object obj = salary;

            //converting reference type to value types
            int number = (int)obj;
            Console.WriteLine("BoxingandUnboxing:{0}", number);

        }

        void NullableTypes()
        {
            int? age = null;
            Console.WriteLine("Age is {0}",age??0);
            String? city = null;
            Console.WriteLine("City is {0}",city??"Mumbai");
        }
        static void Main()
        {
            DatatypesSession datatypes = new DatatypesSession();
            datatypes.Types();
            Console.WriteLine("----------------");
            datatypes.TypeConversion();
            Console.WriteLine("----------------");
            datatypes.NullableTypes();
            Console.WriteLine("----------------");
            datatypes.BoxingandUnboxing();  

        }

    }
}
