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

namespace catalogo.Reportes
{
    public partial class modificar_entrada : Form
    {
        private Diario padre;
        private string identidad;
        private int ID;
        private DateTime fecha;
        public modificar_entrada( Diario padre, tools data)
        {
            InitializeComponent();
            this.padre = padre;
            ID = Convert.ToInt32(data.id);
            identidad = data.identy;

        }

        conexion conect = new conexion();

        private void modificar_entrada_Load(object sender, EventArgs e)
        {
            cargar_data();

        }

        //Llena la tabla de selección de cuenta.
        public void Llenartabla()
        {
            string consulta = "select codigo_cuenta, cuenta, identificador from catalogo";
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conect.access);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);

            gridcuenta.DataSource = dt;
            this.gridcuenta.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gridcuenta.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.gridcuenta.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        //Carga los datos de la entrada en el formulario.
        private void cargar_data()
        {
            try { 
                if (identidad == "ASD")
                {
                    string consulta = "select concepto, detalles, debito, credito, fecha, codigo_cuenta, identificador, asiento, nasiento from asiento_diario where id_entrada = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        conect.access.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tbconcepto.Text = reader["concepto"].ToString();
                            tbdetalle.Text = reader["detalles"].ToString();
                            tbdebe.Text = string.Format("{0:C2}", reader["debito"]);
                            tbhaber.Text = string.Format("{0:C2}", reader["credito"]);
                            fecha = Convert.ToDateTime( reader["fecha"].ToString());
                            tbfecha.Text = fecha.ToString("dd/MM/yyyy");
                            tbcuenta.Text = reader["codigo_cuenta"].ToString();
                            tbcodigo.Text = reader["identificador"].ToString() + reader["asiento"].ToString();
                            tbnentrada.Text = reader["nasiento"].ToString();
                        }
                        conect.access.Close();
                    }
                }
                else if (identidad == "CEG")
                {
                    string consulta = "select concepto, detalles, debito, credito, fecha, codigo_cuenta, identificador, egreso, negreso, ncheque,ncuenta,beneficiario from comp_egresos where id_egreso = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        conect.access.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tbconcepto.Text = reader["concepto"].ToString();
                            tbdetalle.Text = reader["detalles"].ToString();
                            tbdebe.Text = string.Format("{0:C2}", reader["debito"]);
                            tbhaber.Text = string.Format("{0:C2}", reader["credito"]);
                            fecha = Convert.ToDateTime(reader["fecha"].ToString());
                            tbfecha.Text = fecha.ToString("dd/MM/yyyy");
                            tbcuenta.Text = reader["codigo_cuenta"].ToString();
                            tbcodigo.Text = reader["identificador"].ToString() + reader["egreso"].ToString();
                            tbnentrada.Text = reader["negreso"].ToString();
                            tbncheque.Text = reader["ncheque"].ToString();
                            tbncuenta.Text = reader["ncuenta"].ToString();
                            tbbeneficiario.Text = reader["beneficiario"].ToString();
                            tbncheque.Enabled = true;
                            tbncuenta.Enabled = true;
                            tbbeneficiario.Enabled = true;
                        }
                        conect.access.Close();
                    }
                }
                else if (identidad == "CIN")
                {
                    string consulta = "select concepto, detalles, debito, credito, fecha, codigo_cuenta, identificador, ingreso, ningreso from comp_ingresos where id_ingreso = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        conect.access.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tbconcepto.Text = reader["concepto"].ToString();
                            tbdetalle.Text = reader["detalles"].ToString();
                            tbdebe.Text = string.Format("{0:C2}", reader["debito"]);
                            tbhaber.Text = string.Format("{0:C2}", reader["credito"]);
                            fecha = Convert.ToDateTime(reader["fecha"].ToString());
                            tbfecha.Text = fecha.ToString("dd/MM/yyyy");
                            tbcuenta.Text = reader["codigo_cuenta"].ToString();
                            tbcodigo.Text = reader["identificador"].ToString() + reader["ingreso"].ToString();
                            tbnentrada.Text = reader["ningreso"].ToString();
                        }
                        conect.access.Close();
                    }
                }
                else if (identidad == "NC")
                {
                    string consulta = "select concepto, detalles, debito, credito, fecha, codigo_cuenta, identificador, nota_credito, nnota_credito from nota_credito where id_notac = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        conect.access.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tbconcepto.Text = reader["concepto"].ToString();
                            tbdetalle.Text = reader["detalles"].ToString();
                            tbdebe.Text = string.Format("{0:C2}", reader["debito"]);
                            tbhaber.Text = string.Format("{0:C2}", reader["credito"]);
                            fecha = Convert.ToDateTime(reader["fecha"].ToString());
                            tbfecha.Text = fecha.ToString("dd/MM/yyyy");
                            tbcuenta.Text = reader["codigo_cuenta"].ToString();
                            tbcodigo.Text = reader["identificador"].ToString() + reader["nota_credito"].ToString();
                            tbnentrada.Text = reader["nnota_credito"].ToString();
                        }
                        conect.access.Close();
                    }
                }
                else if (identidad == "ND")
                {
                    string consulta = "select concepto, detalles, debito, credito, fecha, codigo_cuenta, identificador, nota_debito, nnota_debito from nota_debito where id_notad = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        conect.access.Open();
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            tbconcepto.Text = reader["concepto"].ToString();
                            tbdetalle.Text = reader["detalles"].ToString();
                            tbdebe.Text = string.Format("{0:C2}", reader["debito"]);
                            tbhaber.Text = string.Format("{0:C2}", reader["credito"]);
                            fecha = Convert.ToDateTime(reader["fecha"].ToString());
                            tbfecha.Text = fecha.ToString("dd/MM/yyyy");
                            tbcuenta.Text = reader["codigo_cuenta"].ToString();
                            tbcodigo.Text = reader["identificador"].ToString() + reader["nota_debito"].ToString();
                            tbnentrada.Text = reader["nnota_debito"].ToString();
                        }
                        conect.access.Close();
                    }
                }
            }
            catch { MessageBox.Show("Ha ocurrido un problema al momento de cargar los datos", "¡Aviso!"); }
        }

        //Cargar el datagrid cuando se ingresa al textbox de cuentas.
        private void tbcuenta_Enter(object sender, EventArgs e)
        {
            Llenartabla();
        }

        //Proceso de selección de cuenta.
        private void gridcuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridcuenta.SelectedCells[0].Value != null && gridcuenta.SelectedCells[2].Value.ToString() == "AUX")
                {
                    tbcuenta.Text = gridcuenta.SelectedCells[0].Value.ToString();
                }
                else if (gridcuenta.SelectedCells[2].Value.ToString() != "AUX")
                {
                    MessageBox.Show("Por favor seleccione una cuenta auxiliar.", "¡Aviso!");
                }
                else
                {
                    MessageBox.Show("Por favor seleccione un registro valido.", "¡Aviso!");
                }
            }catch { }

        }

        //Filtro de la tabla del catálogo de cuentas.
        private void filtro_TextChanged(object sender, EventArgs e)
        {
            string filterField = "cuenta";
            ((DataTable)gridcuenta.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, filtro.Text);
        }

        //Botón de guardado.
        private void btnguardar_Click(object sender, EventArgs e)
        {
            int nv = 0;
            string date = tbfecha.Text;
            string[] Ldate = date.Split('/');
            date = Ldate[1] + "/" + Ldate[0] + "/" + Ldate[2];
            DateTime dt = Convert.ToDateTime(date);
            try { 

                if (String.IsNullOrWhiteSpace(tbconcepto.Text))
                {
                    MessageBox.Show("Favor ingresar un concepto, antes de guardar.", "¡Aviso!");
                    return;
                }else if (String.IsNullOrWhiteSpace(tbdetalle.Text))
                {
                    tbdetalle.Text = "Sin detalle registrado";
                }
                else if (String.IsNullOrWhiteSpace(tbdebe.Text))
                {
                    tbdebe.Text = "0";
                }else if (String.IsNullOrWhiteSpace(tbhaber.Text))
                {
                    tbhaber.Text = "0";
                }

                if (identidad == "ASD")
                {
                    string consulta = "update asiento_diario set concepto = @concepto, detalles = @detalles, fecha = @fecha, debito = @debito, credito = @credito where id_entrada = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                        cmd.Parameters.AddWithValue("@detalles", tbdetalle.Text);
                        cmd.Parameters.AddWithValue("@fecha", dt);
                        cmd.Parameters.AddWithValue("@debito", tbdebe.Text);
                        cmd.Parameters.AddWithValue("@credito", tbhaber.Text);
                        conect.access.Open();
                        cmd.ExecuteNonQuery();
                        conect.access.Close();
                    }
                }
                else if (identidad == "CEG")
                {
                
                    if (String.IsNullOrWhiteSpace(tbncheque.Text) || int.TryParse(tbncheque.Text, out nv) != true)
                    {
                        MessageBox.Show("Favor ingresar el número de cheque, antes de guardar.", "¡Aviso!");
                        return;
                    }else if (String.IsNullOrWhiteSpace(tbncuenta.Text) || int.TryParse(tbncuenta.Text, out nv) != true)
                    {
                        MessageBox.Show("Favor ingresar el número de número, antes de guardar.", "¡Aviso!");
                        return;
                    }else if (String.IsNullOrWhiteSpace(tbbeneficiario.Text))
                    {
                        MessageBox.Show("Favor ingresar el beneficiario, antes de guardar.", "¡Aviso!");
                        return;
                    }

                    string consulta = "update comp_egresos set concepto = @concepto, detalles = @detalles, fecha = @fecha, debito = @debito, credito = @credito where id_egreso = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                        cmd.Parameters.AddWithValue("@detalles", tbdetalle.Text);
                        cmd.Parameters.AddWithValue("@fecha", dt);
                        cmd.Parameters.AddWithValue("@debito", tbdebe.Text);
                        cmd.Parameters.AddWithValue("@credito", tbhaber.Text);
                        conect.access.Open();
                        cmd.ExecuteNonQuery();
                        conect.access.Close();
                    }
                }
                else if (identidad == "CIN")
                {
                    string consulta = "update comp_ingresos set concepto = @concepto, detalles = @detalles, fecha = @fecha, debito = @debito, credito = @credito where id_ingreso = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                        cmd.Parameters.AddWithValue("@detalles", tbdetalle.Text);
                        cmd.Parameters.AddWithValue("@fecha", dt);
                        cmd.Parameters.AddWithValue("@debito", tbdebe.Text);
                        cmd.Parameters.AddWithValue("@credito", tbhaber.Text);
                        conect.access.Open();
                        cmd.ExecuteNonQuery();
                        conect.access.Close();
                    }
                }
                else if (identidad == "NC")
                {
                    string consulta = "update nota_credito set concepto = @concepto, detalles = @detalles, fecha = @fecha, debito = @debito, credito = @credito where id_notac = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                        cmd.Parameters.AddWithValue("@detalles", tbdetalle.Text);
                        cmd.Parameters.AddWithValue("@fecha", dt);
                        cmd.Parameters.AddWithValue("@debito", tbdebe.Text);
                        cmd.Parameters.AddWithValue("@credito", tbhaber.Text);
                        conect.access.Open();
                        cmd.ExecuteNonQuery();
                        conect.access.Close();
                    }
                }
                else if (identidad == "ND")
                {
                    string consulta = "update nota_debito set concepto = @concepto, detalles = @detalles, fecha = @fecha, debito = @debito, credito = @credito where id_notad = @id";
                    using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                    {
                        cmd.Parameters.AddWithValue("@id", ID);
                        cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                        cmd.Parameters.AddWithValue("@detalles", tbdetalle.Text);
                        cmd.Parameters.AddWithValue("@fecha", dt);
                        cmd.Parameters.AddWithValue("@debito", tbdebe.Text);
                        cmd.Parameters.AddWithValue("@credito", tbhaber.Text);
                        conect.access.Open();
                        cmd.ExecuteNonQuery();
                        conect.access.Close();
                    }
                }

                MessageBox.Show("Los registros se han modificado correctamente.", "¡Guardado exitoso!");
                padre.Llenartabla();
                this.Close();
            }catch { MessageBox.Show("Ha ocurrido un problema al momento de guardar la información del formulario.", "¡Aviso!"); }
        }

        private void tbfecha_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime.ParseExact(tbfecha.Text, "dd/MM/yyyy", null);
                if (tbfecha.Text.Length != 10)
                {
                    MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                    tbfecha.Focus();
                    btnguardar.Enabled = false;

                }
                else
                {
                    btnguardar.Enabled = true;
                }

            }
            catch
            {
                MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                btnguardar.Enabled = true;
                var f = fecha.ToString("dd/MM/yyyy");
                tbfecha.Text = f;
            }
        }

        private void tbdebe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbhaber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbncheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void tbncuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
