using System;
namespace polymorphism
{
    class Animal
    {
        public virtual void animalSound()
        {
            Console.WriteLine("The animal make a sound");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says wee! wee!");
        }
    }
    class Dog : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The Dog says Boo! woo!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            Animal myPig = new Pig();
            Animal myDog = new Dog();

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

        }
      
    }
}