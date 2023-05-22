<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="EXAMENPARCIAL.Actualizacion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Actualizar Ave</h1>
    <p>
        &nbsp;</p>
    <p>
        Buscar:
        <asp:TextBox ID="textBoxBuscar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="buttonBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
    </p>
    <p>
        <asp:Label ID="labelNombre" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        Actualizar: <asp:TextBox ID="textBoxActualizar" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="buttonActualizar" runat="server" Enabled="False" OnClick="btnActualizar_Click" Text="Actualizar" />
    </p>
</asp:Content>
