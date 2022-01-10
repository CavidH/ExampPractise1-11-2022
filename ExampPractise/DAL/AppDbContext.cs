using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampPractise.Models;
using Microsoft.EntityFrameworkCore;

namespace ExampPractise.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        

        public DbSet<FeatureCard> FeatureCards { get; set; }
    }
}
