<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Temperature_Converter.docs.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Converter</title>
    <link href="../Styles/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <nav class="navbar navbar-light bg-light">
        <span class="navbar-brand mb-0 h1"><a href="./Home.aspx">Home</a></span>
    </nav>
    <form id="form1" runat="server">
        <div class="align-content-md-center" >
            <h1 class="text-center"><strong>Temperature Converter</strong></h1>
      
        </div>
        <div class="container-fluid">
            <div class="row"> 
                <div class="form-group col-lg-5">
                    <asp:DropDownList ID="DropDownList1" runat="server"   CssClass="form-control" >
                       <asp:ListItem>Celcius</asp:ListItem>
                       <asp:ListItem>Farenheit</asp:ListItem>
                       <asp:ListItem>Kelvin</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <h4>To</h4>
                
                <div class="col-lg-5 form-group">
                    <asp:DropDownList ID="DropDownList2" runat="server"  CssClass="form-control">
                        <asp:ListItem>Celcius</asp:ListItem>
                        <asp:ListItem>Farenheit</asp:ListItem>
                        <asp:ListItem>Kelvin</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>
            
            <div class="row container-fluid">
                <h3>Input:</h3>
                <div class="form-group col-lg-5">
                    <asp:TextBox ID="txtLeftBox" runat="server" CssClass="form-control" OnTextChanged="txtLeftBox_TextChanged"  AutoPostBack="true" ></asp:TextBox> 
                </div>
                
                <h3>Result:</h3>
                    
                <div class="form-group col-lg-5">
                    <asp:TextBox ID="txtRightBox" runat="server" CssClass="form-control" ></asp:TextBox>
                </div>
            </div>
        
        </div>

        <div class="text-center">
            <asp:Button ID="Button1" CssClass="center-block btn btn-success btn-lg" runat="server" Text="Convert" OnClick="Convert" />
        </div>

    </form>
    <footer class="page-footer font-small blue pt-4">

  
  <div class="footer-copyright text-center py-3 align-text-bottom" >© 2018 Copyright:

    <a href="mukeshmahara1github.com"> Mukesh Mahara</a>
  </div>
  

</footer>



</body>
</html>
