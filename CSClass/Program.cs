using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));


            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);

           List<int> list = new List<int>() { 2,3,6,7};
            list.Remove(6); //값삭제
            list.RemoveAt(0); //방에 있는 값 삭제
            foreach (var item in list)
            {
                Console.WriteLine("Count:" + list.Count + "\t" + item);
            }

            Console.WriteLine(Math.Abs(-52211));
            Console.WriteLine(Math.Ceiling(522.11));
            Console.WriteLine(Math.Floor(52.141)); ;
            Console.WriteLine(Math.Round(53.723));
            Console.WriteLine(Math.Min(54,213));
            Console.WriteLine(Math.Max(54,213));
            Console.WriteLine(Math.PI);

            Product product = new Product();


        }
    }
 
}
