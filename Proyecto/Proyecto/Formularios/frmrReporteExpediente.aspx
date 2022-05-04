<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmrReporteExpediente.aspx.cs" Inherits="Proyecto.Formularios.frmrReporteExpediente" %>
<%@ Register assembly="Microsoft.ReportViewer.WebForms" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <asp:ScriptManager ID="scmReporteExpediente" runat="server"></asp:ScriptManager>
        <div>
            <h1 class="auto-style1">Reporte de Clientes</h1>               
              <p> Buscar por</p>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Cedula"></asp:Label>
        <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
    &nbsp;&nbsp;
        <asp:Button ID="btVerReporte" runat="server" OnClick="btBuscar_Click" Text="Ver Reporte" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblResultado" runat="server" ForeColor="Red"></asp:Label>
       
        <br />
        <br />       
    <rsweb:ReportViewer ID="rpvExpedientes" runat="server" Width="100%">
  </rsweb:ReportViewer>

   
    
</asp:Content>
