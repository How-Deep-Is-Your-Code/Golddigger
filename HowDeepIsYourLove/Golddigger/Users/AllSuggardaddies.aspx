<%@ Page Language="C#" Title="View Suggardaddies" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AllSuggardaddies.aspx.cs" Inherits="Golddigger.Users.AllSuggardaddies" %>
<%@ Register TagPrefix="uc" TagName="SuggardaddiesControl" Src="~/Controls/SugardaddiesListControl.ascx"%>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <uc:SuggardaddiesControl ID="GolddiggersControl" runat="server">
    </uc:SuggardaddiesControl>
</asp:Content>
