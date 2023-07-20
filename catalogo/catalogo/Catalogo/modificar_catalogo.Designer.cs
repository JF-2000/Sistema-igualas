namespace catalogo
{
    partial class modificar_catalogo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbcuentas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbgrupo = new System.Windows.Forms.TextBox();
            this.tbsubgrupo = new System.Windows.Forms.TextBox();
            this.tbcontrol = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbfiltro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btmodificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código de cuenta.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de cuenta.";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Enabled = false;
            this.tbcodigo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo.Location = new System.Drawing.Point(16, 196);
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(171, 26);
            this.tbcodigo.TabIndex = 2;
            this.tbcodigo.TextChanged += new System.EventHandler(this.tbcodigo_TextChanged);
            this.tbcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcodigo_KeyPress);
            this.tbcodigo.Leave += new System.EventHandler(this.tbcodigo_Leave);
            // 
            // tbnombre
            // 
            this.tbnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbnombre.Enabled = false;
            this.tbnombre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(16, 259);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(171, 26);
            this.tbnombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(113, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Modificar cuenta";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(342, 260);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // cbcuentas
            // 
            this.cbcuentas.FormattingEnabled = true;
            this.cbcuentas.Items.AddRange(new object[] {
            "GRUPO",
            "SUBGRUPO",
            "CONTROL",
            "AUXILIAR"});
            this.cbcuentas.Location = new System.Drawing.Point(18, 130);
            this.cbcuentas.Name = "cbcuentas";
            this.cbcuentas.Size = new System.Drawing.Size(169, 21);
            this.cbcuentas.TabIndex = 7;
            this.cbcuentas.SelectedValueChanged += new System.EventHandler(this.cbcuentas_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tipo de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(233, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pertenece al grupo";
            // 
            // tbgrupo
            // 
            this.tbgrupo.Enabled = false;
            this.tbgrupo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgrupo.Location = new System.Drawing.Point(229, 130);
            this.tbgrupo.Name = "tbgrupo";
            this.tbgrupo.Size = new System.Drawing.Size(171, 26);
            this.tbgrupo.TabIndex = 10;
            this.tbgrupo.Enter += new System.EventHandler(this.tbgrupo_Enter);
            this.tbgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbgrupo_KeyPress);
            // 
            // tbsubgrupo
            // 
            this.tbsubgrupo.Enabled = false;
            this.tbsubgrupo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsubgrupo.Location = new System.Drawing.Point(229, 196);
            this.tbsubgrupo.Name = "tbsubgrupo";
            this.tbsubgrupo.Size = new System.Drawing.Size(171, 26);
            this.tbsubgrupo.TabIndex = 11;
            this.tbsubgrupo.Enter += new System.EventHandler(this.tbsubgrupo_Enter);
            this.tbsubgrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbsubgrupo_KeyPress);
            // 
            // tbcontrol
            // 
            this.tbcontrol.Enabled = false;
            this.tbcontrol.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcontrol.Location = new System.Drawing.Point(229, 259);
            this.tbcontrol.Name = "tbcontrol";
            this.tbcontrol.Size = new System.Drawing.Size(171, 26);
            this.tbcontrol.TabIndex = 12;
            this.tbcontrol.Enter += new System.EventHandler(this.tbcontrol_Enter);
            this.tbcontrol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbcontrol_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pertenece al subgrupo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Pertenece al control";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(238, 31);
            this.label8.TabIndex = 15;
            this.label8.Text = "Selección de cuentas";
            // 
            // tbfiltro
            // 
            this.tbfiltro.Location = new System.Drawing.Point(489, 82);
            this.tbfiltro.Name = "tbfiltro";
            this.tbfiltro.Size = new System.Drawing.Size(132, 20);
            this.tbfiltro.TabIndex = 16;
            this.tbfiltro.TextChanged += new System.EventHandler(this.filtro_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 25);
            this.label9.TabIndex = 17;
            this.label9.Text = "Filtro:";
            // 
            // btmodificar
            // 
            this.btmodificar.BackColor = System.Drawing.Color.Yellow;
            this.btmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmodificar.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.ForeColor = System.Drawing.Color.Black;
            this.btmodificar.Location = new System.Drawing.Point(119, 328);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(179, 46);
            this.btmodificar.TabIndex = 18;
            this.btmodificar.Text = "Modificar";
            this.btmodificar.UseVisualStyleBackColor = false;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click_1);
            // 
            // modificar_catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 416);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbfiltro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbcontrol);
            this.Controls.Add(this.tbsubgrupo);
            this.Controls.Add(this.tbgrupo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbcuentas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "modificar_catalogo";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "modificar_catalogo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbcuentas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbgrupo;
        private System.Windows.Forms.TextBox tbsubgrupo;
        private System.Windows.Forms.TextBox tbcontrol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbfiltro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btmodificar;
    }
}