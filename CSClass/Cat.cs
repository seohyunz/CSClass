using System;

namespace CSClass
{
    public class Cat : Animal
    {
        public Cat()
        {
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
            Console.WriteLine("고양이가 사료를 먹는다");
        }


    }
}