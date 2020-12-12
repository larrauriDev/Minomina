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

        public AsignacionNovedades()
        {
            InitializeComponent();
            PAsignacionNovedad asig = new PAsignacionNovedad(this);
            asig.FillComboColaborador(cbListaColaborador);
            asig.CompletaGridHeader(dataGridEmpleado);
            
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
            dataGridNovedad.Rows[0].Cells[0].Value = dataGridEmpleado.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void btAgregarNovedad_Click(object sender, EventArgs e)
        {
            
        }
    }
}
