using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minomina.IViews;
using Minomina.Presentation;
using System.Runtime.InteropServices;
namespace Minomina.WindowsUser
{
    public partial class AsignacionNovedades : Form, IAsignacionesNovedad
    {
        public int RECIDTABLEHEADER { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IDREGISTROHEADER { get => int.Parse(cbListaColaborador.SelectedValue.ToString()); set => cbListaColaborador.SelectedValue = value; }
        //public string CODIGOEMPLEADO { get => cbListaColaborador.SelectedItem.ToString(); set => cbListaColaborador.SelectedItem = value; }
        public int RECIDCOLABORADOR { get => int.Parse(cbListaColaborador.SelectedValue.ToString()); set => cbListaColaborador.SelectedValue = value; }
        public string NOMBRECOLABORADOR { get => tbNombre.Text; set => tbNombre.Text = value; }
        public float? TOTALHEADER { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RECIDTABLEDETAILS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RECIDHEADER { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string IDASIGNACION { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int RECIDNOVEDAD { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string DESCRIPCIONNOVEDAD { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float MOTODETAILS { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FECHADESDE { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime FECHAHASTA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string TIPONOVEDAD { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int curretIndex = 0;
        int indexRow = 0;
        DateTimePicker dtp;
        DateTimePicker dtp2;
        public AsignacionNovedades()
        {
            InitializeComponent();
            PAsignacionNovedad asig = new PAsignacionNovedad(this);
            asig.FillComboColaborador(cbListaColaborador);
            asig.CompletaGridHeader(dataGridEmpleado);
            asig.FillComboDatagrid(cbGridNovedad);
            asig.FillDataGridDetails(dataGridNovedad);


        }

        private void btCierre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btRestaurar.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            button1.Visible = false;
            btRestaurar.Visible = true;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btAgregarNovedad_MouseDown(object sender, MouseEventArgs e)
        {
            btAgregarNovedad.BackgroundImage = Properties.Resources.AgregarNovedadDentro;
        }

        private void btAgregarNovedad_MouseUp(object sender, MouseEventArgs e)
        {
            btAgregarNovedad.BackgroundImage = Properties.Resources.AgregarNovedadFuera;
        }

        private void cbListaColaborador_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PAsignacionNovedad asig = new PAsignacionNovedad(this);
            asig.NombreApellido(tbNombre, cbListaColaborador);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            PAsignacionNovedad asig = new PAsignacionNovedad(this);
            asig.InsertaAsigHeader(dataGridEmpleado);
        }

        private void dataGridEmpleado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (dataGridNovedad.Rows.Count > 0)
            {
                dataGridNovedad.Rows[curretIndex].Cells[0].Value = dataGridEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                dataGridNovedad.Rows[curretIndex].Cells[7].Value = dataGridEmpleado.Rows[e.RowIndex].Cells[0].Value;
            }
            
        }

        private void btAgregarNovedad_Click(object sender, EventArgs e)
        {
            
          

            dataGridNovedad.Rows.Add();
            int index = dataGridNovedad.Rows.Count;
            /*  if (index > 1)
              {
                  dataGridNovedad.Rows[index].Cells[0].Value = dataGridNovedad.Rows[index-1].Cells[0].Value;
                  dataGridNovedad.Rows[index].Cells[7].Value = dataGridNovedad.Rows[index-1].Cells[7].Value;
              }*/


        }

        private void dataGridNovedad_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
     
            try
            {
                PAsignacionNovedad asi = new PAsignacionNovedad(this);
                if (e.ColumnIndex == 1)
                    if (dataGridNovedad.Rows[e.RowIndex].Index != -1)
                        asi.CompleteDesNoverdad(dataGridNovedad.Rows[e.RowIndex]);
            }
            catch (Exception)
            {

               
            }
        }

        private void DTPTextChange(object sender, EventArgs e) {

            if (dataGridNovedad.Rows[indexRow].Cells[4].Value != null) {

                dataGridNovedad.Rows[indexRow].Cells[4].Value = dtp.Text.ToString();

            }
            dataGridNovedad.Rows[indexRow].Cells[4].Value = dtp.Text.ToString();

        }
        private void DPClose(object sender, EventArgs e) {
        
            dtp.Visible = false;
        }
        private void DTPTextChange2(object sender, EventArgs e)
        {

            dataGridNovedad.Rows[indexRow].Cells[5].Value = dtp2.Text.ToString();
        }
        private void DPClose2(object sender, EventArgs e)
        {
  
            dtp2.Visible = false;
        }
        private void dataGridNovedad_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            curretIndex = dataGridNovedad.Rows[e.RowIndex].Index;

           
            if (e.RowIndex != -1 && (e.ColumnIndex == 4)) {
                dtp = new DateTimePicker();
                dataGridNovedad.Controls.Add(dtp);
                dtp.Format = DateTimePickerFormat.Custom;
                dtp.CustomFormat = @"dd/MM/yyyy";
                Rectangle displaycalendar = dataGridNovedad.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp.Size = new Size(displaycalendar.Width, displaycalendar.Height);
                dtp.Location = new Point(displaycalendar.X, displaycalendar.Y);

                indexRow = dataGridNovedad.Rows[e.RowIndex].Index;
                dtp.TextChanged += new EventHandler(DTPTextChange);
                dtp.CloseUp += new EventHandler(DPClose);
                
            }
            if (e.RowIndex != -1 && (e.ColumnIndex == 5 && dtp != null))
            {
                dtp2 = new DateTimePicker();
                dataGridNovedad.Controls.Add(dtp2);
                dtp2.Format = DateTimePickerFormat.Custom;
                dtp2.CustomFormat = @"dd/MM/yyyy";
                Rectangle displaycalendar = dataGridNovedad.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtp2.Size = new Size(displaycalendar.Width, displaycalendar.Height);
                dtp2.Location = new Point(displaycalendar.X, displaycalendar.Y);

                
                
                indexRow = dataGridNovedad.Rows[e.RowIndex].Index;
                dtp2.TextChanged += new EventHandler(DTPTextChange2);
                dtp2.CloseUp += new EventHandler(DPClose2);
            }

        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int IParam);
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            PAsignacionNovedad asi = new PAsignacionNovedad(this);
            asi.InsertaDetalleNovedad(dataGridNovedad,dataGridEmpleado);
        }

        private void btCopy_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAsignacionNovedad nove = new PAsignacionNovedad(this);
            nove.DeleteRow(dataGridNovedad.CurrentRow,dataGridNovedad,dataGridEmpleado);
            dataGridNovedad.Rows.Remove(dataGridNovedad.CurrentRow);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
