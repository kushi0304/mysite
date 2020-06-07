using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //  数値の表示
            //Console.Write(123);
            //Console.WriteLine(456);
            //  文字列の表示
            //Console.Write("ABC");
            //Console.WriteLine("DEF");
            //Console.WriteLine("櫛田裕紀");
            //Console.WriteLine("123456789");
            //Console.WriteLine("こんにちは");
            //Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2);  //  足し算
            //Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);  //  引き算
            //Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);  //  掛け算
            //Console.WriteLine("{0} * {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);//  割り算と剰余
            //Console.WriteLine("{0} + {1} = {2}", 5, 2, 5 + 2); // 足し算
            //int a;           // 変数の宣言
            //int b = 3;      //  初期化と代入を同時に行う。
            //int add, sub;    //  複数の変数を同時に宣言
            //double avg;     //  int以外の変数を宣言
            // a = 6;  //  代入（最初に値を入れるので、”初期化”と言う。
            //add = a + b;            //  a,bの和を求める。
            //sub = a - b;            //  a,bの差を求める。
            // avg = (a + b) / 2.0;    //  a,bの平均値を求める。
            //Console.WriteLine("{0} + {1} = {2}", a, b, add);
            // Console.WriteLine("{0} - {1} = {2}", a, b, sub);
            // Console.WriteLine("{0}と{1}の平均値{2}", a, b, avg);
            // 使用する変数の定義
            // int a1 = 2, b1 = 2, c1 = 2, d1 = 2;    // 変数の宣言(1)
            //int a2 = 2, b2 = 2, c2 = 2, d2 = 2;    // 変数の宣言(2)
            //  普通の演算による計算と代入
            //a1 = a1 + 1;
            // b1 = b1 - 1;
            //c1 = c1 * 2;
            // d1 = d1 / 2;
            //  代入演算による計算
            // a2 += 1;
            //  b2 -= 1;
            //  c2 *= 2;
            // d2 /= 2;
            // Console.WriteLine("a1={0} b1={1} c1={2} d1={3}", a1, b1, c1, d1);
            // Console.WriteLine("a2={0} b2={1} c2={2} d2={3}", a2, b2, c2, d2);
            // int a;
            // double b, c, d;
            // a = (int)1.23;  //  キャストで代入
            // b = 1.23;
            //c = 10;         //  キャストなしで代入
            //d = (double)c;  //  キャストありで代入
            // Console.WriteLine("a={0} b={1} c={2} d={3}", a, b, c, d);
            //string str1, str2;
            //Console.Write("str1=Hello");
            //str1 = Console.ReadLine();  //  １つ目の文字列を入力
            //Console.Write("str2=World");
            // str2 = Console.ReadLine();  //  ２つ目の文字列を入力
            //Console.WriteLine("str1 + str2 = {0}", str1 + str2);
            //const int NUMBER = 100;
            //const string STRING = "Hoge";
            //Console.WriteLine(NUMBER);
            //Console.WriteLine(STRING);
            //  constがついた変数は値を変えられない
            //NUMBER = 100;
            //STRING = "fuga";
            // Console.WriteLine("{0} + {1} = {2}", 5, 3, 5 + 3);  //  足し算
            // Console.WriteLine("{0} - {1} = {2}", 5, 2, 5 - 2);  //  引き算
            //Console.WriteLine("{0} * {1} = {2}", 5, 2, 5 * 2);  //  掛け算
            // Console.WriteLine("{0} * {1} = {2} 余り {3}", 5, 2, 5 / 2, 5 % 2);//  割り算と剰余
            //int a = 4, b = 2;
            //Console.WriteLine("a = {0}", a);
            //Console.WriteLine("b = {0}", b);
            //Console.WriteLine("a + b = {0}", a + b);
            //Console.WriteLine("a - b = {0}", a - b);
            //Console.WriteLine("a * b = {0}", a * b);
            //Console.WriteLine("a / b = {0}", a / b);
            //Console.WriteLine("a % b = {0}", a % b);
            //int a1 = 1, b1 = 2, c1 = 3, d1 = 4, e1 = 5;
            //int a2 = 1, b2 = 2, c2 = 3, d2 = 4, e2 = 5;
            //a1 = a1 + 2;  //  aに2を加える
            //b1 = b1 - 1;  //  bから1を引く
            //c1 = c1 * 3;  //  cに3をかける
            //d1 = d1 / 2;  //  dを2で割る
            //e1 = e1 % 2;  //  eに、eを2で割った余りを代入する
            //  代入演算による計算
            //a2+=2;  //  aに2を加える
            //b2-=1;  //  bから1を引く
            //c2*=3;  //  cに3をかける
            //d2/=2;  //  dを2で割る
            //e2%=2;  //  eに、eを2で割った余りを代入する
            //Console.WriteLine("a1={0} b1={1} c1={2} d1={3}", a1, b1, c1, d1);
            //Console.WriteLine("a2={0} b2={1} c2={2} d2={3}", a2, b2, c2, d2);
            //string str;
            //Console.Write("str=Bird");
            //str = Console.ReadLine();  //  文字列を入力
            // string str1,str2;
            //Console.Write("str1=Good");
            //str1= Console.ReadLine();  //  １つ目の文字列を入力
            //Console.Write("str2=Morning");
            //str2= Console.ReadLine();  //  2つ目の文字列を入力
            //Console.WriteLine("str1 + str2 = {0}", str1 + str2);
            //  キーワードから数値を入力
            // Console.Write("整数値を入力:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("a=" + a);
            //  入力した値が、正の数かどうかを調べる
            //if (a > 0)
            // Console.WriteLine("aは正の数です。");  //  正の数だった場合に実行
            //  キーワードから数値を入力
            //{
            //  キーワードから数値を入力
            //Console.Write("整数値を入力:");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("a=" + a);
            //  入力した値が、正の数かどうかを調べる
            //if (a > 0)
            //{
            //  Console.WriteLine("aは正の数です。");  //  正の数だった場合に実行
            //}
            {
                //  キーボードから数値を入力
                //  Console.Write("1から3の整数を入力:");
                //int num = int.Parse(Console.ReadLine());
                //if (num == 1)
                {
                    //    Console.WriteLine("one");    //  numが1だった場合の処理
                }
                //else if (num == 2)
                {
                    // Console.WriteLine("two");    //  numが2だった場合の処理
                }
                //else if (num == 3)
                {
                    //    Console.WriteLine("three");  //  numが3だった場合の処理
                }
                //else
                {
                    // Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理
                    //  サイコロの目を入力
                    //Console.Write("さいころの目(1～6):");
                    //  コンソールから数値を入力
                    // int dice = int.Parse(Console.ReadLine());
                    //  値が、サイコロの目の範囲内かどうかを調べる
                    //if (1 <= dice && dice <= 6)
                    {
                        //  さいころの目が、偶数か、奇数かで、処理を分ける。
                        //if (dice == 2 || dice == 4 || dice == 6)
                        {
                            //    Console.WriteLine("丁（チョウ）です。");  //  偶数ならば丁（チョウ）
                        }
                        //  else
                        {
                            //        Console.WriteLine("半（ハン）です。");   //  奇数ならば半（ハン）
                        }
                    }
                    //  else
                    {
                        // Console.WriteLine("範囲外の数値です。");
                        // Console.Write("1から3の整数を入力:");
                        //int num = int.Parse(Console.ReadLine());
                        //switch (num)

                        //  case 1:
                        //     Console.WriteLine("one");    //  numが1だった場合の処理
                        //   break;
                        //case 2:
                        //  Console.WriteLine("two");    //  numが2だった場合の処理
                        //        break;
                        //  case 3:
                        //    Console.WriteLine("three");  //  numが3だった場合の処理
                        //  break;
                        //default:
                        //  Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理
                        //break;
                        //  キーワードから数値を入力
                        //Console.Write("整数値を入力:");
                        //  int a = int.Parse(Console.ReadLine());
                        //       Console.WriteLine("a=" + a);
                        //  入力した値が、3かどうかを調べる
                        //  if (a == 3)
                        {
                            //   Console.WriteLine("aは3です。");  //  正の数だった場合に実行
                            //  キーワードから数値を入力
                            // Console.Write("整数値を入力:");
                            //int a = int.Parse(Console.ReadLine());
                            //Console.WriteLine("a=" + a);
                            //  入力した値が、4かどうかを調べる
                            //if (a == 4)
                            {
                                //    Console.WriteLine("aは4です。");  //  4だった場合に実行
                                //}
                                //else
                                {
                                    // Console.WriteLine("aは4ありません。");
                                    //}
                                    //  キーワードから数値を入力
                                    // Console.Write("整数値を入力:");
                                    //int a = int.Parse(Console.ReadLine());
                                    //Console.WriteLine("a=" + a);
                                    //  入力した値が、正の数かどうかを調べる
                                    //if (a < 50)
                                    {
                                        //    Console.WriteLine("aは50未満です。");  //  50未満の場合に実行
                                        //}
                                        //else
                                        {
                                            //  Console.WriteLine("aは50未満ではありません。");
                                            //  キーボードから数値を入力
                                            Console.Write("整数を入力:");
                                            int num = int.Parse(Console.ReadLine());
                                            if (num >= 20)
                                            {
                                                Console.WriteLine("20以下か80以上の値です");    //  numが20以上だった場合の処理
                                            }
                                            else if (num <= 80)
                                            {
                                                Console.WriteLine("20以下か80以上の値です");    //  numが80以下だった場合の処理
                                            }
                                            else if (num <= 20)
                                            {
                                                Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理

                                            else if (num >= 80)
                                                    {
                                                        {
                                                            Console.WriteLine("不適切な値です。"); //  それ以外の値が入力された場合の処理
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
｝