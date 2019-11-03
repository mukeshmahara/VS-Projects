<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Temperature_Converter.docs.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link href="../Styles/twitter-bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../Styles/StyleSheet1.css" rel="stylesheet" />
</head>
<body class=" container-fluid join">
    <nav class="navbar navbar-light bg-light">
        <span class="navbar-brand mb-0 h1"><a href="./Home.aspx">Home</a></span>
    </nav>
    <h2 class="text-center white-heading"><strong>Converter</strong></h2>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-lg-4 box">
                <div class="lenC jumbotron text-center">
                    <asp:Button ID="Button1" runat="server" Text="Temperature Converter" OnClick="Button1_Click" CssClass="center-block btn btn-success btn-lg" />
                </div>
            </div>

            <div class="col-lg-4 box">
                <div class="tempC jumbotron text-center">
                    <asp:Button ID="Button2" runat="server" Text="Weight Converter" OnClick="Button2_Click" CssClass="center-block btn btn-success btn-lg" />
                </div>
            </div>
            
            <div class="col-lg-4 box">
                <div class="wegC jumbotron text-center" >
                    <asp:Button ID="Button3" runat="server" Text="Length Converter" OnClick="Button3_Click" CssClass="center-block btn btn-success btn-lg" />
                </div>
            </div>
        </div>
        
    </form>
  
  
  
</body>
</html>
