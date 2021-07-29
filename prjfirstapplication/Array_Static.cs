using System;
namespace prjfirstapplication
{
	//by default access specifiers for class is internal
	class ArrayEg
	{
		//by default access specifiers for member and member function is private
		//single dimensional array
		//datatype[] arrayname=new datatype[size];

		string[] fruits = new string[3];
		int[] mark = { 89, 78, 90 };
		internal void GetFruits()
		{
			for(int i = 0; i < fruits.Length; i++)
            {
				Console.WriteLine("Enter the fruitname");
				fruits[i] = Console.ReadLine();
            }

			//foreach(string fu in fruits)
			//implicitly typed variable

			foreach(var fu in fruits)
            {
				Console.WriteLine("FruitName:{0}", fu);
            }
		}
	}
}
