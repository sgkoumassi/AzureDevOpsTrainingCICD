using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CatalogueService.Database
{
    public class DBContext: DbContext
    {
        /*  Deux facons de definir la chaine de connetion à la base de donnéé
         Soit depuis La classe StartUp ou dans le constructeur de la classe context*/
        public DBContext( DbContextOptions<DBContext> options) : base(options)
        {


        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        
    }
}
