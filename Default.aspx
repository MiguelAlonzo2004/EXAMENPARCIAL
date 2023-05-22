<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EXAMENPARCIAL._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Ingreso de Aves</h1>
        <p class="lead">
            <asp:Label ID="Label1" runat="server" Text="Nombre: "></asp:Label>
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label2" runat="server" Text="Especie: "></asp:Label>
            <asp:TextBox ID="TextBoxEspecie" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Tipo de Alimentación:
            <asp:TextBox ID="TextBoxAlimentacion" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Label ID="Label3" runat="server" Text="Tiempo máximo de vida: "></asp:Label>
            <asp:TextBox ID="TextBoxTiempo" runat="server"></asp:TextBox>
        </p>
        <p class="lead">&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Volador: "></asp:Label>
&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>Sí</asp:ListItem>
                <asp:ListItem>No</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Text="Período de incubación:"></asp:Label>
            <asp:TextBox ID="TextBoxIncubacion" runat="server"></asp:TextBox>
        </p>
        <p class="lead">
            <asp:Button ID="Button1" runat="server" Text="Ingresar" />
        </p>
        <p class="lead">&nbsp;</p>
    </div>

    </asp:Content>
