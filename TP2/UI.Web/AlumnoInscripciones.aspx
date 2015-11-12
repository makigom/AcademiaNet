<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"  CodeBehind="AlumnoInscripciones.aspx.cs" Inherits="UI.Web.AlumnosInscripciones" %>

<asp:Content ID="AlumnoInscripciones" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Alumno Inscricpiones</h2><br />
        <asp:GridView ID="GridView1" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False"
            CssClass="Grid"
            AlternatingRowStyle-CssClass="alt"
            PagerStyle-CssClass="pgr"
            SelectedRowStyle-BackColor="#ffe8e9"
            SelectedRowStyle-ForeColor="Black"
            DataKeyNames="ID" Width="444px">
            <Columns>
                <asp:BoundField HeaderText="ID Alumno Inscripcion" DataField="ID" />
                <asp:BoundField HeaderText="ID Alumno" DataField="IDAlumno" />
                <asp:BoundField HeaderText="ID Curso" DataField="IDCurso" />
                <asp:BoundField HeaderText="Nota" DataField="Nota" />
                <asp:BoundField HeaderText="Condicion" DataField="Condicion" />
                <asp:CommandField HeaderText="Seleccionar" ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
         
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
      
       <asp:Label ID="idAlumnoLabel" runat="server" Text="ID Alumno: "></asp:Label>
        <asp:TextBox ID="idAlumnoTextBox" required="required" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="idCursoLabel" runat="server" Text="ID Curso: "></asp:Label>
        <asp:TextBox ID="idCursoTextBox" required="required" runat="server"></asp:TextBox>
        <br />
        
        <asp:Label ID="notaLabel" runat="server" Text="Nota: "></asp:Label>
        <asp:TextBox ID="notaTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="condicionLabel" runat="server" Text="Condicion: "></asp:Label>
        <!-- <asp:TextBox ID="condicionTextBox" required="required" Text="Password" runat="server"></asp:TextBox> --> 
        <asp:DropDownList ID="condicionddl" required="required" runat="server" >
            <asp:ListItem Text="Inscripto" Value="Inscripto"></asp:ListItem>
            <asp:ListItem Text="No inscripto" Value="No inscripto"></asp:ListItem>
            <asp:ListItem Text="Regular" Value="Regular"></asp:ListItem>
            <asp:ListItem Text="Aprobado" Value="Aprobado"></asp:ListItem>
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