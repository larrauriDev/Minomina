using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minomina.Models
{
    class MAsignacionNovedad
    {
        private int recidTableHeader;
        private int idRegistroHeader;
       // private string codigoEmpleado;
        private int recidColaborador;
        private string nombreColaborar;
        private float? totalesHeader;
        private int? recidTableDetails = 0;
        private int recidHeader;
        private string idAsignacion;
        private int recidNovedad;
        private string descripcionNovedad;
        private float motoDetails;
        private DateTime fechaDesde;
        private DateTime fechaHasta;
        private string tipoNovedad;
        public int RECIDTABLEHEADER { get { return recidTableHeader; } set { recidTableHeader = value; } }
        public int IDREGISTROHEADER { get { return idRegistroHeader; } set { idRegistroHeader = value; } }
       // public string CODIGOEMPLEADO { get=> codigoEmpleado; set => codigoEmpleado =  value; }
        public int RECIDCOLABORADOR { get=> recidColaborador; set => recidColaborador = value; }
        public string NOMBRECOLABORADOR { get => nombreColaborar; set => nombreColaborar = value; }
        public float? TOTALHEADER { get => totalesHeader; set => totalesHeader = value; }
        public int? RECIDTABLEDETAILS { get => recidTableDetails; set => recidTableDetails = value; }
        public int RECIDHEADER { get => recidHeader; set => recidHeader = value; }
        public string IDASIGNACION { get => idAsignacion; set => idAsignacion = value; }
        public int RECIDNOVEDAD { get => recidNovedad; set => recidNovedad = value; }
        public string DESCRIPCIONNOVEDAD { get => descripcionNovedad; set => descripcionNovedad = value; }
        public float MOTODETAILS { get => motoDetails; set => motoDetails = value; }
        public DateTime FECHADESDE { get => fechaDesde; set => fechaDesde = value; }
        public DateTime FECHAHASTA { get => fechaHasta; set => fechaHasta = value; }
        public string TIPONOVEDAD { get => tipoNovedad; set => tipoNovedad = value; }

        private MINOMINAEntities db = new MINOMINAEntities();
        public void InsertNovedadHeader() {
            using (db)
            {
                db.SP_InserAsingCabecera(recidColaborador, nombreColaborar);
                db.SaveChanges();
            }
        
        }
        public void FillaDatagridHeader(DataGridView dtg) {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var fill = from a in db.AsigCabeceras
                           join c in db.Colaboradores on a.RECIDColaborador equals c.RECID
                           select new { a.RECID, a.IDRegitro, c.Codigo_de_empleado, a.Colaborador,a.Total }; //nombre = string.Format("{0} {1}", c.Nombres, c.Apellidos) };
                dtg.DataSource = fill.ToList();
                dtg.Columns[0].Visible = false;
                dtg.Columns[1].HeaderText = "IDRegistro Asignacion";
                dtg.Columns[2].HeaderText = "Codigo Colaborador";
                dtg.Columns[3].HeaderText = "Nombre y Apellido";
                dtg.Columns[4].HeaderText = "Total Neto";
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        
        }
        public void InsertNovedadDetalle(DataGridView dgv) {
            using (db)
            {
                List<int> recid = new List<int>();
                foreach (DataGridViewRow row in dgv.Rows)
                {

                    recidTableHeader = int.Parse(row.Cells[7].Value.ToString());

                    if (row.Cells[8].Value == null) 
                    { recidTableDetails = 0; }
                    else
                    recidTableDetails = int.Parse(row.Cells[8].Value.ToString());

                    recidNovedad = int.Parse(row.Cells[1].Value.ToString());
                    descripcionNovedad = row.Cells[2].Value.ToString();
                    motoDetails = float.Parse(row.Cells[3].Value.ToString());
                    fechaDesde = DateTime.Parse(row.Cells[4].Value.ToString());
                    fechaHasta = DateTime.Parse(row.Cells[5].Value.ToString());
                    tipoNovedad = row.Cells[6].Value.ToString();
                    idAsignacion = row.Cells[0].Value.ToString();
                    if (!recid.Contains(recidTableHeader))
                    {
                        recid.Add(recidTableHeader);
                    }
                    
                    if (recidTableDetails == 0)
                    {
                        db.SP_InsertNovedad(recidTableHeader, idAsignacion, recidNovedad, descripcionNovedad, motoDetails, fechaDesde, fechaHasta, tipoNovedad);
                    }
                    else if (recidTableDetails>0)
                    {
                        
                        db.SP_UpdateAsigNovedadDetails(recidTableDetails, recidTableHeader, idAsignacion, recidNovedad, descripcionNovedad, motoDetails, fechaDesde, fechaHasta, tipoNovedad);
                    }
                        db.SaveChanges();
                   
 
                }
                CalculoDeducciones(recid);




            }
            
        }
        public void CalculoDeducciones(List<int> list) {

            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                
                foreach (var item in list)
                {
                    db.sp_InsertDeducciones(item);
                }
            }
        
        }
        public  void FillDagridDetails(DataGridView dtg) {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var query = from ad in db.AsigNovedadDetalles select new { ad.IDAsignacionCabecera,ad.RECIDNOVEDAD,ad.DescNovedad, ad.Monto, ad.FechaDesde, ad.FechaHasta, ad.TipoNovedad,ad.RECIDHEADER,ad.RECID};
                dtg.Rows.Clear();
                foreach (var item in query)
                {
                    DataGridViewRow row = (DataGridViewRow)dtg.RowTemplate.Clone();
                    
                    row.CreateCells(dtg, item.IDAsignacionCabecera, item.RECIDNOVEDAD, item.DescNovedad, item.Monto, item.FechaDesde, item.FechaHasta, item.TipoNovedad, item.RECIDHEADER,item.RECID);
                    dtg.Rows.Add(row);
                }
                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        
        }
        public void ComplateFielDatagrid(DataGridViewRow dgvr) {
            using (db)
            {
                var query = db.Novedades.Where(n => n.RECID == recidNovedad).FirstOrDefault();
                dgvr.Cells[2].Value = query.Nombre;
                dgvr.Cells[6].Value = query.TipoNovedad;
            }
        }
        public void LLenaComboColaborador(ComboBox cb) {

            using (db)
            {

                cb.DisplayMember = "Codigo_de_empleado";
                cb.ValueMember = "RECID";
                cb.SelectedValue = "Codigo_de_empleado";
                cb.DataSource = db.Colaboradores.ToList();
                cb.SelectedIndex = -1;

            }
        
        }
        public string NombreColaborador() {

            string fullname = string.Empty;
            using (db)
            {
                    var query = db.Colaboradores.Where(c => c.RECID == recidColaborador).FirstOrDefault();
                    fullname = string.Format("{0} {1}",query.Nombres, query.Apellidos);
            }
            return fullname;
        }

        public void FillComboDatagridView(DataGridViewComboBoxColumn dgvc) {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var data = db.Novedades.ToList();
                dgvc.DataSource = data;
                dgvc.DisplayMember = "IDNOVEDAD";
                dgvc.ValueMember = "RECID";
                
               // dgvc.DisplayIndex = -1;

            }
        
        }
        public void CompletaDescripcionNovedad(DataGridViewRow dgr) {

            
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var query = db.Novedades.Where(n => n.RECID == recidNovedad).FirstOrDefault();
                dgr.Cells[2].Value = query.Nombre;
                dgr.Cells[6].Value = query.TipoNovedad;

            }
              
        }

    }
}
