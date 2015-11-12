<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ModulosUsuarios.aspx.cs" Inherits="UI.Web.ModulosUsuarios" %>

<asp:Content ID="ModuloUsuarios" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Modulo Usuarios</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID Modulo Usuario" DataField="ID" />
                <asp:BoundField HeaderText="ID Usuario" DataField="IDUsuario" />
                <asp:BoundField HeaderText="ID Modulo" DataField="IDModulo" />
                <asp:CheckBoxField HeaderText="Permite Alta" DataField="PermiteAlta" />
                <asp:CheckBoxField HeaderText="Permite Baja" DataField="PermiteBaja" />
                <asp:CheckBoxField HeaderText="Permite Modificacion" DataField="PermiteModificacion" />
                <asp:CheckBoxField HeaderText="Permite Consulta" DataField="PermiteConsulta" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="IDUsuarioLabel" runat="server" Text="ID Usuario: "></asp:Label>
        <asp:DropDownList ID="IDUsuarioddl" runat="server" DataValueField="ID" DataTextField="NombreUsuario">      
        </asp:DropDownList>
        <br />
        <asp:Label ID="IDModuloLabel" runat="server" Text="ID Modulo: "></asp:Label>
        <asp:DropDownList ID="IDModuloddl" runat="server" DataValueField="ID" DataTextField="Descripcion">      
        </asp:DropDownList>
        <br />  
        <asp:Label ID="permiteAltaLabel" runat="server" Text="Permite Alta: "></asp:Label> 
        <asp:CheckBox ID="permiteAltaChkBox" runat="server"></asp:CheckBox>
        <br /> 
        <asp:Label ID="permiteBajaLabel" runat="server" Text="Permite Baja: "></asp:Label>
        <asp:CheckBox ID="permiteBajaChkBox" runat="server"></asp:CheckBox>
        <br />
        <asp:Label ID="permiteModificacionLabel" runat="server" Text="Permite Modificacion: "></asp:Label>
        <asp:CheckBox ID="permiteModificacionChkBox" runat="server"></asp:CheckBox>
        <br />
        <asp:Label ID="permiteConsultaLabel" runat="server" Text="Permite Consulta: "></asp:Label>
        <asp:CheckBox ID="permiteConsultaChkBox" runat="server"></asp:CheckBox>
        <br />
    </asp:Panel>
   <asp:Panel ID="gridAdictionsPanel" runat="server">
        <asp:Button ID="btnNuevo" CssClass="button" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>
        <asp:Button ID="btnEditar" CssClass="button" runat="server" Text="Editar" OnClick="btnEditar_Click"/>
        <asp:Button ID="btnEliminar" CssClass="button" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"/>
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">     
        <asp:Button ID="btnAceptar" CssClass="button" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"/>
        <asp:Button ID="btnCancelar" CssClass="button" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
    </asp:Panel>
</asp:Content>
