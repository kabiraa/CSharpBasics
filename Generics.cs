using System.Collections.Generic;

namespace C_Concepts
{
    public class Generics
    {
        public void DoStuffWithGenerics()
        {
            var numbers = new List<int>() {1,2};
            numbers.Add(5);
            numbers.AddRange(new int[2] {7,8});

            foreach(var num in numbers)
            {
              System.Console.WriteLine(num);  
            }

            System.Console.WriteLine("Index is" + numbers.IndexOf(1));;

            numbers.Remove(7);
            numbers.RemoveAt(3);

            System.Console.WriteLine("After removal");

            foreach(var num in numbers)
            {
              System.Console.WriteLine(num);  
            }
        }
    }
}