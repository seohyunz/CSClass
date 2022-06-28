using System;

namespace CSClass
{
    internal class Parent
    {
        public new void Method()
        {
            Console.WriteLine("부모의  메서드");
        }

        public new void Method2()
        {
            Console.WriteLine("자식의 메서드");
        }


        public Parent()
        {
            Console.WriteLine("Parent()");
        }


        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string input)
        {
            Console.WriteLine("Parent(string input)");
        }
    }
}