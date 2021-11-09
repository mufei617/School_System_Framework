<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormProjectAssignment.aspx.cs" Inherits="ReviewForMidterm.GUI.WebFormProjectAssignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: justify;
        }
        .auto-style3 {
            margin-right: 0px;
        }
        .auto-style4 {
            width: 861px;
            height: 755px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style4">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; project assignment student<br />
            <br />
            StudentList<div class="auto-style1">
                <asp:DropDownList ID="DropDownListStudent" runat="server" CssClass="auto-style3">
                </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ProjectList<asp:DropDownList ID="DropDownListProject" runat="server" OnSelectedIndexChanged="DropDownListProject_SelectedIndexChanged">
                </asp:DropDownList>
&nbsp;</div>
            Assigned Date<br />
            <asp:Calendar ID="CalendarAssignDate" runat="server"></asp:Calendar>
            <br />
            Submit Date<asp:Calendar ID="CalendarSubmitDate" runat="server"></asp:Calendar>
            <asp:GridView ID="GridViewInfo" runat="server" Height="155px" Width="401px">
            </asp:GridView>
            <br />
            <br />
            <asp:Button ID="ButtonAssigned" runat="server" Height="49px" OnClick="ButtonAssigned_Click" Text="Button" Width="216px" />
        </div>
    </form>
</body>
</html>
