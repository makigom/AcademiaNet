namespace UI.Desktop
{
    partial class formMain
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
            this.mnsPrincipal = new System.Windows.Forms.MenuStrip();
            this.mnuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlumnosInscripciones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuComisiones = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCursos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDocenteCurso = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEspecialidades = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMaterias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPersonas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlanes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegistrarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReporte = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbsUsuarios = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsPrincipal.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsPrincipal
            // 
            this.mnsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArchivo,
            this.mnuGestion,
            this.mnuAyuda});
            this.mnsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnsPrincipal.Name = "mnsPrincipal";
            this.mnsPrincipal.Size = new System.Drawing.Size(360, 24);
            this.mnsPrincipal.TabIndex = 1;
            this.mnsPrincipal.Text = "menuStrip1";
            // 
            // mnuArchivo
            // 
            this.mnuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir,
            this.mnuCerrarSesion});
            this.mnuArchivo.Name = "mnuArchivo";
            this.mnuArchivo.Size = new System.Drawing.Size(60, 20);
            this.mnuArchivo.Text = "Archivo";
            this.mnuArchivo.Click += new System.EventHandler(this.mnuArchivo_Click);
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(143, 22);
            this.mnuSalir.Text = "Salir";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // mnuCerrarSesion
            // 
            this.mnuCerrarSesion.Name = "mnuCerrarSesion";
            this.mnuCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.mnuCerrarSesion.Text = "Cerrar Sesion";
            this.mnuCerrarSesion.Click += new System.EventHandler(this.mnuCerrarSesion_Click);
            // 
            // mnuGestion
            // 
            this.mnuGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlumnosInscripciones,
            this.mnuComisiones,
            this.mnuCursos,
            this.mnuDocenteCurso,
            this.mnuEspecialidades,
            this.mnuMaterias,
            this.mnuPersonas,
            this.mnuPlanes,
            this.mnuUsuarios,
            this.mnuRegistrarAlumno,
            this.mnuReporte});
            this.mnuGestion.Name = "mnuGestion";
            this.mnuGestion.Size = new System.Drawing.Size(59, 20);
            this.mnuGestion.Text = "Gestion";
            // 
            // mnuAlumnosInscripciones
            // 
            this.mnuAlumnosInscripciones.Name = "mnuAlumnosInscripciones";
            this.mnuAlumnosInscripciones.Size = new System.Drawing.Size(209, 22);
            this.mnuAlumnosInscripciones.Text = "Alumno inscripciones";
            this.mnuAlumnosInscripciones.Visible = false;
            this.mnuAlumnosInscripciones.Click += new System.EventHandler(this.mnuAlumnosInscripciones_Click);
            // 
            // mnuComisiones
            // 
            this.mnuComisiones.Name = "mnuComisiones";
            this.mnuComisiones.Size = new System.Drawing.Size(209, 22);
            this.mnuComisiones.Text = "Comisiones";
            this.mnuComisiones.Visible = false;
            this.mnuComisiones.Click += new System.EventHandler(this.mnuComisiones_Click);
            // 
            // mnuCursos
            // 
            this.mnuCursos.Name = "mnuCursos";
            this.mnuCursos.Size = new System.Drawing.Size(209, 22);
            this.mnuCursos.Text = "Cursos";
            this.mnuCursos.Visible = false;
            this.mnuCursos.Click += new System.EventHandler(this.mnuCursos_Click);
            // 
            // mnuDocenteCurso
            // 
            this.mnuDocenteCurso.Name = "mnuDocenteCurso";
            this.mnuDocenteCurso.Size = new System.Drawing.Size(209, 22);
            this.mnuDocenteCurso.Text = "Docente Curso";
            this.mnuDocenteCurso.Visible = false;
            this.mnuDocenteCurso.Click += new System.EventHandler(this.mnuDocentesCursos_Click);
            // 
            // mnuEspecialidades
            // 
            this.mnuEspecialidades.Name = "mnuEspecialidades";
            this.mnuEspecialidades.Size = new System.Drawing.Size(209, 22);
            this.mnuEspecialidades.Text = "Especialidades";
            this.mnuEspecialidades.Visible = false;
            this.mnuEspecialidades.Click += new System.EventHandler(this.mnuEspecialidades_Click);
            // 
            // mnuMaterias
            // 
            this.mnuMaterias.Name = "mnuMaterias";
            this.mnuMaterias.Size = new System.Drawing.Size(209, 22);
            this.mnuMaterias.Text = "Materias";
            this.mnuMaterias.Visible = false;
            this.mnuMaterias.Click += new System.EventHandler(this.mnuMaterias_Click);
            // 
            // mnuPersonas
            // 
            this.mnuPersonas.Name = "mnuPersonas";
            this.mnuPersonas.Size = new System.Drawing.Size(209, 22);
            this.mnuPersonas.Text = "Personas";
            this.mnuPersonas.Visible = false;
            this.mnuPersonas.Click += new System.EventHandler(this.mnuPersonas_Click);
            // 
            // mnuPlanes
            // 
            this.mnuPlanes.Name = "mnuPlanes";
            this.mnuPlanes.Size = new System.Drawing.Size(209, 22);
            this.mnuPlanes.Text = "Planes";
            this.mnuPlanes.Visible = false;
            this.mnuPlanes.Click += new System.EventHandler(this.mnuPlanes_Click);
            // 
            // mnuUsuarios
            // 
            this.mnuUsuarios.Name = "mnuUsuarios";
            this.mnuUsuarios.Size = new System.Drawing.Size(209, 22);
            this.mnuUsuarios.Text = "Usuarios";
            this.mnuUsuarios.Visible = false;
            this.mnuUsuarios.Click += new System.EventHandler(this.mnuUsuarios_Click);
            // 
            // mnuRegistrarAlumno
            // 
            this.mnuRegistrarAlumno.Name = "mnuRegistrarAlumno";
            this.mnuRegistrarAlumno.Size = new System.Drawing.Size(209, 22);
            this.mnuRegistrarAlumno.Text = "Registrar Alumno a Curso";
            this.mnuRegistrarAlumno.Visible = false;
            this.mnuRegistrarAlumno.Click += new System.EventHandler(this.mnuRegistrarAlumno_Click);
            // 
            // mnuReporte
            // 
            this.mnuReporte.Name = "mnuReporte";
            this.mnuReporte.Size = new System.Drawing.Size(209, 22);
            this.mnuReporte.Text = "Reporte";
            this.mnuReporte.Visible = false;
            this.mnuReporte.Click += new System.EventHandler(this.mnuReporte_Click);
            // 
            // mnuAyuda
            // 
            this.mnuAyuda.Name = "mnuAyuda";
            this.mnuAyuda.Size = new System.Drawing.Size(53, 20);
            this.mnuAyuda.Text = "Ayuda";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tsbsUsuarios});
            this.statusStrip.Location = new System.Drawing.Point(0, 240);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(360, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // tsbsUsuarios
            // 
            this.tsbsUsuarios.Name = "tsbsUsuarios";
            this.tsbsUsuarios.Size = new System.Drawing.Size(0, 17);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 262);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mnsPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnsPrincipal;
            this.Name = "formMain";
            this.Text = "Academia";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMain_Load);
            this.mnsPrincipal.ResumeLayout(false);
            this.mnsPrincipal.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuGestion;
        private System.Windows.Forms.ToolStripMenuItem mnuAlumnosInscripciones;
        private System.Windows.Forms.ToolStripMenuItem mnuComisiones;
        private System.Windows.Forms.ToolStripMenuItem mnuCursos;
        private System.Windows.Forms.ToolStripMenuItem mnuDocenteCurso;
        private System.Windows.Forms.ToolStripMenuItem mnuEspecialidades;
        private System.Windows.Forms.ToolStripMenuItem mnuMaterias;
        private System.Windows.Forms.ToolStripMenuItem mnuPersonas;
        private System.Windows.Forms.ToolStripMenuItem mnuPlanes;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel tsbsUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuArchivo;
        private System.Windows.Forms.ToolStripMenuItem mnuAyuda;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mnuRegistrarAlumno;
        private System.Windows.Forms.ToolStripMenuItem mnuReporte;
    }
}