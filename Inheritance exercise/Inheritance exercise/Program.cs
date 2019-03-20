using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
    }

    class Student : Person
    {
        public int StudentId { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeId { get; set; }
    }

    class Teacher : Employee
    {
        public string Office { get; set; }

        public Teacher(string _fname, string _lname, string _empid, string _office )
        {

        }

        public string GetTeachDeets()
        {
            return $"Firstname: {Fname} \nLastname: {Lname} \n EmployeeID: {EmployeeId} \nOffice: {Office} ";
        }
    }
}
