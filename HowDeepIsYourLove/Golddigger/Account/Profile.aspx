<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Golddigger.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-6">
            <div class="well">
                <asp:ListView runat="server" ID="ListViewProfile" ItemType="Golddigger.Models.User" SelectMethod="ListViewUser_GetData">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div><img src="<%# "data:image/jpeg;base64," + Convert.ToBase64String(Item.ProfilePhoto) %>" alt="Profile Photo" width="300" height="300"></div>
                        <asp:Panel runat="server" Font-Size="XX-Large"><%# Item.UserName %></asp:Panel>
                         <asp:Panel runat="server" Font-Size="X-Large"><%# string.Format("{0}", Item.IsFemale ? "Female" : "Male") %></asp:Panel>
                        <asp:Panel runat="server" Font-Size="X-Large"><%# Item.Email %></asp:Panel>
                    </ItemTemplate>
                </asp:ListView>
            </div>
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
