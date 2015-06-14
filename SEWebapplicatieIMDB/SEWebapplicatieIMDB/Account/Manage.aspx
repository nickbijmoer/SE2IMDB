<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="SEWebapplicatieIMDB.Account.Manage" %>


<asp:Content ContentPlaceHolderID="MainContent" runat="server">


    <div class="row">
        <div class="col-md-12">
            <section id="passwordForm">
              
                    <div class="form-horizontal">
                        <h4><br/><br/><br />Set Password:</h4>
                        <hr />
                        <div class="form-group">
                            <div class ="col-md-10">
                
                                <asp:Label ID="lbPassword" runat="server" Text="New Password:"></asp:Label>
                                <asp:TextBox ID="TbPassword" runat="server"></asp:TextBox>       
                            </div>
                        </div>
                 
                         <div class="form-group">
                            <div class ="col-md-10">
                
                                <asp:Label ID="Label1" runat="server" Text="Confirm Password:"></asp:Label>
                                <asp:TextBox ID="TbConfirmPassword" runat="server"></asp:TextBox>       
                             </div>
                        </div>
                            
                         <div class="form-group">
                            <div class="col-md-10">
                                <asp:Button runat="server" Text="Set Password" ValidationGroup="SetPassword" OnClick="SetPassword_Click" CssClass="btn btn-default" />
                              <asp:CompareValidator runat="server" ControlToCompare="TbPassword" ControlToValidate="TbConfirmPassword"
                                    CssClass="text-error" Display="Dynamic" ErrorMessage="The password and confirmation password do not match."
                                />
                            </div>
                        </div>
    
            </section>


        </div>              
   </div>
         
</asp:Content>
