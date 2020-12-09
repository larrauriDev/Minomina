using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        public int ROL { get => rol; set => rol = value;}
        public int IDDEPARTAMENTO { get => idDepartamento; set => idDepartamento = value; }
        public bool USUARIO { get => usuario; set => usuario = value; }
        public void InsertColaborador() 
        {
            using (MINOMINAEntities db = new MINOMINAEntities()) 
            { 
                db.SP_InsertColaboradores(idPuestoTrabajo,estadoLaborar, nombre, apellido, sexo, cedula, direccion, mail, telefono, cuentaBanco, tipoCuenta, banco, fechaIngreso, usuario);
                db.SaveChanges();

            }
        
        
        }
    }
}
