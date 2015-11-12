namespace UI.Desktop
{
    partial class ModuloUsuarioDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblIDModulo = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIDModulo = new System.Windows.Forms.ComboBox();
            this.mtbIDUsuario = new System.Windows.Forms.MaskedTextBox();
            this.ttIDUsuario = new System.Windows.Forms.ToolTip(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID";
            // 
            // lblIDModulo
            // 
            this.lblIDModulo.AutoSize = true;
            this.lblIDModulo.Location = new System.Drawing.Point(12, 76);
            this.lblIDModulo.Name = "lblIDModulo";
            this.lblIDModulo.Size = new System.Drawing.Size(56, 13);
            this.lblIDModulo.TabIndex = 1;
            this.lblIDModulo.Text = "ID Modulo";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Location = new System.Drawing.Point(12, 48);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(57, 13);
            this.lblIDUsuario.TabIndex = 2;
            this.lblIDUsuario.Text = "ID Usuario";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(84, 18);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(147, 20);
            this.txtID.TabIndex = 1;
            this.txtID.Tag = "ID";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(73, 112);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(168, 112);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIDModulo
            // 
            this.cbIDModulo.DisplayMember = "id_modulo";
            this.cbIDModulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDModulo.FormattingEnabled = true;
            this.cbIDModulo.Location = new System.Drawing.Point(84, 73);
            this.cbIDModulo.Name = "cbIDModulo";
            this.cbIDModulo.Size = new System.Drawing.Size(147, 21);
            this.cbIDModulo.TabIndex = 2;
            this.cbIDModulo.Tag = "IDModulo";
            this.cbIDModulo.ValueMember = "id_modulo";
            // 
            // mtbIDUsuario
            // 
            this.mtbIDUsuario.Location = new System.Drawing.Point(84, 45);
            this.mtbIDUsuario.Mask = "99999";
            this.mtbIDUsuario.Name = "mtbIDUsuario";
            this.mtbIDUsuario.Size = new System.Drawing.Size(147, 20);
            this.mtbIDUsuario.TabIndex = 3;
            this.mtbIDUsuario.Tag = "IDUsuario";
            this.mtbIDUsuario.ValidatingType = typeof(int);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(246, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ModuloUsuarioDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(333, 145);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mtbIDUsuario);
            this.Controls.Add(this.cbIDModulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.lblIDModulo);
            this.Controls.Add(this.lblID);
            this.Name = "ModuloUsuarioDesktop";
            this.Text = "Modulo - Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDModulo;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIDModulo;
        private System.Windows.Forms.MaskedTextBox mtbIDUsuario;
        private System.Windows.Forms.ToolTip ttIDUsuario;
        private System.Windows.Forms.Button btnBuscar;
    }
}