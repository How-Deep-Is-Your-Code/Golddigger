<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AdminHome.aspx.cs" Inherits="Golddigger.Admin.AdminHome" %>
<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
        <div class="container-fluid">
            <div class="row text-center">
                <div class="col-md-12">
                    <div class="panel panel-info">
                        <div class="panel-heading text-center"><%: Title %></div>
                        <asp:ListView ID="ViewAllUsers" runat="server"
                            SelectMethod="GridViewAll_GetData"
                            ItemType="Golddigger.Models.User"
                            AllowPaging="True"
                            EnableSortingAndPagingCallback="True"
                            AllowSorting="True"
                            DataKeyNames="Id"
                            AutoGenerateColumns="false">
                            <LayoutTemplate>
                                <table class="table table-striped table-hover">
                                    <tr>
                                        <th class="text-center">
                                            <asp:Literal Text="Image" runat="server" />
                                        </th>
                                        <th class="text-center">
                                            <asp:Literal Text="Account Type" runat="server" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Username" runat="server"
                                                ID="SortByUsername"
                                                CommandName="Sort"
                                                CommandArgument="Username" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Email" runat="server"
                                                ID="SortByEmail"
                                                CommandName="Sort"
                                                CommandArgument="Email" />
                                        </th>
                                        <th class="text-center">
                                            <asp:LinkButton Text="Gender" runat="server"
                                                ID="SortByGender"
                                                CommandName="Sort"
                                                CommandArgument="IsFemale" />
                                        </th>
                                        <th class="text-center">
                                            <asp:Literal Text="Town" runat="server" />
                                        </th>
                                        <th class="text-center">
                                            <asp:Literal Text="Country" runat="server"/>
                                        </th>
                                        <th class="text-center">
                                            <asp:Literal Text="Details" runat="server" />
                                        </th>
                                    </tr>
                                    <asp:PlaceHolder ID="itemplaceholder" runat="server" />
                                </table>
                            </LayoutTemplate>

                            <ItemTemplate runat="server">
                                <tr>
                                    <td>
                                        <img src="<%# "data:image/jpeg;base64," + Convert.ToBase64String(Item.ProfilePhoto) %>" alt="Profile Photo" width="70" height="70">
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.UserInfo.AccountType %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.UserName %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.Email %>' runat="server" />
                                    </td>
                                    
                                    <td>
                                        <asp:Label Text='<%#: Item.IsFemale? "Female":"Male" %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.UserInfo.Town.Name %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:Label Text='<%#: Item.UserInfo.Country.Name %>' runat="server" />
                                    </td>
                                    <td>
                                        <asp:HyperLink NavigateUrl='<%#: string.Format("~/Account/Profile.aspx?id={0}", Item.Id) %>' runat="server"> Details
                                        </asp:HyperLink>
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <EmptyDataTemplate runat="server">
                                <h5 class="content-empty">No items available</h5>
                            </EmptyDataTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
            <div class="bs-component text-center">
                <asp:DataPager ID="DataPagerAll" PagedControlID="ViewAllUsers" PageSize="5" runat="server" CssClass="btn-group btn-group-sm">
                    <Fields>
                        <asp:NextPreviousPagerField PreviousPageText="<" FirstPageText="|<" ShowPreviousPageButton="true"
                            ShowFirstPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" ButtonType="Button"
                            ButtonCssClass="btn btn-default" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />

                        <asp:NumericPagerField ButtonType="Button" CurrentPageLabelCssClass="btn btn-primary disabled" RenderNonBreakingSpacesBetweenControls="false"
                            NumericButtonCssClass="btn btn-default" ButtonCount="10" NextPageText="..." NextPreviousButtonCssClass="btn btn-default" />

                        <asp:NextPreviousPagerField NextPageText=">" LastPageText=">|" ShowNextPageButton="true"
                            ShowLastPageButton="true" ShowPreviousPageButton="false" ShowFirstPageButton="false" ButtonType="Button"
                            ButtonCssClass="btn btn-default" RenderNonBreakingSpacesBetweenControls="false" RenderDisabledButtonsAsLabels="false" />
                    </Fields>
                </asp:DataPager>
            </div>
        </div>
</asp:Content>