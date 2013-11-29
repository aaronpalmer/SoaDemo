<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SoaDemo.Web._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:HiddenField runat="server" ID="CogIdHiddenField"/>
    <asp:ValidationSummary runat="server" ID="ValidationSummary1"/>
    <br />
    <asp:Label runat="server" ID="CogIdInputLabel" Text="Cog ID:" AssociatedControlID="CogIdInputTextBox" />
    <asp:TextBox runat="server" ID="CogIdInputTextBox" />
    <br />
    <asp:Button runat="server" ID="GetCogButton" Text="Get Cog" OnClick="GetCogButton_Click" />
    <br />
    <asp:Label runat="server" ID="CogIdDisplayLabel"/>
    <br />
    <asp:Label runat="server" ID="CogNameDisplayLabel" Text="Cog Name:"/>
    <asp:TextBox runat="server" ID="CogNameDisplayTextBox" />
    <br />
    <asp:Label runat="server" ID="CogDescriptionDisplayLabel" Text="Cog Description:"/>
    <asp:TextBox runat="server" ID="CogDescriptionDisplayTextBox" />
    <br />
    <asp:Button runat="server" ID="SaveCogButton" Text="Save Cog" OnClick="SaveCogButton_Click"/>

</asp:Content>
