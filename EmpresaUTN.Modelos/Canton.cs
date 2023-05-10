using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaUTN.Modelos
{
    public class Canton
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CabeceraCantonal { get; set; }

        // relacion
        public Provincia? Provincia { get; set; }
        public int ProvinciaId { get; set; }  // fk
    }
}
