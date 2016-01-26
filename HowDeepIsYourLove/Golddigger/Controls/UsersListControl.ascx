<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsersListControl.ascx.cs" Inherits="Golddigger.Controls.UsersListControl" %>
<div class="row">
    <div class="table-responsive">
        <table class="table">
            <thead>
                <tr>
                    <th>Profile Photo</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Account Type</th>
                    <th>Gender</th>
                    <th>Town</th>
                    <th>Country</th>
                    <th>Interests</th>
                </tr>
            </thead>
            <asp:ListView runat="server" ID="ListViewAllUsers" ItemType="Golddigger.Models.User" SelectMethod="ListView_GetAllUsers">
                <ItemTemplate>
                    <tbody id="itemPlaceholder" runat="server">
                        <tr>
                            <td>
                                <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70"></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server" Text="<%#: Item.UserName %>" /></td>
                            <td><%# Item.Email %></td>
                            <td><%# Item.UserInfo != null? Item.UserInfo.AccountType.ToString() : "No information" %></td>
                            <td><%# Item.IsFemale ? "Female" : "Male" %></td>
                            <td><%# (Item.UserInfo != null && Item.UserInfo.Town != null) ? Item.UserInfo.Town.Name : "No information" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Country != null ? Item.UserInfo.Country.Name : "No information" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Interests != null ? string.Join(",",Item.UserInfo.Interests) : "No information" %></td>
                        </tr>
                    </tbody>
                </ItemTemplate>
            </asp:ListView>
        </table>
    </div>

</div>
