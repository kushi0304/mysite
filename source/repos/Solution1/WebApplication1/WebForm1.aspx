<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
</head>
<body>
    <form id="form2" runat="server">
        <div class="container mt-3">

            <h1 class="text-center">学生検索サービス</h1>

            <div class="m-5">
                <p class="text-center font-weight-bold">検索フォーム</p>
                <div class="input-group">
                    <div class="input-group-append">
                        <span class="btn btn-dark">学生番号</span>
                    </div>
                    <input class="form-control"  name="number" placeholder="半角数字で入力して下さい。" maxlength="3" />
                    <div class="input-group-append">
                        <span class="btn btn-dark">学年</span>
                    </div>
                    <select name="age" class="custom-select">
                        <option value="0">-----</option>
                        <option value="1">1</option>
                        <option value="2">2</option>
                        <option value="3">3</option>
                    </select>
                    <div class="input-group-append">
                        <span class="btn btn-dark">並び替え</span>
                    </div>
                    <select name="order" class="custom-select">
                        <option value="0">-----</option>
                        <option value="1">背が高い順</option>
                        <option value="2">背が低い順</option>
                        <option value="3">体重が重い順</option>
                        <option value="4">体重が軽い順</option>
                    </select>
                </div>
                <div class="mt-3 text-center">
                    <input name="search" type="submit" class="btn btn-success" value="検　索" />
                </div>
            </div>

            <% 
                if (StudentsList.Any())
                { 
            %>
            <table class="table">
                <thead>
                    <tr>
                        <th>番号</th>
                        <th>学年</th>
                        <th>名前</th>
                        <th>身長</th>
                        <th>体重</th>
                    </tr>
                </thead>
                <tbody>
                    <%
                        foreach(var item in StudentsList)
                        {
                    %>
                    <tr>
                        <td><%=item.number %></td>
                        <td><%=item.age %></td>
                        <td><%=item.name %></td>
                        <td><%=item.tall %></td>
                        <td><%=item.wait %></td>
                    </tr>
                    <%
                        }
                    %>
                </tbody>
            </table>
            <% 
                }
                else
                {
            %>
            <span class="font-weight-bold text-danger">対象の学生はいません。</span>
            <%
                }
            %>
        </div>
    </form>
    <script src="js/jquery-3.5.1.min.js"></script>
    <script src="js/bootstrap.min.js"></script>
</body>
</html>
