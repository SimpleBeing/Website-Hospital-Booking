<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Appointment Scheduling</h3>
    <p>This site is used by you the patient to book for an appointment</p>
    <p>
        <asp:Image ID="Image1" runat="server" ImageUrl="~/images/hospital-art-toy.jpg" />
    </p>
</asp:Content>
