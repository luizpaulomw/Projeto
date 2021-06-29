using Microsoft.EntityFrameworkCore;
using Models;

namespace Conexão_banco
{
    public class Context : DbContext
    {
        public DbSet<ClienteModels> Clientes { get; set; }
        public DbSet<VeiculoModels> Veiculos { get; set; }
        public DbSet<LocacaoModels> Locacoes { get; set; }
        public DbSet<LocacaoVeiculoModels> LocacaoVeiculo { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql("Server=localhost;User Id=root;Database=bancoveiculo");
            
        

          /*  string connUser = "bf07458e8e5095";
            string connPass = "236c2802";
            string connHost = "us-cdbr-east-04.cleardb.com";
            string connDb = "heroku_1fb931cf91c4b37";
            string connStr = $"server={connHost};Uid={connUser};Pwd={connPass};Database={connDb};SSL Mode=None";




            var dbContextOptionsBuilder1 = options.UseMySql(connStr, mySqlOptionsAction: mysqlOptions =>
                        mysqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 1,
                        maxRetryDelay: System.TimeSpan.FromSeconds(30),
                        errorNumbersToAdd: null
                       );
            DbContextOptionsBuilder dbContextOptionsBuilder = dbContextOptionsBuilder1;*/
           

          
          }         

    }
}
