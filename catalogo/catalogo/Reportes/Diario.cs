using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace catalogo.Reportes
{
    public partial class Diario : Form
    {
        public Diario()
        {
            InitializeComponent();
        }
        private tools data = new tools();
        private conexion conect = new conexion();
        private DateTime hoy = DateTime.Now;
        DateTime rmes;

        private void Diario_Load(object sender, EventArgs e)
        {
            tbhasta.Text = hoy.ToString("dd/MM/yyyy");
            rmes = hoy.AddDays(-30);
            tbdesde.Text = rmes.ToString("dd/MM/yyyy");

            Llenartabla();
        }


        private void sum_totals()
        {
            double totaldebit = 0;
            double totalcredit = 0;

            try
            {
                foreach (DataGridViewRow row in griddiario.Rows)
                {
                    if (row.Cells[6].Value != null)
                    {
                        totaldebit += Convert.ToDouble(row.Cells[6].Value);
                    }

                    if (row.Cells[7].Value != null)
                    {
                        totalcredit += Convert.ToDouble(row.Cells[7].Value);
                    }

                }

                tbtotaldebe.Text = string.Format("{0:C2}", totaldebit);
                tbtotalhaber.Text = string.Format("{0:C2}", totalcredit);
            }
            catch
            {
                MessageBox.Show("¡Ocurrio un problema con la suma de los totales, por favor verifique los valores en las columna de Debito y Credito!");
            }

        }

        public void Llenartabla()
        {
            string date = tbhasta.Text;
            string[] Ldate = date.Split('/');
            date = Ldate[1] + "/" + Ldate[0] + "/" + Ldate[2];
            DateTime hasta = Convert.ToDateTime(date);

            string date2 = tbdesde.Text;
            string[] Ldate2 = date2.Split('/');
            date2 = Ldate2[1] + "/" + Ldate2[0] + "/" + Ldate2[2];
            DateTime desde = Convert.ToDateTime(date2);

            string consulta = "select id_entrada as ID, fecha as fecha, nasiento as numentrada, CONCAT(x.identificador, asiento) as codigo, x.codigo_cuenta as cuenta, cuenta as descripcion, debito as debe, credito as haber, detalles as detalles, 'Asiento Diario' as identidad, x.identificador as identificador from asiento_diario x inner join catalogo ct on x.codigo_cuenta = ct.codigo_cuenta "+
            "where fecha >= @desde and fecha <= @hasta and x.activo = 1 union "+
            "select id_ingreso as ID, fecha as fecha, ningreso as numentrada, CONCAT(x.identificador, ingreso) as codigo, x.codigo_cuenta as cuenta, cuenta as descripcion, debito as debe, credito as haber, detalles as detalles, 'Ingresos' as identidad, x.identificador as identificador from comp_ingresos x inner join catalogo ct on x.codigo_cuenta = ct.codigo_cuenta " +
            "where fecha >= @desde and fecha <= @hasta and x.activo = 1 union " +
            "select id_egreso as ID, fecha as fecha, negreso as numentrada, CONCAT(x.identificador, egreso) as codigo, x.codigo_cuenta as cuenta, cuenta as descripcion, debito as debe, credito as haber, detalles as detalles, 'Egresos' as identidad, x.identificador as identificador from comp_egresos x inner join catalogo ct on x.codigo_cuenta = ct.codigo_cuenta " +
            "where fecha >= @desde and fecha <= @hasta and x.activo = 1 union " +
            "select id_notac as ID, fecha as fecha, nnota_credito as numentrada, CONCAT(x.identificador, nota_credito) as codigo, x.codigo_cuenta as cuenta, cuenta as descripcion, debito as debe, credito as haber, detalles as detalles, 'Nota de crédito' as identidad, x.identificador as identificador from nota_credito x inner join catalogo ct on x.codigo_cuenta = ct.codigo_cuenta " +
            "where fecha >= @desde and fecha <= @hasta and x.activo = 1 union " +
            "select id_notad as ID, fecha as fecha, nnota_debito as numentrada, CONCAT(x.identificador, nota_debito) as codigo, x.codigo_cuenta as cuenta, cuenta as descripcion, debito as debe, credito as haber, detalles as detalles, 'Nota de debito' as identidad, x.identificador as identificador from nota_debito x inner join catalogo ct on x.codigo_cuenta = ct.codigo_cuenta " +
            "where fecha >= @desde and fecha <= @hasta and x.activo = 1 " +
            "order by x.identificador";

            using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
            {
                cmd.Parameters.AddWithValue("desde", desde);
                cmd.Parameters.AddWithValue("hasta", hasta);

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

                griddiario.DataSource = dt;
                this.griddiario.Columns[0].Visible = false;
                this.griddiario.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.griddiario.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            sum_totals();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //  #Control movimiento del form.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int WParam, int lParam);

        private void Pbarratitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void tbdesde_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime.ParseExact(tbdesde.Text, "dd/MM/yyyy", null);
                if (tbdesde.Text.Length != 10)
                {
                    MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                    tbdesde.Focus();

                }
                else
                {
                    Llenartabla();
                }

            }
            catch
            {
                MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                var fecha = rmes.ToString("dd/MM/yyyy");
                tbdesde.Text = fecha;

            }
        }

        private void tbhasta_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime.ParseExact(tbdesde.Text, "dd/MM/yyyy", null);
                if (tbdesde.Text.Length != 10)
                {
                    MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                    tbdesde.Focus();

                }
                else
                {
                    Llenartabla();
                }

            }
            catch
            {
                MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                var fecha = hoy.ToString("dd/MM/yyyy");
                tbhasta.Text = fecha;

            }
        }

        private void griddiario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (griddiario.SelectedCells[0].Value != null)
                {
                    data.id = griddiario.SelectedCells[0].Value.ToString();
                    data.identy = griddiario.SelectedCells[10].Value.ToString();

                    btnmodificar.Enabled = true;
                }
                else
                {
                    btnmodificar.Enabled = false;
                }
            }
            catch {}
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            Form mform = new modificar_entrada(this,data);
            mform.Show();
        }
    }
}
