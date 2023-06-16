using System;

class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }
}

static class StatisticsHelper
{
    public static double GetAverageGrade(Student[] students)
    {
        int sum = 0;
        foreach (var student in students)
        {
            sum += student.Grade;
        }
        return (double)sum / students.Length;
    }

    public static int GetHighestGrade(Student[] students)
    {
        int highestGrade = int.MinValue;
        foreach (var student in students)
        {
            if (student.Grade > highestGrade)
            {
                highestGrade = student.Grade;
            }
        }
        return highestGrade;
    }

    public static int GetLowestGrade(Student[] students)
    {
        int lowestGrade = int.MaxValue;
        foreach (var student in students)
        {
            if (student.Grade < lowestGrade)
            {
                lowestGrade = student.Grade;
            }
        }
        return lowestGrade;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter total student count:");
            int studentCount = int.Parse(Console.ReadLine());

            Student[] students = new Student[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("Enter student's name:");
                string name = Console.ReadLine();

                Console.WriteLine("Enter student's grade:");
                int grade = int.Parse(Console.ReadLine());

                students[i] = new Student { Name = name, Grade = grade };
            }

            Console.WriteLine("Average Grade: " + StatisticsHelper.GetAverageGrade(students));
            Console.WriteLine("Highest Grade: " + StatisticsHelper.GetHighestGrade(students));
            Console.WriteLine("Lowest Grade: " + StatisticsHelper.GetLowestGrade(students));
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}