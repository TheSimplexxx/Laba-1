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
            console.writeline("введiть одне з +,-,*,/");
            string a = console.readline();
            console.writeline("перше число");
            int x = convert.toint32(console.readline());
            console.writeline("друге число");
            int y = convert.toint32(console.readline());
            switch (a)
            {
                case "+":
                    mydelegat mydelegat = (c, b) => c + b;
                    int del = mydelegat(x, y);
                    console.writeline("вiдповiть:{0}", del);
                    break;
                case "-":
                    mydelegat mydelegat1 = (c, b) => c - b;
                    int del1 = mydelegat1(x, y);
                    console.writeline("вiдповiть:{0}", del1);
                    break;
                case "*":
                    mydelegat mydelegat2 = (c, b) => c * b;
                    int del2 = mydelegat2(x, y);
                    console.writeline("вiдповiть:{0}", del2);
                    break;
                case "/":
                    mydelegat mydelegat3 = (c, b) => b == 0 ? 0 : c / b;
                    int del3 = mydelegat3(x, y);
                    console.writeline("вiдповiть:{0}", del3);
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
            random random = new random();
            int number = random.next(1, 10);
            console.writeline(number);
            return number;
        }


        static void main()
        {
            console.writeline("введить число елементiв масива: ");
            int n = int.parse(console.readline());
            console.writeline(new string('-', 50));

            var array = new mydelegate[n];

            for (int i = 0; i < array.length; i++)
            {
                array[i] = () => new mydelegate(getrandom)();
            }

            mydel d = delegate (mydelegate[] a)
            {
                double sr = 0;
                for (int i = 0; i < a.length; i++)
                {
                    sr += a[i]();
                }
                return sr / array.length;
            };

            console.writeline("середнє арифметичне = {0}", d(array));
            console.writeline(new string('-', 50));

            for (int i = 0; i < array.length; i++)
            {
                console.writeline(array[i]());
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





