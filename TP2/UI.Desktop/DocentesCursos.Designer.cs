namespace UI.Desktop
{
    partial class DocentesCursos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocentesCursos));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tlDocenteCurso = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDocenteCurso = new System.Windows.Forms.DataGridView();
            this.idDictado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsDocenteCurso = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlDocenteCurso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).BeginInit();
            this.tsDocenteCurso.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlDocenteCurso);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(450, 359);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(450, 384);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsDocenteCurso);
            // 
            // tlDocenteCurso
            // 
            this.tlDocenteCurso.ColumnCount = 2;
            this.tlDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocenteCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlDocenteCurso.Controls.Add(this.dgvDocenteCurso, 0, 0);
            this.tlDocenteCurso.Controls.Add(this.btnSalir, 1, 1);
            this.tlDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDocenteCurso.Location = new System.Drawing.Point(0, 0);
            this.tlDocenteCurso.Name = "tlDocenteCurso";
            this.tlDocenteCurso.RowCount = 2;
            this.tlDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlDocenteCurso.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlDocenteCurso.Size = new System.Drawing.Size(450, 359);
            this.tlDocenteCurso.TabIndex = 0;
            // 
            // dgvDocenteCurso
            // 
            this.dgvDocenteCurso.AllowUserToAddRows = false;
            this.dgvDocenteCurso.AllowUserToDeleteRows = false;
            this.dgvDocenteCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocenteCurso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDictado,
            this.idCurso,
            this.idDocente,
            this.tipoCargo});
            this.tlDocenteCurso.SetColumnSpan(this.dgvDocenteCurso, 2);
            this.dgvDocenteCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDocenteCurso.Location = new System.Drawing.Point(3, 3);
            this.dgvDocenteCurso.Name = "dgvDocenteCurso";
            this.dgvDocenteCurso.ReadOnly = true;
            this.dgvDocenteCurso.Size = new System.Drawing.Size(444, 324);
            this.dgvDocenteCurso.TabIndex = 0;
            // 
            // idDictado
            // 
            this.idDictado.DataPropertyName = "ID";
            this.idDictado.HeaderText = "ID Dictado";
            this.idDictado.Name = "idDictado";
            this.idDictado.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.DataPropertyName = "IDCurso";
            this.idCurso.HeaderText = "ID Curso";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            // 
            // idDocente
            // 
            this.idDocente.DataPropertyName = "IDDocente";
            this.idDocente.HeaderText = "ID Docente";
            this.idDocente.Name = "idDocente";
            this.idDocente.ReadOnly = true;
            // 
            // tipoCargo
            // 
            this.tipoCargo.DataPropertyName = "TipoCargo";
            this.tipoCargo.HeaderText = "Tipo Cargo";
            this.tipoCargo.Name = "tipoCargo";
            this.tipoCargo.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(372, 333);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsDocenteCurso
            // 
            this.tsDocenteCurso.Dock = System.Windows.Forms.DockStyle.None;
            this.tsDocenteCurso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsDocenteCurso.Location = new System.Drawing.Point(3, 0);
            this.tsDocenteCurso.Name = "tsDocenteCurso";
            this.tsDocenteCurso.Size = new System.Drawing.Size(112, 25);
            this.tsDocenteCurso.TabIndex = 0;
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(23, 22);
            this.tsbNuevo.Text = "Nuevo";
            this.tsbNuevo.Visible = false;
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
            this.tsbEditar.Visible = false;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbEliminar
            // 
            this.tsbEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEliminar.Image")));
            this.tsbEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEliminar.Name = "tsbEliminar";
            this.tsbEliminar.Size = new System.Drawing.Size(23, 22);
            this.tsbEliminar.Text = "Eliminar";
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // DocentesCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 384);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "DocentesCursos";
            this.Text = "DocenteCurso";
            this.Load += new System.EventHandler(this.DocenteCurso_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlDocenteCurso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocenteCurso)).EndInit();
            this.tsDocenteCurso.ResumeLayout(false);
            this.tsDocenteCurso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlDocenteCurso;
        private System.Windows.Forms.DataGridView dgvDocenteCurso;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsDocenteCurso;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDictado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCargo;

    }
}