using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minomina.IViews
{
    interface INomina
    {
        string OBSERVACIONES { get; set; }
        string APROBADO { get; set; }
        bool APROBACION { get; set; }
        DateTime FECHADESDE { get; set; }
        DateTime FECHAHASTA { get; set; }
        bool GENERADO { get; set; }
        float TOTALPAGADO { get; set; }

    }
}
