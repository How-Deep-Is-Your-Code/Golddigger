<%@ Page ValidateRequest="false" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Golddigger.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col-md-6">
            <div class="well">
                <asp:ListView runat="server" ID="ListViewProfile" ItemType="Golddigger.Models.User" SelectMethod="ListViewUser_GetData">
                    <LayoutTemplate>
                        <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div>
                            <img src="<%# "data:image/jpeg;base64," + Convert.ToBase64String(Item.ProfilePhoto) %>" alt="Profile Photo" width="300" height="300">
                        </div>
                        <asp:Panel runat="server" Font-Size="XX-Large">Username: <%# this.Server.HtmlEncode(Item.UserName) %></asp:Panel>
                        <asp:Panel runat="server" Font-Size="X-Large">Gender: <%# string.Format("{0}", Item.IsFemale ? "Female" : "Male") %></asp:Panel>
                        <asp:Panel runat="server" Font-Size="X-Large">Email: <%# Item.Email %></asp:Panel>
                    </ItemTemplate>
                </asp:ListView>
                <asp:Panel runat="server" Font-Size="XX-Large">Interests</asp:Panel>
                <asp:ListView ID="UserInterests" runat="server"
                    ItemType="Golddigger.Models.Interest">
                    <ItemTemplate>
                        <asp:Panel runat="server" Font-Size="X-Large"><%# Item !=null? Item.Name :""%></asp:Panel>
                    </ItemTemplate>
                </asp:ListView>
            </div>
        </div>
        <div class="col-md-6">
            <div class="well">
                <asp:Label AssociatedControlID="CommentInput" Text="Add comment" Font-Bold="true" Font-Size="Larger" runat="server" />
                <asp:TextBox ID="CommentInput" runat="server" CssClass="textInput" />
                <asp:UpdatePanel runat="server">
                    <ContentTemplate>
                        <asp:Button OnClick="AddComment_Click" runat="server" Text="Add Comment" CssClass="btn btn-primary" AutoPostBack="True" />
                    </ContentTemplate>
                </asp:UpdatePanel>

                <h2>Comments</h2>
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                <asp:UpdatePanel ID="UpdatePanelTest" runat="server"
                    UpdateMode="Conditional"
                    AutoPostBack="True">
                    <ContentTemplate>
                        <asp:Panel ID="PanelTest" runat="server" Visible="true" class="panel">
                            <asp:ListView runat="server" ID="ListViewComments" ItemType="Golddigger.Models.Comment" SelectMethod="ListViewComments_GetData">
                                <%--   <LayoutTemplate>
                    </LayoutTemplate>--%>

                                <ItemTemplate>
                                    <itemtemplate>
                        <h3><asp:hyperlink navigateurl='<%# "~/Account/Profile.aspx?id=" + Item.UserFromId %>' runat="server" Text="<%#: Item.UserFrom.UserName %>" /></h3>
                        <p>
                            Sent on: <%# Item.CreatedOn.ToLocalTime()  %>
                        </p>
                        <p> <%#: this.Server.HtmlDecode(Item.Content) %></p>
                        </itemtemplate>
                                </ItemTemplate>
                            </asp:ListView>
                        </asp:Panel>
                    </ContentTemplate>
                </asp:UpdatePanel>
            </div>
        </div>
    </div>
</asp:Content>
