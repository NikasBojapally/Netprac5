<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="calendar.aspx.cs"
    Inherits="prac_5.calendar" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Academic Calendar</title>
</head>
<body>
<form id="form1" runat="server">
<div>

    <asp:Calendar ID="Calendar1" runat="server"
        OnSelectionChanged="Calendar1_SelectionChanged">
    </asp:Calendar>

    <br />

    <asp:Label ID="lblSelectedDate"
        runat="server"
        Text="Select Date">
    </asp:Label>

    <br /><br />

    <asp:Button ID="BtnApplyLeave"
        runat="server"
        Text="Apply Leave"
        OnClick="BtnApplyLeave_Click" />

</div>
</form>
</body>
</html>
