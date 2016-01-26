﻿<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Golddigger._Default" %>

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
            <asp:ListView runat="server" ID="ListViewImages" ItemType="Golddigger.Models.User" SelectMethod="ListViewImages_GetData">
                <LayoutTemplate>
                    <h2 class="text-center">Golddiggers</h2>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder" />
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="row">
                    <img src='<%# "data:image/jpeg;base64,"+ Convert.ToBase64String(Item.ProfilePhoto)%>' alt="Profile Photo" width="70" height="70">
                    <h4><asp:HyperLink NavigateUrl='<%# "~/Account/Profile.aspx?id=" + Item.Id %>' runat="server" Text="<%#: Item.UserName %>" /></h4>
                    </div>
                </ItemTemplate>
            </asp:ListView>
        </div>
        <div class="col-md-4">
            <h2 class="text-center">Sugardaddies</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2 class="text-center">Sugarmammas</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
