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

            

            foreach ( Employee employess in myStack)
            {
                Console.WriteLine("Items left in stack: " + myStack.Count);
                Console.WriteLine(employess._ID + " - " + employess._FirstName + " - " + employess._LastName + " - " + employess._Gender + " - " + employess._YearlySalary);             
            }
            Console.WriteLine("-------------------------------");


            Console.WriteLine("Pop method");
            Employee em1 = myStack.Pop();
            Console.WriteLine(em1._ID + " - " + em1._FirstName + " - " + em1._LastName + " - " + em1._Gender + " - " + em1._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee em2 = myStack.Pop();
            Console.WriteLine(em2._ID + " - " + em2._FirstName + " - " + em2._LastName + " - " + em2._Gender + " - " + em2._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee em3 = myStack.Pop();
            Console.WriteLine(em3._ID + " - " + em3._FirstName + " - " + em3._LastName + " - " + em3._Gender + " - " + em3._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee em4 = myStack.Pop();
            Console.WriteLine(em4._ID + " - " + em4._FirstName + " - " + em4._LastName + " - " + em4._Gender + " - " + em4._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee em5 = myStack.Pop();
            Console.WriteLine(em5._ID + " - " + em5._FirstName + " - " + em5._LastName + " - " + em5._Gender + " - " + em5._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);




            myStack.Push(em1);
            myStack.Push(em2);
            myStack.Push(em3);
            myStack.Push(em4);
            myStack.Push(em5);

            Console.WriteLine("-------------------------------");

            Console.WriteLine("items left in stack: " + myStack.Count); 

            Console.WriteLine("-------------------------------");

            Employee emp1 = myStack.Peek();
            Console.WriteLine(emp1._ID + " - " + emp1._FirstName + " - " + emp1._LastName + " - " + emp1._Gender + " - " + emp1._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee emp2 = myStack.Peek();
            Console.WriteLine(emp2._ID + " - " + emp2._FirstName + " - " + emp2._LastName + " - " + emp2._Gender + " - " + emp2._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee emp3 = myStack.Peek();
            Console.WriteLine(emp3._ID + " - " + emp3._FirstName + " - " + emp3._LastName + " - " + emp3._Gender + " - " + emp3._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee emp4 = myStack.Peek();
            Console.WriteLine(emp4._ID + " - " + emp4._FirstName + " - " + emp4._LastName + " - " + emp4._Gender + " - " + emp4._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Employee emp5 = myStack.Peek();
            Console.WriteLine(emp5._ID + " - " + emp5._FirstName + " - " + emp5._LastName + " - " + emp5._Gender + " - " + emp5._YearlySalary);
            Console.WriteLine("items in the stack = " + myStack.Count);

            Console.WriteLine("-------------------------------");

            if (myStack.Contains(emp3))
            {
                Console.WriteLine("emp3 is in stack");
            }
            else
            {
                Console.WriteLine("emp3 is not in stack");
            }



            List<Employee> EmpList = new List<Employee>();
            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);

            Console.WriteLine("-------------------------------");

            if (EmpList.Contains(emp2))
            {
                Console.WriteLine("Employee2 object exist in the list");
            }
            else
            {
                Console.WriteLine("Emplyee2 object does not exist in the list");
            }
            Console.WriteLine("-------------------------------");
            Employee FindFemale = EmpList.Find(x => x._Gender == "Female");
            Console.WriteLine(FindFemale._ID + " - " + FindFemale._FirstName + " - " + FindFemale._LastName + " - " + FindFemale._Gender + " - " + FindFemale._YearlySalary);


            Console.WriteLine("-------------------------------");
            List<Employee> EmpList2 = new List<Employee>();
            EmpList2 = EmpList.FindAll(y => y._Gender == "Male");
            foreach (Employee AllMale in EmpList2)
            {
                Console.WriteLine(AllMale._ID + " - " + AllMale._FirstName + " - " + AllMale._LastName + " - " + AllMale._Gender + " - " + AllMale._YearlySalary);
            }
        }
    }
}
