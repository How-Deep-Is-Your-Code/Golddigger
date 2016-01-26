<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UsersListControl.ascx.cs" Inherits="Golddigger.Controls.UsersListControl" %>
<div class="row">
    <asp:ListView runat="server" ID="ListViewAllUsers" ItemType="Golddigger.Models.User" SelectMethod="ListView_GetAllUsers">
        <ItemTemplate>
            <div class="table-responsive">
                <table class="table">
                    <thead>
                        <tr>
                            <th>User Image</th>
                            <th>Username</th>
                            <th>Email</th>
                            <th>Account Type</th>
                            <th>Gender</th>
                            <th>Town</th>
                            <th>Country</th>
                            <th>Interests</th>
                            <th>Interactions</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70"></td>
                            <td><asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server" Text="<%#: Item.UserName %>" /></td>
                            <td><%# Item.Email %></td>
                            <td><%# Item.UserInfo != null? Item.UserInfo.AccountType.ToString() : "No information" %></td>
                            <td><%# Item.IsFemale ? "Female" : "Male" %></td>
                            <td><%# (Item.UserInfo != null && Item.UserInfo.Town != null) ? Item.UserInfo.Town.Name : "No information" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Country != null ? Item.UserInfo.Country.Name : "No information" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Interests != null ? string.Join(",",Item.UserInfo.Interests) : "No information" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Comments != null ? Item.UserInfo.Comments.Count : 0 %></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </ItemTemplate>
    </asp:ListView>
</div>
