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
    public partial class PuestoTrabajo : Form,IPuesto
    {
        string IPuesto.SALARIO { get => tbSalario.Text; set => tbSalario.Text = value; }
        string IPuesto.NOMBRE { get => tbPuesto.Text; set => tbPuesto.Text = value; }
        string IPuesto.CANTIDAD { get => tbCantidadpuesto.Text; set => tbCantidadpuesto.Text = value; }
        string IPuesto.FRESALARIO { get => cbFrecueciaSalario.Text; set => cbFrecueciaSalario.Text = value; }
        string IPuesto.PAGOSHORAS { get => tbPagoHoras.Text; set => tbPagoHoras.Text = value; }
        string IPuesto.RECIDDEPARTAMENTO { get => cbDepartamento.SelectedValue.ToString(); set => cbDepartamento.SelectedValue = value; }
        string IPuesto.DEBERES { get => tbDeberes.Text; set => tbDeberes.Text = value; }
        string IPuesto.IDPUESTO { get => tbID.Text; set => tbID.Text = value; }

        public PuestoTrabajo()
        {
            InitializeComponent();
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

            puesto.InsertaPuesto(PuestoTrabajo.ActiveForm);
        }

        private void tbSalario_Leave(object sender, EventArgs e)
        {
            PPuesto puesto = new PPuesto(this);
            puesto.CalculoHorasSalario();
        }
    }
}
