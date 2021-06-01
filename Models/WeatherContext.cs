using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace APIExamplewithEFCoreDB.Models
{
    public class WeatherContext : DbContext
    {

        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        { 
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=Weather;Trusted_Connection=True;"); 
        }

    }
}
