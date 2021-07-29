using System;
namespace prjfirstapplication
{
	class Datatypes
	{
		void Types()
		{
			string name;
			int age;
			float salary = 67900.89f;
			Console.WriteLine("Enter the name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Enter the age:");
			age = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Name:{0} && Age:{1} && Salary:{2}", name, age, salary);
		}
		static void Main()
        {
			Datatypes datatypes = new Datatypes();
			datatypes.Types();
        }
	}
}
