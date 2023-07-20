namespace catalogo
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Pbarratitulo = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btn_diario = new System.Windows.Forms.Button();
            this.btn_ingreso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_egreso = new System.Windows.Forms.Button();
            this.btn_nd = new System.Windows.Forms.Button();
            this.btn_nc = new System.Windows.Forms.Button();
            this.btn_catalogo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Pbarratitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
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
            this.Pbarratitulo.TabIndex = 22;
            this.Pbarratitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pbarratitulo_MouseDown_1);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Impact", 32F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(497, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 53);
            this.label7.TabIndex = 27;
            this.label7.Text = "MENÚ";
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
            // btn_diario
            // 
            this.btn_diario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_diario.FlatAppearance.BorderSize = 0;
            this.btn_diario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_diario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_diario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_diario.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diario.ForeColor = System.Drawing.Color.White;
            this.btn_diario.Location = new System.Drawing.Point(49, 192);
            this.btn_diario.Name = "btn_diario";
            this.btn_diario.Size = new System.Drawing.Size(331, 63);
            this.btn_diario.TabIndex = 25;
            this.btn_diario.Text = "ASIENTO DIARIO";
            this.btn_diario.UseVisualStyleBackColor = false;
            this.btn_diario.Click += new System.EventHandler(this.btn_diario_Click);
            // 
            // btn_ingreso
            // 
            this.btn_ingreso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ingreso.FlatAppearance.BorderSize = 0;
            this.btn_ingreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_ingreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ingreso.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingreso.ForeColor = System.Drawing.Color.White;
            this.btn_ingreso.Location = new System.Drawing.Point(49, 283);
            this.btn_ingreso.Name = "btn_ingreso";
            this.btn_ingreso.Size = new System.Drawing.Size(331, 63);
            this.btn_ingreso.TabIndex = 26;
            this.btn_ingreso.Text = "COMP. INGRESOS";
            this.btn_ingreso.UseVisualStyleBackColor = false;
            this.btn_ingreso.Click += new System.EventHandler(this.btn_ingreso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 56);
            this.label1.TabIndex = 27;
            this.label1.Text = "CONTABILIZAR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(875, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 56);
            this.label2.TabIndex = 28;
            this.label2.Text = "CATÁLOGO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(490, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(289, 56);
            this.label3.TabIndex = 29;
            this.label3.Text = "REPORTES";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_egreso
            // 
            this.btn_egreso.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_egreso.FlatAppearance.BorderSize = 0;
            this.btn_egreso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_egreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_egreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_egreso.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_egreso.ForeColor = System.Drawing.Color.White;
            this.btn_egreso.Location = new System.Drawing.Point(49, 374);
            this.btn_egreso.Name = "btn_egreso";
            this.btn_egreso.Size = new System.Drawing.Size(331, 63);
            this.btn_egreso.TabIndex = 30;
            this.btn_egreso.Text = "COMP. EGRESOS";
            this.btn_egreso.UseVisualStyleBackColor = false;
            this.btn_egreso.Click += new System.EventHandler(this.btn_egreso_Click);
            // 
            // btn_nd
            // 
            this.btn_nd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nd.FlatAppearance.BorderSize = 0;
            this.btn_nd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_nd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_nd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nd.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nd.ForeColor = System.Drawing.Color.White;
            this.btn_nd.Location = new System.Drawing.Point(49, 466);
            this.btn_nd.Name = "btn_nd";
            this.btn_nd.Size = new System.Drawing.Size(331, 63);
            this.btn_nd.TabIndex = 31;
            this.btn_nd.Text = "NOTA DE DEBITO";
            this.btn_nd.UseVisualStyleBackColor = false;
            this.btn_nd.Click += new System.EventHandler(this.btn_nd_Click);
            // 
            // btn_nc
            // 
            this.btn_nc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_nc.FlatAppearance.BorderSize = 0;
            this.btn_nc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_nc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_nc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_nc.Font = new System.Drawing.Font("Impact", 32F);
            this.btn_nc.ForeColor = System.Drawing.Color.White;
            this.btn_nc.Location = new System.Drawing.Point(49, 558);
            this.btn_nc.Name = "btn_nc";
            this.btn_nc.Size = new System.Drawing.Size(331, 63);
            this.btn_nc.TabIndex = 32;
            this.btn_nc.Text = "NOTA DE CRÉDITO";
            this.btn_nc.UseVisualStyleBackColor = false;
            this.btn_nc.Click += new System.EventHandler(this.btn_nc_Click);
            // 
            // btn_catalogo
            // 
            this.btn_catalogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_catalogo.FlatAppearance.BorderSize = 0;
            this.btn_catalogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btn_catalogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_catalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_catalogo.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_catalogo.ForeColor = System.Drawing.Color.White;
            this.btn_catalogo.Location = new System.Drawing.Point(865, 192);
            this.btn_catalogo.Name = "btn_catalogo";
            this.btn_catalogo.Size = new System.Drawing.Size(303, 63);
            this.btn_catalogo.TabIndex = 33;
            this.btn_catalogo.Text = "CATÁLOGO";
            this.btn_catalogo.UseVisualStyleBackColor = false;
            this.btn_catalogo.Click += new System.EventHandler(this.btn_catalogo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Impact", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(460, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(331, 63);
            this.button1.TabIndex = 34;
            this.button1.Text = "DIARIO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_catalogo);
            this.Controls.Add(this.btn_nc);
            this.Controls.Add(this.btn_nd);
            this.Controls.Add(this.btn_egreso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ingreso);
            this.Controls.Add(this.Pbarratitulo);
            this.Controls.Add(this.btn_diario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Pbarratitulo.ResumeLayout(false);
            this.Pbarratitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pbarratitulo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_diario;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Button btn_ingreso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_egreso;
        private System.Windows.Forms.Button btn_nd;
        private System.Windows.Forms.Button btn_nc;
        private System.Windows.Forms.Button btn_catalogo;
        private System.Windows.Forms.Button button1;
    }
}