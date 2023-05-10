using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpresaUTN.Modelos;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // opcionalmente: pluralizar el nombre de los dbSet's
        // dado que con este nombre se crearàn las tablas fìsicametne en la BDD 
        public DbSet<EmpresaUTN.Modelos.Canton> Cantones { get; set; } = default!;

        public DbSet<EmpresaUTN.Modelos.Provincia>? Provincias { get; set; }

        public DbSet<EmpresaUTN.Modelos.Pais>? Paises { get; set; }
    }
