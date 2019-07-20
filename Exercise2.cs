using System.Numerics;
using System.Linq;
using  System;

namespace C_Concepts
{
    public class Exercise2
    {
        public void DoStuffWithStringBuilder()
        {
            bool isConsecutiveNumbers = false;
            System.Console.WriteLine("Enter numbers with hypen");
            var input = Console.ReadLine();
            var numbers = input.Split('-');
            for(int i = 0; i < numbers.Count(); i++)
            {
                if(i!=0)
                {
                    if(Convert.ToInt32(numbers[i]) - Convert.ToInt32(numbers[i-1]) == 1)
                    {
                        isConsecutiveNumbers = true;
                    }
                    else{
                        isConsecutiveNumbers = false;
                        break;
                    }
                }
            }

            if(isConsecutiveNumbers)
            System.Console.WriteLine("Numbers are consecutive");
            else
            System.Console.WriteLine("Numbers are non consecutive");
        }
    }
}