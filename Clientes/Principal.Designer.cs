namespace Clientes
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.crearNuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Example = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fotoCrear = new System.Windows.Forms.PictureBox();
            this.fotoConsultar = new System.Windows.Forms.PictureBox();
            this.fotoUsuario = new System.Windows.Forms.PictureBox();
            this.fotoExit = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoConsultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Clientes.Properties.Resources.efi_preview_rev_1;
            this.pictureBox1.Location = new System.Drawing.Point(716, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(980, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArchivo
            // 
            this.menuArchivo.BackColor = System.Drawing.Color.Transparent;
            this.menuArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearNuevoClienteToolStripMenuItem,
            this.consultarClientesToolStripMenuItem,
            this.registrarNuevoUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuArchivo.Name = "menuArchivo";
            this.menuArchivo.Size = new System.Drawing.Size(60, 20);
            this.menuArchivo.Text = "Archivo";
            // 
            // crearNuevoClienteToolStripMenuItem
            // 
            this.crearNuevoClienteToolStripMenuItem.Name = "crearNuevoClienteToolStripMenuItem";
            this.crearNuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.crearNuevoClienteToolStripMenuItem.Text = "Crear nuevo Cliente / Modificar";
            this.crearNuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.crearNuevoClienteToolStripMenuItem_Click);
            // 
            // consultarClientesToolStripMenuItem
            // 
            this.consultarClientesToolStripMenuItem.Name = "consultarClientesToolStripMenuItem";
            this.consultarClientesToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.consultarClientesToolStripMenuItem.Text = "Consultar Clientes";
            this.consultarClientesToolStripMenuItem.Click += new System.EventHandler(this.consultarClientesToolStripMenuItem_Click);
            // 
            // registrarNuevoUsuarioToolStripMenuItem
            // 
            this.registrarNuevoUsuarioToolStripMenuItem.Name = "registrarNuevoUsuarioToolStripMenuItem";
            this.registrarNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.registrarNuevoUsuarioToolStripMenuItem.Text = "Registrar nuevo Usuario";
            this.registrarNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.registrarNuevoUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(240, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Example
            // 
            this.Example.AutoSize = true;
            this.Example.BackColor = System.Drawing.Color.Silver;
            this.Example.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Example.Location = new System.Drawing.Point(175, 144);
            this.Example.Name = "Example";
            this.Example.Size = new System.Drawing.Size(455, 40);
            this.Example.TabIndex = 2;
            this.Example.Text = "Crear Nuevo Cliente / Modificar";
            this.Example.Click += new System.EventHandler(this.Example_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(175, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Consultar Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(175, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Crear nuevo usuario para inicio de sesión";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(175, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 40);
            this.label3.TabIndex = 5;
            this.label3.Text = "Salir del programa";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fotoCrear
            // 
            this.fotoCrear.BackColor = System.Drawing.Color.Transparent;
            this.fotoCrear.Image = ((System.Drawing.Image)(resources.GetObject("fotoCrear.Image")));
            this.fotoCrear.Location = new System.Drawing.Point(37, 103);
            this.fotoCrear.Name = "fotoCrear";
            this.fotoCrear.Size = new System.Drawing.Size(80, 80);
            this.fotoCrear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoCrear.TabIndex = 6;
            this.fotoCrear.TabStop = false;
            this.fotoCrear.Click += new System.EventHandler(this.fotoCrear_Click);
            // 
            // fotoConsultar
            // 
            this.fotoConsultar.BackColor = System.Drawing.Color.Transparent;
            this.fotoConsultar.Image = ((System.Drawing.Image)(resources.GetObject("fotoConsultar.Image")));
            this.fotoConsultar.Location = new System.Drawing.Point(37, 213);
            this.fotoConsultar.Name = "fotoConsultar";
            this.fotoConsultar.Size = new System.Drawing.Size(80, 80);
            this.fotoConsultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoConsultar.TabIndex = 7;
            this.fotoConsultar.TabStop = false;
            this.fotoConsultar.Click += new System.EventHandler(this.fotoConsultar_Click);
            // 
            // fotoUsuario
            // 
            this.fotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.fotoUsuario.Image = ((System.Drawing.Image)(resources.GetObject("fotoUsuario.Image")));
            this.fotoUsuario.Location = new System.Drawing.Point(37, 313);
            this.fotoUsuario.Name = "fotoUsuario";
            this.fotoUsuario.Size = new System.Drawing.Size(80, 80);
            this.fotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoUsuario.TabIndex = 8;
            this.fotoUsuario.TabStop = false;
            this.fotoUsuario.Click += new System.EventHandler(this.fotoUsuario_Click);
            // 
            // fotoExit
            // 
            this.fotoExit.BackColor = System.Drawing.Color.Transparent;
            this.fotoExit.Image = ((System.Drawing.Image)(resources.GetObject("fotoExit.Image")));
            this.fotoExit.Location = new System.Drawing.Point(27, 410);
            this.fotoExit.Name = "fotoExit";
            this.fotoExit.Size = new System.Drawing.Size(90, 83);
            this.fotoExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoExit.TabIndex = 9;
            this.fotoExit.TabStop = false;
            this.fotoExit.Click += new System.EventHandler(this.fotoExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(513, 590);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(455, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Todo el codigo de este programa es modificable, para mas informacion escanea el Q" +
    "r";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(868, 487);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Clientes.Properties.Resources.Principal2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(980, 607);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fotoExit);
            this.Controls.Add(this.fotoUsuario);
            this.Controls.Add(this.fotoConsultar);
            this.Controls.Add(this.fotoCrear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Example);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 650);
            this.MinimumSize = new System.Drawing.Size(1000, 650);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EfiData - Menú Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoConsultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuArchivo;
        private ToolStripMenuItem crearNuevoClienteToolStripMenuItem;
        private ToolStripMenuItem consultarClientesToolStripMenuItem;
        private ToolStripMenuItem registrarNuevoUsuarioToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private Label Example;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox fotoCrear;
        private PictureBox fotoConsultar;
        private PictureBox fotoUsuario;
        private PictureBox fotoExit;
        private Label label4;
        private PictureBox pictureBox2;
    }
}