using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public Cat()
        {
            Age = 0;
        }

        public void Sleep()
        {
            Console.WriteLine("zz");
        }

        public void Meow()
        {
            Console.WriteLine("Meow");
        }

        public void Eat()
        {
            Console.WriteLine("eat");
        }


    }
}