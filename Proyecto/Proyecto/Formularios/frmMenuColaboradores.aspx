<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmMenuColaboradores.aspx.cs" Inherits="Proyecto.Formularios.frmMenuColaboradores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2><asp:Label ID="lblBienvenida" runat="server"></asp:Label>
    </h2>

    <h3>Menú Colaboradores&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Mantenimiento Catálogos"></asp:Label>
    </h3>
    <asp:DropDownList ID="ddlMenuColaboradores" runat="server">
        <asp:ListItem Value="Seleccione una opcion">Seleccione una opcion</asp:ListItem>
        <asp:ListItem Value="Ver Citas">Ver Citas</asp:ListItem>
        <asp:ListItem Value="Cancelar Citas">Cancelar Citas</asp:ListItem>
        <asp:ListItem Value="Modificar datos paciente">Modificar datos paciente</asp:ListItem>
        <asp:ListItem Value="Ver Reportes ">Ver Reportes</asp:ListItem>
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlCatalogos" runat="server">
        <asp:ListItem Value="Seleccione una opcion">Seleccione una opcion</asp:ListItem>
        <asp:ListItem Value="Clientes">Clientes</asp:ListItem>
        <asp:ListItem Value="Especialidades Medicas">Especialidades Médicas</asp:ListItem>
        <asp:ListItem Value="Enfermedades">Enfermedades</asp:ListItem>
        <asp:ListItem Value="Tratamientos Quirurgicos">Tratamientos Quirúrgicos</asp:ListItem>
        <asp:ListItem Value="Doctores">Doctores</asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Button ID="btnSiguiente" runat="server" OnClick="btnSiguiente_Click" Text="Siguiente" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnMantenimiento" runat="server" OnClick="btnMantenimiento_Click" Text="Mantenimiento" />
    <br />
</asp:Content>
