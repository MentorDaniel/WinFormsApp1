using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using PracticeApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticeApi.Data
{
    public class DataContext:DbContext
    {

        public DataContext(DbContextOptions options) : base (options)
        {
           
        }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
