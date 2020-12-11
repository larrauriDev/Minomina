using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minomina.IViews
{
    interface INovedades
    {
        string IDNOVEDADES { get; set; }
        string NOMBRE { get; set; }
        string TIPO { get; set; }
        bool IMPUESTO { get; set; }
    }
}
