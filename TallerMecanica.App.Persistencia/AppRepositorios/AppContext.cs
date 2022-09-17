using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TallerMecanica.App.Dominio;

namespace TallerMecanica.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            if (!optionsBuilder.IsConfigured) 
            {
              optionsBuilder
              //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TallerMecanicatData");
                .UseSqlServer(@"Data Source=localhost\192.168.1.11,1433;Initial Catalog= TallerMecanicatData;Integrated Security=True");

            }
        }
    
    }


}


    
