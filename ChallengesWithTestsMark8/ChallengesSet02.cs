using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals) //DONE TESTS PASSED
        {
            var counter = 0;
            foreach(var word in vals)
            {
                counter++;
            }
            if (counter % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number){return number % 2 == 0;}//DONE TESTS PASSED-REFACTOR COMPLETE

        public bool IsNumberOdd(int num) { return num % 2 != 0;} //DONE TESTS PASSED -REFACTOR COMPLETE

        public double SumOfMinAndMax(IEnumerable<double> numbers)//DONE TESTS PASSED
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            var sum = numbers.Min() + numbers.Max();
           
                return sum;

        }//TESTS FAILED RETURN 0: System.InvalidOperationException : Sequence contains no elements

        public int GetLengthOfShortestString(string str1, string str2) //DONE TESTS PASSED
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }

        }

        public int Sum(int[] numbers) //DONE TESTS PASSED
        {
            var answer = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach(var num in numbers)
            {
                 answer += num;  
            }
            return answer;
        }       

        public int SumEvens(int[] numbers)//DONE TESTS PASSED
        {
            if (numbers == null)
            {
                return 0;
            }
            var evens = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens += num;
                }
            }
            return evens;
        }

        public bool IsSumOdd(List<int> numbers) //DONE TESTS PASSED
        {

            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            foreach(var num in numbers)
            {
                sum += num;
            }


            if (sum % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number) //DONE TESTS PASSED
        {
            if (number < 0)
            {
                return 0;
            }
                return number / 2;
            
  
        }
    }
}
