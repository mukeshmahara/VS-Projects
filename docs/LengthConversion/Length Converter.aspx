<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Length Converter.aspx.cs" Inherits="Temperature_Converter.docs.LengthConversion.Length_Converter"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Length Converter</title>
    <link href="../../Styles/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../../Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-light bg-light">
        <span class="navbar-brand mb-0 h1"><a href="../Home.aspx">Home</a></span>
    </nav>

    <div  class="container-fluid text-center">
    <form id="form1"  runat="server">
        <div class="row text-center">
            <div class="form-group">
                
                <asp:DropDownList ID="lengthDropDownList1" cssclass="form-control" runat="server" >
                    <asp:ListItem>centimeter</asp:ListItem>
                    <asp:ListItem>inches</asp:ListItem>
                    <asp:ListItem>meter</asp:ListItem>
                    <asp:ListItem>kilometer</asp:ListItem>
                    <asp:ListItem>mile</asp:ListItem>
                    <asp:ListItem>feet</asp:ListItem>
                </asp:DropDownList>
                
            </div>

            <strong>To</strong>
            
            <div class="form-group text-center">
                <asp:DropDownList ID="LengthDropDownList2" CssClass="form-control" runat="server" >
                <asp:ListItem>centimeter</asp:ListItem>
                <asp:ListItem>inches</asp:ListItem>
                <asp:ListItem>meter</asp:ListItem>
                <asp:ListItem>kilometer</asp:ListItem>
                <asp:ListItem>mile</asp:ListItem>
                <asp:ListItem>feet</asp:ListItem>
            </asp:DropDownList>
            </div>

        </div>
        <div class="row">
            <strong>Input:</strong>
            <div class="col-lg-3">
                <div class="form-group">
                    <asp:TextBox ID="inputbox" runat="server" CssClass="form-control" OnTextChanged="inputbox_TextChanged" AutoPostBack="true"></asp:TextBox>
                </div>
            </div>
            <strong>Result</strong>
            <div class="col-lg-3">
                <div class="form-group">
                    <asp:TextBox ID="resultbox" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>

        </div>
        <asp:Button ID="LengthConvertButton" runat="server" Text="Convert" OnClick="LengthConvertButton_Click" />
    </form>
    </div>
</body>
</html>
