using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minomina.IViews;
using Minomina.Models;

namespace Minomina.Presentation
{
    class PAsignacionNovedad
    {
        IAsignacionesNovedad iAsig;
        MAsignacionNovedad mAsig = new MAsignacionNovedad();
        public PAsignacionNovedad(IAsignacionesNovedad iasig) {

            iAsig = iasig;

        }
        public void ConectarModel() {

            //mAsig.CODIGOEMPLEADO = iAsig.CODIGOEMPLEADO;
            mAsig.DESCRIPCIONNOVEDAD = iAsig.DESCRIPCIONNOVEDAD;
            mAsig.FECHADESDE = iAsig.FECHADESDE;
            mAsig.FECHAHASTA = iAsig.FECHAHASTA;
            mAsig.IDASIGNACION = iAsig.IDASIGNACION;
            mAsig.IDREGISTROHEADER = iAsig.IDREGISTROHEADER;
            mAsig.MOTODETAILS = iAsig.MOTODETAILS;
            mAsig.NOMBRECOLABORADOR = iAsig.NOMBRECOLABORADOR;
            mAsig.RECIDCOLABORADOR = iAsig.RECIDCOLABORADOR;
            mAsig.RECIDHEADER = iAsig.RECIDHEADER;
            mAsig.RECIDNOVEDAD = iAsig.RECIDNOVEDAD;
            mAsig.RECIDTABLEDETAILS = iAsig.RECIDTABLEDETAILS;
            mAsig.RECIDTABLEHEADER = iAsig.RECIDTABLEHEADER;
            mAsig.TIPONOVEDAD = iAsig.TIPONOVEDAD;
            mAsig.TOTALHEADER = iAsig.TOTALHEADER;

        }
        public void InsertaAsigHeader(DataGridView dtg) {
            //ConectarModel();
            mAsig.RECIDCOLABORADOR = iAsig.RECIDCOLABORADOR;
            mAsig.NOMBRECOLABORADOR = iAsig.NOMBRECOLABORADOR;

            mAsig.InsertNovedadHeader();
            CompletaGridHeader(dtg);


        }
        public void CompletaGridHeader(DataGridView dtg) {
            mAsig.FillaDatagridHeader(dtg);

        }
        public void FillComboColaborador(ComboBox cb) {

            mAsig.LLenaComboColaborador(cb);
        
        }
        public void NombreApellido(TextBox tb,ComboBox cb) {
            if (cb.SelectedIndex == -1)
                return;

            mAsig.RECIDCOLABORADOR = iAsig.RECIDCOLABORADOR;
            tb.Text = mAsig.NombreColaborador();
        
        }
        public void FillComboDatagrid(DataGridViewComboBoxColumn dgvc)
        {
            mAsig.FillComboDatagridView(dgvc);
        
        }
        public void CompleteDesNoverdad(DataGridViewRow dgr) {

            mAsig.RECIDNOVEDAD =int.Parse( dgr.Cells[1].Value.ToString());
            mAsig.CompletaDescripcionNovedad(dgr);
        
        }
        public void InsertaDetalleNovedad(DataGridView dtg, DataGridView dtg2) {

            mAsig.InsertNovedadDetalle(dtg);
            mAsig.FillDagridDetails(dtg);
            mAsig.FillaDatagridHeader(dtg2);
        
        }
        public void FillDataGridDetails(DataGridView dtg)
        {
            mAsig.FillDagridDetails(dtg);
            
        }
    }
}
