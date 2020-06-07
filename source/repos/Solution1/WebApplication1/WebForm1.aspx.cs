using AngleSharp.Html.Dom;
using AngleSharp.Io;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page

    {
        /// <summary>
        /// 学生情報リスト
        /// </summary>
        protected List<student> StudentsList;
        protected void Page_Load(object sender, EventArgs e, int number)
        {
            if (Request.Form["search"] != null)
            {
                //検索ボタンを押した時
                int.TryParse(Request.Form["number"], out int number);
                int age = int.Parse(Request.Form["age"]);
                int order = int.Parse(Request.Form["order"]);
                NameValueCollection name = System.Web.HttpUtility.ParseQueryString(string.Empty);
                if (number > 0)
                {
                    name["number"] = number.ToString();
                }
                if (age > 0)
                {
                    name["age"] = age.ToString();
                }
                if (order > 0)
                {
                    name["order"] = order.ToString();
                }
                Response.Redirect(Request.Url.AbsolutePath + (name.ToString() == string.Empty ? "" : "?" + name.ToString()));
                return;
            }
            StudentsList = GetStudents();
            //TryParseを使って番号、学年、並び替え(if else)のパラメータの値を取得して、リストの編集を行う
            int.TryParse(Request.Form["number"], out number);
            int age = int.Parse(Request.Form["age"]);
            int order = int.Parse(Request.Form["order"]);
            switch ()
            { 
            case number:
                        (Request.QueryString["number"] == "1");
            break;
            case age;
                        (Request.QueryString["age"] == "1");
            break;
            case order;
                        (Request.QueryString["order"] == "1");
            break;
            }
        }
    }
        /// <summary>
        /// 学生情報用クラス
        /// </summary>
        protected class student
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

        /// <summary>
        /// 学生情報のリストを取得する
        /// </summary>
        /// <returns></returns>
        protected List<student> GetStudents()
        {
            //番号
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            //学年
            int[] schoolAges = new int[] { 1, 1, 2, 2, 3, 3 };
            //名前
            string[] names = new string[] { "カトウ", "ハヤシ", "ムカイ", "タンゲ", "イトウ", "サトウ" };
            //身長
            int[] talls = new int[] { 150, 162, 155, 161, 173, 149 };
            //体重
            int[] waits = new int[] { 60, 57, 62, 85, 47, 53 };

            var list = new List<student>();
            for (int i = 0; i < numbers.Length; i++)
            {
                student student = new student();
                student.number = numbers[i];
                student.age = schoolAges[i];
                student.name = names[i];
                student.tall = talls[i];
                student.wait = waits[i];
                list.Add(student);
            }
            return list;
        }
    }
}