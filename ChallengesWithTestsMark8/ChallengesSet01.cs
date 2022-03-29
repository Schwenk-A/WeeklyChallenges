using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//testpass-done

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;
        }//testpass-done

        public int Add(int number1, int number2)
        {
            return number1 + number2;
        } //testpass-done

        public int GetSmallestNumber(int number1, int number2)//testpass-done
        {
           return (number1 < number2)?  number1 :  number2;
            
        }

        public long Multiply(long factor1, long factor2)
        {
            return factor1 * factor2;
        }//testpass-done

        public string GetGreeting(string nameOfPerson)//testpass-done
        {
            return $"Hello!{nameOfPerson}";
        }

        public string GetHey()//testpass-done
        {
            return "HEY!";
        }
    }
}
