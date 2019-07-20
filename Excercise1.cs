using System.Collections.Generic;
using System;

namespace C_Concepts
{
    public class Excercise1
    {
        public void DoExercise()
        {
            var names = new List<string>();
            Console.WriteLine("Enter name:");
            var name = Console.ReadLine();
            while(!String.IsNullOrEmpty(name))
            {
                names.Add(name);
                Console.WriteLine("Enter name:");
                name = Console.ReadLine();
            }

            if(names.Count == 2)
            {
                System.Console.WriteLine(names[0] + " and " + names[1] + "likes your post.");
            }
            else if(names.Count > 2)
            {
                System.Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count-2) + " other likes your post.");
            }
        }
    }
}