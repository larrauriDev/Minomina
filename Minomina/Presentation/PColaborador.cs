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
        public PColaborador(IColaboradores icola) {

            iCola = icola;
        }
        public void ConnectionModel()
        {
            mCola.APELLIDO = iCola.APELLIDO;
            mCola.BANCO = iCola.BANCO;
            mCola.CEDULA = iCola.CEDULA;
            mCola.CUENTABANCO = iCola.CUENTABANCO;
            mCola.DIRECCION = iCola.DIRECCION;
            mCola.ESTADOLABORAR = iCola.ESTADOLABORAR;
            mCola.FECHAINGRESO = DateTime.Parse(iCola.FECHAINGRESO);
            mCola.MAIL = iCola.MAIL;
            mCola.NOMBRE = iCola.NOMBRE;
            mCola.PUESTOTRABAJO = Int32.Parse(iCola.IDPUESTOTRABAJO);
            mCola.SEXO = iCola.SEXO;
            mCola.TELEFONO = iCola.TELEFONO;
            mCola.TIPOCUENTA = iCola.TIPOCUENTA;
            mCola.USUARIO = iCola.USUARIO;

        }
        public void InsertaColaborador(Form colaForms)
        {
            ConnectionModel();
            if (HelperForms.CheckEmpy(colaForms))
            return;
            
            mCola.InsertColaborador();
        
        }
        public void ModifLabel(Label aviso, Label creado, Timer time, TextBox id)
        {

            if (id.Text == "" && id.Enabled == false)
            {
                aviso.Visible = false;
                creado.Visible = true;
                time.Start();

                if (time.GetLifetimeService().Equals(3000))
                {
                    time.Stop();
                }

            }

            
        }
    }
}
