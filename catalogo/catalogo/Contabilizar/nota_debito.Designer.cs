namespace catalogo
{
    partial class nota_debito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nota_debito));
            this.tbnota_debito = new System.Windows.Forms.TextBox();
            this.griddiario = new System.Windows.Forms.DataGridView();
            this.Cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnumnota_debito = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbfecha = new System.Windows.Forms.MaskedTextBox();
            this.gridcuenta = new System.Windows.Forms.DataGridView();
            this.btnguardar = new System.Windows.Forms.Button();
            this.filtro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbtotaldebito = new System.Windows.Forms.TextBox();
            this.tbtotalcredito = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbconcepto = new System.Windows.Forms.TextBox();
            this.Pbarratitulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Inicio = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btn_Contabilizar = new System.Windows.Forms.Button();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.griddiario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcuenta)).BeginInit();
            this.Pbarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnota_debito
            // 
            this.tbnota_debito.BackColor = System.Drawing.Color.White;
            this.tbnota_debito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnota_debito.Location = new System.Drawing.Point(189, 96);
            this.tbnota_debito.Name = "tbnota_debito";
            this.tbnota_debito.ReadOnly = true;
            this.tbnota_debito.Size = new System.Drawing.Size(200, 22);
            this.tbnota_debito.TabIndex = 0;
            this.tbnota_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // griddiario
            // 
            this.griddiario.AllowUserToResizeColumns = false;
            this.griddiario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griddiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.griddiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cuenta,
            this.Descripcion,
            this.Debito,
            this.Credito,
            this.Detalles});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.griddiario.DefaultCellStyle = dataGridViewCellStyle18;
            this.griddiario.Location = new System.Drawing.Point(329, 184);
            this.griddiario.Name = "griddiario";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griddiario.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.griddiario.RowHeadersWidth = 51;
            this.griddiario.Size = new System.Drawing.Size(850, 407);
            this.griddiario.TabIndex = 2;
            this.griddiario.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.griddiario_CellBeginEdit);
            this.griddiario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddiario_CellClick);
            this.griddiario.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddiario_CellEndEdit);
            this.griddiario.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.griddiario_RowsRemoved);
            // 
            // Cuenta
            // 
            this.Cuenta.DataPropertyName = "0";
            this.Cuenta.HeaderText = "Cuenta";
            this.Cuenta.MinimumWidth = 6;
            this.Cuenta.Name = "Cuenta";
            this.Cuenta.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 300F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Descripcion.Width = 200;
            // 
            // Debito
            // 
            dataGridViewCellStyle16.Format = "N2";
            dataGridViewCellStyle16.NullValue = "0";
            this.Debito.DefaultCellStyle = dataGridViewCellStyle16;
            this.Debito.HeaderText = "Debito";
            this.Debito.MinimumWidth = 6;
            this.Debito.Name = "Debito";
            this.Debito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Debito.Width = 125;
            // 
            // Credito
            // 
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = "0";
            this.Credito.DefaultCellStyle = dataGridViewCellStyle17;
            this.Credito.HeaderText = "Credito";
            this.Credito.MinimumWidth = 6;
            this.Credito.Name = "Credito";
            this.Credito.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Credito.Width = 125;
            // 
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles";
            this.Detalles.MinimumWidth = 6;
            this.Detalles.Name = "Detalles";
            this.Detalles.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Detalles.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "N_D-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "NOTA DEBITO №:";
            // 
            // tbnumnota_debito
            // 
            this.tbnumnota_debito.BackColor = System.Drawing.Color.White;
            this.tbnumnota_debito.Enabled = false;
            this.tbnumnota_debito.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnumnota_debito.Location = new System.Drawing.Point(551, 96);
            this.tbnumnota_debito.Name = "tbnumnota_debito";
            this.tbnumnota_debito.ReadOnly = true;
            this.tbnumnota_debito.Size = new System.Drawing.Size(200, 22);
            this.tbnumnota_debito.TabIndex = 5;
            this.tbnumnota_debito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(787, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "FECHA:";
            // 
            // tbfecha
            // 
            this.tbfecha.Culture = new System.Globalization.CultureInfo("es-MX");
            this.tbfecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbfecha.Location = new System.Drawing.Point(855, 93);
            this.tbfecha.Mask = "00/00/0000";
            this.tbfecha.Name = "tbfecha";
            this.tbfecha.Size = new System.Drawing.Size(89, 26);
            this.tbfecha.TabIndex = 8;
            this.tbfecha.ValidatingType = typeof(System.DateTime);
            this.tbfecha.Leave += new System.EventHandler(this.tbfecha_Leave);
            // 
            // gridcuenta
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridcuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.gridcuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridcuenta.DefaultCellStyle = dataGridViewCellStyle21;
            this.gridcuenta.Location = new System.Drawing.Point(19, 223);
            this.gridcuenta.Name = "gridcuenta";
            this.gridcuenta.RowHeadersWidth = 51;
            this.gridcuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcuenta.Size = new System.Drawing.Size(303, 368);
            this.gridcuenta.TabIndex = 9;
            this.gridcuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridcuenta_CellDoubleClick);
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.LimeGreen;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.White;
            this.btnguardar.Location = new System.Drawing.Point(1020, 640);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(159, 43);
            this.btnguardar.TabIndex = 10;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(79, 197);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(223, 20);
            this.filtro.TabIndex = 13;
            this.filtro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Filtrar:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(613, 598);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "TOTAL:";
            // 
            // tbtotaldebito
            // 
            this.tbtotaldebito.BackColor = System.Drawing.Color.White;
            this.tbtotaldebito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtotaldebito.Location = new System.Drawing.Point(686, 597);
            this.tbtotaldebito.Name = "tbtotaldebito";
            this.tbtotaldebito.ReadOnly = true;
            this.tbtotaldebito.Size = new System.Drawing.Size(121, 20);
            this.tbtotaldebito.TabIndex = 16;
            // 
            // tbtotalcredito
            // 
            this.tbtotalcredito.BackColor = System.Drawing.Color.White;
            this.tbtotalcredito.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtotalcredito.Location = new System.Drawing.Point(806, 597);
            this.tbtotalcredito.Name = "tbtotalcredito";
            this.tbtotalcredito.ReadOnly = true;
            this.tbtotalcredito.Size = new System.Drawing.Size(121, 20);
            this.tbtotalcredito.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(142, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "CONCEPTO:";
            // 
            // tbconcepto
            // 
            this.tbconcepto.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbconcepto.Location = new System.Drawing.Point(254, 127);
            this.tbconcepto.Margin = new System.Windows.Forms.Padding(2);
            this.tbconcepto.Multiline = true;
            this.tbconcepto.Name = "tbconcepto";
            this.tbconcepto.Size = new System.Drawing.Size(637, 52);
            this.tbconcepto.TabIndex = 19;
            // 
            // Pbarratitulo
            // 
            this.Pbarratitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pbarratitulo.Controls.Add(this.label7);
            this.Pbarratitulo.Controls.Add(this.btn_Inicio);
            this.Pbarratitulo.Controls.Add(this.logo);
            this.Pbarratitulo.Controls.Add(this.btn_Contabilizar);
            this.Pbarratitulo.Controls.Add(this.btn_Reportes);
            this.Pbarratitulo.Controls.Add(this.btnMinimizar);
            this.Pbarratitulo.Controls.Add(this.btnCerrar);
            this.Pbarratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pbarratitulo.Location = new System.Drawing.Point(0, 0);
            this.Pbarratitulo.Name = "Pbarratitulo";
            this.Pbarratitulo.Size = new System.Drawing.Size(1200, 60);
            this.Pbarratitulo.TabIndex = 21;
            this.Pbarratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pbarratitulo_MouseDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(364, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(205, 45);
            this.label7.TabIndex = 27;
            this.label7.Text = "NOTA DEBITO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Inicio
            // 
            this.btn_Inicio.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inicio.FlatAppearance.BorderSize = 0;
            this.btn_Inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio.ForeColor = System.Drawing.Color.White;
            this.btn_Inicio.Location = new System.Drawing.Point(640, 12);
            this.btn_Inicio.Name = "btn_Inicio";
            this.btn_Inicio.Size = new System.Drawing.Size(111, 40);
            this.btn_Inicio.TabIndex = 25;
            this.btn_Inicio.Text = "INICIO";
            this.btn_Inicio.UseVisualStyleBackColor = false;
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(278, 60);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 22;
            this.logo.TabStop = false;
            // 
            // btn_Contabilizar
            // 
            this.btn_Contabilizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Contabilizar.FlatAppearance.BorderSize = 0;
            this.btn_Contabilizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Contabilizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Contabilizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Contabilizar.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Contabilizar.ForeColor = System.Drawing.Color.White;
            this.btn_Contabilizar.Location = new System.Drawing.Point(745, 12);
            this.btn_Contabilizar.Name = "btn_Contabilizar";
            this.btn_Contabilizar.Size = new System.Drawing.Size(183, 40);
            this.btn_Contabilizar.TabIndex = 24;
            this.btn_Contabilizar.Text = "CONTABILIZAR";
            this.btn_Contabilizar.UseVisualStyleBackColor = false;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.BackColor = System.Drawing.Color.Transparent;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reportes.ForeColor = System.Drawing.Color.White;
            this.btn_Reportes.Location = new System.Drawing.Point(934, 12);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(128, 40);
            this.btn_Reportes.TabIndex = 22;
            this.btn_Reportes.Text = "REPORTES";
            this.btn_Reportes.UseVisualStyleBackColor = false;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1086, 7);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 45);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizar.TabIndex = 23;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1146, 7);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 45);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 22;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(847, 640);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(159, 43);
            this.btnNuevo.TabIndex = 22;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // nota_debito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.Pbarratitulo);
            this.Controls.Add(this.tbconcepto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbtotalcredito);
            this.Controls.Add(this.tbtotaldebito);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.gridcuenta);
            this.Controls.Add(this.tbfecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnumnota_debito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.griddiario);
            this.Controls.Add(this.tbnota_debito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "nota_debito";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIARIO";
            this.Load += new System.EventHandler(this.diario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.griddiario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridcuenta)).EndInit();
            this.Pbarratitulo.ResumeLayout(false);
            this.Pbarratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbnota_debito;
        private System.Windows.Forms.DataGridView griddiario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnumnota_debito;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbfecha;
        private System.Windows.Forms.DataGridView gridcuenta;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbtotaldebito;
        private System.Windows.Forms.TextBox tbtotalcredito;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbconcepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credito;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.Panel Pbarratitulo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btn_Reportes;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button btn_Contabilizar;
        private System.Windows.Forms.Button btn_Inicio;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label7;
    }
}