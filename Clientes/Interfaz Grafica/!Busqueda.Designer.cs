using Clientes.Conexion;
using System.Data.SqlClient;

namespace Clientes
{
    partial class Busqueda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Busqueda));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.txtRUC = new System.Windows.Forms.TextBox();
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvlista = new System.Windows.Forms.DataGridView();
            this.dataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDALBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDComunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteDALBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDALBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDComunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDALBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rázon Social:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "RUC:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(124, 68);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(154, 23);
            this.txtRazonSocial.TabIndex = 4;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // txtRUC
            // 
            this.txtRUC.Location = new System.Drawing.Point(124, 118);
            this.txtRUC.Name = "txtRUC";
            this.txtRUC.Size = new System.Drawing.Size(154, 23);
            this.txtRUC.TabIndex = 5;
            this.txtRUC.TextChanged += new System.EventHandler(this.txtRUC_TextChanged);
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnbusqueda.Location = new System.Drawing.Point(192, 163);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(86, 29);
            this.btnbusqueda.TabIndex = 7;
            this.btnbusqueda.Text = "Consultar";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.Location = new System.Drawing.Point(16, 222);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(86, 29);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(124, 222);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvlista
            // 
            this.dgvlista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlista.Location = new System.Drawing.Point(300, 58);
            this.dgvlista.Name = "dgvlista";
            this.dgvlista.ReadOnly = true;
            this.dgvlista.RowTemplate.Height = 25;
            this.dgvlista.Size = new System.Drawing.Size(460, 190);
            this.dgvlista.TabIndex = 10;
            this.dgvlista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataSetBindingSource
            // 
            this.dataSetBindingSource.DataSource = typeof(System.Data.DataSet);
            this.dataSetBindingSource.Position = 0;
            // 
            // Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(784, 261);
            this.Controls.Add(this.dgvlista);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnbusqueda);
            this.Controls.Add(this.txtRUC);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 300);
            this.MinimumSize = new System.Drawing.Size(800, 300);
            this.Name = "Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Clientes";
            this.Load += new System.EventHandler(this.Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDALBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDComunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteDALBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRazonSocial;
        private TextBox txtRUC;
        private TextBox txttelefono;
        private Button btnbusqueda;
        private Button btnAceptar;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridView dgvlista;
        private DataGridViewTextBoxColumn Column1;
        private BindingSource bDComunBindingSource;
        private BindingSource clienteDALBindingSource;
        private BindingSource clienteDALBindingSource1;
        private BindingSource dataSetBindingSource;
    }
}