<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Golddigger.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-6">
            <h4 class="header">My Profile</h4>
            <img src="<%= CurrentUser!=null?"data:image/jpeg;base64," + Convert.ToBase64String(CurrentUser.ProfilePhoto):""%>" alt="Profile Photo" width="300" height="300">
            <% if (CurrentUser != null)
                {
                    Response.Write("<div>" + (CurrentUser.IsFemale ? "Female" : "Male") + "</div>");
                }
            %>
            <div><%= CurrentUser!=null? CurrentUser.UserName:"" %></div>
            <div><%= CurrentUser!=null? CurrentUser.Email:"" %></div>
            <asp:ListView ID="UserInterests" runat="server"
                ItemType="Golddigger.Models.Interest">
                <ItemTemplate><%#:Item.Name%></ItemTemplate>
            </asp:ListView>
        </div>
        <div class="col-md-6">
            <div class="well">
                <asp:Label AssociatedControlID="CommentInput" Text="Add comment" Font-Bold="true" Font-Size="Larger" runat="server" />
                <asp:TextBox ID="CommentInput" runat="server" CssClass="textInput" />
                <asp:Button OnClick="AddComment_Click" runat="server" Text="Add Comment" CssClass="btn btn-primary" />
                <asp:ListView runat="server" ID="ListViewComments" ItemType="Golddigger.Models.Comment" SelectMethod="ListViewComments_GetData">
                    <LayoutTemplate>
                        <h2>Comments</h2>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <itemtemplate>
                        <h3><asp:hyperlink navigateurl='<%# "~/Account/Profile.aspx?id=" + Item.UserFromId %>' runat="server" Text="<%#: Item.UserFrom.UserName %>" /></h3>
                        <p>
                            Sent on: <%# Item.CreatedOn.ToLocalTime()  %>
                        </p>
                        <p> <%#: Item.Content %></p>
                        </itemtemplate>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
    </div>
</asp:Content>
