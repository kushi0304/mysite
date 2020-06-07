using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp4
{
    class Program
    {
        //学生情報を閲覧できるプログラムを作成する
        //必要な機能
        //・番号検索
        //・絞り込み(学年)
        //・並び替え(身長・体重)

        //番号
        static int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
        //学年
        static int[] schoolAges = new int[] { 1, 1, 2, 2, 3, 3 };
        //名前
        static string[] names = new string[] { "カトウ", "ハヤシ", "ムカイ", "タンゲ", "イトウ", "サトウ" };
        //身長
        static int[] talls = new int[] { 150, 162, 155, 161, 173, 149 };
        //体重
        static int[] waits = new int[] { 60, 57, 62, 85, 47, 53 };

        static void Main(string[] args)
        {
            //①上記の学生情報を↓のリスト(students)にまとめよう
            List<student> students = new List<student>();
            for (int i = 0; i < numbers.Length; i++)
            {
                student student = new student();
                
                student.number = numbers[i];
                
                student.age = schoolAges[i];
                
                student.name = names[i];
                
                student.tall = talls[i];
                
                student.wait = waits[i];
                
                students.Add(student);
            }

            //②学生番号で情報を取得して表示しよう
            Console.WriteLine("学生データベース");
            
            Console.WriteLine("検索する学生番号を入力してください。");
            
            //0なら一覧表示機能に移動する
            Console.WriteLine("一覧表示は[0]を入力してください。");
            
            //入力された値を取得する
            int getNumber = int.Parse(Console.ReadLine());
            
            if (getNumber == 0)
            {
                // 1～6なら指定された学生情報を表示する
            }
            else if (getNumber >= 1 && getNumber <= 6)
            {
            var student = students.First(x => x.number == getNumber);
                Console.WriteLine("番号　学年　名前　身長　体重");
                Console.WriteLine(student.number + " " + student.age + " "+ student.name +" " + student.tall +" " + student.wait);
                return;

            }
            
            //③学年で絞り込みをしてみよう(ヒント：Linqのwhere)
            Console.WriteLine("学年を指定してください。");
            Console.WriteLine("指定しない場合は[0]を入力してください。");
            
            int getAge = int.Parse(Console.ReadLine());
            
            //0の時は、指定しないので何もしない
            if (getAge == 0) 
            {
            }
            else
            {
                //該当する学生がいるか確認する。いない時は「対象の学生はいません。」と表示する。
                var student = students.Where(x => x.age == getAge).ToList(); 
                if (student.Count > 0)
                {

                }
                else
                {
                    Console.WriteLine("対象の学生はいません。");
                }
            }

            //④並び替えをしてみよう(ヒント：Linqのorderby)
            Console.WriteLine("身長が高い順は[1]、体重が軽い順は[2]、並び替えしない時は[0]を入力してください。");
            
            int getOrder = int.Parse(Console.ReadLine());
            
            //全学年
            
            if (getAge == 0)
            {
                //並び替えなし
                if (getOrder == 0)
                {
                    //何もしない
                }
                //身長が高い順
                else if (getOrder == 1)
                {
                    students = students.OrderByDescending(x => x.tall).ToList();
                }
                //体重が軽い順
                else if (getOrder == 2)
                {
                    students = students.OrderBy(x => x.wait).ToList();
                }
            
             }
            //指定の学年
            else
            {
                //並び替えなし
                if (getOrder == 0)
                {
                    students = students.Where(x => x.age == getAge).ToList();
                }

                //身長が高い順
                else if (getOrder == 1)
                {
                    students = students.Where(x => x.age == getAge).OrderByDescending(x => x.tall).ToList();
                }

                //体重が軽い順
                else if (getOrder == 2)
                {
                    students = students.Where(x => x.age == getAge).OrderBy(x => x.wait).ToList();
                }

                //学生情報を表示する
                Console.WriteLine("番号　学年　名前　身長　体重");

                foreach (var item in students) 
                {
                    Console.WriteLine(item.number + " " + item.age + " " + item.name + " " + item.tall + " " + item.wait);
                }
            }
        }
    }

    /// <summary>
    /// 学生情報用クラス
    /// </summary>
    class student
    {
        /// <summary>
        /// 学生番号
        /// </summary>
        public int number { get; set; }
        /// <summary>
        /// 学年
        /// </summary>
        public int age { get; set; }
        /// <summary>
        /// 名前
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 身長
        /// </summary>
        public int tall { get; set; }
        /// <summary>
        /// 体重
        /// </summary>
        public int wait { get; set; }

    }
}