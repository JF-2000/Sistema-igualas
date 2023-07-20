using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace catalogo
{
    public partial class agregar_catalogo : Form
    {
        private string grupo;
        private int maxcode;

        private Catalogo_cuentas padre;
        public agregar_catalogo(Catalogo_cuentas padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        conexion conect = new conexion();

        public void Llenartabla()
        {
            string consulta = "select codigo_cuenta, cuenta, identificador from catalogo where identificador = '" + grupo + "' ";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conect.access);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void agregar_catalogo_Load(object sender, EventArgs e)
        {

        }

        private void btagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbnombre.Text) || string.IsNullOrEmpty(tbcodigo.Text))
            {
                MessageBox.Show("Favor llenar el campo de condigo de cuenta y nombre de cuenta.", "¡Aviso!");
            }
            else
            {
                string consulta = "select codigo_cuenta from catalogo where codigo_cuenta = '" + tbcodigo.Text + "' ";
                SqlCommand ident = new SqlCommand(consulta, conect.access);
                conect.access.Open();
                SqlDataReader comp = ident.ExecuteReader();
                if (comp.Read() == false)
                {
                    string tgrupo = cbcuentas.Text;
                    conect.access.Close();
                    if (tgrupo == "GRUPO")
                    {
                        consulta = "insert into catalogo (codigo_cuenta,cuenta,identificador) values(@codigoc,@cuenta,'GP')";
                        using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.Parameters.AddWithValue("@codigoc", tbcodigo.Text);
                            cmd.Parameters.AddWithValue("@cuenta", tbnombre.Text);

                            conect.access.Open();
                            int res = cmd.ExecuteNonQuery();
                            conect.access.Close();
                            if (res == 1)
                            {
                                MessageBox.Show("Cuenta agregada correctamente.");
                                padre.Llenartabla();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Ocurrio un error.");
                            }
                        }
                    }
                    if (tgrupo == "SUBGRUPO")
                    {
                        if (string.IsNullOrEmpty(tbgrupo.Text) )
                        {
                            MessageBox.Show("Favor llenar a que grupo pertenece la cuenta.", "¡Aviso!");
                        }
                        else
                        {
                            consulta = "insert into catalogo (codigo_cuenta,cuenta,grupo,identificador) values(@codigoc,@cuenta,@grupo,'SGP')";
                            using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@codigoc", tbcodigo.Text);
                                cmd.Parameters.AddWithValue("@cuenta", tbnombre.Text);
                                cmd.Parameters.AddWithValue("@grupo", tbgrupo.Text);

                                conect.access.Open();
                                int res = cmd.ExecuteNonQuery();
                                conect.access.Close();
                                if (res == 1)
                                {
                                    MessageBox.Show("Cuenta agregada correctamente.");
                                    padre.Llenartabla();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error.");
                                }
                            }
                        }

                    }
                    if (tgrupo == "CONTROL")
                    {
                        if (string.IsNullOrEmpty(tbgrupo.Text) || string.IsNullOrEmpty(tbsubgrupo.Text))
                        {
                            MessageBox.Show("Favor llenar a que grupo y subgrupo pertenece la cuenta.", "¡Aviso!");
                        }
                        else
                        {
                            consulta = "insert into catalogo (codigo_cuenta,cuenta,grupo,subgrupo,identificador) values(@codigoc,@cuenta,@grupo,@subgrupo,'CTL')";
                            using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@codigoc", tbcodigo.Text);
                                cmd.Parameters.AddWithValue("@cuenta", tbnombre.Text);
                                cmd.Parameters.AddWithValue("@grupo", tbgrupo.Text);
                                cmd.Parameters.AddWithValue("@subgrupo", tbsubgrupo.Text);

                                conect.access.Open();
                                int res = cmd.ExecuteNonQuery();
                                conect.access.Close();
                                if (res == 1)
                                {
                                    MessageBox.Show("Cuenta agregada correctamente.");
                                    padre.Llenartabla();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error.");
                                }
                            }
                        }
                    }
                    if (tgrupo == "AUXILIAR")
                    {
                        if (string.IsNullOrEmpty(tbgrupo.Text) || string.IsNullOrEmpty(tbsubgrupo.Text) || string.IsNullOrEmpty(tbcontrol.Text))
                        {
                            MessageBox.Show("Favor llenar a que grupo, subgrupo y control pertenece la cuenta.", "¡Aviso!");
                        }
                        else
                        {
                            consulta = "insert into catalogo (codigo_cuenta,cuenta,grupo,subgrupo,control,identificador) values(@codigoc,@cuenta,@grupo,@subgrupo,@control,'AUX')";
                            using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                            {
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.AddWithValue("@codigoc", tbcodigo.Text);
                                cmd.Parameters.AddWithValue("@cuenta", tbnombre.Text);
                                cmd.Parameters.AddWithValue("@grupo", tbgrupo.Text);
                                cmd.Parameters.AddWithValue("@subgrupo", tbsubgrupo.Text);
                                cmd.Parameters.AddWithValue("@control", tbcontrol.Text);

                                conect.access.Open();
                                int res = cmd.ExecuteNonQuery();
                                conect.access.Close();
                                if (res == 1)
                                {
                                    MessageBox.Show("Cuenta agregada correctamente.");
                                    padre.Llenartabla();
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Ocurrio un error.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    conect.access.Close();
                    MessageBox.Show("¡Codigo de cuenta ya registrado!", "¡Error!");
                }
            }

        }

        private void cbcuentas_SelectedValueChanged(object sender, EventArgs e)
        {
            tbcodigo.Enabled = true;
            tbnombre.Enabled = true;
            string tgrupo = cbcuentas.Text;
            if (tgrupo == "GRUPO")
            {
                tbgrupo.Enabled = false;
                tbsubgrupo.Enabled = false;
                tbcontrol.Enabled = false;
                maxcode = 1;
                tbgrupo.Clear();
                tbsubgrupo.Clear();
                tbcontrol.Clear();
            }
            else if (tgrupo == "SUBGRUPO")
            {
                tbgrupo.Enabled = true;
                tbsubgrupo.Enabled = false;
                tbcontrol.Enabled = false;
                maxcode = 2;
                tbsubgrupo.Clear();
                tbcontrol.Clear();
            }
            else if (tgrupo == "CONTROL")
            {
                tbgrupo.Enabled = true;
                tbsubgrupo.Enabled = true;
                tbcontrol.Enabled = false;
                maxcode = 6;
                tbcontrol.Clear();
            }
            else if (tgrupo == "AUXILIAR")
            {
                tbgrupo.Enabled = true;
                tbsubgrupo.Enabled = true;
                tbcontrol.Enabled = true;
                maxcode = 9;
            }

            Llenartabla();
        }

        private void tbgrupo_Enter(object sender, EventArgs e)
        {
            grupo = "GP";
            Llenartabla();
        }

        private void tbsubgrupo_Enter(object sender, EventArgs e)
        {
            grupo = "SGP";
            Llenartabla();
        }

        private void tbcontrol_Enter(object sender, EventArgs e)
        {
            grupo = "CTL";
            Llenartabla();
        }

        private void tbcodigo_TextChanged(object sender, EventArgs e)
        {
            if (tbcodigo.TextLength > maxcode)
            {
                MessageBox.Show("Excediste la cantidad de caracteres en el codigo!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbcodigo.Clear();
            }
        }

        private void tbcodigo_Leave(object sender, EventArgs e)
        {
            
            string tgrupo = cbcuentas.Text;
            if (tgrupo == "SUBGRUPO")
            {
                string i = tbcodigo.Text.Substring(0, 1);
                string consulta = "select codigo_cuenta from catalogo where codigo_cuenta = @cuenta ";
                SqlCommand cmd = new SqlCommand(consulta, conect.access);
                cmd.Parameters.AddWithValue("@cuenta", i);
                conect.access.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbgrupo.Text = reader["codigo_cuenta"].ToString();
                }
                conect.access.Close();  
            }
            if (tgrupo == "CONTROL")
            {
                string i = tbcodigo.Text.Substring(0, 2);
                string consulta = "select codigo_cuenta, grupo from catalogo where codigo_cuenta = @cuenta ";
                SqlCommand cmd = new SqlCommand(consulta, conect.access);
                cmd.Parameters.AddWithValue("@cuenta", i);
                conect.access.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbgrupo.Text = reader["grupo"].ToString();
                    tbsubgrupo.Text = reader["codigo_cuenta"].ToString();
                }
                conect.access.Close();
            }
            if (tgrupo == "AUXILIAR")
            {
                string i = tbcodigo.Text.Substring(0, 3);
                string consulta = "select codigo_cuenta, grupo, subgrupo from catalogo where codigo_cuenta = @cuenta ";
                SqlCommand cmd = new SqlCommand(consulta, conect.access);
                cmd.Parameters.AddWithValue("@cuenta", i);
                conect.access.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    tbgrupo.Text = reader["grupo"].ToString();
                    tbsubgrupo.Text = reader["subgrupo"].ToString();
                    tbcontrol.Text = reader["codigo_cuenta"].ToString();
                }
                conect.access.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                if (grupo == "GP")
                {
                    tbgrupo.Text = dataGridView1.SelectedCells[0].Value.ToString();
                }
                if (grupo == "SGP")
                {
                    tbsubgrupo.Text = dataGridView1.SelectedCells[0].Value.ToString();
                }
                if (grupo == "CTL")
                {
                    tbcontrol.Text = dataGridView1.SelectedCells[0].Value.ToString();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro valido.");
            }
        }


        private void tbcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 44) || (e.KeyChar >= 58 && e.KeyChar <= 255) || (e.KeyChar == 47) || (e.KeyChar == 46))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbsubgrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbcontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void filtro_TextChanged(object sender, EventArgs e)
        {
            string filterField = "cuenta";
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbfiltro.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
