﻿using System;
namespace CSClass
{
    internal class Sample
    {
        private static int value = 10;

        static Sample()
        {
            value = 20;
            Console.WriteLine("정적 생성자 호출");
        }
        
    }
}