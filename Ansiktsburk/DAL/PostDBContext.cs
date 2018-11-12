using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ansiktsburk.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ansiktsburk.Models;

namespace Ansiktsburk.DAL
{
    public class PostDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
        {
        }
    }
}
