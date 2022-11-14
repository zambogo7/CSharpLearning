using System;

namespace myApplication
{
    interface IAnimal
    {
        void animalSound();
    }
    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig says: Wee! Wee!");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
        }
    }
}
