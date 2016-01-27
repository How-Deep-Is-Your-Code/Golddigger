<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GolddigersListControl.ascx.cs" Inherits="Golddigger.Controls.GolddigersListControl" %>
<div class="jumbotron"><h1 class="text-center">Goldiggers</h1></div>
<div class="row">
    <div class="table-responsive">
        <table class="table">
            <thead class="jumbotron">
                <tr>
                    <th>Profile Photo</th>
                    <th>Username</th>
                    <th>Email</th>
                    <th>Gender</th>
                    <th>Town</th>
                    <th>Country</th>
                    <th>Interests</th>
                </tr>
            </thead>
            <asp:ListView runat="server" ID="ListViewAllGolddiggers" ItemType="Golddigger.Models.User" SelectMethod="ListView_GetGolddiggers">
                <ItemTemplate>
                    <tbody id="itemPlaceholder" runat="server">
                        <tr>
                            <td>
                                <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70"></td>
                            <td>
                                <asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server" Text="<%#: Item.UserName %>" /></td>
                            <td><%# Item.Email %></td>
                            <td><%# Item.IsFemale ? "Female" : "Male" %></td>
                            <td><%# (Item.UserInfo != null && Item.UserInfo.Town != null) ? Item.UserInfo.Town.Name : "" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Country != null ? Item.UserInfo.Country.Name : "" %></td>
                            <td><%# Item.UserInfo != null && Item.UserInfo.Interests != null ? string.Join(", ",Item.UserInfo.Interests.Select(i=>i.Name)) : "" %></td>
                        </tr>
                    </tbody>
                </ItemTemplate>
            </asp:ListView>
    </table>
 </div>
    <div class="text-center">
        <asp:DataPager class="btn-group btn-group-sm" ID="allGDPager" runat="server" PagedControlID="ListViewAllGolddiggers" PageSize="5">
            <Fields>
                <asp:NextPreviousPagerField PreviousPageText="<" ShowPreviousPageButton="true" ShowNextPageButton="false"
                    ButtonCssClass="btn btn-default" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />
                <asp:NumericPagerField ButtonType="Link" CurrentPageLabelCssClass="btn btn-primary disabled" RenderNonBreakingSpacesBetweenControls="false"
                    NumericButtonCssClass="btn btn-default" ButtonCount="10" NextPageText="..." NextPreviousButtonCssClass="btn btn-default" />
                <asp:NextPreviousPagerField NextPageText=">" ShowNextPageButton="true"
                    ShowPreviousPageButton="false" ShowFirstPageButton="false"
                    ButtonCssClass="btn btn-default" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />
            </Fields>
        </asp:DataPager>
    </div>
</div>
