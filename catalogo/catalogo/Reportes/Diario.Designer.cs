namespace catalogo.Reportes
{
    partial class Diario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pbarratitulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.griddiario = new System.Windows.Forms.DataGridView();
            this.tbdesde = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbhasta = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtotalhaber = new System.Windows.Forms.TextBox();
            this.tbtotaldebe = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.Pbarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddiario)).BeginInit();
            this.SuspendLayout();
            // 
            // Pbarratitulo
            // 
            this.Pbarratitulo.BackColor = System.Drawing.Color.DodgerBlue;
            this.Pbarratitulo.Controls.Add(this.label7);
            this.Pbarratitulo.Controls.Add(this.logo);
            this.Pbarratitulo.Controls.Add(this.btnMinimizar);
            this.Pbarratitulo.Controls.Add(this.btnCerrar);
            this.Pbarratitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pbarratitulo.Location = new System.Drawing.Point(0, 0);
            this.Pbarratitulo.Name = "Pbarratitulo";
            this.Pbarratitulo.Size = new System.Drawing.Size(1200, 60);
            this.Pbarratitulo.TabIndex = 23;
            this.Pbarratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pbarratitulo_MouseDown);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Impact", 32F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(517, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 53);
            this.label7.TabIndex = 27;
            this.label7.Text = "DIARIO";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // griddiario
            // 
            this.griddiario.AllowUserToAddRows = false;
            this.griddiario.AllowUserToDeleteRows = false;
            this.griddiario.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.griddiario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.griddiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.griddiario.Location = new System.Drawing.Point(12, 114);
            this.griddiario.MultiSelect = false;
            this.griddiario.Name = "griddiario";
            this.griddiario.ReadOnly = true;
            this.griddiario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.griddiario.Size = new System.Drawing.Size(1176, 584);
            this.griddiario.TabIndex = 24;
            this.griddiario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.griddiario_CellClick);
            // 
            // tbdesde
            // 
            this.tbdesde.Culture = new System.Globalization.CultureInfo("es-MX");
            this.tbdesde.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdesde.Location = new System.Drawing.Point(106, 82);
            this.tbdesde.Mask = "00/00/0000";
            this.tbdesde.Name = "tbdesde";
            this.tbdesde.Size = new System.Drawing.Size(89, 26);
            this.tbdesde.TabIndex = 27;
            this.tbdesde.ValidatingType = typeof(System.DateTime);
            this.tbdesde.Leave += new System.EventHandler(this.tbdesde_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "DESDE:";
            // 
            // tbhasta
            // 
            this.tbhasta.Culture = new System.Globalization.CultureInfo("es-MX");
            this.tbhasta.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbhasta.Location = new System.Drawing.Point(294, 82);
            this.tbhasta.Mask = "00/00/0000";
            this.tbhasta.Name = "tbhasta";
            this.tbhasta.Size = new System.Drawing.Size(89, 26);
            this.tbhasta.TabIndex = 29;
            this.tbhasta.ValidatingType = typeof(System.DateTime);
            this.tbhasta.Leave += new System.EventHandler(this.tbhasta_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "HASTA:";
            // 
            // btnmodificar
            // 
            this.btnmodificar.BackColor = System.Drawing.Color.Yellow;
            this.btnmodificar.Enabled = false;
            this.btnmodificar.FlatAppearance.BorderSize = 2;
            this.btnmodificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodificar.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodificar.ForeColor = System.Drawing.Color.Black;
            this.btnmodificar.Location = new System.Drawing.Point(983, 706);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(190, 45);
            this.btnmodificar.TabIndex = 30;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = false;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(249, 707);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 31;
            this.label2.Text = "TOTAL HABER:";
            // 
            // tbtotalhaber
            // 
            this.tbtotalhaber.Location = new System.Drawing.Point(375, 706);
            this.tbtotalhaber.Name = "tbtotalhaber";
            this.tbtotalhaber.Size = new System.Drawing.Size(123, 20);
            this.tbtotalhaber.TabIndex = 32;
            // 
            // tbtotaldebe
            // 
            this.tbtotaldebe.Location = new System.Drawing.Point(630, 706);
            this.tbtotaldebe.Name = "tbtotaldebe";
            this.tbtotaldebe.Size = new System.Drawing.Size(123, 20);
            this.tbtotaldebe.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 707);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 33;
            this.label4.Text = "TOTAL DEBE:";
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.GreenYellow;
            this.btnimprimir.FlatAppearance.BorderSize = 2;
            this.btnimprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimir.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.Black;
            this.btnimprimir.Location = new System.Drawing.Point(781, 706);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(189, 45);
            this.btnimprimir.TabIndex = 35;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = false;
            // 
            // Diario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1200, 760);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.tbtotaldebe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbtotalhaber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmodificar);
            this.Controls.Add(this.tbhasta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdesde);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.griddiario);
            this.Controls.Add(this.Pbarratitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Diario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diario";
            this.Load += new System.EventHandler(this.Diario_Load);
            this.Pbarratitulo.ResumeLayout(false);
            this.Pbarratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.griddiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pbarratitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.DataGridView griddiario;
        private System.Windows.Forms.MaskedTextBox tbdesde;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox tbhasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtotalhaber;
        private System.Windows.Forms.TextBox tbtotaldebe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnimprimir;
    }
}