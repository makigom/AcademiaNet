namespace UI.Desktop
{
    partial class DocenteCursoDesktop
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
            this.txtIDDictado = new System.Windows.Forms.TextBox();
            this.lblIDDictado = new System.Windows.Forms.Label();
            this.lblIDDocente = new System.Windows.Forms.Label();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblTipoCargo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIDCurso = new System.Windows.Forms.ComboBox();
            this.cbTipoCargo = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mtbIDDocente = new System.Windows.Forms.MaskedTextBox();
            this.ttIDDocente = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txtIDDictado
            // 
            this.txtIDDictado.Location = new System.Drawing.Point(90, 6);
            this.txtIDDictado.Name = "txtIDDictado";
            this.txtIDDictado.ReadOnly = true;
            this.txtIDDictado.Size = new System.Drawing.Size(127, 20);
            this.txtIDDictado.TabIndex = 1;
            this.txtIDDictado.Tag = "ID";
            // 
            // lblIDDictado
            // 
            this.lblIDDictado.AutoSize = true;
            this.lblIDDictado.Location = new System.Drawing.Point(8, 9);
            this.lblIDDictado.Name = "lblIDDictado";
            this.lblIDDictado.Size = new System.Drawing.Size(58, 13);
            this.lblIDDictado.TabIndex = 4;
            this.lblIDDictado.Text = "ID Dictado";
            // 
            // lblIDDocente
            // 
            this.lblIDDocente.AutoSize = true;
            this.lblIDDocente.Location = new System.Drawing.Point(8, 35);
            this.lblIDDocente.Name = "lblIDDocente";
            this.lblIDDocente.Size = new System.Drawing.Size(62, 13);
            this.lblIDDocente.TabIndex = 5;
            this.lblIDDocente.Text = "ID Docente";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(8, 65);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 6;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblTipoCargo
            // 
            this.lblTipoCargo.AutoSize = true;
            this.lblTipoCargo.Location = new System.Drawing.Point(8, 98);
            this.lblTipoCargo.Name = "lblTipoCargo";
            this.lblTipoCargo.Size = new System.Drawing.Size(59, 13);
            this.lblTipoCargo.TabIndex = 7;
            this.lblTipoCargo.Text = "Tipo Cargo";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(79, 127);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(160, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIDCurso
            // 
            this.cbIDCurso.DisplayMember = "id_curso";
            this.cbIDCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCurso.FormattingEnabled = true;
            this.cbIDCurso.Location = new System.Drawing.Point(90, 62);
            this.cbIDCurso.Name = "cbIDCurso";
            this.cbIDCurso.Size = new System.Drawing.Size(127, 21);
            this.cbIDCurso.TabIndex = 4;
            this.cbIDCurso.Tag = "IDCurso";
            this.cbIDCurso.ValueMember = "id_curso";
            // 
            // cbTipoCargo
            // 
            this.cbTipoCargo.DisplayMember = "legajo";
            this.cbTipoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoCargo.FormattingEnabled = true;
            this.cbTipoCargo.Location = new System.Drawing.Point(90, 90);
            this.cbTipoCargo.Name = "cbTipoCargo";
            this.cbTipoCargo.Size = new System.Drawing.Size(127, 21);
            this.cbTipoCargo.TabIndex = 5;
            this.cbTipoCargo.Tag = "TipoCargo";
            this.cbTipoCargo.ValueMember = "tipo_persona";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(223, 29);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mtbIDDocente
            // 
            this.mtbIDDocente.Location = new System.Drawing.Point(90, 35);
            this.mtbIDDocente.Mask = "99999";
            this.mtbIDDocente.Name = "mtbIDDocente";
            this.mtbIDDocente.Size = new System.Drawing.Size(127, 20);
            this.mtbIDDocente.TabIndex = 2;
            this.mtbIDDocente.Tag = "IDDocente";
            this.mtbIDDocente.ValidatingType = typeof(int);
            // 
            // DocenteCursoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 157);
            this.Controls.Add(this.mtbIDDocente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbTipoCargo);
            this.Controls.Add(this.cbIDCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblTipoCargo);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblIDDocente);
            this.Controls.Add(this.lblIDDictado);
            this.Controls.Add(this.txtIDDictado);
            this.Name = "DocenteCursoDesktop";
            this.Text = "Docente - Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDDictado;
        private System.Windows.Forms.Label lblIDDictado;
        private System.Windows.Forms.Label lblIDDocente;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblTipoCargo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIDCurso;
        private System.Windows.Forms.ComboBox cbTipoCargo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbIDDocente;
        private System.Windows.Forms.ToolTip ttIDDocente;
    }
}