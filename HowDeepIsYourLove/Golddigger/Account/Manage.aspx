<%@ Page Title="Manage Account" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="Golddigger.Account.Manage" %>
<%@ Register Src="~/Account/OpenAuthProviders.ascx" TagPrefix="uc" TagName="OpenAuthProviders" %>

<asp:Content ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <div>
        <asp:PlaceHolder runat="server" ID="successMessage" Visible="false" ViewStateMode="Disabled">
            <p class="text-success"><%: SuccessMessage %></p>
        </asp:PlaceHolder>
    </div>

    <div class="row">
        <div class="col-md-12">
            <div class="form-horizontal">
                <asp:ValidationSummary runat="server" CssClass="text-danger" />
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Country" CssClass="col-md-2 control-label">Country</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Country" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Town" CssClass="col-md-2 control-label">Town</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Town" CssClass="form-control" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-4 col-md-10">
                        <asp:CheckBoxList ID="DropDownListCategories" runat="server" DataTextField="Name" DataValueField="InterestId" CssClass="dropdown-category"></asp:CheckBoxList>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" CssClass="col-md-2 control-label" AssociatedControlID="Type">Type:</asp:Label>
                    <asp:RadioButtonList ID="Type" runat="server" CssClass="radio-inline">
                        <asp:ListItem Value="0">Golddigger</asp:ListItem>
                        <asp:ListItem Value="1">Suggardaddy</asp:ListItem>
                        <asp:ListItem Value="2">Sugarmamma</asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="form-group">
                    <div class="col-md-offset-4 col-md-10">
                        <asp:Button runat="server" OnClick="EditUserInfo_Click" Text="Update my profile" CssClass="btn btn-primary" />
                    </div>
                </div>
            </div>
            <div class="form-horizontal">
                <asp:DetailsView ID="UserInfoProps" runat="server">
                    <Fields>
                        <asp:BoundField DataField="user.UserInfo.Country" />
                    </Fields>
                </asp:DetailsView>
                <h4>Change your profile details</h4>
                <hr />
                <dl class="dl-horizontal">
                    <dt>Password:</dt>
                    <dd>
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Change]" Visible="false" ID="ChangePassword" runat="server" />
                        <asp:HyperLink NavigateUrl="/Account/ManagePassword" Text="[Create]" Visible="false" ID="CreatePassword" runat="server" />
                    </dd>
                    <dt>External Logins:</dt>
                    <dd><%: LoginsCount %>
                        <asp:HyperLink NavigateUrl="/Account/ManageLogins" Text="[Manage]" runat="server" />

                    </dd>
                    <dt>Two-Factor Authentication:</dt>
                    <dd>
                        <p>
                            There are no two-factor authentication providers configured. See <a href="http://go.microsoft.com/fwlink/?LinkId=403804">this article</a>
                            for details on setting up this ASP.NET application to support two-factor authentication.
                        </p>
                        <% if (TwoFactorEnabled)
                            { %>
                        <%--
                        Enabled
                        <asp:LinkButton Text="[Disable]" runat="server" CommandArgument="false" OnClick="TwoFactorDisable_Click" />
                        --%>
                        <% }
                            else
                            { %>
                        <%--
                        Disabled
                        <asp:LinkButton Text="[Enable]" CommandArgument="true" OnClick="TwoFactorEnable_Click" runat="server" />
                        --%>
                        <% } %>
                    </dd>
                </dl>
            </div>
        </div>
    </div>

</asp:Content>
