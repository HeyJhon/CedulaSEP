using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace CedulaSEP
{
    public class CedulaContext:DbContext
    {
        public DbSet<DataInfo> DataInfos { get; set; }

        string portableConection = ConfigurationManager.ConnectionStrings["DbConection"].ConnectionString; 
         //"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\CedulaDB.mdf;Integrated Security=True;Connect Timeout=30";

        //$"Server =.\\SQLExpress;AttachDbFilename=|{Environment.CurrentDirectory}|\\CedulaDB.mdf;Database=CedulaDB; Trusted_Connection=Yes;";
        //string localConnection = @"Server=LAPTOP-1K29SKO8\MSSQLSERVER2020;Database=CedulaDB;User Id=sa;Password=admin2020;TrustServerCertificate=True";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conexion = portableConection;
            optionsBuilder.UseSqlServer(conexion);
        }
    }
}
