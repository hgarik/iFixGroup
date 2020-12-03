using Core.Models;
using DAL.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data
{
    public class IFixGroupDbContext : DbContext
    {
        public DbSet<Project> Project { get; set; }
        public DbSet<ProjectTask> ProjectTask { get; set; }

        public IFixGroupDbContext(DbContextOptions<IFixGroupDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ProjectConfigurations());

            builder
                .ApplyConfiguration(new ProjectTaskConfigurations());
        }
    }
}
