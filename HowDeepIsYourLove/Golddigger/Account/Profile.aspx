<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Golddigger.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div class="row">
        <div class="col s12 m4 l4">
            <h4 class="header">My Profile</h4>
            <div class="card">
                <div class="card-content">
                    <img src="<%= CurrentUser!=null?"data:image/jpeg;base64," + Convert.ToBase64String(CurrentUser.ProfilePhoto):""%>" alt="Profile Photo" width="300" height="300">
                    <% if (CurrentUser != null)
                        {
                            Response.Write("<div>" + (CurrentUser.IsFemale ? "Female" : "Male") + "</div>");
                        }
                    %>
                    <div><%= CurrentUser!=null? CurrentUser.UserName:"" %></div>
                    <div><%= CurrentUser!=null? CurrentUser.Email:"" %></div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
