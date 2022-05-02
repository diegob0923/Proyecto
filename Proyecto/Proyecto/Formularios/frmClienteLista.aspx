<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmClienteLista.aspx.cs" Inherits="Proyecto.Formularios.frmClienteLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <h3><asp:Label ID="Label2" runat="server" Text="Formulario Clientes"></asp:Label></h3>
    <asp:Label ID="Label1" runat="server" Text="Cédula"></asp:Label>
&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCargarDatos" runat="server" Text="Cargar datos" OnClick="btnBuscar_Click" />
&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlNuevoCliente" runat="server" NavigateUrl="~/Formularios/frmClienteInsertar.aspx">Nuevo Cliente</asp:HyperLink>
<br />
    <br />
    <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
<br />
<br />
    <asp:GridView ID="grdClientes" runat="server" AutoGenerateColumns="False" style="margin-bottom: 0px" Width="1253px">
        <Columns>
            <asp:BoundField DataField="cedula" HeaderText="Cédula" />
            <asp:BoundField DataField="genero" HeaderText="Genero" />
            <asp:BoundField DataField="fecha_nacimiento" HeaderText="Fecha nacimiento" />
            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
            <asp:BoundField DataField="primer_apellido" HeaderText="1er Apellido " />
            <asp:BoundField DataField="segundo_apellido" HeaderText="2do Apellido" />
            <asp:BoundField DataField="telefono1" HeaderText="Teléfono1" />
            <asp:BoundField DataField="telefono2" HeaderText="Teléfono2" />
            <asp:BoundField DataField="correo" HeaderText="Correo" />
            <asp:BoundField DataField="provincia" HeaderText="Provincia" />
            <asp:BoundField DataField="canton" HeaderText="Canton" />
            <asp:BoundField DataField="distrito" HeaderText="Distrito" />
            <asp:BoundField DataField="direccion" HeaderText="Dirección" />
            <asp:HyperLinkField DataNavigateUrlFields="id_cliente" DataNavigateUrlFormatString="frmClienteModificar.aspx?id_cliente={0}" Text="Modificar" />
            <asp:HyperLinkField DataNavigateUrlFields="id_cliente" DataNavigateUrlFormatString="frmClienteEliminar.aspx?id_cliente={0}" Text="Eliminar" />
        </Columns>
    </asp:GridView>
<br />
    <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/frmMenuColaboradores.aspx">Regresar</asp:HyperLink>
<br />
</asp:Content>
