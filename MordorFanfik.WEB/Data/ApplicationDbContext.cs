using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MordorFanfik.WEB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MordorFanfik.WEB.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext() { }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {           
        }
        public DbSet<Creation> Creations { get; set; }
        public DbSet<Chapter> Chapters { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
