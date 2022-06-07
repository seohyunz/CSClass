using System;

namespace CSClass
{

    internal class MyMath
    {

        int some_int=3;

         public static double  Abs(double v) //절대값을 구하는 매서드
        {
            //some_int = 5;  인스턴스 변수 : 클래스 메서드에서 사용 불가
            //foo();         인스턴스 메서드 : 클래스 메서드에서 사용 불가
            return (v < 0) ? -1 : v;
        }

        void foo()
        {
            Console.WriteLine("클래스 메서드에서 접근 불가");
        }



    }
}