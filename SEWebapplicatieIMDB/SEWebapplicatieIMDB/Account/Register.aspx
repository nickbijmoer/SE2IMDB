<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="SEWebapplicatieIMDB.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account.</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-2 control-label">User name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbUserName" CssClass="form-control" />
             
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbPassword" TextMode="Password" CssClass="form-control" />
          
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server"  CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
        </div>
        </div>
       <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">First Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbFirstName" CssClass="form-control" />
            </div>
        </div>  
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Last Name</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbLastName" CssClass="form-control" />
            </div>
        </div>
        <div class="form-group">
            <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="RbGender" runat="server">
                <asp:ListItem Selected="True">Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Year Of Birth</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbYearOfBirth" CssClass="form-control" />
            </div>
        </div> 
          <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Country</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbCountry" CssClass="form-control" />
            </div>
        </div> 
         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">Postal Code</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbPostalCode" CssClass="form-control" />
            </div>
        </div> 
         <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label">E-Mail</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="TbEmail" CssClass="form-control" />
            </div>
        </div> 
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" />
            </div>
        </div>
    </div>
</asp:Content>
