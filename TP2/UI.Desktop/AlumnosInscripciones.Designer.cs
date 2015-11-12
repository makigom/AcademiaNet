namespace UI.Desktop
{
    partial class AlumnosInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlumnosInscripciones));
            this.tscAlumnosInscripciones = new System.Windows.Forms.ToolStripContainer();
            this.tlAlumnosInscripciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvAlumnoInscripciones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsAlumnosInscripciones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscAlumnosInscripciones.ContentPanel.SuspendLayout();
            this.tscAlumnosInscripciones.TopToolStripPanel.SuspendLayout();
            this.tscAlumnosInscripciones.SuspendLayout();
            this.tlAlumnosInscripciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).BeginInit();
            this.tsAlumnosInscripciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscAlumnosInscripciones
            // 
            // 
            // tscAlumnosInscripciones.ContentPanel
            // 
            this.tscAlumnosInscripciones.ContentPanel.Controls.Add(this.tlAlumnosInscripciones);
            this.tscAlumnosInscripciones.ContentPanel.Size = new System.Drawing.Size(545, 385);
            this.tscAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscAlumnosInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tscAlumnosInscripciones.Name = "tscAlumnosInscripciones";
            this.tscAlumnosInscripciones.Size = new System.Drawing.Size(545, 410);
            this.tscAlumnosInscripciones.TabIndex = 0;
            this.tscAlumnosInscripciones.Text = "toolStripContainer1";
            // 
            // tscAlumnosInscripciones.TopToolStripPanel
            // 
            this.tscAlumnosInscripciones.TopToolStripPanel.Controls.Add(this.tsAlumnosInscripciones);
            // 
            // tlAlumnosInscripciones
            // 
            this.tlAlumnosInscripciones.ColumnCount = 2;
            this.tlAlumnosInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnosInscripciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlAlumnosInscripciones.Controls.Add(this.dgvAlumnoInscripciones, 0, 0);
            this.tlAlumnosInscripciones.Controls.Add(this.btnSalir, 1, 1);
            this.tlAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlAlumnosInscripciones.Location = new System.Drawing.Point(0, 0);
            this.tlAlumnosInscripciones.Name = "tlAlumnosInscripciones";
            this.tlAlumnosInscripciones.RowCount = 2;
            this.tlAlumnosInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlAlumnosInscripciones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlAlumnosInscripciones.Size = new System.Drawing.Size(545, 385);
            this.tlAlumnosInscripciones.TabIndex = 0;
            // 
            // dgvAlumnoInscripciones
            // 
            this.dgvAlumnoInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoInscripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idAlumno,
            this.idCurso,
            this.nota,
            this.condicion});
            this.tlAlumnosInscripciones.SetColumnSpan(this.dgvAlumnoInscripciones, 2);
            this.dgvAlumnoInscripciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnoInscripciones.Location = new System.Drawing.Point(3, 3);
            this.dgvAlumnoInscripciones.MultiSelect = false;
            this.dgvAlumnoInscripciones.Name = "dgvAlumnoInscripciones";
            this.dgvAlumnoInscripciones.ReadOnly = true;
            this.dgvAlumnoInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoInscripciones.Size = new System.Drawing.Size(539, 350);
            this.dgvAlumnoInscripciones.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID ";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idAlumno
            // 
            this.idAlumno.DataPropertyName = "IDAlumno";
            this.idAlumno.HeaderText = "ID Alumno";
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "IDCurso";
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            // 
            // nota
            // 
            this.nota.DataPropertyName = "Nota";
            this.nota.HeaderText = "Nota";
            this.nota.Name = "nota";
            this.nota.ReadOnly = true;
            // 
            // condicion
            // 
            this.condicion.DataPropertyName = "Condicion";
            this.condicion.HeaderText = "Condicion";
            this.condicion.Name = "condicion";
            this.condicion.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(467, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsAlumnosInscripciones
            // 
            this.tsAlumnosInscripciones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlumnosInscripciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsAlumnosInscripciones.Location = new System.Drawing.Point(3, 0);
            this.tsAlumnosInscripciones.Name = "tsAlumnosInscripciones";
            this.tsAlumnosInscripciones.Size = new System.Drawing.Size(112, 25);
            this.tsAlumnosInscripciones.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "toolStripButton1";
            this.tsbNuevo.ToolTipText = "Nuevo";
            this.tsbNuevo.Click += new System.EventHandler(this.tsbNuevo_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(23, 22);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "toolStripButton2";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // AlumnosInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 410);
            this.Controls.Add(this.tscAlumnosInscripciones);
            this.Name = "AlumnosInscripciones";
            this.Text = "Alumnos e Inscripciones";
            this.Load += new System.EventHandler(this.AlumnoInscripciones_Load);
            this.tscAlumnosInscripciones.ContentPanel.ResumeLayout(false);
            this.tscAlumnosInscripciones.TopToolStripPanel.ResumeLayout(false);
            this.tscAlumnosInscripciones.TopToolStripPanel.PerformLayout();
            this.tscAlumnosInscripciones.ResumeLayout(false);
            this.tscAlumnosInscripciones.PerformLayout();
            this.tlAlumnosInscripciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoInscripciones)).EndInit();
            this.tsAlumnosInscripciones.ResumeLayout(false);
            this.tsAlumnosInscripciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscAlumnosInscripciones;
        private System.Windows.Forms.TableLayoutPanel tlAlumnosInscripciones;
        private System.Windows.Forms.DataGridView dgvAlumnoInscripciones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsAlumnosInscripciones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nota;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
    }
}