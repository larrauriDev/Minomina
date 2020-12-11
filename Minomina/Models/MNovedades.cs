using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minomina.Models
{
    class MNovedades
    {
        private string idNovedaddes;
        private string tipoNovedad;
        private string nombre;
        private bool impuesto;

        public string IDNOVEDADES { get => idNovedaddes; set => idNovedaddes = value; }
        public string NOMBRE { get => nombre; set => nombre = value; }
        public string TIPO { get => tipoNovedad; set => tipoNovedad = value; }
        public bool IMPUESTO { get => impuesto; set => impuesto = value; }


        public void InsertaNovedad()
        {

            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.sp_InsertaNovedad(nombre, tipoNovedad, impuesto);
                db.SaveChanges();


            }

        }
        public void UpdateNovedad()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.sp_UpdateNovedad(idNovedaddes, nombre, tipoNovedad, impuesto);
                db.SaveChanges();


            }

        }
        public void DeleteNovedad()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.sp_DeleteNovedad(idNovedaddes);
                db.SaveChanges();


            }


        }
        public void FillDatagridNovedad(DataGridView dtg)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var nove = (from p in db.Novedades select new { p.IDNOVEDAD, p.Nombre, p.TipoNovedad, p.AplicaTax }).ToList();
                dtg.DataSource = nove;
                dtg.Columns[0].HeaderText = "Codigo Novedad";
                dtg.Columns[1].HeaderText = "Nombre Novedad";
                dtg.Columns[2].HeaderText = "Tipo de Novedad";
                dtg.Columns[3].Visible = false;
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }
        public void BuscarNovedad(DataGridView dtg)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var nove = (from p in db.Novedades select new { p.IDNOVEDAD, p.Nombre, p.TipoNovedad, p.AplicaTax }).Where(x => x.IDNOVEDAD.Contains(idNovedaddes)).ToList();
                dtg.DataSource = nove;
                dtg.Columns[0].HeaderText = "Codigo Novedad";
                dtg.Columns[1].HeaderText = "Nombre Novedad";
                dtg.Columns[2].HeaderText = "Tipo de Novedad";
                dtg.Columns[3].Visible = false;
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }
    }
}
