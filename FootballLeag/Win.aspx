<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Win.aspx.cs" Inherits="FootballLeag.Win" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button2" runat="server" Height="28px" OnClick="Button2_Click" style="margin-top: 0px" Text="Draw" Width="94px" />
        <asp:Button ID="Button1" runat="server" Text="Win"  OnClick="Button1_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="JapanData" />
        <asp:GridView ID="GridView1" runat="server" Height="232px" style="margin-left: 182px; margin-top: 10px; padding-top: 0px" Width="506px">
        </asp:GridView>
    </form>
</body>
</html>
