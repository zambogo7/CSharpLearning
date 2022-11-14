using System;
namespace Myexception
{
    
    class Program 
    {
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access Denied - You must be atleast 18 years old");

            }
            else 
            {
                Console.WriteLine("Access granted - You are old enough");
            }
        }
        static void Main(string[] args)
        {
            try 
            {
                int[] numbers = {1,2,3,4,};
                Console.WriteLine(numbers[10]);
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                Console.WriteLine("something went wrong");
            }
            finally
            {
                Console.WriteLine("the try & catch is finished");
            }
            checkAge(20);
        }
    }
}