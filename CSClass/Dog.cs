using System;

namespace CSClass
{
    public class Dog :Animal
    {
        int Age;

        public Dog()
        {
            Age = 0;
        }

        public void Sleep()
        {
            Console.WriteLine("zz");
        }

        public void Bark()
        {
            Console.WriteLine("멍멍");
        }

        public void Eat()
        {
            Console.WriteLine("강아지가 사료를 먹는다");
        }

    }
}