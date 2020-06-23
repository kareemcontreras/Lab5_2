using System;
using System.Collections.Generic;

namespace Lab5_2
{
    class Program
    {
    public enum DaysoftheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            //Create a list to hold tasks
            List<string> taskList = new List<string>();

            //for each value in the Enum...let the user create a task.
            foreach (DaysoftheWeek day in Enum.GetValues(typeof(DaysoftheWeek)))
            {
                Console.WriteLine("Enter a new task for" + day);
                string task = day + " : " + Console.ReadLine();
                taskList.Add(task);
            }

            //print all of the tasks.
            foreach(string task in taskList)
            {
                Console.WriteLine(task);
            }


        }
    }
}
