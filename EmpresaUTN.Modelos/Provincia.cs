using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaUTN.Modelos
{
    public class Provincia
    {
        public int Id { get; set; }  //PK
        public string Nombre { get; set; }
        public int Area { get; set;}
        public string? ActividadEconomica { get; set;}

        // relacion
        public int PaisCodigoPais { get; set;}  // FK
        public Pais? Pais { get; set;}

        public List<Canton>? Cantones { get; set;} 
    }
}
