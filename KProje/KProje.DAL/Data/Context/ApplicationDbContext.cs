using KProje.DAL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace KProje.DAL.Data.Context
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("DbConnection"){
            Database.SetInitializer<ApplicationDbContext>(new DropCreateDatabaseIfModelChanges<ApplicationDbContext>());
            }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<bilim> bilim { get; set; }
        public DbSet<haberler> haberler { get; set; }
        public DbSet<iletisim> iletisim { get; set; }
        public DbSet<mobil> mobil { get; set; }
        public DbSet<sosyalmedya> sosyalmedya { get; set; }
    }
}
