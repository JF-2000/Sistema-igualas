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
    public partial class Catalogo_cuentas : Form
    {
        public string ID;
        public Catalogo_cuentas()
        {
            InitializeComponent();
            
        }

        conexion conect = new conexion();

        public void Llenartabla()
        {
            string consulta = "select codigo_cuenta, cuenta, identificador from catalogo where activo = 1";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conect.access);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            dataGridView1.DataSource = dt;
            this.dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Llenartabla();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Form aform = new agregar_catalogo(this);
            aform.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        { 
            tools datos = new tools();
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                datos.id = dataGridView1.SelectedCells[0].Value.ToString();
                datos.nombre = dataGridView1.SelectedCells[1].Value.ToString();
                datos.tipo = dataGridView1.SelectedCells[2].Value.ToString();

                Form modcatalogo = new modificar_catalogo(this,datos);
                modcatalogo.Show();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro valido.");
            }

        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells[0].Value != null)
            {
                if (MessageBox.Show("¿Quieres eliminar esta cuenta del catálogo?", "¡Advertencia!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ID = dataGridView1.SelectedCells[0].Value.ToString();
                    conect.access.Open();

                    string consulta = "update catalogo SET activo = 0 where codigo_cuenta = @codigoc";
                    SqlCommand comando = new SqlCommand(consulta, conect.access);
                    comando.Parameters.AddWithValue("@codigoc", ID);
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cuenta eliminada correctamente.");

                    conect.access.Close();

                    Llenartabla();
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro valido.");
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string filterField = "cuenta";
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, tbfiltro.Text);
        }
    }
}
