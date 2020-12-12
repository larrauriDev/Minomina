using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minomina.IViews
{
    interface IAsignacionesNovedad
    {
        int RECIDTABLEHEADER { get; set; }
        int IDREGISTROHEADER { get; set; }
        //string CODIGOEMPLEADO { get; set; }
        int RECIDCOLABORADOR { get; set; }
        string NOMBRECOLABORADOR { get; set; }
        float? TOTALHEADER { get; set; }
        int RECIDTABLEDETAILS { get; set; }
        int RECIDHEADER { get; set; }
        string  IDASIGNACION { get; set; }
        int RECIDNOVEDAD { get; set; }
        string DESCRIPCIONNOVEDAD { get; set; }
        float MOTODETAILS { get; set; }
        DateTime FECHADESDE { get; set; }
        DateTime FECHAHASTA { get; set; }
        string TIPONOVEDAD { get; set; }
       
    }
}
