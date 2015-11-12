namespace UI.Desktop
{
    partial class AlumnoInscripcionesDesktop
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
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbIDCurso = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.mtbNota = new System.Windows.Forms.MaskedTextBox();
            this.ttNota = new System.Windows.Forms.ToolTip(this.components);
            this.mtbIDAlumno = new System.Windows.Forms.MaskedTextBox();
            this.ttIDAlumno = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(42, 48);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Tag = "ID";
            this.lblID.Text = "ID ";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(42, 74);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 1;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(42, 100);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlumno.TabIndex = 2;
            this.lblIDAlumno.Text = "ID Alumno";
            // 
            // lblCondicion
            // 
            this.lblCondicion.AutoSize = true;
            this.lblCondicion.Location = new System.Drawing.Point(42, 152);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(54, 13);
            this.lblCondicion.TabIndex = 3;
            this.lblCondicion.Text = "Condición";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(120, 41);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 1;
            this.ID.Tag = "ID";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(42, 126);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(30, 13);
            this.lblNota.TabIndex = 5;
            this.lblNota.Text = "Nota";
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(120, 145);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(100, 20);
            this.txtCondicion.TabIndex = 6;
            this.txtCondicion.Tag = "Condicion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(80, 189);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.Enter += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 189);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbIDCurso
            // 
            this.cbIDCurso.DisplayMember = "id_curso";
            this.cbIDCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCurso.FormattingEnabled = true;
            this.cbIDCurso.Location = new System.Drawing.Point(120, 66);
            this.cbIDCurso.Name = "cbIDCurso";
            this.cbIDCurso.Size = new System.Drawing.Size(100, 21);
            this.cbIDCurso.TabIndex = 2;
            this.cbIDCurso.Tag = "IDCurso";
            this.cbIDCurso.ValueMember = "id_curso";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 92);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // mtbNota
            // 
            this.mtbNota.Location = new System.Drawing.Point(120, 119);
            this.mtbNota.Mask = "99";
            this.mtbNota.Name = "mtbNota";
            this.mtbNota.Size = new System.Drawing.Size(100, 20);
            this.mtbNota.TabIndex = 5;
            this.mtbNota.Tag = "Nota";
            this.mtbNota.ValidatingType = typeof(int);
            this.mtbNota.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbNota_MaskInputRejected);
            // 
            // mtbIDAlumno
            // 
            this.mtbIDAlumno.Location = new System.Drawing.Point(120, 92);
            this.mtbIDAlumno.Mask = "00000";
            this.mtbIDAlumno.Name = "mtbIDAlumno";
            this.mtbIDAlumno.Size = new System.Drawing.Size(100, 20);
            this.mtbIDAlumno.TabIndex = 3;
            this.mtbIDAlumno.Tag = "IDAlumno";
            this.mtbIDAlumno.ValidatingType = typeof(int);
            this.mtbIDAlumno.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbIDAlumno_MaskInputRejected);
            // 
            // AlumnoInscripcionesDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 220);
            this.Controls.Add(this.mtbIDAlumno);
            this.Controls.Add(this.mtbNota);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cbIDCurso);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.lblIDAlumno);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.lblID);
            this.Name = "AlumnoInscripcionesDesktop";
            this.Text = "AlumnoInscripcionesDesktop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbIDCurso;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.MaskedTextBox mtbNota;
        private System.Windows.Forms.ToolTip ttNota;
        private System.Windows.Forms.MaskedTextBox mtbIDAlumno;
        private System.Windows.Forms.ToolTip ttIDAlumno;

    }
}