using System;                       //Erik Norell Sut21
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Labb_4___Collection_generics
{
    public class Employee
    {
        public int _ID = 0;
        public string _FirstName = "No first name";
        public string _LastName = "No last name";
        public string _Gender = "No gender";
        public int _YearlySalary = 0;


        public Employee(int ID, string FirstName, string LastName, string Gender, int YearlySalary)
        {
            _ID = ID;
            _FirstName = FirstName;
            _LastName = LastName;
            _Gender = Gender;
            _YearlySalary = YearlySalary;
        }

        public void PrintInfo()
        {
            Console.WriteLine(_ID + " - " + _FirstName + " - " + _LastName + " - " + _Gender + " - " + _YearlySalary);
        }

        public override string ToString()
        {
            return _ID + " - " + _FirstName + " - " + _LastName + " - " + _Gender + " - " + _YearlySalary;
        }
    }
}
