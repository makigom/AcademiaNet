namespace UI.Desktop
{
    partial class Comisiones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comisiones));
            this.tcComisiones = new System.Windows.Forms.ToolStripContainer();
            this.tlComisiones = new System.Windows.Forms.TableLayoutPanel();
            this.dvgComisiones = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioEspecialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tcComisiones.ContentPanel.SuspendLayout();
            this.tcComisiones.TopToolStripPanel.SuspendLayout();
            this.tcComisiones.SuspendLayout();
            this.tlComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgComisiones)).BeginInit();
            this.tsComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcComisiones
            // 
            // 
            // tcComisiones.ContentPanel
            // 
            this.tcComisiones.ContentPanel.Controls.Add(this.tlComisiones);
            this.tcComisiones.ContentPanel.Size = new System.Drawing.Size(447, 246);
            this.tcComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcComisiones.Location = new System.Drawing.Point(0, 0);
            this.tcComisiones.Name = "tcComisiones";
            this.tcComisiones.Size = new System.Drawing.Size(447, 271);
            this.tcComisiones.TabIndex = 0;
            this.tcComisiones.Text = "toolStripContainer1";
            // 
            // tcComisiones.TopToolStripPanel
            // 
            this.tcComisiones.TopToolStripPanel.Controls.Add(this.tsComisiones);
            // 
            // tlComisiones
            // 
            this.tlComisiones.ColumnCount = 2;
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlComisiones.Controls.Add(this.dvgComisiones, 0, 0);
            this.tlComisiones.Controls.Add(this.btnSalir, 1, 1);
            this.tlComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlComisiones.Location = new System.Drawing.Point(0, 0);
            this.tlComisiones.Name = "tlComisiones";
            this.tlComisiones.RowCount = 2;
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlComisiones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlComisiones.Size = new System.Drawing.Size(447, 246);
            this.tlComisiones.TabIndex = 0;
            // 
            // dvgComisiones
            // 
            this.dvgComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgComisiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idPlan,
            this.descripcion,
            this.anioEspecialidad});
            this.tlComisiones.SetColumnSpan(this.dvgComisiones, 2);
            this.dvgComisiones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgComisiones.Location = new System.Drawing.Point(3, 3);
            this.dvgComisiones.MultiSelect = false;
            this.dvgComisiones.Name = "dvgComisiones";
            this.dvgComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgComisiones.Size = new System.Drawing.Size(441, 211);
            this.dvgComisiones.TabIndex = 0;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID ";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // idPlan
            // 
            this.idPlan.DataPropertyName = "IDPlan";
            this.idPlan.HeaderText = "ID Plan";
            this.idPlan.Name = "idPlan";
            this.idPlan.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "Descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // anioEspecialidad
            // 
            this.anioEspecialidad.DataPropertyName = "AnioEspecialidad";
            this.anioEspecialidad.HeaderText = "Año Especialidad";
            this.anioEspecialidad.Name = "anioEspecialidad";
            this.anioEspecialidad.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(369, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsComisiones
            // 
            this.tsComisiones.Dock = System.Windows.Forms.DockStyle.None;
            this.tsComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsComisiones.Location = new System.Drawing.Point(3, 0);
            this.tsComisiones.Name = "tsComisiones";
            this.tsComisiones.Size = new System.Drawing.Size(111, 25);
            this.tsComisiones.TabIndex = 0;
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
            this.tsbEditar.Text = "toolStripButton2";
            this.tsbEditar.ToolTipText = "Editar";
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
            this.tsbEliminar.Text = "toolStripButton3";
            this.tsbEliminar.ToolTipText = "Eliminar";
            this.tsbEliminar.Visible = false;
            this.tsbEliminar.Click += new System.EventHandler(this.tsbEliminar_Click);
            // 
            // Comisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 271);
            this.Controls.Add(this.tcComisiones);
            this.Name = "Comisiones";
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.Comisiones_Load);
            this.tcComisiones.ContentPanel.ResumeLayout(false);
            this.tcComisiones.TopToolStripPanel.ResumeLayout(false);
            this.tcComisiones.TopToolStripPanel.PerformLayout();
            this.tcComisiones.ResumeLayout(false);
            this.tcComisiones.PerformLayout();
            this.tlComisiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgComisiones)).EndInit();
            this.tsComisiones.ResumeLayout(false);
            this.tsComisiones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tcComisiones;
        private System.Windows.Forms.TableLayoutPanel tlComisiones;
        private System.Windows.Forms.DataGridView dvgComisiones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsComisiones;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioEspecialidad;
    }
}