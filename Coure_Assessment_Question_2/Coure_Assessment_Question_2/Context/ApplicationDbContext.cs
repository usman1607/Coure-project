using Coure_Assessment_Question_2.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Coure_Assessment_Question_2.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseInMemoryDatabase("InMemoryDb");
        }

        public DbSet<Country> Countries { get; set; } 
        public DbSet<CountryDetails> CountryDetails { get; set; }

    }
}
