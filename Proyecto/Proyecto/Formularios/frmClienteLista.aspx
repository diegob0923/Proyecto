<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteLista.aspx.cs" Inherits="Proyecto.Formularios.frmClienteLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:Label ID="Label1" runat="server" Text="Cédula"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" />
<br />
<br />
<br />
<br />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
<br />
<br />
</asp:Content>
