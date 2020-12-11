using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minomina.Helpers;
using Minomina.Models;
using Minomina.IViews;

namespace Minomina.Presentation
{
    class PNovedades
    {
        INovedades iNove;
        MNovedades mNove = new MNovedades();

        public PNovedades() { }
        public PNovedades(INovedades ino)
        {

            iNove = ino;

        }
        public void InsertaNove(Form pantalla, DataGridView dtg)
        {
            if (HelperForms.CheckEmpy(pantalla))
                return;

            ConectaModel();

            mNove.InsertaNovedad();

            mNove.FillDatagridNovedad(dtg);

            HelperForms.ClearControllers(pantalla);

        }
        public void UpdateNove(Form fornove, DataGridView dtg)
        {
            if (HelperForms.CheckEmpy(fornove))
                return;

            if (!iNove.IDNOVEDADES.Contains("NOVE"))
            {
                MessageBox.Show("No es un registro valido para actualizar", "Actualizacion no Procede", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ConectaModel();

            mNove.UpdateNovedad();
            mNove.FillDatagridNovedad(dtg);
            HelperForms.ClearControllers(fornove);
        }
        public void ConectaModel() {
            mNove.IDNOVEDADES = iNove.IDNOVEDADES;
            mNove.NOMBRE = iNove.NOMBRE;
            mNove.TIPO = iNove.TIPO;
            mNove.IMPUESTO = iNove.IMPUESTO;

        }
        public void DeleteNove(Form fornove, DataGridView dtg)
        {
            if (!iNove.IDNOVEDADES.Contains("NOVE"))
            {
                MessageBox.Show("No es un registro valido para Eliminar", "Actualizacion no Procede", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (iNove.IDNOVEDADES.Contains("NOVE"))
            {

                mNove.IDNOVEDADES = iNove.IDNOVEDADES;
                mNove.DeleteNovedad();
                mNove.FillDatagridNovedad(dtg);
                HelperForms.ClearControllers(fornove);
            }


        }
        public void FillGrid(DataGridView dtg)
        {
            mNove.FillDatagridNovedad(dtg);


        }
        public void BuscaFillData(DataGridView dtg)
        {
            mNove.IDNOVEDADES = iNove.IDNOVEDADES;
            mNove.BuscarNovedad(dtg);


        }
        public void InsertaActualiza(DataGridView dtg, Label lbaviso, TextBox tbID, Form pantalla) {
            
            lbaviso.Visible = false;
          
            if (tbID.Text == "" && tbID.Enabled == false)
            {
                InsertaNove(pantalla, dtg);
                tbID.Enabled = true;

            }
            else if (tbID.Text != "" && tbID.Text.Contains("NOVE"))
            {
                UpdateNove(pantalla, dtg);
                MessageBox.Show("Registro Actualizado", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        public void LimpiarControles(Form pantalla) {
            HelperForms.ClearControllers(pantalla);
            
        
        }
    }
}
