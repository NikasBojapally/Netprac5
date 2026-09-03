<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveApply.aspx.cs"
    Inherits="prac_5.LeaveApply" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Leave Application</title>
</head>

<body>
<form id="form1" runat="server">
<div>

    <h3>LEAVE APPLICATION</h3>

    Employee Name
    <asp:TextBox ID="txtemp"
        runat="server">
    </asp:TextBox>

    <br /><br />

    Leave Date
    <asp:TextBox ID="lblButtonDT"
        runat="server">
    </asp:TextBox>

    <br /><br />

    Leave Type
    <asp:DropDownList ID="DropDownList1"
        runat="server">

        <asp:ListItem>
            Select Leave Type
        </asp:ListItem>

        <asp:ListItem>
            Personal Leave
        </asp:ListItem>

        <asp:ListItem>
            Medical Leave
        </asp:ListItem>

        <asp:ListItem>
            Emergency Leave
        </asp:ListItem>

    </asp:DropDownList>

    <br /><br />

    Reason

    <asp:TextBox ID="TextBox2"
        runat="server"
        TextMode="MultiLine"
        Rows="4"
        Columns="20">
    </asp:TextBox>

    <br /><br />

    <asp:CheckBox ID="CheckBox1"
        runat="server"
        Text="Remember my name..." />

    <br /><br />

    <asp:Button ID="btnSubmit"
        runat="server"
        Text="Submit Leave"
        OnClick="btnSubmit_Click" />

    <br /><br />

    <asp:Label ID="lblmsg"
        runat="server">
    </asp:Label>

</div>
</form>
</body>
</html>
