
namespace Minomina.WindowsUser
{
    partial class Nomina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelUp = new System.Windows.Forms.Panel();
            this.dataGridEmpleado = new System.Windows.Forms.DataGridView();
            this.dataGridNovedad = new System.Windows.Forms.DataGridView();
            this.RegistroDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbGridNovedad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Desc_Novedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoNovedad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECIDAsigHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTotalPagar = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btAprobar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btCierre = new System.Windows.Forms.Button();
            this.btRestaurar = new System.Windows.Forms.Button();
            this.btMinimizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNovedad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.panelUp.Controls.Add(this.btCierre);
            this.panelUp.Controls.Add(this.btRestaurar);
            this.panelUp.Controls.Add(this.btMinimizar);
            this.panelUp.Controls.Add(this.button1);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1230, 50);
            this.panelUp.TabIndex = 98;
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUp_MouseDown);
            // 
            // dataGridEmpleado
            // 
            this.dataGridEmpleado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridEmpleado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridEmpleado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dataGridEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmpleado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridEmpleado.ColumnHeadersHeight = 25;
            this.dataGridEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridEmpleado.EnableHeadersVisualStyles = false;
            this.dataGridEmpleado.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.dataGridEmpleado.Location = new System.Drawing.Point(606, 232);
            this.dataGridEmpleado.MultiSelect = false;
            this.dataGridEmpleado.Name = "dataGridEmpleado";
            this.dataGridEmpleado.ReadOnly = true;
            this.dataGridEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmpleado.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridEmpleado.RowHeadersVisible = false;
            this.dataGridEmpleado.RowHeadersWidth = 35;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            this.dataGridEmpleado.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridEmpleado.RowTemplate.Height = 24;
            this.dataGridEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmpleado.Size = new System.Drawing.Size(565, 276);
            this.dataGridEmpleado.TabIndex = 106;
            // 
            // dataGridNovedad
            // 
            this.dataGridNovedad.AllowUserToAddRows = false;
            this.dataGridNovedad.AllowUserToDeleteRows = false;
            this.dataGridNovedad.AllowUserToOrderColumns = true;
            this.dataGridNovedad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridNovedad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridNovedad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridNovedad.BackgroundColor = System.Drawing.Color.White;
            this.dataGridNovedad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridNovedad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNovedad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridNovedad.ColumnHeadersHeight = 25;
            this.dataGridNovedad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridNovedad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegistroDetalle,
            this.cbGridNovedad,
            this.Desc_Novedad,
            this.monto,
            this.Desde,
            this.hasta,
            this.TipoNovedad,
            this.RECIDAsigHeader,
            this.Recid});
            this.dataGridNovedad.EnableHeadersVisualStyles = false;
            this.dataGridNovedad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.dataGridNovedad.Location = new System.Drawing.Point(40, 514);
            this.dataGridNovedad.MultiSelect = false;
            this.dataGridNovedad.Name = "dataGridNovedad";
            this.dataGridNovedad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNovedad.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridNovedad.RowHeadersVisible = false;
            this.dataGridNovedad.RowHeadersWidth = 35;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            this.dataGridNovedad.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridNovedad.RowTemplate.Height = 24;
            this.dataGridNovedad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridNovedad.Size = new System.Drawing.Size(1131, 222);
            this.dataGridNovedad.TabIndex = 105;
            // 
            // RegistroDetalle
            // 
            this.RegistroDetalle.HeaderText = "Registro";
            this.RegistroDetalle.MinimumWidth = 6;
            this.RegistroDetalle.Name = "RegistroDetalle";
            // 
            // cbGridNovedad
            // 
            this.cbGridNovedad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cbGridNovedad.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.cbGridNovedad.HeaderText = "Codigo Novedad";
            this.cbGridNovedad.MinimumWidth = 6;
            this.cbGridNovedad.Name = "cbGridNovedad";
            this.cbGridNovedad.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbGridNovedad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Desc_Novedad
            // 
            this.Desc_Novedad.HeaderText = "Descripcion Novedad";
            this.Desc_Novedad.MinimumWidth = 6;
            this.Desc_Novedad.Name = "Desc_Novedad";
            // 
            // monto
            // 
            this.monto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.monto.HeaderText = "Monto";
            this.monto.MinimumWidth = 6;
            this.monto.Name = "monto";
            // 
            // Desde
            // 
            this.Desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desde.HeaderText = "Desde";
            this.Desde.MinimumWidth = 6;
            this.Desde.Name = "Desde";
            // 
            // hasta
            // 
            this.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.hasta.HeaderText = "Hasta";
            this.hasta.MinimumWidth = 6;
            this.hasta.Name = "hasta";
            // 
            // TipoNovedad
            // 
            this.TipoNovedad.HeaderText = "Tipo De Novedad";
            this.TipoNovedad.MinimumWidth = 6;
            this.TipoNovedad.Name = "TipoNovedad";
            // 
            // RECIDAsigHeader
            // 
            this.RECIDAsigHeader.HeaderText = "Recid Header";
            this.RECIDAsigHeader.MinimumWidth = 6;
            this.RECIDAsigHeader.Name = "RECIDAsigHeader";
            this.RECIDAsigHeader.Visible = false;
            // 
            // Recid
            // 
            this.Recid.HeaderText = "Recid";
            this.Recid.MinimumWidth = 6;
            this.Recid.Name = "Recid";
            this.Recid.Visible = false;
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbObservaciones.Location = new System.Drawing.Point(44, 223);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(308, 157);
            this.tbObservaciones.TabIndex = 107;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.label13.Location = new System.Drawing.Point(49, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 20);
            this.label13.TabIndex = 108;
            this.label13.Text = "Fecha a Calcular";
            // 
            // dtFechaDesde
            // 
            this.dtFechaDesde.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDesde.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtFechaDesde.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.dtFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDesde.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtFechaDesde.Location = new System.Drawing.Point(57, 463);
            this.dtFechaDesde.MaximumSize = new System.Drawing.Size(120, 120);
            this.dtFechaDesde.Name = "dtFechaDesde";
            this.dtFechaDesde.Size = new System.Drawing.Size(120, 22);
            this.dtFechaDesde.TabIndex = 109;
            // 
            // dtFechaHasta
            // 
            this.dtFechaHasta.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaHasta.CalendarForeColor = System.Drawing.Color.Blue;
            this.dtFechaHasta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(131)))), ((int)(((byte)(163)))));
            this.dtFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaHasta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtFechaHasta.Location = new System.Drawing.Point(199, 463);
            this.dtFechaHasta.MaximumSize = new System.Drawing.Size(120, 120);
            this.dtFechaHasta.Name = "dtFechaHasta";
            this.dtFechaHasta.Size = new System.Drawing.Size(120, 22);
            this.dtFechaHasta.TabIndex = 110;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 112;
            this.label7.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 113;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(348, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 114;
            this.label2.Text = "Total a Pagar";
            // 
            // tbTotalPagar
            // 
            this.tbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.tbTotalPagar.Location = new System.Drawing.Point(355, 463);
            this.tbTotalPagar.Name = "tbTotalPagar";
            this.tbTotalPagar.Size = new System.Drawing.Size(228, 24);
            this.tbTotalPagar.TabIndex = 115;
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.btGuardar.Location = new System.Drawing.Point(40, 166);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(171, 51);
            this.btGuardar.TabIndex = 116;
            this.btGuardar.Text = "Calcular";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.BackgroundImage = global::Minomina.Properties.Resources.No_aprobado;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(716, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 39);
            this.button3.TabIndex = 118;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btAprobar
            // 
            this.btAprobar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAprobar.BackgroundImage = global::Minomina.Properties.Resources.Aprobar;
            this.btAprobar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAprobar.Location = new System.Drawing.Point(606, 147);
            this.btAprobar.Name = "btAprobar";
            this.btAprobar.Size = new System.Drawing.Size(91, 38);
            this.btAprobar.TabIndex = 117;
            this.btAprobar.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Minomina.Properties.Resources.Calculos_Nomina;
            this.pictureBox1.Location = new System.Drawing.Point(393, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // btCierre
            // 
            this.btCierre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCierre.BackgroundImage = global::Minomina.Properties.Resources.Cierre;
            this.btCierre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCierre.FlatAppearance.BorderSize = 0;
            this.btCierre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCierre.Location = new System.Drawing.Point(1186, 7);
            this.btCierre.Margin = new System.Windows.Forms.Padding(0);
            this.btCierre.Name = "btCierre";
            this.btCierre.Size = new System.Drawing.Size(35, 33);
            this.btCierre.TabIndex = 0;
            this.btCierre.UseVisualStyleBackColor = true;
            this.btCierre.Click += new System.EventHandler(this.btCierre_Click);
            // 
            // btRestaurar
            // 
            this.btRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btRestaurar.BackgroundImage = global::Minomina.Properties.Resources.RestoreDown;
            this.btRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btRestaurar.FlatAppearance.BorderSize = 0;
            this.btRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRestaurar.Location = new System.Drawing.Point(1152, 7);
            this.btRestaurar.Margin = new System.Windows.Forms.Padding(0);
            this.btRestaurar.Name = "btRestaurar";
            this.btRestaurar.Size = new System.Drawing.Size(35, 33);
            this.btRestaurar.TabIndex = 1;
            this.btRestaurar.UseVisualStyleBackColor = true;
            this.btRestaurar.Click += new System.EventHandler(this.btRestaurar_Click);
            // 
            // btMinimizar
            // 
            this.btMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btMinimizar.BackgroundImage = global::Minomina.Properties.Resources.Minimizar;
            this.btMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btMinimizar.FlatAppearance.BorderSize = 0;
            this.btMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimizar.Location = new System.Drawing.Point(1114, 12);
            this.btMinimizar.Name = "btMinimizar";
            this.btMinimizar.Size = new System.Drawing.Size(35, 28);
            this.btMinimizar.TabIndex = 3;
            this.btMinimizar.UseVisualStyleBackColor = true;
            this.btMinimizar.Click += new System.EventHandler(this.btMinimizar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = global::Minomina.Properties.Resources.Mini;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1151, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(163)))));
            this.label3.Location = new System.Drawing.Point(602, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 119;
            this.label3.Text = "Detalle Del Pago Por Novedad";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(54)))), ((int)(((byte)(68)))));
            this.tbNombre.Location = new System.Drawing.Point(894, 152);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(183, 26);
            this.tbNombre.TabIndex = 120;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(891, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 121;
            this.label4.Text = "Aprobado Por";
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1230, 790);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btAprobar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbTotalPagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtFechaHasta);
            this.Controls.Add(this.dtFechaDesde);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.dataGridEmpleado);
            this.Controls.Add(this.dataGridNovedad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nomina";
            this.Text = "Nomina";
            this.panelUp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNovedad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCierre;
        private System.Windows.Forms.Button btRestaurar;
        private System.Windows.Forms.Button btMinimizar;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridEmpleado;
        private System.Windows.Forms.DataGridView dataGridNovedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroDetalle;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbGridNovedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc_Novedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoNovedad;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECIDAsigHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recid;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFechaDesde;
        private System.Windows.Forms.DateTimePicker dtFechaHasta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTotalPagar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btAprobar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label4;
    }
}