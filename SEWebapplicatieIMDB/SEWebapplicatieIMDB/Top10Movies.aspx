<%@ Page Title="Top10Movies" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Top10Movies.aspx.cs" Inherits="SEWebapplicatieIMDB.Top10Movies" %>
<%@ Import Namespace="System.Data" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetTop10Movies" TypeName="SEWebapplicatieIMDB.Classes.BusinessLayer"></asp:ObjectDataSource>
        <asp:Repeater ID="Repeater2" runat="server" DataSourceID="ObjectDataSource2">
        <ItemTemplate>
            <div>
                <SeparatorTemplate>
                    <hr />
                </SeparatorTemplate>
                <table>
                    <tr>
                        <td>Movie ID :</td>
                        <td><%# Eval("Movie_ID") %></td>
                    </tr>
                       <tr>
                        <td>Title</td>
                        <td><%# Eval("Title") %></td>
                    </tr>
                       <tr>
                        <td>Duration</td>
                        <td><%# Eval("Duration") %></td>
                    </tr>
                       <tr>
                        <td>Rating</td>
                        <td><%# Eval("Rating") %></td>
                    </tr>
                       <tr>
                        <td>Director</td>
                  
                        <td><%# Eval("Director") %></td>
                    </tr>
                       <tr>
                        <td>Storyline</td>
                        <td><%# Eval("Storyline") %></td>
                    </tr>
                       <tr>
                        <td>Category</td>
                        <td><%# Eval("Category") %></td>
                    </tr>
                    <tr>
                        <td>
                        <asp:Button ID="BtnDelete2" runat="server" Text="Delete Movie" OnCommand="BtnDelete2_click" CommandArgument='<%# Eval("Movie_ID") %>' />
                        </td>
                    </tr>
                </table>
            </div>
        </ItemTemplate>
        </asp:Repeater>
     
</asp:Content>
