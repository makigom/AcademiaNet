namespace UI.Desktop
{
    partial class RegistrarAlumnoDesktop
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
            this.lblID = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.lblIDCurso = new System.Windows.Forms.Label();
            this.cbIDCurso = new System.Windows.Forms.ComboBox();
            this.lblIDAlumno = new System.Windows.Forms.Label();
            this.mtbIDAlumno = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(36, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Tag = "ID";
            this.lblID.Text = "ID ";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(92, 29);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 2;
            this.ID.Tag = "ID";
            // 
            // lblIDCurso
            // 
            this.lblIDCurso.AutoSize = true;
            this.lblIDCurso.Location = new System.Drawing.Point(34, 63);
            this.lblIDCurso.Name = "lblIDCurso";
            this.lblIDCurso.Size = new System.Drawing.Size(48, 13);
            this.lblIDCurso.TabIndex = 3;
            this.lblIDCurso.Text = "ID Curso";
            // 
            // cbIDCurso
            // 
            this.cbIDCurso.DisplayMember = "id_curso";
            this.cbIDCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCurso.FormattingEnabled = true;
            this.cbIDCurso.Location = new System.Drawing.Point(92, 60);
            this.cbIDCurso.Name = "cbIDCurso";
            this.cbIDCurso.Size = new System.Drawing.Size(100, 21);
            this.cbIDCurso.TabIndex = 4;
            this.cbIDCurso.Tag = "IDCurso";
            this.cbIDCurso.ValueMember = "id_curso";
            // 
            // lblIDAlumno
            // 
            this.lblIDAlumno.AutoSize = true;
            this.lblIDAlumno.Location = new System.Drawing.Point(34, 92);
            this.lblIDAlumno.Name = "lblIDAlumno";
            this.lblIDAlumno.Size = new System.Drawing.Size(56, 13);
            this.lblIDAlumno.TabIndex = 5;
            this.lblIDAlumno.Text = "ID Alumno";
            // 
            // mtbIDAlumno
            // 
            this.mtbIDAlumno.Location = new System.Drawing.Point(92, 89);
            this.mtbIDAlumno.Mask = "00000";
            this.mtbIDAlumno.Name = "mtbIDAlumno";
            this.mtbIDAlumno.Size = new System.Drawing.Size(100, 20);
            this.mtbIDAlumno.TabIndex = 6;
            this.mtbIDAlumno.Tag = "IDAlumno";
            this.mtbIDAlumno.ValidatingType = typeof(int);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(200, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Tag = "";
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(37, 127);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(118, 127);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RegistrarAlumnoDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 169);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.mtbIDAlumno);
            this.Controls.Add(this.lblIDAlumno);
            this.Controls.Add(this.cbIDCurso);
            this.Controls.Add(this.lblIDCurso);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.lblID);
            this.Name = "RegistrarAlumnoDesktop";
            this.Text = "Registrar Alumno a Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label lblIDCurso;
        private System.Windows.Forms.ComboBox cbIDCurso;
        private System.Windows.Forms.Label lblIDAlumno;
        private System.Windows.Forms.MaskedTextBox mtbIDAlumno;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}