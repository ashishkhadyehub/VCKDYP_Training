<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Training.Sessions.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Web Form</title>
</head>
<meta name="viewport" content="width=device-width, initial-scale=1">
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet">
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js"></script>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-md-6">
                    <div class="mb-3 mt-3">
                        <label>Name :</label>
                        <asp:TextBox runat="server" ID="txtName" placeholder="Enter Name" CssClass="form-control" ></asp:TextBox>
                        
                    </div>
                 <div class="mb-3 mt-3">
                        <label>Contact :</label>
                        <asp:TextBox  runat="server" ID="txtContact" placeholder="Enter Contact" CssClass="form-control" ></asp:TextBox>
                 </div>
                 <div class="mb-3 mt-3">
                        <label>City :</label>
                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCity">  
                            <asp:ListItem>-- Select City --</asp:ListItem>
                            <asp:ListItem>Kolhapur</asp:ListItem>
                            <asp:ListItem>Pune</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                        </asp:DropDownList>
                 </div>
                 
                   <asp:Button runat="server" ID="btnSubmit" Text="Submit" CssClass="btn btn-success" />
                </div>
            </div>
        </div>
    </form>

</body>
</html>
