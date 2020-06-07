using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    //  最大値と最小値を求めるクラス
    class MinMax
    {
        //  最大値の取得
        public int Max(int n1, int n2, int n3)
        {
            if (n1 > n2)
            {
                if (n1 > n3)
                {
                    return n1;
                }
                else
                {
                    return n3;
                }
            }
            else
            {
                if (n2 > n3)
                {
                    return n2;
                }
                else
                {
                    return n3;
                }
            }
        }
        //  最大値の取得
        public int Min(int n1, int n2, int n3)
        {
            if (n1 < n2)
            {
                if (n1 < n3)
                {
                    return n1;
                }
                else
                {
                    return n3;
                }
            }
            else
            {
                if (n2 < n3)
                {
                    return n2;
                }
                else
                {
                    return n3;
                }
            }
        }
    }
}