<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmEnfermedadesLista.aspx.cs" Inherits="Proyecto.Formularios.frmEnfermedadesLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3><asp:Label ID="Label2" runat="server" Text="Formulario Enfermedades"></asp:Label></h3>
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCargarRegistros" runat="server" OnClick="btnCargarRegistros_Click" Text="Cargar Registros" />
    &nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlNuevaEnfermedad" runat="server" NavigateUrl="~/Formularios/frmEnfermedadesInsertar.aspx">Nueva Enfermedad</asp:HyperLink>
    <br />
    <br />
    <br />
    <asp:GridView ID="grdEnfermedad" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_enfermedad" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Enfermedad" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:HyperLinkField DataNavigateUrlFields="id_enfermedad" DataNavigateUrlFormatString="frmEnfermedadesModificar.aspx?id_enfermedad={0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_enfermedad" DataNavigateUrlFormatString="frmEnfermedadesEliminar.aspx?id_enfermedad={0}" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
&nbsp;
    <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/frmMenuColaboradores.aspx">Regresar</asp:HyperLink>
</asp:Content>
