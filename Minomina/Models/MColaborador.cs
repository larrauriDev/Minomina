using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Minomina.Models
{
    class MColaborador
    {
        private int idPuestoTrabajo;
        private string codigoEmpreado;
        private DateTime fechaIngreso;
        private string estadoLaborar;
        private string nombre;
        private string cedula;
        private string apellido;
        private string sexo;
        private string direccion;
        private string mail;
        private string telefono;
        private string cuentaBanco;
        private string tipoCuenta;
        private string banco;
        private int rol;
        private int idDepartamento;
        private bool usuario;
        public int PUESTOTRABAJO { get => idPuestoTrabajo; set => idPuestoTrabajo = value; }
        public string CODIGOEMPLEADO { get => codigoEmpreado; set => codigoEmpreado = value; }
        public DateTime FECHAINGRESO { get => fechaIngreso; set => fechaIngreso = value; }
        public string ESTADOLABORAR { get => estadoLaborar; set => estadoLaborar = value; }
        public string NOMBRE { get => nombre; set => nombre = value; }
        public string CEDULA { get => cedula; set => cedula = value; }
        public string APELLIDO { get => apellido; set => apellido = value; }
        public string SEXO { get => sexo; set => sexo = value; }
        public string DIRECCION { get => direccion; set => direccion = value; }
        public string MAIL { get => mail; set => mail = value; }
        public string TELEFONO { get => telefono; set => telefono = value; }
        public string CUENTABANCO { get => cuentaBanco; set => cuentaBanco = value; }
        public string TIPOCUENTA { get => tipoCuenta; set => tipoCuenta = value; }
        public string BANCO { get => banco; set => banco = value; }
        public int ROL { get => rol; set => rol = value; }
        public int IDDEPARTAMENTO { get => idDepartamento; set => idDepartamento = value; }
        public bool USUARIO { get => usuario; set => usuario = value; }
        public void InsertColaborador()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.SP_InsertColaboradores(idPuestoTrabajo, estadoLaborar, nombre, apellido, sexo, cedula, direccion, mail, telefono, cuentaBanco, tipoCuenta, banco, fechaIngreso, usuario);
                db.SaveChanges();

            }
        }
        public void FillPuestoTrabajo(ComboBox cbpuesto)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                //var pues = (from p in db.Puestos select new { p.Puesto1,p.r }).ToList();

                //cbpuesto.DataSource = pues;
                cbpuesto.DisplayMember = "Puesto1";
                cbpuesto.ValueMember = "RECID";
                cbpuesto.SelectedValue = "Puesto1";
                cbpuesto.DataSource = db.Puestos.ToList();
                cbpuesto.SelectedIndex = -1;

            }

        }
        public void FillDataGridcolaborador(DataGridView dataCola)
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var cola = from p in db.DatagridColaboradors
                           select new { p.Codigo_de_empleado, p.Nombres, p.Apellidos, p.Fecha_de_ingreso, p.Puesto, p.Telefono, p.Email, p.Sexo, p.Tipo_de_Cuenta, p.Cuenta_Bancaria, p.Cedula_o_Pasaporte, p.Direccion, p.Banco, p.Estatus_Laboral, p.Usuario_del_Sistema, p.RECID };

                dataCola.DataSource = cola.ToList();
                dataCola.Columns[0].HeaderText = "Codigo Empleado";
                dataCola.Columns[1].HeaderText = "Nombre";
                dataCola.Columns[2].HeaderText = "Apellido";
                dataCola.Columns[3].HeaderText = "Fecha de Ingreso";
                dataCola.Columns[4].HeaderText = "Puesto de Trabajo";
                dataCola.Columns[5].HeaderText = "Telefono";
                dataCola.Columns[6].HeaderText = "Correo Electronico";
                dataCola.Columns[7].HeaderText = "Sexo";
                dataCola.Columns[8].Visible = false;
                dataCola.Columns[9].Visible = false;
                dataCola.Columns[10].Visible = false;
                dataCola.Columns[11].Visible = false;
                dataCola.Columns[12].Visible = false;
                dataCola.Columns[13].Visible = false;
                dataCola.Columns[14].Visible = false;
                dataCola.Columns[15].Visible = false;
                dataCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }
        public void UpdateDatosColaboradores()
        {
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                db.sp_UpdateColaborador(codigoEmpreado, idPuestoTrabajo, estadoLaborar, nombre, apellido, sexo, cedula, direccion, mail, telefono, cuentaBanco, tipoCuenta, banco, fechaIngreso, usuario);
                db.SaveChanges();


            }


        }
        public void BuscaColaborador(DataGridView dataCola)
        {
            if (codigoEmpreado == "")
                codigoEmpreado = "COL";
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var cola = (from p in db.DatagridColaboradors
                            select new
                            {
                                p.Codigo_de_empleado,
                                p.Nombres,
                                p.Apellidos,
                                p.Fecha_de_ingreso,
                                p.Puesto,
                                p.Telefono,
                                p.Email,
                                p.Sexo,
                                p.Tipo_de_Cuenta,
                                p.Cuenta_Bancaria,
                                p.Cedula_o_Pasaporte,
                                p.Direccion,
                                p.Banco,
                                p.Estatus_Laboral,
                                p.Usuario_del_Sistema
                            }).Where(p => p.Nombres.Contains(nombre));


                dataCola.DataSource = cola.ToList();
                dataCola.Columns[0].HeaderText = "Codigo Empleado";
                dataCola.Columns[1].HeaderText = "Nombre";
                dataCola.Columns[2].HeaderText = "Apellido";
                dataCola.Columns[3].HeaderText = "Fecha de Ingreso";
                dataCola.Columns[4].HeaderText = "Puesto de Trabajo";
                dataCola.Columns[5].HeaderText = "Telefono";
                dataCola.Columns[6].HeaderText = "Correo Electronico";
                dataCola.Columns[7].HeaderText = "Sexo";
                dataCola.Columns[8].Visible = false;
                dataCola.Columns[9].Visible = false;
                dataCola.Columns[10].Visible = false;
                dataCola.Columns[11].Visible = false;
                dataCola.Columns[12].Visible = false;
                dataCola.Columns[13].Visible = false;
                dataCola.Columns[14].Visible = false;
                dataCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }


        }
        public int ExisteID()
        {
            int existeID = 0;
            using (MINOMINAEntities db = new MINOMINAEntities())
            {
                var find = from p in db.Colaboradores where p.Codigo_de_empleado == codigoEmpreado select p;
                existeID = find.Count();
            }
            MessageBox.Show(existeID.ToString());
            return existeID;
        }
        public void DeleteColaborador() 
        {
            using (MINOMINAEntities db = new MINOMINAEntities()) {
                db.sp_DeleteColaborador(codigoEmpreado);
                db.SaveChanges();
                
            }
        
        }


    }
}
