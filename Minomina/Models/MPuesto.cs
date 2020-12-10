using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Minomina.Models
{
    class MPuesto
    {
        private float? salario;
        private string nombre;
        private string idPuesto;
        private int cantidad;
        private string freSalario;
        private float pagoHoras;
        private int recidDepartamento;
        private string deberes;

        public float? SALARIO
        {
            get => salario;
            set => this.salario = value;

        }
        public string PUESTO
        {
            get => idPuesto;
            set => idPuesto = value;
        }
        public string NOMBRE
        {
            get => nombre;
            set => this.nombre = value;

        }
        public string IDPUESTO
        {
            get => idPuesto;
            set => idPuesto = value;

        }
        public int CANTIDAD
        {
            get => cantidad;
            set => this.cantidad = value;

        }
        public string FRESALARIO
        {
            get => freSalario;
            set => this.freSalario = value;

        }
        public float PAGOSHORAS
        {
            get => pagoHoras;
            set => this.pagoHoras = value;

        }
        public int RECIDDEPARTAMENTO
        {
            get => recidDepartamento;
            set => recidDepartamento = value;

        }
        public string DEBERES
        {
            get => deberes;
            set => this.deberes = value;

        }

        public void InsertarPuesto()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var tbPuesto = new Puesto();
                db.sp_InsertarPuestos(nombre, salario, freSalario, pagoHoras, cantidad, deberes, recidDepartamento);
                db.SaveChanges();
                var query = db.Puestos.Max(p => p.ID_Puesto);
                idPuesto = query;

            }

        }
        public void UpdateData()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.sp_UpdatePuesto(idPuesto, nombre, salario, freSalario, pagoHoras, cantidad, deberes, recidDepartamento);
                db.SaveChanges();

            }

        }
        public void FillDataGrid(DataGridView dtg)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                //var tbPuesto = from p in db.DataGridPuestoes
                //             select new { p.ID_Puesto, p.Puesto, p.Departamento, p.Cantidad_Disponible, p.Pago_por_horas, p.Salario, p.Deberes, p.Frecuencia_del_salario };

                var tbPuesto = from p in db.Puestos
                               join a in db.Departamentos on p.RECIDDEPAR equals a.RECID
                               select new { p.ID_Puesto, p.Puesto1, a.Departamento1, p.Cantidad_Disponible,p.Pago_por_horas,p.Salario, p.Deberes, p.Frecuencia_del_salario,p.RECID};

                dtg.DataSource = tbPuesto.ToList();
                dtg.Columns[0].HeaderText = "Codigo Puesto";
                dtg.Columns[1].HeaderText = "Puesto";
                dtg.Columns[2].HeaderText = "Departamento";
                dtg.Columns[3].HeaderText = "Disponible";
                dtg.Columns[4].Visible = false;
                dtg.Columns[5].Visible = false;
                dtg.Columns[6].Visible = false;
                dtg.Columns[7].Visible = false;

                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }
        public ComboBox FillComboDepartamento(ComboBox cbDepa)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                //var cb = from p in db.Departamentos select new {p.RECID, p.Codigo_de_Departamento, p.Departamento1 };
                
                cbDepa.DisplayMember = "Departamento1";
                cbDepa.ValueMember = "RECID";
                cbDepa.SelectedValue = "Departamento1";
                cbDepa.DataSource = db.Departamentos.ToList();
                cbDepa.SelectedIndex = -1;

            }

            return cbDepa;
        }

        public int ExisteID() {
            int filas;
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var encontrado = from p in db.Puestos where p.ID_Puesto == idPuesto select p;
                filas = encontrado.Count();

            }
            return filas;
        
        }

        public void BuscarPuesto(DataGridView dtg)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                
                if (idPuesto == "")
                {
                    idPuesto = "PUES";
                }
              
                  var tbPuesto = (from p in db.DataGridPuestoes
                                select new { p.ID_Puesto, p.Puesto, p.Departamento, p.Cantidad_Disponible, p.Pago_por_horas, p.Salario, p.Deberes, p.Frecuencia_del_salario }).Where(x => x.ID_Puesto.Contains(idPuesto)).ToList();
                
                /* ipuesto.NOMBRE = tbPuesto.Puesto.ToString();
                 ipuesto.PAGOSHORAS = tbPuesto.Pago_por_horas.ToString();
                 ipuesto.SALARIO = tbPuesto.Salario.ToString();
                 ipuesto.FRESALARIO = tbPuesto.Frecuencia_del_salario.ToString();
                 ipuesto.RECIDDEPARTAMENTO = tbPuesto.Departamento.ToString();*/

                dtg.DataSource = tbPuesto;
                dtg.Columns[0].HeaderText = "Codigo Puesto";
                dtg.Columns[1].HeaderText = "Puesto";
                dtg.Columns[2].HeaderText = "Departamento";
                dtg.Columns[3].HeaderText = "Disponible";
                dtg.Columns[4].Visible = false;
                dtg.Columns[5].Visible = false;
                dtg.Columns[6].Visible = false;
                dtg.Columns[7].Visible = false;

                dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }

        }
    }
}
