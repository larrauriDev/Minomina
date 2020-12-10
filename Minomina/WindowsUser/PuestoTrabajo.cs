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
using Minomina.Helpers;

namespace Minomina.WindowsUser
{
    public partial class PuestoTrabajo : Form,IPuesto
    {
        string IPuesto.SALARIO { get => tbSalario.Text; set => tbSalario.Text = value; }
        string IPuesto.NOMBRE { get => tbPuesto.Text; set => tbPuesto.Text = value; }
        string IPuesto.CANTIDAD { get => tbCantidadpuesto.Text; set => tbCantidadpuesto.Text = value; }
        string IPuesto.FRESALARIO { get => cbFrecueciaSalario.Text; set => cbFrecueciaSalario.Text = value; }
        string IPuesto.PAGOSHORAS { get => tbPagoHoras.Text; set => tbPagoHoras.Text = value; }
        int IPuesto.RECIDDEPARTAMENTO { get => int.Parse(cbDepartamento.SelectedValue.ToString()); set => cbDepartamento.SelectedValue = value; }
        string IPuesto.DEBERES { get => tbDeberes.Text; set => tbDeberes.Text = value; }
        string IPuesto.IDPUESTO { get => tbID.Text; set => tbID.Text = value; }
        public PuestoTrabajo()
        {
            InitializeComponent();
            PPuesto pue = new PPuesto(this);
            pue.FillComboDepar(cbDepartamento);
            pue.CompletaDatagrid(dataGridPuesto);
        }

        private void btAgregarPuesto_MouseEnter(object sender, EventArgs e)
        {
            btAgregarPuesto.BackgroundImage = Properties.Resources.IconoCreapuestoRojo;
        }

        private void btAgregarPuesto_MouseLeave(object sender, EventArgs e)
        {
            btAgregarPuesto.BackgroundImage = Properties.Resources.IconoCreapuestoColor;
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

        private void btNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btMaximizar.Visible = true;
            btNormal.Visible = false;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
           
            PPuesto puesto = new PPuesto(this);

            //puesto.InsertaPuesto(PuestoTrabajo.ActiveForm);
            puesto.InsertarActualizar(PuestoTrabajo.ActiveForm, dataGridPuesto, tbID,time,lbcreado);
        }

        private void tbSalario_Leave(object sender, EventArgs e)
        {
            PPuesto puesto = new PPuesto(this);
            puesto.CalculoHorasSalario();
        }

        private void tbSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            PPuesto pues = new PPuesto(this);

            pues.ValidaDataType(sender, e);
        }

        private void tbCantidadpuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            PPuesto pues = new PPuesto(this);

            pues.ValidaDataType(sender, e);

        }

        private void dataGridPuesto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;
            tbPuesto.Text = dataGridPuesto.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbPagoHoras.Text = dataGridPuesto.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbSalario.Text = dataGridPuesto.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbDeberes.Text = dataGridPuesto.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbFrecueciaSalario.Text = dataGridPuesto.Rows[e.RowIndex].Cells[7].Value.ToString();
            tbCantidadpuesto.Text = dataGridPuesto.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbDepartamento.Text = dataGridPuesto.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbID.Text = dataGridPuesto.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            PPuesto puesto = new PPuesto(this);
            puesto.BuscarPuesto(dataGridPuesto);
            time.Start();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            HelperForms.ClearControllers(PuestoTrabajo.ActiveForm);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            lbcreado.Visible = false;
            time.Stop();
        }
    }
}
