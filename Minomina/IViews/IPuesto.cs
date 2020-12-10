using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minomina.IViews
{
    interface IPuesto
    {
        string SALARIO{ get; set; }
        string NOMBRE { get; set; }
        string CANTIDAD { get; set; }
        string FRESALARIO { get; set; }
        string PAGOSHORAS { get; set; }
        string RECIDDEPARTAMENTO { get; set; }
        string DEBERES { get; set; }
        string IDPUESTO { get; set; }
    }
}
