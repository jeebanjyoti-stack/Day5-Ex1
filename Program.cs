using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of working days for each employee: ");
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            int[][] salaries = new int[numberOfEmployees][];

            for (int i = 0; i < numberOfEmployees; i++)
            {
                salaries[i] = new int[numberOfWorkingDays];
                Console.WriteLine($"Enter salary for Employee {i + 1}:");
                for (int j = 0; j < numberOfWorkingDays; j++)
                {
                    Console.Write($"Enter salary for Day {j + 1}: ");
                    salaries[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nDisplay:");

            for (int i = 0; i < numberOfEmployees; i++)
            {
                int totalSalary = 0;
                Console.Write($"Employee {i + 1}: ");
                for (int j = 0; j < numberOfWorkingDays; j++)
                {
                    Console.Write($"{salaries[i][j]} ");
                    totalSalary += salaries[i][j];
                }
                Console.WriteLine($"Total Salary: {totalSalary}");
            }


        }
    }
}
