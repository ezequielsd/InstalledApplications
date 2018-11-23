using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Reflection;

namespace CFSqlCe.Dal
{
    public class Context : DbContext
    {
        static Context()
        {
            // Not initialize database
            //  Database.SetInitializer<ProjectDatabase>(null);
            // Database initialize
            Database.SetInitializer<Context>(new DbInitializer());
            using (Context db = new Context())
                db.Database.Initialize(false);
        }
                 
        public DbSet<Aplicacao> Aplicacaos { get; set; }               
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Versao> Versoes { get; set; }        
    }

    class DbInitializer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {  
            context.Versoes.Add(new Versao { Version = Assembly.GetExecutingAssembly().GetName().Version.ToString() });
                        
            base.Seed(context);
        }
    }
}
