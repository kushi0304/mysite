using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("1～100までの整数入力:");
                for (int number = 1; number < 101; number++)
                {
                    if (number >= 80)
                        Console.Write("優");   //  numberが80以上の場合
                    else if (number <= 80 || number >= 70)
                        Console.Write("良"); //　numberが70以上80未満の場合
                    else if (number <= 70 || number >= 60)
                        Console.Write("可");  // numberが60以上70未満の場合
                    else if (number >= 60)
                        Console.Write("不可"); // numberが60未満の場合
                    else
                    {
                         Console.Write("範囲外の数値です。");
                    }
                }
            }
        }
    }

