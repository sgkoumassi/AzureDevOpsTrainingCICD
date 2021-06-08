using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserService.DataBase.Entities;

namespace UserService.DataBase
{
    public class DatabaseContext: DbContext
    {
        public DbSet<User> Users { get; set; }

        // Definition de la connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source = GANI-SH17F17; initial catalog = UserDB; Trusted_Connection = true;");
        }
    }


}
