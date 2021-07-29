using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplicaion
{
    class Organization
    {
        internal static string OrgName = "LTI"; //Static Variable
        string city = "Chennai"; //non-static variable

        internal static void GetOrgDetails()
        {
            Console.WriteLine(OrgName);
        }
    }
    class Employee
    {
        int Eid { get; set; }

        string? Empname { get; set; }

        string? Location { get; set; }

        int Salary { get; set; }

        int Did { get; } //Read only property

        //Constructor
        Employee()
        {
            Did = 101;
        }

        //Constructor overloading
        Employee(int Eid,string Ename, string Location,int Sal)
        {
            this.Eid = Eid;
            this.Empname = Empname;
            this.Location = Location;
            Salary = Sal;
        }

        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("Eid:{0} || Empname:{1} || Location:{2} || Salary:{3} || Did:{4} || OrgName:{5}", Eid, Empname, Location, Salary, emp.Did, Organization.OrgName);
        }

       static void Main()
        {
            int Empid, Esalary;
            string Elocation, Ename;
            int n = 2;
            Employee employee = new Employee();
            Employee[] employee1 = new Employee[n];
            for (int i = 0; i < n; i++)
            {
                //constructor
                Console.WriteLine("Enter the Eid");
                Empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter the Location");
                Elocation = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                Esalary = Convert.ToInt32(Console.ReadLine());
                employee1[i] = new Employee(Empid, Ename, Elocation, Esalary);
            }
               // Employee employee1 = new Employee(Empid, Ename, Elocation, Esalary);
               for (int i=0; i<n;i++)
            {
                employee1[i].DisplayEmployee(employee);
            }

            Organization.GetOrgDetails();
            //employee1.DisplayEmployee(employee);


        }
    }

}
