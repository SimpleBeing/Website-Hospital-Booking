<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Schedule Appointment.aspx.cs" Inherits="About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        <asp:Label ID="Label1" runat="server" Text="Schedule Appointment"></asp:Label></h2>
    <h3>
        <asp:Label ID="lblError" runat="server"></asp:Label></h3>
    <p>
        <asp:Button ID="btnViewAllAppointments" runat="server" Text="View All Apointments" OnClick="Button1_Click" /></p>
    <p>
        <asp:GridView ID="gvBookings" runat="server">
        </asp:GridView>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Surname"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSurname" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Date"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="CalDate" runat="server" OnSelectionChanged="CalDate_SelectionChanged"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Time"></asp:Label>
&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlAppTime" runat="server">
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="btnBook" runat="server" OnClick="btnBook_Click" Text="Book" />
    </p>
</asp:Content>
