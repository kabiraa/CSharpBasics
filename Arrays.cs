using System;

namespace C_Concepts
{
    public class Arrays
    {
        public void DoStuffWithArrays()
        {
            var numbers = new int[] {2,5,1,8,9,7};
            // Console.WriteLine("Length of array is:" + numbers.Length);
            // System.Console.WriteLine("Index of 8 is:" + Array.IndexOf(numbers,8));
            // Array.Sort(numbers);
            // System.Console.WriteLine("Result after sort:");
            // foreach(var num in numbers)
            // {
            //     System.Console.WriteLine(num);
            // }
            var anothernumbers = new int[6];
            Array.Copy(numbers,anothernumbers,6);
            Array.Reverse(anothernumbers);
            foreach(var num in anothernumbers)
            {
                System.Console.WriteLine(num);
            }
        }
    }
}