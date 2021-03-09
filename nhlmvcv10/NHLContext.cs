using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NHLPlayv3.Models
{
    public class NHLContext : DbContext
    {

        public NHLContext(DbContextOptions<NHLContext> options) : base(options)
        {
        }

        public NHLContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("TestConnection"));
        }
        public Microsoft.EntityFrameworkCore.DbSet<Models.Team> Teams { get; set; }
    }
}
