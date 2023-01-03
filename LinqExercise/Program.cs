using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers
            Console.WriteLine("Task 1");
            Console.WriteLine();
            Console.WriteLine();
            var task1 = numbers.Sum(Num => Num);
            Console.WriteLine("Sum of all numbers is  " + task1);
            Console.WriteLine();
            Console.WriteLine();
            //TODO: Print the Average of numbers
            Console.WriteLine("Task 2");
            Console.WriteLine();
            Console.WriteLine();
            var task2 = Queryable.Average(numbers.AsQueryable());
            Console.WriteLine("Average of all numbers is " + task2);
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Task 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Numbers going up...");
            var task3 = numbers.OrderBy(Num => Num);
            foreach(var item in task3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine();
            
            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Task 4");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Going Down...");
            var task4 = numbers.OrderByDescending(Num => Num);
            foreach( var item in task4) { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Task 5");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Numbers greater than 6...");
            var task5 = numbers.Where(Num => Num > 6);
            foreach(int item in task5) { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine();
            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Task 6");
            Console.WriteLine();
            Console.WriteLine();
            var task6 = numbers.Where(Num => Num < 4);
            foreach( int item in task6) { Console.WriteLine(item); }
           
            Console.WriteLine();
            Console.WriteLine();


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Task 7");
            Console.WriteLine();
            Console.WriteLine();
            numbers[4] = 36;
            var task7 = numbers.OrderByDescending(Num => Num);
            foreach(int item in task7) { Console.WriteLine(item); }
            Console.WriteLine();
            Console.WriteLine();




            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.
            Console.WriteLine("Task 8");
            Console.WriteLine();
            Console.WriteLine();

            var Clist = employees.Where(employee => employee.FirstName.StartsWith("C"));
            var SList = employees.Where(employee => employee.FirstName.StartsWith("S"));
            foreach( var employee in Clist) { Console.WriteLine(employee.FullName); }
            foreach(var employee in SList) { Console.WriteLine(employee.FullName); }
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("Task 9");
            Console.WriteLine();
            Console.WriteLine();
            foreach (var employee in employees)
            {
                if(employee.Age > 26)
                {
                    Console.WriteLine(employee.FullName);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Task 10");
            Console.WriteLine();
            Console.WriteLine();
            var task10 = employees.Where(employee => employee.Age > 35);
           
                var YOE = task10.Sum(employee => employee.YearsOfExperience);
                
                Console.WriteLine(YOE);
            
            Console.WriteLine();
            Console.WriteLine();

            //TODO: Add an employee to the end of the list without using employees.Add()
            Console.WriteLine("Task 11");
            Console.WriteLine("Before...");
            foreach(var employee in employees) { Console.WriteLine(employee.FullName); }
            Console.WriteLine();
            Console.WriteLine();
           
            var task11 = employees.Append(new Employee { Age = 42, YearsOfExperience = 10, FirstName = "Marcus", LastName = "Smart" });
            Console.WriteLine("After...");
            foreach (var employee in task11) { Console.WriteLine(employee.FullName); }

            Console.WriteLine();

            
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
