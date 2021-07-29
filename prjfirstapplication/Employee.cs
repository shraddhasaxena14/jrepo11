using System;
namespace prjfirstapplication
{
	class Employee
	{
		//Property

		int Eid { get; set; }
		string? Empname { get; set; }
		string? Location { get; set; }
		int Salary { get; set; }
		int Did { get; } //Read only property
        
		//Constructor
		//Initialize values for the variables

        Employee()
        {
			Did = 101;
        }

		Employee(int Eid,string Empname,string Location,int Sal)
        {
			//this represents current class instance(employee) variable
			this.Eid = Eid;
			this.Empname = Empname;
			this.Location = Location;
			Salary = Sal;

        }

		void DisplayEmployee(Employee emp)
        {
			Console.WriteLine("Eid:{0} || EmpName:{1} || Location:{2} || Salary:{3} || Did:{4}", Eid, Empname, Location, Salary, emp.Did);
        }
		static void Main()
		{
			int Empid, Esalary;
			string Elocation, Ename;
			Employee employee = new Employee();
			/*Property
			employee.Eid = 1001;
			employee.Empname = "Anu";
			employee.Location = "Chennai";
			employee.Salary = 670000;
			//employee.Did = 101; --error because it is read only
			Console.WriteLine("eid:{0} || ename:{1} || location:{2} || salary:{3} || did:{4}",
				employee.Eid, employee.Empname, employee.Location, employee.Salary, employee.Did);*/

			//Constructor
			Console.WriteLine("Enter the Eid:");
			Empid = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter the name:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Ename = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Enter the location:");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Elocation = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Enter the salary:");
			Esalary = Convert.ToInt32(Console.ReadLine());

			Employee employee1 = new Employee(Empid, Ename, Elocation, Esalary);

			employee1.DisplayEmployee(employee);
		}
	}
}
