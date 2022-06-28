using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSClass
{
    internal class Program
    {
        public static int number = 10;
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
            /*
                        Product product = new Product();
                        product.name ="고구마";
                        product.price = 1000;*/

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { price = 6000, name = "고구마" };
            Product productC = new Product() { name = "옥수수" };

            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
                new Student() { name = "가", grade = 100 },
                new Student() { name = "나", grade = 70 },
                new Student() { name = "다", grade = 50 },
                new Student() { name = "라", grade = 80 },
                new Student() { name = "마", grade = 90 }
            };


            /* foreach(var student in students)
             {
                 if (student.grade > 60)
                 {
                     students.Remove(student);
                 }  
             }
 */
            /*foreach (var student in students)
            {
                Console.WriteLine(student.grade);
            }

            for(int i = 0; i<students.Count; i++)
            {
                students.RemoveAt(i);
                i--;
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }*/


            for (int i = students.Count-1; i >=0; i--)
            {
                if (students[i].grade > 60)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }


            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52.3));
            Console.WriteLine(MyMath.Abs(52f));
            Console.WriteLine(MyMath.Abs(52L));

            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productY+ ":" + productY.name);
            Console.WriteLine(productX + ":" + productX.name);
            Console.WriteLine(Product.conuter + "개가 생성되었습니다.");


            SingleTon mySingle =  SingleTon.getInstance();

            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째 위치"); 
           // Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치");

            Product product = new Product("과자", 1500);


            Fibonacci fibo = new Fibonacci();
            /*Console.WriteLine(fibo.Get(1));
            Console.WriteLine(fibo.Get(2));
            Console.WriteLine(fibo.Get(3));*/
           // Console.WriteLine(Fibonacci.Get(1000));

            Cat c = new Cat();
            Dog d = new Dog();


            //List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            // List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> Animals = new List<Animal>() {
          /*      new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(),new Cat()};
            
            foreach(var item in Animals)
            {
               // item.Eat();
                item.Sleep();
                if(item is Dog) { ((Dog)item).Mong(); }
                if(item is Cat) { ((Cat)item).Meow(); }

                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }
                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
                // itme is Animal;
            }*/

            Child ChildA = new Child();
            Child ChildB = new Child("string");

            int number = 20;
            Console.WriteLine(number);

            foreach(var item in Animals)
            {
                item.Eat();
            }



        }
    }
 
}
