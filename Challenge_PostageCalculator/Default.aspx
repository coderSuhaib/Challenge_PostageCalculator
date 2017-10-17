<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Challenge_PostageCalculator.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Postal Calculator<br />
            <br />
            Width:
            <asp:TextBox ID="widthTextBox" runat="server" AutoPostBack="True" OnTextChanged="getCalculation"></asp:TextBox>
            <br />
            Height:
            <asp:TextBox ID="heightTextBox" runat="server" AutoPostBack="True" OnTextChanged="getCalculation"></asp:TextBox>
            <br />
            Length:
            <asp:TextBox ID="lengthTextBox" runat="server" AutoPostBack="True" OnTextChanged="getCalculation"></asp:TextBox>
            <br />
            <br />
            Select the shipping type:<br />
            <br />
            <asp:RadioButton ID="groundRadioBtn" runat="server" AutoPostBack="True" GroupName="shippingType" OnCheckedChanged="getCalculation" Text=" Ground" />
            <br />
            <asp:RadioButton ID="airRadioBtn" runat="server" AutoPostBack="True" GroupName="shippingType" OnCheckedChanged="getCalculation" Text=" Air" />
            <br />
            <asp:RadioButton ID="nextDayRadioBtn" runat="server" AutoPostBack="True" GroupName="shippingType" OnCheckedChanged="getCalculation" Text=" Next Day" />
            <br />
            <br />
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
