<%@ Page ErrorPage="~/ErrorPage.aspx" Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Golddigger._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Golddiggers & Suggardaddies Portal</h1>
        <br />
        <p class="lead text-center">Golddigger.com is a totally FREE and totally HONEST dating website.</p>
        <p class="lead text-center">Tired of wondering if your next girlfriend is only after your money? With Golddiger.com - you know the answer to that question so you can focus on the more important things!</p>
        <p class="lead text-center"><a href="/Account/Register" class="btn btn-primary btn-lg">Register Now &raquo;</a></p>
        <br />
    </div>
    <div class="row">
        <div class="col-md-4">
            <asp:ListView runat="server" ID="ListViewGoldDiggerImages" ItemType="Golddigger.Models.User" SelectMethod="ListViewImages_GetGolddiggers">
                <LayoutTemplate>
                    <h2 class="text-center"><a href="Users/AllGolddiggers">Golddiggers</a></h2>
                    <br />
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </LayoutTemplate>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server">
                                <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70">
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="col-md-4">
            <asp:ListView runat="server" ID="ListViewSugardaddiesImages" ItemType="Golddigger.Models.User" SelectMethod="ListViewImages_GetSugardaddies">
                <LayoutTemplate>
                    <h2 class="text-center"><a href="Users/AllSuggardaddies">Sugardaddies</a></h2>
                    <br />
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </LayoutTemplate>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server">
                        <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70">
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="col-md-4">
            <asp:ListView runat="server" ID="ListViewSugarmammasImages" ItemType="Golddigger.Models.User" SelectMethod="ListViewImages_GetSugarmammas">
                <LayoutTemplate>
                    <h2 class="text-center"><a href="Users/AllSugarmammas">Sugarmammas</h2>
                    <br />
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </LayoutTemplate>
                <ItemTemplate>
                    <asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server">
                        <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70">
                    </asp:HyperLink>
                </ItemTemplate>
            </asp:ListView>
        </div>
    </div>
</asp:Content>
