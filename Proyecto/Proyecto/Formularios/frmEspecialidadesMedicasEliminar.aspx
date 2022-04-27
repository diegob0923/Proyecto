<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmEspecialidadesMedicasEliminar.aspx.cs" Inherits="Proyecto.Formularios.frmEspecialidadMedicaEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hfIdEspecialidad" runat="server" />
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNombre" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Descripción"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDescripcion" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnEliminar" runat="server" OnClick="btnEliminar_Click" Text="Eliminar" />
    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
</asp:Content>
