<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Personas.aspx.cs" Inherits="UI.Web.Personas" %>

<asp:Content ID="Personas" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Personas</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID Persona" DataField="ID" />
                <asp:BoundField HeaderText="Nombre" DataField="Nombre" />
                <asp:BoundField HeaderText="Apellido" DataField="Apellido" />
                <asp:BoundField HeaderText="Direccion" DataField="Direccion" />
                <asp:BoundField HeaderText="Email" DataField="Email" />
                <asp:BoundField HeaderText="Telefono" DataField="Telefono" />
                <asp:BoundField HeaderText="Fecha de Nacimiento" DataField="FechaNacimiento" />
                <asp:BoundField HeaderText="Legajo" DataField="Legajo" />
                <asp:BoundField HeaderText="Tipo Persona" DataField="TiposPersona" />
                <asp:BoundField HeaderText="ID Plan" DataField="IDPlan" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre: "></asp:Label>
        <asp:TextBox ID="nombreTextBox" required="required" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="apellidoLabel" runat="server" Text="Apellido: "></asp:Label>
        <asp:TextBox ID="apellidoTextBox" required="required" runat="server"></asp:TextBox>
        <br />  
        <asp:Label ID="direccionLabel" runat="server" Text="Direccion: "></asp:Label>
        <asp:TextBox ID="direccionTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="emailLabel" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="emailTextBox" type="email" required="required" runat="server"></asp:TextBox>
        <br />       
        <asp:Label ID="telefonoLabel" runat="server" Text="Telefono: "> </asp:Label>
        <asp:TextBox ID="telefonoTextBox" type="tel" runat="server">  </asp:TextBox>      
        <br />
        <asp:Label ID="fechaNacLabel" runat="server" Text="Fecha de Nacimiento: "></asp:Label>
        <asp:TextBox ID="fechaNacTextBox" type="date" required="required" runat="server">  </asp:TextBox>
        <br />
        <asp:Label ID="legajoLabel" runat="server" Text="Legajo: "></asp:Label>
        <asp:TextBox ID="legajoTextBox" required="required" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="tipoPersonaLabel" runat="server" Text="Tipo Persona: "></asp:Label>
        <asp:DropDownList ID="tipoPersonaddl" required="required" runat="server" >
            <asp:ListItem Text="No docente" Value="No docente"></asp:ListItem>
            <asp:ListItem Text="Docente" Value="Docente"></asp:ListItem>
            <asp:ListItem Text="Alumno" Value="Alumno"></asp:ListItem>
        </asp:DropDownList> 
        <br />
        <asp:Label ID="idPlanLabel" runat="server" Text="ID Plan: "></asp:Label>
        <asp:DropDownList ID="idPlanddl" runat="server" DataValueField="ID" DataTextField="Descripcion"></asp:DropDownList>
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