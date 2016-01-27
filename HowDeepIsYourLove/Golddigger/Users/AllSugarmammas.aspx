<%@ Page Language="C#" Title="View Sugarmammas" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllSugarmammas.aspx.cs" Inherits="Golddigger.Users.AllSugarmammas" %>
<%@ Register TagPrefix="uc" TagName="SugarmammasControl" Src="~/Controls/SugarmammasListControl.ascx"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:SugarmammasControl ID="SugarmammasControl" runat="server">
    </uc:SugarmammasControl>
</asp:Content>