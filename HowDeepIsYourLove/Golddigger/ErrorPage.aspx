<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ErrorPage.aspx.cs" Inherits="Golddigger.ErrorPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="FriendlyErrorMsg" runat="server" Text="Label" Font-Size="Large" CssClass="text-center jumbotron" Style="color: red"></asp:Label>
    <asp:Panel ID="DetailedErrorPanel" runat="server" Visible="false" CssClass="text-center jumbotron">
        <h1 class="jumbotron text-center">Oh sugar! An Error has occurred!</h1>
        <h2 class="text-center"> We are very sorry. Try turning it on and off again. This usually does the trick.</h2>
        <p>And keep smiling, noone likes a sad golddigger. :D</p>
        <div class="text-center">
            <img src="http://static.yourtango.com/cdn/farfuture/2FOrQcxoDMry6sLzWiTUNWfXJcZvSDRcWpssPjvPt9o/mtime:1428643268/sites/default/files/styles/listing_big/public/image_blog/income-minimums.jpg?itok=e6rXT5Le" />
        </div>
        <p>
            <asp:Label ID="ErrorDetailedMsg" runat="server" Font-Size="Small" /><br />
        </p>

        <h4>Error Handler:</h4>
        <p>
            <asp:Label ID="ErrorHandler" runat="server" Font-Size="Small" /><br />
        </p>

        <h4>Detailed Error Message:</h4>
        <p>
            <asp:Label ID="InnerMessage" runat="server" Font-Size="Small" /><br />
        </p>
        <p>
            <asp:Label ID="InnerTrace" runat="server" />
        </p>
    </asp:Panel>
</asp:Content>
