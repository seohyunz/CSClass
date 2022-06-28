using System;

namespace CSClass
{
     public class Child : Parent
    {
        public string variable = "shadowing";s
        //private string input;

        public new void Method()
        {
            Console.WriteLine("자식의 메서드");
        }

        public Child() : base(10)
        {
            Console.WriteLine("Chikld():base(10)");
        }

        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(stirng input :) base(input)");
        }
    }
}