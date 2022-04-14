<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmRegistroCitasLista.aspx.cs" Inherits="Proyecto.Formularios.FrmRegistroCitasLista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="idCliente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtidCliente" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnCargarRegistros" runat="server" OnClick="btnCargarRegistros_Click" Text="Cargar Registros" />
    <br />
    <br />
    <br />
    <asp:Label ID="lblMensajeError" runat="server"></asp:Label>
<br />
<br />
    <asp:GridView ID="grdRegistroCitas" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="id_Doctor" HeaderText="Id Doctor" />
            <asp:BoundField DataField="fechaCita" HeaderText="Fecha Cita" />
            <asp:BoundField DataField="HoraCita" HeaderText="Hora Cita" />
            <asp:BoundField DataField="Especialidad" HeaderText="Especialidad" />
            <asp:BoundField DataField="Observaciones" HeaderText="Observaciones" />
            <asp:BoundField DataField="EstadoCita" HeaderText="Estado Cita" />
        </Columns>
    </asp:GridView>
    <br />
    <br />
&nbsp;
</asp:Content>
