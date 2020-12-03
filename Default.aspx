<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Hospital Patient App </h1>
    </div>

    <div>
        <asp:Image 
            ID="Image1" 
            runat="server" 
            ImageUrl="~/images/Bethesda Heart Hospital - NEW SIGNAGE - January 2011 002.jpg" 
            Height="100%"
            Width="100%" />
    </div>
</asp:Content>
