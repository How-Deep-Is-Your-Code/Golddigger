<%@ Page Language="C#" Title="View Golddiggers" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllGolddiggers.aspx.cs" Inherits="Golddigger.Users.AllGolddiggers" %>
<%@ Register TagPrefix="uc" TagName="GolddiggersControl" Src="~/Controls/GolddigersListControl.ascx"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:GolddiggersControl ID="GolddiggersControl" runat="server">
    </uc:GolddiggersControl>
</asp:Content>
