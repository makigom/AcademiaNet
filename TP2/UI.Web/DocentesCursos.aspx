<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DocentesCursos.aspx.cs" Inherits="UI.Web.DocentesCursos" %>

<asp:Content ID="DocentesCursos" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Docentes y Cursos</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID" DataField="ID" />
                <asp:BoundField HeaderText="ID Docente" DataField="IDDocente" />
                <asp:BoundField HeaderText="ID Curso" DataField="IDCurso" />
                <asp:BoundField HeaderText="Tipo Cargo" DataField="TipoCargo" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="idDocenteLabel" runat="server" Text="ID Docente: "></asp:Label>
        <asp:DropDownList ID="idDocenteddl" runat="server" DataValueField="ID" DataTextField="Apellido" >      
        </asp:DropDownList>
        <br />
        <asp:Label ID="idCursoLabel" runat="server" Text="ID Curso: "></asp:Label>
        <asp:DropDownList ID="idCursoddl" runat="server" DataValueField="ID" DataTextField="ID">      
        </asp:DropDownList>
        <br />  
        <asp:Label ID="tipoCargoLabel" runat="server" Text="Tipo Cargo: "></asp:Label>
        <asp:DropDownList ID="tipoCargoddl" runat="server" >
            <asp:ListItem Text="Titular" Value="Titular"></asp:ListItem>
            <asp:ListItem Text="Auxiliar" Value="Auxiliar"></asp:ListItem>
            <asp:ListItem Text="Ayudante" Value="Ayudante"></asp:ListItem>
        </asp:DropDownList>
        <br />
        <!--!
        <asp:TextBox ID="idComisionTextBox" runat="server"></asp:TextBox>
        <br />   -->            
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