using System;
using System.Linq;
using LinqTutorials;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            var task1Result = LinqTasks.Task1();
            Console.WriteLine("Task 1:");

            
            foreach (var emp in task1Result)
            {
                Console.WriteLine(emp.Ename);
            }

            Console.WriteLine();

            // Task 2
            var task2Result = LinqTasks.Task2();
            Console.WriteLine("Task 2:");

            
            foreach (var emp in task2Result)
            {
                Console.WriteLine(emp.Ename);
            }

            Console.WriteLine();

            // Task 3
            var task3Result = LinqTasks.Task3();
            Console.WriteLine("Task 3: " + task3Result);
            Console.WriteLine();

            // Task 4
            var task4Result = LinqTasks.Task4();
            Console.WriteLine("Task 4:");

            foreach (var emp in task4Result)
            {
                Console.WriteLine(emp.Ename);
            }
            // Task 5
            var task5Results = LinqTasks.Task5();
            Console.WriteLine("Task 5:");

            foreach (var resultt in task5Results)
            {
                Console.WriteLine(
                    $"Surname: {resultt.GetType().GetProperty("Surname")?.GetValue(resultt)}, Job: {resultt.GetType().GetProperty("Job")?.GetValue(resultt)}");
            }
            // Task 6

            var task6Results = LinqTasks.Task6();
            Console.WriteLine("Task 6:");

            foreach (var resultt in task6Results)
            {
                Console.WriteLine(
                    $"Ename: {resultt.GetType().GetProperty("Ename")?.GetValue(resultt)}, Job: {resultt.GetType().GetProperty("Job")?.GetValue(resultt)}, Departments: {resultt.GetType().GetProperty("Departments")?.GetValue(resultt)}");
            }
            // Task 7

            var task7Results = LinqTasks.Task7();
            Console.WriteLine("Task 7:");

            foreach (var resultt in task7Results)
            {
                Console.WriteLine(
                    $"Job: {resultt.GetType().GetProperty("Job")?.GetValue(resultt)}, NumberOfEmployees: {resultt.GetType().GetProperty("NumberOfEmployees")?.GetValue(resultt)}");
            }

            // Task 8
            var task8Result = LinqTasks.Task8();
            Console.WriteLine("Task 8: " + task8Result);
            Console.WriteLine();

            // Task 9
            var task9Result = LinqTasks.Task9();
            
            Console.WriteLine("Task 9: " + task9Result.Ename);
            // Task 10

            var task10Results = LinqTutorials.LinqTasks.Task10();
            Console.WriteLine("Task 10:");

            foreach (var resultt in task10Results)
            {
                Console.WriteLine(
                    $"Ename: {resultt.GetType().GetProperty("Ename")?.GetValue(resultt)}, Job: {resultt.GetType().GetProperty("Job")?.GetValue(resultt)}, HireDate: {resultt.GetType().GetProperty("HireDate")?.GetValue(resultt)}");
            }
            // Task 11

            var task11Results = LinqTutorials.LinqTasks.Task11();
            Console.WriteLine("Task 11:");

            foreach (var resultt in task11Results)
            {
                Console.WriteLine($"Name: {resultt.GetType().GetProperty("name")?.GetValue(resultt)}, NumberOfEmployees: {resultt.GetType().GetProperty("numOfEmployees")?.GetValue(resultt)}");
            }
            // Task 12
            var task12Result = LinqTasks.Task12();
            Console.WriteLine("Task 12:");
            foreach (var emp in task12Result)
            {
                Console.WriteLine(emp.Ename);
            }
            // Task Task 13

            Console.WriteLine();

            var task13Result = LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 });
            Console.WriteLine("Task 13: " + task13Result);
       
            // Task 14
            var task14Result = LinqTasks.Task14();
            Console.WriteLine("Task 14:");
            foreach (var dept in task14Result)
            {
                Console.WriteLine($"Deptno: {dept.Deptno}, Dname: {dept.Dname}, Loc: {dept.Loc}");
            }
            // Task 15

            var result = LinqTasks.Task15();
            Console.WriteLine("Task 15:");

            foreach (var dept in result)
            {
                Console.WriteLine($"Deptno: {dept.Deptno}, Dname: {dept.Dname}, Loc: {dept.Loc}");
            }
            // Task 16

            var task16Result = LinqTasks.Task16();

            Console.WriteLine("Task 16:");
            foreach (var dept in task16Result)
            {
                Console.WriteLine($"Deptno: {dept.Deptno}, Dname: {dept.Dname}, Loc: {dept.Loc}");
            }
            
            
            
        }
    }
}