namespace UI.Desktop
{
    partial class PersonaDesktop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtFechaNac = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblTipoPersona = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblIDPlan = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.cbIDPlan = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.mtbFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.ttFechaNacimiento = new System.Windows.Forms.ToolTip(this.components);
            this.mtbLegajo = new System.Windows.Forms.MaskedTextBox();
            this.ttTelefono = new System.Windows.Forms.ToolTip(this.components);
            this.ttLegajo = new System.Windows.Forms.ToolTip(this.components);
            this.cbTipoPersona = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtFechaNac
            // 
            this.txtFechaNac.AutoSize = true;
            this.txtFechaNac.Location = new System.Drawing.Point(12, 121);
            this.txtFechaNac.Name = "txtFechaNac";
            this.txtFechaNac.Size = new System.Drawing.Size(108, 13);
            this.txtFechaNac.TabIndex = 20;
            this.txtFechaNac.Text = "Fecha de Nacimiento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(337, 193);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(216, 193);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(429, 10);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(160, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Tag = "Dirección";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 88);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.Tag = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(131, 62);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(160, 20);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.Tag = "Apellido";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(131, 10);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(160, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "ID";
            // 
            // lblTipoPersona
            // 
            this.lblTipoPersona.AutoSize = true;
            this.lblTipoPersona.Location = new System.Drawing.Point(334, 117);
            this.lblTipoPersona.Name = "lblTipoPersona";
            this.lblTipoPersona.Size = new System.Drawing.Size(70, 13);
            this.lblTipoPersona.TabIndex = 8;
            this.lblTipoPersona.Text = "Tipo Persona";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(334, 95);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 7;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblIDPlan
            // 
            this.lblIDPlan.AutoSize = true;
            this.lblIDPlan.Location = new System.Drawing.Point(12, 44);
            this.lblIDPlan.Name = "lblIDPlan";
            this.lblIDPlan.Size = new System.Drawing.Size(42, 13);
            this.lblIDPlan.TabIndex = 6;
            this.lblIDPlan.Text = "ID Plan";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(334, 43);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "Teléfono";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(334, 69);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(334, 17);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 95);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 17);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // cbIDPlan
            // 
            this.cbIDPlan.DisplayMember = "desc_plan";
            this.cbIDPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDPlan.FormattingEnabled = true;
            this.cbIDPlan.Location = new System.Drawing.Point(132, 36);
            this.cbIDPlan.Name = "cbIDPlan";
            this.cbIDPlan.Size = new System.Drawing.Size(160, 21);
            this.cbIDPlan.TabIndex = 2;
            this.cbIDPlan.Tag = "IDPlan";
            this.cbIDPlan.ValueMember = "id_plan";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(429, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(163, 20);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.Tag = "Email";
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(429, 35);
            this.mtbTelefono.Mask = "000-0000";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(160, 20);
            this.mtbTelefono.TabIndex = 7;
            this.mtbTelefono.Tag = "Teléfono";
            this.mtbTelefono.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbTelefono_MaskInputRejected);
            // 
            // mtbFechaNacimiento
            // 
            this.mtbFechaNacimiento.Location = new System.Drawing.Point(132, 113);
            this.mtbFechaNacimiento.Mask = "00/00/0000";
            this.mtbFechaNacimiento.Name = "mtbFechaNacimiento";
            this.mtbFechaNacimiento.Size = new System.Drawing.Size(159, 20);
            this.mtbFechaNacimiento.TabIndex = 5;
            this.mtbFechaNacimiento.Tag = "FechaNacimiento";
            // 
            // mtbLegajo
            // 
            this.mtbLegajo.Location = new System.Drawing.Point(429, 89);
            this.mtbLegajo.Mask = "99999";
            this.mtbLegajo.Name = "mtbLegajo";
            this.mtbLegajo.Size = new System.Drawing.Size(163, 20);
            this.mtbLegajo.TabIndex = 9;
            this.mtbLegajo.Tag = "Legajo";
            this.mtbLegajo.ValidatingType = typeof(int);
            this.mtbLegajo.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbLegajo_MaskInputRejected);
            // 
            // cbTipoPersona
            // 
            this.cbTipoPersona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPersona.FormattingEnabled = true;
            this.cbTipoPersona.Location = new System.Drawing.Point(429, 113);
            this.cbTipoPersona.Name = "cbTipoPersona";
            this.cbTipoPersona.Size = new System.Drawing.Size(121, 21);
            this.cbTipoPersona.TabIndex = 23;
            // 
            // PersonaDesktop
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 228);
            this.Controls.Add(this.cbTipoPersona);
            this.Controls.Add(this.mtbLegajo);
            this.Controls.Add(this.mtbFechaNacimiento);
            this.Controls.Add(this.mtbTelefono);
            this.Controls.Add(this.cbIDPlan);
            this.Controls.Add(this.txtFechaNac);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTipoPersona);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.lblIDPlan);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblID);
            this.Name = "PersonaDesktop";
            this.Text = "Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblIDPlan;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblTipoPersona;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label txtFechaNac;
        private System.Windows.Forms.ComboBox cbIDPlan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.MaskedTextBox mtbFechaNacimiento;
        private System.Windows.Forms.ToolTip ttFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox mtbLegajo;
        private System.Windows.Forms.ToolTip ttTelefono;
        private System.Windows.Forms.ToolTip ttLegajo;
        private System.Windows.Forms.ComboBox cbTipoPersona;
    }
}