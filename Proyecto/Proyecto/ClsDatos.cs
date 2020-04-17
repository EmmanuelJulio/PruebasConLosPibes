using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class ClsDatos
    { 
        public static ClsDatos instans = null;
        private ClsDatos()
        {
           
        }
        public static ClsDatos GetDatos()
        {
            if (instans == null)
            {
                instans = new ClsDatos();
            }
            return instans;
        }

        public List<Diccionario> GetAlldic()
        {
            using (bulonera2Entities db = new bulonera2Entities())
            {
                List<Diccionario> listdic = (from x in db.Diccionario select x).ToList();
                return listdic;
            }
        }
    }
}
