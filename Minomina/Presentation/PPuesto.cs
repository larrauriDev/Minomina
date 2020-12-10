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
        }
        public void InsertaPuesto(Form pt) {

            

            if (HelperForms.CheckEmpy(pt))
                return;
            ConnectionModelPuesto();
            mPuesto.InsertarPuesto();
        }
        public void UpdateData(Form pt) {

            ConnectionModelPuesto();
            if (HelperForms.CheckEmpy(pt))
            {
                return;
            }
            if (ipuesto.IDPUESTO == "")
            {
                MessageBox.Show("No hay registro para actualizar", "Ingresar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            mPuesto.UpdateData();
        }
        public void CalculoHorasSalario()
        {
            float ordinario = float.Parse(ipuesto.SALARIO) / 23.84f;
            ipuesto.PAGOSHORAS = (ordinario / (int)8).ToString();

        }

    }
}
