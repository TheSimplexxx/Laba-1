using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba1
{
    public delegate int mydelegat(int a, int b);

    class program
    {
        static void main()
        {
            Console.WriteLine("введiть одне з +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("перше число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("друге число");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case "+":
                    mydelegat mydelegat = (c, b) => c + b;
                    int del = mydelegat(x, y);
                    Console.WriteLine("вiдповiть:{0}", del);
                    break;
                case "-":
                    mydelegat mydelegat1 = (c, b) => c - b;
                    int del1 = mydelegat1(x, y);
                    Console.WriteLine("вiдповiть:{0}", del1);
                    break;
                case "*":
                    mydelegat mydelegat2 = (c, b) => c * b;
                    int del2 = mydelegat2(x, y);
                    Console.WriteLine("вiдповiть:{0}", del2);
                    break;
                case "/":
                    mydelegat mydelegat3 = (c, b) => b == 0 ? 0 : c / b;
                    int del3 = mydelegat3(x, y);
                    Console.WriteLine("вiдповiть:{0}", del3);
                    break;
            }
        }
    }


    class program2
    {

        delegate int mydelegate();
        delegate double mydel(mydelegate[] a);

        static int getrandom()
        {
            Random Random = new Random();
            int number = Random.Next(1, 10);
            Console.WriteLine(number);
            return number;
        }


        static void Main()
        {
            Console.WriteLine("введить число елементiв масива: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('-', 50));

            var array = new mydelegate[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = () => new mydelegate(getrandom)();
            }

            mydel d = delegate (mydelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.Length;
            };

            Console.WriteLine("середнє арифметичне = {0}", d(array));
            Console.WriteLine(new string('-', 50));

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]());
            }
        }
    }

    class Program3
    {
        static void Calculate(int a, int b, int c)
        {
            Console.WriteLine("середнє арифметичне: " + ((a + b + c) / 3).ToString());
            Console.ReadKey();
        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Введіть 1 число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть 2 число");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть 3 число");
            c = Convert.ToInt32(Console.ReadLine());

            Calculate(a, b, c);

        }


    }

}





