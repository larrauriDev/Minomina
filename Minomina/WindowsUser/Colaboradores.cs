using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Minomina.Helpers;
using Minomina.Views;
using Minomina.Presentation;


namespace Minomina.WindowsUser
{
    public partial class Colaboradores : Form, IColaboradores
    {
        int IColaboradores.IDPUESTOTRABAJO { get => int.Parse(cbPuesto.SelectedValue.ToString()); set =>  cbPuesto.SelectedValue = value; }
        string IColaboradores.CODIGOEMPLEADO { get => tbID.Text; set => tbID.Text = value; }
        string IColaboradores.FECHAINGRESO { get => dtpFechaIngreso.Text; set => dtpFechaIngreso.Text = value; }
        string IColaboradores.ESTADOLABORAR { get => cbEstado.Text; set => cbEstado.Text = value; }
        string IColaboradores.NOMBRE { get => tbNombre.Text; set => tbNombre.Text = value; }
        string IColaboradores.CEDULA { get => tbCedula.Text; set => tbCedula.Text = value; }
        string IColaboradores.APELLIDO { get => tbApellido.Text; set => tbApellido.Text = value; }
        string IColaboradores.SEXO { get => cbSexo.Text; set => cbSexo.Text = value; }
        string IColaboradores.DIRECCION { get => tbDireccion.Text; set => tbDireccion.Text = value; }
        string IColaboradores.MAIL { get => tbMail.Text; set => tbMail.Text = value; }
        string IColaboradores.TELEFONO { get => tbTele.Text; set => tbTele.Text = value; }
        string IColaboradores.CUENTABANCO { get => tbCuentabancaria.Text; set => tbCuentabancaria.Text = value; }
        string IColaboradores.TIPOCUENTA { get => cbTipoCuenta.Text; set => cbTipoCuenta.Text = value; }
        string IColaboradores.BANCO { get => tbBanco.Text; set => tbBanco.Text = value; }
        bool IColaboradores.USUARIO { get => ckUsuario.Checked; set => ckUsuario.Checked = value; }
        
        public Colaboradores()
        {
            InitializeComponent();
            PColaborador cola = new PColaborador(this);
            cola.FillComboPueso(cbPuesto);
            cola.FillDataGrid(dataGridColaboradores);


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

        private void btAgregarColaborador_MouseEnter(object sender, EventArgs e)
        {
            btAgregarColaborador.BackgroundImage = Properties.Resources.IconoagregarColaboradorClaro;
        }

        private void btAgregarColaborador_MouseLeave(object sender, EventArgs e)
        {
            btAgregarColaborador.BackgroundImage = Properties.Resources.IconoAgregarColaboradorColor;
        }

        private void btAgregarColaborador_Click(object sender, EventArgs e)
        {

            PColaborador cola = new PColaborador(this);
            cola.EventosBotonCrear(Colaboradores.ActiveForm, groupBox1, lbAviso, tbID);
        }

        private void time_Tick(object sender, EventArgs e)
        {
            lbcreado.Visible = false;
            time.Stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PColaborador cola = new PColaborador(this);
            cola.InsertarActualizar(Colaboradores.ActiveForm, dataGridColaboradores, tbID, time, lbcreado,lbAviso, groupBox1);
        }

        private void dataGridColaboradores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbID.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbNombre.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbApellido.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpFechaIngreso.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbPuesto.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[4].Value.ToString();
            tbTele.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[5].Value.ToString();
            tbMail.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbSexo.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[7].Value.ToString();
            cbTipoCuenta.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[8].Value.ToString();
            tbCuentabancaria.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[9].Value.ToString();
            tbCedula.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[10].Value.ToString();
            tbDireccion.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[11].Value.ToString();
            tbBanco.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[12].Value.ToString();
            cbEstado.Text = dataGridColaboradores.Rows[e.RowIndex].Cells[13].Value.ToString();
            if (dataGridColaboradores.Rows[e.RowIndex].Cells[14].Value is true)
                ckUsuario.Checked = true;
            else
                ckUsuario.Checked = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            PColaborador cola = new PColaborador();
            cola.LimpiarControles(Colaboradores.ActiveForm,groupBox1,tbID, lbAviso);;
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            PColaborador cola = new PColaborador(this);
            cola.BuscarEmpleado(dataGridColaboradores);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            PColaborador cola = new PColaborador(this);
            cola.BorrarColaborador(dataGridColaboradores,Colaboradores.ActiveForm,groupBox1);
            
        }
    }
}
