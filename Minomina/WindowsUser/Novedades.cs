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
using Minomina.IViews;
using Minomina.Presentation;

namespace Minomina.WindowsUser
{
    public partial class Novedades : Form, INovedades
    {
        public string IDNOVEDADES { get => tbID.Text; set => tbID.Text = value; }
        public string NOMBRE { get => tbNombre.Text; set => tbNombre.Text = value; }
        public string TIPO { get => cbTipoNovedad.Text; set => cbTipoNovedad.Text = value; }
        public bool IMPUESTO { get => ckImpuesto.Checked; set => ckImpuesto.Checked = value; }

        public Novedades()
        {
            InitializeComponent();
            PNovedades nove = new PNovedades(this);
            nove.FillGrid(dataGridNovedad);
        }

        private void CerrarApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btMaximizar.Visible = false;
                btNormal.Visible = true;
            }
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btMaximizar.Visible = true;
            btNormal.Visible = false;
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int IParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btAgregarNovedad_MouseDown(object sender, MouseEventArgs e)
        {
            btAgregarNovedad.BackgroundImage = Properties.Resources.IconocreanoveDentro;
        }

        private void btAgregarNovedad_MouseUp(object sender, MouseEventArgs e)
        {
            btAgregarNovedad.BackgroundImage = Properties.Resources.IconoCreaNoveAfuera;
        }

        private void dataGridNovedad_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            tbID.Text = dataGridNovedad.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNombre.Text = dataGridNovedad.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbTipoNovedad.Text = dataGridNovedad.Rows[e.RowIndex].Cells[2].Value.ToString();
            if (dataGridNovedad.Rows[e.RowIndex].Cells[3].Value is true)
                ckImpuesto.Checked = true;
            else
                ckImpuesto.Checked = false;
        }

        private void btAgregarNovedad_Click(object sender, EventArgs e)
        {
            tbID.Enabled = false;
            lbAviso.Visible = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            PNovedades nove = new PNovedades(this);
            nove.InsertaActualiza(dataGridNovedad, lbAviso, tbID, Novedades.ActiveForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PNovedades nove = new PNovedades(this);
            nove.DeleteNove(Novedades.ActiveForm, dataGridNovedad);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            PNovedades nove = new PNovedades();
            nove.LimpiarControles(Novedades.ActiveForm);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            PNovedades nove = new PNovedades(this);
            nove.BuscaFillData(dataGridNovedad);
        }
    }
}
