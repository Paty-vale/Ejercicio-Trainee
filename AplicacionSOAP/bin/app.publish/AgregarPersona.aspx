<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AgregarPersona.aspx.cs" Inherits="AplicacionSOAP.AgregarPersona" %>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Boton" runat="server" OnClick = "MyButton_Click" Text="Enviar" />
</asp:Content>
