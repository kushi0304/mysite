using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        /// <summary>
        /// 学生情報リスト
        /// </summary>
        protected List<student> StudentsList;

        protected int Number;
        protected int Age;
        protected int Order;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["search"] != null)
            {
                //検索押されている
                int number = 0;
                int.TryParse(Request.Form["number"], out number);
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

            if (int.TryParse(Request.QueryString["number"], out Number))
            {
                if (Number > 0)
                {
                    StudentsList = StudentsList.Where(x => x.number == Number).ToList();
                }
            }

            if (int.TryParse(Request.QueryString["age"], out Age))
            {
                if (Age > 0)
                {
                    StudentsList = StudentsList.Where(x => x.age == Age).ToList();
                }
            }

            if (int.TryParse(Request.QueryString["order"], out Order))
            {
                switch (Order)
                {
                    // OrderByDescendingは降順を示すメソット,Tolistはリストに変換するメソット
                    case 1:
                        StudentsList = StudentsList.OrderByDescending(x => x.tall).ToList();
                        break;
                    case 2:
                        StudentsList = StudentsList.OrderBy(x => x.tall).ToList();
                        break;
                    case 3:
                        StudentsList = StudentsList.OrderByDescending(x => x.wait).ToList();
                        break;
                    case 4:
                        StudentsList = StudentsList.OrderBy(x => x.tall).ToList();
                        break;
                    default:
                        break;
                }
            }

            //var list = GetTable("SELECT * FROM userdate");
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