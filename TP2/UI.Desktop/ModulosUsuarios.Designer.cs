namespace UI.Desktop
{
    partial class ModulosUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModulosUsuarios));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tlModuloUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvModuloUsuario = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsModuloUsuario = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDModulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.modificacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.consulta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tlModuloUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuloUsuario)).BeginInit();
            this.tsModuloUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tlModuloUsuario);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(630, 321);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(630, 346);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.tsModuloUsuario);
            // 
            // tlModuloUsuario
            // 
            this.tlModuloUsuario.ColumnCount = 2;
            this.tlModuloUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModuloUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlModuloUsuario.Controls.Add(this.dgvModuloUsuario, 0, 0);
            this.tlModuloUsuario.Controls.Add(this.btnSalir, 1, 1);
            this.tlModuloUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlModuloUsuario.Location = new System.Drawing.Point(0, 0);
            this.tlModuloUsuario.Name = "tlModuloUsuario";
            this.tlModuloUsuario.RowCount = 2;
            this.tlModuloUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlModuloUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlModuloUsuario.Size = new System.Drawing.Size(630, 321);
            this.tlModuloUsuario.TabIndex = 0;
            // 
            // dgvModuloUsuario
            // 
            this.dgvModuloUsuario.AllowUserToAddRows = false;
            this.dgvModuloUsuario.AllowUserToDeleteRows = false;
            this.dgvModuloUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModuloUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDModulo,
            this.IDUsuario,
            this.alta,
            this.baja,
            this.modificacion,
            this.consulta});
            this.tlModuloUsuario.SetColumnSpan(this.dgvModuloUsuario, 2);
            this.dgvModuloUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModuloUsuario.Location = new System.Drawing.Point(3, 3);
            this.dgvModuloUsuario.Name = "dgvModuloUsuario";
            this.dgvModuloUsuario.ReadOnly = true;
            this.dgvModuloUsuario.Size = new System.Drawing.Size(624, 286);
            this.dgvModuloUsuario.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(552, 295);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsModuloUsuario
            // 
            this.tsModuloUsuario.Dock = System.Windows.Forms.DockStyle.None;
            this.tsModuloUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsModuloUsuario.Location = new System.Drawing.Point(3, 0);
            this.tsModuloUsuario.Name = "tsModuloUsuario";
            this.tsModuloUsuario.Size = new System.Drawing.Size(111, 25);
            this.tsModuloUsuario.TabIndex = 0;
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // IDModulo
            // 
            this.IDModulo.DataPropertyName = "IDModulo";
            this.IDModulo.HeaderText = "ID Modulo";
            this.IDModulo.Name = "IDModulo";
            this.IDModulo.ReadOnly = true;
            // 
            // IDUsuario
            // 
            this.IDUsuario.DataPropertyName = "IDUsuario";
            this.IDUsuario.HeaderText = "ID Usuario";
            this.IDUsuario.Name = "IDUsuario";
            this.IDUsuario.ReadOnly = true;
            // 
            // alta
            // 
            this.alta.DataPropertyName = "PermiteAlta";
            this.alta.HeaderText = "Permite Alta";
            this.alta.Name = "alta";
            this.alta.ReadOnly = true;
            this.alta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.alta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // baja
            // 
            this.baja.DataPropertyName = "PermiteBaja";
            this.baja.HeaderText = "Permite Baja";
            this.baja.Name = "baja";
            this.baja.ReadOnly = true;
            this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.baja.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // modificacion
            // 
            this.modificacion.DataPropertyName = "PermiteModificacion";
            this.modificacion.HeaderText = "Permite Modificacion";
            this.modificacion.Name = "modificacion";
            this.modificacion.ReadOnly = true;
            this.modificacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.modificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // consulta
            // 
            this.consulta.DataPropertyName = "PermiteConsulta";
            this.consulta.HeaderText = "Permite Consulta";
            this.consulta.Name = "consulta";
            this.consulta.ReadOnly = true;
            this.consulta.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.consulta.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ModulosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 346);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ModulosUsuarios";
            this.Text = "ModuloUsuario";
            this.Load += new System.EventHandler(this.ModuloUsuario_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tlModuloUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModuloUsuario)).EndInit();
            this.tsModuloUsuario.ResumeLayout(false);
            this.tsModuloUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tlModuloUsuario;
        private System.Windows.Forms.DataGridView dgvModuloUsuario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsModuloUsuario;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDModulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDUsuario;
        private System.Windows.Forms.DataGridViewCheckBoxColumn alta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn modificacion;
        private System.Windows.Forms.DataGridViewCheckBoxColumn consulta;
    }
}