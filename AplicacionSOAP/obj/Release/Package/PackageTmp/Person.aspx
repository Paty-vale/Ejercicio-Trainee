<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="AplicacionSOAP.Person" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h4>Personas existentes en el sistema</h4>
    <asp:Table id="Table1"  
        Runat="server"/>
    <div id="per_list" runat="server"></div>
    <asp:HyperLink NavigateUrl="~/AgregarPersona" Text="Agregar una nueva persona" runat="server" />
</asp:Content>
