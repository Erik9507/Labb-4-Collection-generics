using System;                       //Erik Norell Sut21
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Labb_4___Collection_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee(101, "Erik", "Norell", "Male", 500000);
            Employee E2 = new Employee(102, "Viktor", "Gunnarsson", "Male", 100000);
            Employee E3 = new Employee(103, "Lukas", "Rose", "Male", 200000);
            Employee E4 = new Employee(104, "Erik", "Riholm", "Male", 300000);
            Employee E5 = new Employee(105, "Anna", "Larsson", "Female", 350000);

            Stack<Employee> myStack = new Stack<Employee>();
            myStack.Push(E1);
            myStack.Push(E2);
            myStack.Push(E3);
            myStack.Push(E4);
            myStack.Push(E5);

            foreach (Employee employess in myStack)
            {
                Console.WriteLine("Items left in stack: " + myStack.Count);
                employess.PrintInfo();
            }

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Pop method");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myStack.Pop());
                Console.WriteLine("items in the stack = " + myStack.Count);
            }

            myStack.Push(E1);
            myStack.Push(E2);
            myStack.Push(E3);
            myStack.Push(E4);
            myStack.Push(E5);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("items left in stack: " + myStack.Count);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("Peek method");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(myStack.Peek());
                Console.WriteLine("items in the stack = " + myStack.Count);
            }

            Console.WriteLine("-------------------------------");

            if (myStack.Contains(E3))
            {
                Console.WriteLine("E3 is in stack");
            }
            else
            {
                Console.WriteLine("E3 is not in stack");
            }

            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);

            Console.WriteLine("-------------------------------");

            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list");
            }
            Console.WriteLine("-------------------------------");
            Employee FindFemale = EmpList.Find(x => x._Gender == "Female");
            FindFemale.PrintInfo();

            Console.WriteLine("-------------------------------");
            List<Employee> EmpList2 = new List<Employee>();
            EmpList2 = EmpList.FindAll(y => y._Gender == "Male");
            foreach (Employee AllMale in EmpList2)
            {
                AllMale.PrintInfo();
            }
        }
    }
}
