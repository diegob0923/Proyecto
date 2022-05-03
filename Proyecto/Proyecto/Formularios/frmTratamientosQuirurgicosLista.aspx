<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmTratamientosQuirurgicosLista.aspx.cs" Inherits="Proyecto.Formularios.frmTratamientosQuirurgicosLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h3><asp:Label ID="Label2" runat="server" Text="Formulario Tratamientos Quirúrgicos"></asp:Label></h3>
    <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCargarRegistros" runat="server" OnClick="btnCargarRegistros_Click" Text="Cargar Registros" />
    &nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlNuevoTratamiento" runat="server" NavigateUrl="~/Formularios/frmTratamientosQuirurgicosInsertar.aspx">Nuevo Tratamiento</asp:HyperLink>
    <br />
    <br />
    <br />
    <asp:GridView ID="grdTratamientosQuirurgicos" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_tratamiento" HeaderText="Código" />
            <asp:BoundField DataField="nombre" HeaderText="Tratamientos" />
            <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
            <asp:HyperLinkField DataNavigateUrlFields="id_tratamiento" DataNavigateUrlFormatString="frmTratamientosQuirurgicosModificar.aspx?id_tratamiento={0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_tratamiento" DataNavigateUrlFormatString="frmTratamientosQuirurgicosEliminar.aspx?id_tratamiento={0}" Text="Eliminar" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
&nbsp;
    <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/frmMenuColaboradores.aspx">Regresar</asp:HyperLink>
</asp:Content>
