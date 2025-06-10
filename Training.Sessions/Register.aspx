<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Training.Sessions.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
         
           <asp:Button runat="server" OnClick="btnSubmit_Click" ID="btnSubmit" Text="Submit" CssClass="btn btn-success" />
        </div>
    </div>
</div>
</asp:Content>
