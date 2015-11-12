namespace UI.Desktop
{
    partial class Personas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Personas));
            this.tscPersona = new System.Windows.Forms.ToolStripContainer();
            this.tlPersona = new System.Windows.Forms.TableLayoutPanel();
            this.dgvPersona = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsPersona = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbEliminar = new System.Windows.Forms.ToolStripButton();
            this.tscPersona.ContentPanel.SuspendLayout();
            this.tscPersona.TopToolStripPanel.SuspendLayout();
            this.tscPersona.SuspendLayout();
            this.tlPersona.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).BeginInit();
            this.tsPersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscPersona
            // 
            // 
            // tscPersona.ContentPanel
            // 
            this.tscPersona.ContentPanel.Controls.Add(this.tlPersona);
            this.tscPersona.ContentPanel.Size = new System.Drawing.Size(701, 391);
            this.tscPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscPersona.Location = new System.Drawing.Point(0, 0);
            this.tscPersona.Name = "tscPersona";
            this.tscPersona.Size = new System.Drawing.Size(701, 416);
            this.tscPersona.TabIndex = 0;
            this.tscPersona.Text = "toolStripContainer1";
            // 
            // tscPersona.TopToolStripPanel
            // 
            this.tscPersona.TopToolStripPanel.Controls.Add(this.tsPersona);
            // 
            // tlPersona
            // 
            this.tlPersona.ColumnCount = 2;
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersona.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlPersona.Controls.Add(this.dgvPersona, 0, 0);
            this.tlPersona.Controls.Add(this.btnSalir, 1, 1);
            this.tlPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlPersona.Location = new System.Drawing.Point(0, 0);
            this.tlPersona.Name = "tlPersona";
            this.tlPersona.RowCount = 2;
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlPersona.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlPersona.Size = new System.Drawing.Size(701, 391);
            this.tlPersona.TabIndex = 0;
            // 
            // dgvPersona
            // 
            this.dgvPersona.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersona.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersona.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.apellido,
            this.nombre,
            this.direccion,
            this.email,
            this.telefono,
            this.fechNac,
            this.legajo,
            this.IDPlan,
            this.tipoPersona});
            this.tlPersona.SetColumnSpan(this.dgvPersona, 2);
            this.dgvPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPersona.Location = new System.Drawing.Point(3, 3);
            this.dgvPersona.Name = "dgvPersona";
            this.dgvPersona.Size = new System.Drawing.Size(695, 356);
            this.dgvPersona.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID ";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // apellido
            // 
            this.apellido.DataPropertyName = "Apellido";
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            this.apellido.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "Nombre";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "Direccion";
            this.direccion.HeaderText = "Dirección";
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            // 
            // email
            // 
            this.email.DataPropertyName = "Email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "Telefono";
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechNac
            // 
            this.fechNac.DataPropertyName = "FechaNacimiento";
            this.fechNac.HeaderText = "Fecha de nacimiento";
            this.fechNac.Name = "fechNac";
            this.fechNac.ReadOnly = true;
            // 
            // legajo
            // 
            this.legajo.DataPropertyName = "Legajo";
            this.legajo.HeaderText = "Legajo";
            this.legajo.Name = "legajo";
            this.legajo.ReadOnly = true;
            // 
            // IDPlan
            // 
            this.IDPlan.DataPropertyName = "IDPlan";
            this.IDPlan.HeaderText = "ID Plan";
            this.IDPlan.Name = "IDPlan";
            this.IDPlan.ReadOnly = true;
            // 
            // tipoPersona
            // 
            this.tipoPersona.DataPropertyName = "TipoPersona";
            this.tipoPersona.HeaderText = "Tipo Persona";
            this.tipoPersona.Name = "tipoPersona";
            this.tipoPersona.ReadOnly = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(623, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsPersona
            // 
            this.tsPersona.Dock = System.Windows.Forms.DockStyle.None;
            this.tsPersona.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbEditar,
            this.tsbEliminar});
            this.tsPersona.Location = new System.Drawing.Point(3, 0);
            this.tsPersona.Name = "tsPersona";
            this.tsPersona.Size = new System.Drawing.Size(112, 25);
            this.tsPersona.TabIndex = 0;
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
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 416);
            this.Controls.Add(this.tscPersona);
            this.Name = "Personas";
            this.Text = "Persona";
            this.Load += new System.EventHandler(this.Personas_Load);
            this.tscPersona.ContentPanel.ResumeLayout(false);
            this.tscPersona.TopToolStripPanel.ResumeLayout(false);
            this.tscPersona.TopToolStripPanel.PerformLayout();
            this.tscPersona.ResumeLayout(false);
            this.tscPersona.PerformLayout();
            this.tlPersona.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersona)).EndInit();
            this.tsPersona.ResumeLayout(false);
            this.tsPersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscPersona;
        private System.Windows.Forms.TableLayoutPanel tlPersona;
        private System.Windows.Forms.DataGridView dgvPersona;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStrip tsPersona;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoPersona;
    }
}