using System;

namespace Laba1
{
    public delegate int MyDelegat(int a, int b);

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введiть одне з +,-,*,/");
            string a = Console.ReadLine();
            Console.WriteLine("Перше число");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Друге число");
            int y = Convert.ToInt32(Console.ReadLine());
            switch (a)
                {
                case "+": MyDelegat myDelegat = (c, b) => c + b;
                int del = myDelegat(x, y);
                Console.WriteLine("Вiдповiть:{0}", del);
                    break;
                case "-": MyDelegat myDelegat1 = (c, b) => c - b;
                int del1 = myDelegat1(x, y);
                Console.WriteLine("Вiдповiть:{0}", del1);
                    break;
                case "*": MyDelegat myDelegat2 = (c, b) => c * b;
                int del2 = myDelegat2(x, y);
                Console.WriteLine("Вiдповiть:{0}", del2);
                    break;
                case "/": MyDelegat myDelegat3 = (c, b) => b == 0 ? 0 : c / b;
                int del3 = myDelegat3(x, y);
                Console.WriteLine("Вiдповiть:{0}", del3);
                    break;
            }
        }
    }
}
