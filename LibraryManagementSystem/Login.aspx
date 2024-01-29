<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LibraryManagementSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="StyleSheet1.css" rel="stylesheet"/>
</head>
<body class="BgImage" >
    <div class="container">
        <div class="row">
            <div class="col-lg-6 col-lg-offset-3 LoginBox">
                <h1 class="text-center">Library Management System</h1>
                <input type="button" value="admin" class="ButtonStyle active" id="admin" name="usertype" />
                <input type="button" value="Student" class="ButtonStyle" id="student" name="usertype" />
                <form id="form1" runat="server">
                    <div id="UserTypeForm"></div>
                    <div class="text-center">
                        <input type="button" value="Login" id="login" class="LoginUserButton" name="login" />
                    </div>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </form>
            </div>
        </div>
    </div>
<script src="Scripts/jquery-3.4.1.min.js"></script>
<script src="JavaScript.js"></script>
</body>
</html>
