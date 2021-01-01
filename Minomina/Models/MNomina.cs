using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minomina.Models
{
    class MNomina
    {
        private string observaciones;
        string aprobado;
        bool aprobacion;
        DateTime fechaDede;
        DateTime fechaHasta;
        bool generado;
        float totalPagdo;

        public string OBSERVACIONES { get; set; }
        public string APROBADO { get; set; }
        public bool APROBACION { get; set; }
        public DateTime FECHADESDE { get; set; }
        public DateTime FECHAHASTA { get; set; }
        public bool GENERADO { get; set; }
        public float TOTALPAGADO { get; set; }
        MINOMINAEntities db = new MINOMINAEntities();
        public void FillDataGridNominaDetalle(DataGridView dgv)
        {
            using (db)
            {
                var query = db.vNominas.ToList();
                dgv.DataSource = query;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].HeaderText = "IDRegistro";
                dgv.Columns[2].HeaderText = "Codigo Empleado";
                dgv.Columns[3].HeaderText = "Nombre Empleado";
                dgv.Columns[4].HeaderText = "Deducciones";
                dgv.Columns[5].HeaderText = "Ingreso";
                dgv.Columns[6].HeaderText = "Total a pagar";

                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        
        
        }
        public void InsertNominaDatalle(DataGridViewRow dgvr) 
        {
            using (db)
            {
             
                

            }
        
        
        }



    }
}
