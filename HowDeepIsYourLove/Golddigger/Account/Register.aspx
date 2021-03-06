﻿<%@ Page ValidateRequest="false" Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Golddigger.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email" 
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Username" CssClass="col-md-2 control-label">Username</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Username" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Username"
                    CssClass="text-danger" ErrorMessage="The username field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-10">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" CssClass="col-md-2 control-label" AssociatedControlID="Gender">Gender</asp:Label>
            <asp:RadioButtonList ID="Gender" runat="server" CssClass="radio-inline">
                <asp:ListItem Value="true">Female</asp:ListItem>
                <asp:ListItem Value="false">Male</asp:ListItem>
            </asp:RadioButtonList>
            <asp:RequiredFieldValidator ID="GenderValidator" runat="server"
                CssClass="text-danger" Display="Dynamic" ControlToValidate="Gender" ErrorMessage="Gender is Required">
            </asp:RequiredFieldValidator>
        </div>
        <div class="form-group">
                <asp:Label runat="server" CssClass="col-md-2 control-label" AssociatedControlID="Photo">Profile photo</asp:Label>
            <div class="col-md-10">
                <asp:FileUpload ID="Photo" runat="server" />
                <asp:RequiredFieldValidator ID="PhotoValidator" runat="server"
                    CssClass="text-danger" Display="Dynamic" ControlToValidate="Photo" ErrorMessage="Profile photo is Required">
                </asp:RequiredFieldValidator>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-4 col-md-10">
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-primary" />
            </div>
        </div>
    </div>
</asp:Content>
