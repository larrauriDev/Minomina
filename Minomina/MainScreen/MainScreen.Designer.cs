namespace Minomina
{
    partial class MainScreen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btMaximizar = new System.Windows.Forms.Button();
            this.btNormal = new System.Windows.Forms.Button();
            this.CerrarApp = new System.Windows.Forms.Button();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAdministracion = new System.Windows.Forms.Button();
            this.btNomina = new System.Windows.Forms.Button();
            this.btGestionHumana = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btMaximizar);
            this.panel1.Controls.Add(this.btNormal);
            this.panel1.Controls.Add(this.CerrarApp);
            this.panel1.Controls.Add(this.btMinimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 42);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btMaximizar
            // 
            this.btMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMaximizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.btMaximizar.BackgroundImage = global::Minomina.Properties.Resources.RestoreDown;
            this.btMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMaximizar.FlatAppearance.BorderSize = 0;
            this.btMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMaximizar.Location = new System.Drawing.Point(1160, 9);
            this.btMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.btMaximizar.Name = "btMaximizar";
            this.btMaximizar.Size = new System.Drawing.Size(35, 33);
            this.btMaximizar.TabIndex = 5;
            this.btMaximizar.UseVisualStyleBackColor = false;
            this.btMaximizar.Click += new System.EventHandler(this.btMaximizar_Click);
            // 
            // btNormal
            // 
            this.btNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btNormal.BackgroundImage = global::Minomina.Properties.Resources.Mini;
            this.btNormal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btNormal.FlatAppearance.BorderSize = 0;
            this.btNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNormal.Location = new System.Drawing.Point(1160, 9);
            this.btNormal.Margin = new System.Windows.Forms.Padding(0);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(35, 33);
            this.btNormal.TabIndex = 3;
            this.btNormal.UseVisualStyleBackColor = true;
            this.btNormal.Click += new System.EventHandler(this.btNormal_Click);
            // 
            // CerrarApp
            // 
            this.CerrarApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarApp.BackgroundImage = global::Minomina.Properties.Resources.Cierre;
            this.CerrarApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerrarApp.FlatAppearance.BorderSize = 0;
            this.CerrarApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CerrarApp.Location = new System.Drawing.Point(1195, 6);
            this.CerrarApp.Margin = new System.Windows.Forms.Padding(0);
            this.CerrarApp.Name = "CerrarApp";
            this.CerrarApp.Size = new System.Drawing.Size(35, 33);
            this.CerrarApp.TabIndex = 4;
            this.CerrarApp.UseVisualStyleBackColor = true;
            this.CerrarApp.Click += new System.EventHandler(this.CerrarApp_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = global::Minomina.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(1122, 11);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(35, 28);
            this.btMinimizar.TabIndex = 6;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.btAdministracion);
            this.panel2.Controls.Add(this.btNomina);
            this.panel2.Controls.Add(this.btGestionHumana);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 713);
            this.panel2.TabIndex = 1;
            // 
            // btAdministracion
            // 
            this.btAdministracion.FlatAppearance.BorderSize = 0;
            this.btAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdministracion.ForeColor = System.Drawing.Color.White;
            this.btAdministracion.Image = global::Minomina.Properties.Resources.iconoAdminColor;
            this.btAdministracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdministracion.Location = new System.Drawing.Point(0, 491);
            this.btAdministracion.Name = "btAdministracion";
            this.btAdministracion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btAdministracion.Size = new System.Drawing.Size(299, 49);
            this.btAdministracion.TabIndex = 4;
            this.btAdministracion.Text = "        Administracion";
            this.btAdministracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btAdministracion.UseVisualStyleBackColor = true;
            this.btAdministracion.Click += new System.EventHandler(this.btAdministracion_Click);
            // 
            // btNomina
            // 
            this.btNomina.FlatAppearance.BorderSize = 0;
            this.btNomina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNomina.ForeColor = System.Drawing.Color.White;
            this.btNomina.Image = global::Minomina.Properties.Resources.IconoNomina;
            this.btNomina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNomina.Location = new System.Drawing.Point(0, 397);
            this.btNomina.Name = "btNomina";
            this.btNomina.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btNomina.Size = new System.Drawing.Size(302, 49);
            this.btNomina.TabIndex = 2;
            this.btNomina.Text = "        Nomina";
            this.btNomina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btNomina.UseVisualStyleBackColor = true;
            this.btNomina.Click += new System.EventHandler(this.btNomina_Click);
            // 
            // btGestionHumana
            // 
            this.btGestionHumana.FlatAppearance.BorderSize = 0;
            this.btGestionHumana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGestionHumana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGestionHumana.ForeColor = System.Drawing.Color.White;
            this.btGestionHumana.Image = global::Minomina.Properties.Resources.IconoGestionHumana;
            this.btGestionHumana.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestionHumana.Location = new System.Drawing.Point(0, 313);
            this.btGestionHumana.Name = "btGestionHumana";
            this.btGestionHumana.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.btGestionHumana.Size = new System.Drawing.Size(302, 49);
            this.btGestionHumana.TabIndex = 1;
            this.btGestionHumana.Text = "       Gestion Humana";
            this.btGestionHumana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btGestionHumana.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.pictureBox1.Image = global::Minomina.Properties.Resources.Logo03;
            this.pictureBox1.Location = new System.Drawing.Point(25, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Minomina.Properties.Resources.FondosPresentacion03;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1235, 755);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainScreen";
            this.Text = "QMProducts1";
            this.SizeChanged += new System.EventHandler(this.MenuGestionHumana_AutoSizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CerrarApp;
        private System.Windows.Forms.Button btMaximizar;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Button btNormal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btAdministracion;
        private System.Windows.Forms.Button btNomina;
        private System.Windows.Forms.Button btGestionHumana;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}