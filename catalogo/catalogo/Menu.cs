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
using catalogo.Reportes;

namespace catalogo
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
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

        private void Pbarratitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_diario_Click(object sender, EventArgs e)
        {
            asiento_diario formu = new asiento_diario();
            formu.Show();
            this.Close();
        }

        private void btn_ingreso_Click(object sender, EventArgs e)
        {
            comprobante_ingreso formu = new comprobante_ingreso();
            formu.Show();
            this.Close();
        }

        private void btn_egreso_Click(object sender, EventArgs e)
        {
            comprobante_egreso formu = new comprobante_egreso();
            formu.Show();
            this.Close();
        }

        private void btn_nd_Click(object sender, EventArgs e)
        {
            nota_debito formu = new nota_debito();
            formu.Show();
            this.Close();
        }

        private void btn_nc_Click(object sender, EventArgs e)
        {
            nota_credito formu = new nota_credito();
            formu.Show();
            this.Close();
        }

        private void btn_catalogo_Click(object sender, EventArgs e)
        {
            Catalogo_cuentas formu = new Catalogo_cuentas();
            formu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diario formu = new Diario();
            formu.Show();
            this.Close();
        }
    }
}
