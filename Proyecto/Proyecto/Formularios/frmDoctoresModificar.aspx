<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="frmDoctoresModificar.aspx.cs" Inherits="Proyecto.Formularios.frmDoctoresModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <asp:HiddenField ID="hfIdDoctores" runat="server" />
    
    <br />
    <asp:Label ID="Label1" runat="server" Text="Cédula"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtCedula" runat="server" TextMode="Number" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Género"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtGenero" runat="server" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Fecha Nacimiento"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtFechaNacimiento" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Nombre"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtNombre" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

    <br />
    <br />
            <asp:Label ID="Label5" runat="server" Text="Primer Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrimerApellido" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br />
            <asp:Label ID="Label6" runat="server" Text="Segundo Apellido"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtSegundoApellido" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br />
            <asp:Label ID="Label7" runat="server" Text="Telefono1"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono1" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br />
            <asp:Label ID="Label8" runat="server" Text="Telefono2"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTelefono2" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br />
            <asp:Label ID="Label9" runat="server" Text="Correo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCorreo" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br />
     <asp:Label ID="Label16" runat="server" Text="Carnet"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCarnet" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="rfvCarnet" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            <asp:Label ID="Label10" runat="server" Text="Provincia"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlProvincia" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Provincia" OnSelectedIndexChanged="ddlProvincia_SelectedIndexChanged" Enabled="False">
            </asp:DropDownList>
            <br />
    <br />
            <asp:Label ID="Label11" runat="server" Text="Canton"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlCanton" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Canton" OnSelectedIndexChanged="ddlCanton_SelectedIndexChanged" Enabled="False">
            </asp:DropDownList>
            <br />
    <br />
            <asp:Label ID="Label12" runat="server" Text="Distrito"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="ddlDistrito" runat="server" AutoPostBack="True" DataTextField="nombre" DataValueField="id_Distrito" OnSelectedIndexChanged="ddlDistrito_SelectedIndexChanged" Enabled="False">
            </asp:DropDownList>
            <br />
    <br />
            <asp:Label ID="Label13" runat="server" Text="Dirección"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDireccion" runat="server" MaxLength="50" Enabled="False"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCarnet" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>

            <br />
    <br/>
         <asp:Label ID="Label14" runat="server" Text="Especialidad Médica"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtEspecialidad" runat="server" MaxLength="50"></asp:TextBox>
            &nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvEspecialidad" runat="server" ControlToValidate="txtEspecialidad" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <br />
            <br />
     <asp:Label ID="Label15" runat="server" Text="Hora Almuerzo"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtHoraAlmuerzo" runat="server" MaxLength="50"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;<asp:RequiredFieldValidator ID="rfvHoraAlmuerzo" runat="server" ControlToValidate="txtHoraAlmuerzo" ErrorMessage="Campo requerido" ForeColor="Red"></asp:RequiredFieldValidator>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
    <asp:Button ID="btnModificar" runat="server" OnClick="btnModificar_Click" Text="Modificar" />
    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/frmDoctoresLista.aspx">Regresar</asp:HyperLink>
    
    <br />
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    

</asp:Content>
