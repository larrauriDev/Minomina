using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minomina.IViews;
using Minomina.Models;
using Minomina.Helpers;
using System.Windows.Forms;

namespace Minomina.Presentation
{
    class PPuesto
    {
        IPuesto ipuesto;
        MPuesto mPuesto = new MPuesto();

        public PPuesto(IPuesto view) {

            ipuesto = view;
        
        }
        public void ConnectionModelPuesto() {

            mPuesto.FRESALARIO = ipuesto.FRESALARIO;
            mPuesto.CANTIDAD = int.Parse(ipuesto.CANTIDAD);
            mPuesto.RECIDDEPARTAMENTO = Convert.ToInt32(ipuesto.RECIDDEPARTAMENTO);
            mPuesto.NOMBRE = ipuesto.NOMBRE;
            mPuesto.PAGOSHORAS = float.Parse(ipuesto.PAGOSHORAS);
            mPuesto.SALARIO = float.Parse(ipuesto.SALARIO);
            mPuesto.DEBERES = ipuesto.DEBERES;
            mPuesto.IDPUESTO = ipuesto.IDPUESTO;
        }
        public void InsertaPuesto(Form pt,Timer time,Label lb) {

            if (HelperForms.CheckEmpy(pt))
                return;

            ConnectionModelPuesto();
            mPuesto.InsertarPuesto();
            HelperForms.ClearControllers(pt);
            lb.Visible = true;
            time.Start();
        }
        public void UpdateData(Form pt) {

            
            if (HelperForms.CheckEmpy(pt))
            {
                return;
            }

            ConnectionModelPuesto();

            if (mPuesto.ExisteID()<=0)
            {
                MessageBox.Show("No hay registro para actualizar", "Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ConnectionModelPuesto();
            mPuesto.UpdateData();
        }
        public void InsertarActualizar(Form pt, DataGridView dtg, TextBox tb, Timer time,Label lb) {
            if (tb.Text == "")
            {
                InsertaPuesto(pt,time,lb);
            }
            else
                UpdateData(pt);

            CompletaDatagrid(dtg);
            HelperForms.ClearControllers(pt);


        }
        public void CalculoHorasSalario()
        {
            float ordinario = float.Parse(ipuesto.SALARIO) / 23.84f;
            ipuesto.PAGOSHORAS = (ordinario / (int)8).ToString();

        }
        public void FillComboDepar(ComboBox cb) {
            cb = mPuesto.FillComboDepartamento(cb);
        
        }
        public void ValidaDataType(object sender, KeyPressEventArgs e) {
            HelperForms.ValidaDatos(e, sender);
        
        }
        public void CompletaDatagrid(DataGridView dtg)
        {
            mPuesto.FillDataGrid(dtg);

        }
        public void BuscarPuesto(DataGridView dtg) {
            mPuesto.IDPUESTO = ipuesto.IDPUESTO;
            mPuesto.BuscarPuesto(dtg);
            
        
        }
    }

}
