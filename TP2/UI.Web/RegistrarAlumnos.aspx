<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarAlumnos.aspx.cs" Inherits="UI.Web.RegistrarAlumnos" %>

<asp:Content ID="RegistrarAlumno" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
   
     <asp:Panel ID="gridPanel" HorizontalAlign="Center" runat="server">
         <h2>Inscripcion</h2><br />             
    </asp:Panel>
    <asp:Panel ID="formPanel" Visible="false" HorizontalAlign="Center" runat="server" Height="159px">
        <asp:Label ID="idCursoLabel" runat="server" Text="ID Curso: "></asp:Label>
        <asp:DropDownList ID="idCursoddl" runat="server" DataValueField="ID" DataTextField="Descripcion"></asp:DropDownList>
        <br />
        <asp:Label ID="idAlumnoLabel" runat="server" Text="ID Alumno: "></asp:Label>
        <asp:TextBox ID="idAlumnoTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btnAceptar" CssClass="button" runat="server" Text="Aceptar" OnClick="btnAceptar_Click"/>
        <asp:Button ID="btnCancelar" CssClass="button" runat="server" OnClick="btnCancelar_Click" Text="Cancelar" />
    </asp:Panel>
   <asp:Panel ID="gridAdictionsPanel" runat="server">
        <asp:Button ID="btnNuevo" CssClass="button" runat="server" Text="Nuevo" OnClick="btnNuevo_Click"/>
    </asp:Panel>
    <asp:Panel ID="formActionsPanel" runat="server">     
       
    </asp:Panel>
</asp:Content>

