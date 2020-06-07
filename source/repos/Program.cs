using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("１から100までの数値");
            for (int number = 0; number < 102; number++)
            {
                //80点以上なら”優”と表示
                if (number <= 100 && number >= 80)
                {
                    Console.WriteLine(number + "優");
                }
                //80点未満、70点以上なら、”良”と表示。
                else if (number <= 80 && number >= 70)
                {
                    Console.WriteLine(number + "良");
                }
                //70点未満、60点以上なら、”可”と表示
                else if (number <= 70 && number >= 60)
                {
                    Console.WriteLine(number + ":可");
                }
                //60点未満なら、”不可”と表示。
                else if (number <= 60 && number >= 1)
                {
                    Console.WriteLine(number + ":不可");
                }
                else
                {
                    //範囲外なら”範囲外”と表示。

                    Console.WriteLine(number + "範囲外。");
                }
            }
        }
    }
}