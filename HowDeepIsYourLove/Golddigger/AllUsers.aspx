<%@ Page Title="AllUsers" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllUsers.aspx.cs" Inherits="Golddigger.AllUsers" %>
<%@ Register TagPrefix="uc" TagName="UsersControl" Src="~/Controls/UsersListControl.ascx"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:UsersControl ID="UsersControl" runat="server">
    </uc:UsersControl>
</asp:Content>
