<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>

<asp:Content ID="Materias" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Materias</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID Materia" DataField="ID" />
                <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                <asp:BoundField HeaderText="Horas Semanales" DataField="HsSemanales" />
                <asp:BoundField HeaderText="Horas Totales" DataField="HsTotales" />
                <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion: "></asp:Label>
        <asp:TextBox ID="descripcionTextBox" required="required" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="hsSemanalesLabel" runat="server" Text="Horas Semanales: "></asp:Label>
        <asp:TextBox ID="hsSemanalesTextBox" type="number" required="required" min="1" max="8" runat="server"></asp:TextBox>
        <br />    
         <asp:Label ID="hsTotalesLabel" runat="server" Text="Horas Totales: "></asp:Label>
        <asp:TextBox ID="hsTotalesTextBox" type="number" required="required" min="10" max="100" runat="server"></asp:TextBox>
        <br /> 
        <asp:Label ID="idPlanLabel" runat="server" Text="Plan: "></asp:Label> 
        <asp:DropDownList ID="idPlanddl" runat="server" DataTextField="Descripcion" DataValueField="ID">
        </asp:DropDownList>
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
