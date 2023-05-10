using EmpresaUTN.UAPI;
using EmpresaUTN.Modelos;

/*
var uapi = new Crud<Pais>();

var ec = uapi.Select_ById("https://localhost:7264/api/Paises", "1");

ec.Capital = "QUITO DM";
ec.Idioma = "ESPAÑOL";
ec.Moneda = "DOLAR USD";

//uapi.Update("https://localhost:7264/api/Paises", "1", ec);

var paises = uapi.Select("https://localhost:7264/api/Paises");

/*
var co = new Pais
{
    Nombre = "COLOMBIA",
    Capital = "BOGOTA",
    CodigoISO = "CO",
    Idioma = "ES",
    Moneda = "PCO",
    Poblacion = 30000000,
    CodigoPais = 0
};

var nuevoPais = uapi.Insert("https://localhost:7264/api/Paises", co);


uapi.Delete("https://localhost:7264/api/Paises", "2");
paises = uapi.Select("https://localhost:7264/api/Paises");
*/

var cantones = new Crud<Canton>();

var nuevoCanton = cantones.Insert("https://localhost:7264/api/cantones", new Canton
{
    Nombre = "XYZ",
    ProvinciaId = 1,
    CabeceraCantonal = "ABC",
    Id = 0
});


Console.WriteLine("Hello, World!");
