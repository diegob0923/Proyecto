<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmEspecialidadesMedicasLista.aspx.cs" Inherits="Proyecto.Formularios.frmEspecialidadesMedicasLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCargarRegistros" runat="server" OnClick="btnCargarRegistros_Click" Text="Cargar Registros" />
    <br />
    <br />
    <br />
    <asp:GridView ID="grdEspecialidadesMedicas" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_especialidad" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Especialidad" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:HyperLinkField DataNavigateUrlFields="id_especialidad" DataNavigateUrlFormatString="frmEspecialidadesMedicasModificar.aspx?id_especialidad={0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_especialidad" DataNavigateUrlFormatString="frmEspecialidadesMedicasEliminar.aspx?id_especialidad={0}" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
&nbsp;
</asp:Content>
