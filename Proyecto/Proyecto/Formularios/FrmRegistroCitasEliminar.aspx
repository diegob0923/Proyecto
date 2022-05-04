<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="FrmRegistroCitasEliminar.aspx.cs" Inherits="Proyecto.Formularios.FrmRegistroCitasEliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="hfIdRegistroCitas" runat="server" />
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Id Doctor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtidDoctor" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvidDoctor" runat="server" ControlToValidate="txtidDoctor" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Id Cliente"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtidCliente" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvidCliente" runat="server" ControlToValidate="txtidCliente" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Fecha Cita"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtFechaCita" runat="server" MaxLength="50"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="rfvFechaCita" runat="server" ControlToValidate="txtFechaCita" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Hora Cita"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtHoraCita" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvHoraCita" runat="server" ControlToValidate="txtHoraCita" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Text="Especialidad"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="txtEspecialidad" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ControlToValidate="txtEspecialidad" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Observaciones"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtObservaciones" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvObservaciones" runat="server" ControlToValidate="txtObservaciones" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label7" runat="server" Text="Estado Cita"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtestadoCita" runat="server" MaxLength="50"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvestadoCita" runat="server" ControlToValidate="txtestadoCita" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" />
            <br />
            <br />
              
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/frmRegistroCitasLista.aspx">Regresar</asp:HyperLink>
    
    <br />
    <br />
            <asp:Label ID="lblMensaje" runat="server"></asp:Label>
        </div>
    </form>
</asp:Content>