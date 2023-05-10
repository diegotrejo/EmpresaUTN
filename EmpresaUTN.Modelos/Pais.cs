using System.ComponentModel.DataAnnotations;

namespace EmpresaUTN.Modelos
{
    public class Pais
    {
        [Key]       // anotations: en este caso designamos PK
        public int CodigoPais { get; set; }    // pk, sugerencia de tipo INT para que sea autonumerico
        public String Nombre { get; set; }
        public int Poblacion { get; set; }
        public string CodigoISO { get; set;}
        public string Moneda { get; set;}
        public string Capital { get;set;}
        public string Idioma { get; set;}


        // relacion
        public List<Provincia>? Provincias { get; set;}

    }
}