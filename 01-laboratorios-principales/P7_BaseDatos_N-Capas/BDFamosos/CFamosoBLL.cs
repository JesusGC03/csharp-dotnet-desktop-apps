using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDFamosos
{
    public class CFamosoBLL
    {
        private CFamosoDAL bd = new CFamosoDAL();

        public ColCFamosos ObtenerFilasFamosos()
        {
            ColCFamosos colFamosos = bd.ObtenerFilasFamosos();
            return colFamosos;
        }

        public void ActualizarFamosos(CFamosoBO bo)
        {
            bd.ActualizarFamosos(bo);
        }
    }
}
