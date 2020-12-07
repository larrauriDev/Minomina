using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minomina.Views
{
    interface IColaboradores
    {
        string IDPUESTOTRABAJO { get; set; }
        string CODIGOEMPLEADO { get; set; }
        string FECHAINGRESO { get; set; }
        string ESTADOLABORAR { get; set; }
        string NOMBRE { get; set; }
        string CEDULA { get; set; }
        string APELLIDO { get; set; }
        string SEXO { get; set; }
        string DIRECCION { get; set; }
        string MAIL { get; set; }
        string TELEFONO { get; set; }
        string CUENTABANCO { get; set; }
        string TIPOCUENTA { get; set; }
        string BANCO { get; set; }
        string IDDEPARTAMENTO { get; set; }
        string ROL { get; set; }
        bool USUARIO { get; set; }
    }
}
