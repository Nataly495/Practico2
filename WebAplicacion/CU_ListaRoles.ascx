<%@ Control Language="C#" AutoEventWireup="true" 
    CodeBehind="CU_ListaRoles.ascx.cs"
    Inherits="WebAplicacion.CU_ListaRoles" %>
<asp:GridView ID="rgvListaRoles" runat="server"
AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" />
        <asp:BoundField DataField="NombreRol" HeaderText="Rol" />
        </Columns>
    </asp:GridView>
