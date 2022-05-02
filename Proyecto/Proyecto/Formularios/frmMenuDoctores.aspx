<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmMenuDoctores.aspx.cs" Inherits="Proyecto.Formularios.frmMenuDoctores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><asp:Label ID="lblBienvenida" runat="server"></asp:Label></h2>
    
    <h3>Menú doctores</h3>
    <asp:DropDownList ID="ddlMenuDoctores" runat="server">
        <asp:ListItem Value="Seleccione una opcion">Seleccione una opcion</asp:ListItem>
        <asp:ListItem Value="Ver Citas">Ver Citas</asp:ListItem>
        <asp:ListItem Value="Cancelar Citas">Cancelar Citas</asp:ListItem>
        <asp:ListItem Value="Ver Expedientes">Ver Expedientes</asp:ListItem>
        <asp:ListItem Value="Ver Reportes">Ver Reportes</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" />
    <br />
</asp:Content>
