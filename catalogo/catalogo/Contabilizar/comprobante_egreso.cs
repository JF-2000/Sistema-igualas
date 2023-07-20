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
using System.Drawing.Printing;
using System.Drawing;
using System.Runtime.InteropServices;

namespace catalogo
{
    public partial class comprobante_egreso : Form
    {
        public comprobante_egreso()
        {
            InitializeComponent();
        }

        conexion conect = new conexion();
        private int egreso;
        private int numegreso;
        private string compfecha;
        private int colum;
        private int cell;
        DateTime hoy = DateTime.Now;

        //  #Tabla de selección del catálogo de cuentas.
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

        //  #Asignación de egreso
        private void asig_egreso()
        {
            try
            {
                string dateStr = tbfecha.Text;
                string[] Ldate = dateStr.Split('/');
                dateStr = Ldate[1] + "/" + Ldate[0] + "/" + Ldate[2];
                DateTime dt = Convert.ToDateTime(dateStr);

                var consulta = "select MAX(egreso)egreso, MAX(fecha)fecha from comp_egresos where YEAR(fecha) = YEAR(GETDATE())";
                using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                {
                    conect.access.Open();
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (string.IsNullOrEmpty(reader["egreso"].ToString()))
                        {
                            egreso = 1;
                            tbegreso.Text = "CEG" + Convert.ToString(egreso);
                            numegreso = 1;
                            tbnumegreso.Text = Convert.ToString(numegreso);
                            conect.access.Close();
                            return;
                        }
                        else
                        {
                            egreso = Convert.ToInt32(reader["egreso"]);
                            compfecha = reader["fecha"].ToString();
                        }

                    }
                    conect.access.Close();
                }

                DateTime date = DateTime.Parse(compfecha);
                if (dt == date)
                {
                    var verif = "select MAX(egreso)egreso, MAX(negreso)negreso from comp_egresos where fecha = @fecha";
                    using (SqlCommand cmd2 = new SqlCommand(verif, conect.access))
                    {
                        conect.access.Open();
                        cmd2.Parameters.AddWithValue("@fecha", date);
                        var reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            egreso = Convert.ToInt32(reader["egreso"]);
                            numegreso = Convert.ToInt32(reader["negreso"]);
                        }
                        conect.access.Close();

                        tbegreso.Text = "CEG" + Convert.ToString(egreso);
                        numegreso += 1;
                        tbnumegreso.Text = Convert.ToString(numegreso);
                    }
                }
                else if (dt < date)
                {
                    var verif = "select MAX(egreso)egreso, MAX(negreso)negreso from comp_egresos where fecha = @fecha";
                    using (SqlCommand cmd2 = new SqlCommand(verif, conect.access))
                    {
                        cmd2.Parameters.AddWithValue("@fecha", dt);

                        conect.access.Open();
                        var reader = cmd2.ExecuteReader();
                        while (reader.Read())
                        {
                            if (string.IsNullOrEmpty(reader["egreso"].ToString()))
                            {
                                egreso += 1;
                                tbegreso.Text = "CEG" + Convert.ToString(egreso);
                                numegreso = 1;
                                tbnumegreso.Text = Convert.ToString(numegreso);
                            }
                            else
                            {
                                egreso = Convert.ToInt32(reader["egreso"]);
                                numegreso = Convert.ToInt32(reader["negreso"]);

                                tbegreso.Text = "CEG" + Convert.ToString(egreso);
                                numegreso += 1;
                                tbnumegreso.Text = Convert.ToString(numegreso);
                            }
                        }
                        conect.access.Close();
                    }
                }
                else
                {
                    egreso += 1;
                    tbegreso.Text = "CEG" + Convert.ToString(egreso);
                    numegreso = 1;
                    tbnumegreso.Text = Convert.ToString(numegreso);
                }
            }
            catch
            {
                MessageBox.Show("¡Ha ocurrido un problema en la asignación de asiento!", "¡Ocurrio un problema!");
            }
        }

        //  #Control de fecha
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
                    asig_egreso();
                }

            }
            catch
            {
                MessageBox.Show("Introduzca la fecha en el formato correcto, ejemplo: 28/01/2000");
                btnguardar.Enabled = true;
                var fecha = hoy.ToString("dd/MM/yyyy");
                tbfecha.Text = fecha;
                asig_egreso();
            }

        }

        private void diario_Load(object sender, EventArgs e)
        {
            var fecha = hoy.ToString("dd/MM/yyyy");
            tbfecha.Text = fecha;
            asig_egreso();
        }

        //  #Obtiene la cuenta seleccionada.
        private void griddiario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (griddiario.Columns[e.ColumnIndex].Index == 0)
                {
                    colum = griddiario.Columns[e.ColumnIndex].Index;
                    cell = griddiario.Rows[e.RowIndex].Index;
                    Llenartabla();
                }
            }
            catch { }
        }

        //  #Filtro de la tabla del catalogo de cuentas
        private void filtro_TextChanged(object sender, EventArgs e)
        {
            string filterField = "cuenta";
            ((DataTable)gridcuenta.DataSource).DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, filtro.Text);
        }

        private void gridcuenta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridcuenta.SelectedCells[0].Value != null && gridcuenta.SelectedCells[2].Value.ToString() == "AUX")
            {
                griddiario.Rows[cell].Cells[colum].Value = gridcuenta.SelectedCells[0].Value.ToString();
                griddiario.Rows[cell].Cells[colum + 1].Value = gridcuenta.SelectedCells[1].Value.ToString();
            }
            else if (gridcuenta.SelectedCells[2].Value.ToString() != "AUX")
            {
                MessageBox.Show("Por favor seleccione una cuenta auxiliar.");
            }
            else
            {
                MessageBox.Show("Por favor seleccione un registro valido.");
            }
        }

        //  #Boton de guardado
        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                if(tbtotaldebito.Text != tbtotalcredito.Text){
                    MessageBox.Show("Existen un descuadre entre el total debito y total crédito, por favor verificar los datos ingresados.", "¡Debido y crédito descuadrados!");
                    return;
                }
                var verif = "select * from comp_egresos where egreso = @egreso and negreso = @negreso";
                using (SqlCommand cmd2 = new SqlCommand(verif, conect.access))
                {
                    cmd2.Parameters.AddWithValue("@egreso", egreso);
                    cmd2.Parameters.AddWithValue("@negreso", numegreso);
                    conect.access.Open();
                    var reader = cmd2.ExecuteReader();
                    if (reader.Read()==false)
                    {
                        conect.access.Close();

                        string date = tbfecha.Text;
                        string[] Ldate = date.Split('/');
                        date = Ldate[1] + "/" + Ldate[0] + "/" + Ldate[2];
                        DateTime dt = Convert.ToDateTime(date);

                        string consulta = "insert into comp_egresos (egreso, negreso, codigo_cuenta, fecha, debito, credito, detalles, concepto, beneficiario, ncuenta, ncheque) values (@egreso, @negreso, @codigo_cuenta, @fecha, @debito, @credito, @detalles, @concepto, @beneficiario, @ncuenta, @ncheque)";
                        using (SqlCommand cmd = new SqlCommand(consulta, conect.access))
                        {
                            conect.access.Open();
                            var cantrow = griddiario.Rows;
                            if (cantrow.Count <= 1) { MessageBox.Show("No existen movimientos los cuales guardar.", "Error la tabla esta vacía."); return; }
                            foreach (DataGridViewRow row in griddiario.Rows)
                            {
                                int err = 0;
                                cmd.Parameters.Clear();

                                if (row.IsNewRow) continue;

                                cmd.Parameters.AddWithValue("@egreso", egreso);
                                cmd.Parameters.AddWithValue("@negreso", numegreso);
                                cmd.Parameters.AddWithValue("@fecha", dt);

                                if (row.Cells["Debito"].Value == null)
                                {
                                    cmd.Parameters.AddWithValue("@debito", 0);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@debito", row.Cells["Debito"].Value);
                                }
                                if (row.Cells["Credito"].Value == null)
                                {
                                    cmd.Parameters.AddWithValue("@credito", 0);
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@credito", row.Cells["Credito"].Value);
                                }
                                if (row.Cells["Detalles"].Value == null)
                                {
                                    cmd.Parameters.AddWithValue("@detalles", "Sin detalle registrado");
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@detalles", row.Cells["Detalles"].Value);
                                }
                                if (row.Cells["Cuenta"].Value == null)
                                {
                                    err += 1;
                                    MessageBox.Show("Favor seleccionar o introduccir una cuenta del catalogo, antes de guardar.", "¡Aviso!");
                                    return;
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@codigo_cuenta", row.Cells["Cuenta"].Value);
                                }
                                if (String.IsNullOrWhiteSpace(tbconcepto.Text))
                                {
                                    err += 1;
                                    MessageBox.Show("Favor ingresar un concepto, antes de guardar.");
                                    return;
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@concepto", tbconcepto.Text);
                                }
                                if (String.IsNullOrWhiteSpace(tbbeneficiario.Text))
                                {
                                    err += 1;
                                    MessageBox.Show("Favor ingresar el beneficiario, antes de guardar.");
                                    return;
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@beneficiario", tbbeneficiario.Text);
                                }
                                if (String.IsNullOrWhiteSpace(tbnumcuenta.Text))
                                {
                                    err += 1;
                                    MessageBox.Show("Favor ingresar el número de cuenta, antes de guardar.");
                                    return;
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ncuenta", tbnumcuenta.Text);
                                }
                                if (String.IsNullOrWhiteSpace(tbnumcheque.Text))
                                {
                                    err += 1;
                                    MessageBox.Show("Favor ingresar el número de cheque, antes de guardar.");
                                    return;
                                }
                                else
                                {
                                    cmd.Parameters.AddWithValue("@ncheque", tbnumcheque.Text);
                                }

                                if (err == 0)
                                {
                                    cmd.ExecuteNonQuery();
                                }
                            }
                            MessageBox.Show("Todos los registros se han guardado correctamente.", "¡Guardado con exito!");

                        }
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema, el número de egreso ya está registrado en la base de datos, por favor presione el boton de nuevo para seguir registrando.", "¡Ocurrio un problema!");
                    }
                    
                }

               
            }
            catch (Exception f)
            {
                MessageBox.Show("Ocurrio un problema al guardar los datos." + f.Message.ToString());
            }
            finally
            {
                conect.access.Close();
            }

        }

        //  #Control de los totales.
        private void griddiario_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            sum_totals();
        }

        private void sum_totals()
        {
            double totaldebit = 0;
            double totalcredit = 0;

            try
            {
                foreach (DataGridViewRow row in griddiario.Rows)
                {
                    if (row.Cells[2].Value != null)
                    {
                        totaldebit += Convert.ToDouble(row.Cells[2].Value);
                    }

                    if (row.Cells[3].Value != null)
                    {
                        totalcredit += Convert.ToDouble(row.Cells[3].Value);
                    }

                }

                tbtotaldebito.Text = string.Format("{0:C2}", totaldebit);
                tbtotalcredito.Text = string.Format("{0:C2}", totalcredit);
            }
            catch
            {
                MessageBox.Show("¡Ocurrio un problema con la suma de los totales, por favor verifique los valores en las columna de Debito y Credito!");
            }

        }

        private void griddiario_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            string v = Convert.ToString(griddiario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (griddiario.Columns[e.ColumnIndex].Index == 2 || griddiario.Columns[e.ColumnIndex].Index == 3)
            {
                if (v.Length <= 0)
                {
                    griddiario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
                else
                {
                    sum_totals();
                }
            }
        }

        private void griddiario_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string v = Convert.ToString(griddiario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            if (griddiario.Columns[e.ColumnIndex].Index == 2 || griddiario.Columns[e.ColumnIndex].Index == 3)
            {
                if (v.Length <= 0)
                {
                    griddiario.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
                else
                {
                    sum_totals();
                }
            }
        }

        //  #Boton cerrar app.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  #Boton minimizar app.
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

        //  #Boton Nuevo.
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            comprobante_egreso fegreso = new comprobante_egreso();
            fegreso.Show();

            this.Close();
        }

    }
}
