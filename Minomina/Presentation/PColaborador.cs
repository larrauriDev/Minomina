using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minomina.Views;
using Minomina.Models;
using Minomina.Helpers;

namespace Minomina.Presentation
{
    class PColaborador
    {
        private IColaboradores iCola;
        MColaborador mCola = new MColaborador();
        public PColaborador() { }
        public PColaborador(IColaboradores icola) {

            iCola = icola;
        }
        public void ConnectionModel()
        {
            mCola.APELLIDO = iCola.APELLIDO;
            mCola.BANCO = iCola.BANCO;
            mCola.CODIGOEMPLEADO = iCola.CODIGOEMPLEADO;
            mCola.CEDULA = iCola.CEDULA;
            mCola.CUENTABANCO = iCola.CUENTABANCO;
            mCola.DIRECCION = iCola.DIRECCION;
            mCola.ESTADOLABORAR = iCola.ESTADOLABORAR;
            mCola.FECHAINGRESO = DateTime.Parse(iCola.FECHAINGRESO);
            mCola.MAIL = iCola.MAIL;
            mCola.NOMBRE = iCola.NOMBRE;
            mCola.PUESTOTRABAJO = iCola.IDPUESTOTRABAJO;
            mCola.SEXO = iCola.SEXO;
            mCola.TELEFONO = iCola.TELEFONO;
            mCola.TIPOCUENTA = iCola.TIPOCUENTA;
            mCola.USUARIO = iCola.USUARIO;

        }
        public void InsertaColaborador(Form colaForms,Timer timer, Label lbcreado,Label lbaviso,GroupBox gb)
        {
            if (HelperForms.CheckEmpy(colaForms))
                return;
            

            ConnectionModel();
            
            mCola.InsertColaborador();
            
            HelperForms.ClearGroupBox(gb);
            HelperForms.ClearControllers(colaForms);
            lbaviso.Visible = false;
            lbcreado.Visible = true;
            timer.Start();



        }
        public void EventosBotonCrear(Form colaForms, GroupBox gb, Label lbAviso, TextBox tb) {

            HelperForms.ClearGroupBox(gb);
            HelperForms.ClearControllers(colaForms);
            lbAviso.Visible = true;
            tb.Enabled = false;

        }
        public void ActulizaColaborador(Form cola) {

            if (HelperForms.CheckEmpy(cola))
            {
                return;
            }
            
            ConnectionModel();
            

            if (mCola.ExisteID() <= 0)
            {
                MessageBox.Show("No hay registro para actualizar", "Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            mCola.UpdateDatosColaboradores();
        }
        public void FillDataGrid(DataGridView dtg) {

            mCola.FillDataGridcolaborador(dtg);

        }
        public void FillComboPueso(ComboBox cbpuesto)
        {
            mCola.FillPuestoTrabajo(cbpuesto);

        }
        public void ValidaDataType(object sender, KeyPressEventArgs e)
        {
            HelperForms.ValidaDatos(e, sender);

        }
        public void InsertarActualizar(Form pt, DataGridView dtg,TextBox tb, Timer time, Label lbcrado,Label lbaviso, GroupBox gb)
        {
            if (tb.Text == "" && !tb.Enabled)
            {
                InsertaColaborador(pt, time, lbcrado,lbaviso, gb);
            }
            else
                ActulizaColaborador(pt);

            FillDataGrid(dtg);
            HelperForms.ClearControllers(pt);


        }
        public void LimpiarControles(Form forcola,GroupBox gb, TextBox tbid, Label lbaviso) {

            HelperForms.ClearControllers(forcola);
            HelperForms.ClearGroupBox(gb);

            tbid.Enabled = true;
            lbaviso.Visible = false;    
        
        }
        public void BuscarEmpleado(DataGridView data)
        {
            mCola.NOMBRE = iCola.NOMBRE;
            mCola.CODIGOEMPLEADO = iCola.CODIGOEMPLEADO;
            mCola.BuscaColaborador(data);
        }
        public void BorrarColaborador(DataGridView dtg,Form form,GroupBox gb) {
            mCola.CODIGOEMPLEADO = iCola.CODIGOEMPLEADO;
            mCola.DeleteColaborador();
            FillDataGrid(dtg);
            HelperForms.ClearControllers(form);
            HelperForms.ClearGroupBox(gb);
            
        }


    }
}
