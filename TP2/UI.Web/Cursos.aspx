<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>

<asp:Content ID="Cursos" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Cursos</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID Curso" DataField="ID" />
                <asp:BoundField HeaderText="Anio Calendario" DataField="AnioCalendario" />
                <asp:BoundField HeaderText="ID Comision" DataField="IDComision" />
                <asp:BoundField HeaderText="ID Materia" DataField="IDMateria" />
                <asp:BoundField HeaderText="Cupo" DataField="Cupo" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="anioCalendarioLabel" runat="server" Text="Anio Calendario: "></asp:Label>
        <asp:TextBox ID="anioCalendarioTextBox" type="number" required="required" runat="server"></asp:TextBox>
        <br />
        <!--!
        <asp:TextBox ID="idComisionTextBox" runat="server"></asp:TextBox>
        <br />   -->
        <asp:Label ID="cupoLabel" runat="server" Text="Cupo: "></asp:Label>
        <asp:TextBox ID="cupoTextBox" type="number" required="required" min="5" max="30" runat="server"></asp:TextBox>
        <br />  
        <asp:Label ID="idComisionLabel" runat="server" Text="Comision: "></asp:Label> 
        <asp:DropDownList ID="idComisionddl" runat="server" DataTextField="Descripcion" DataValueField="ID">
        </asp:DropDownList>
        <br /> 
        <asp:Label ID="idMateriaLabel" runat="server" Text="Materia: "></asp:Label>
        <br />
        <asp:DropDownList ID="idMateriaddl" runat="server" DataValueField="ID" DataTextField="Descripcion">      
        </asp:DropDownList>
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
