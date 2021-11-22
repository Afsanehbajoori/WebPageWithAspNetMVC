using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPageWithAspNetMVC.Models;

namespace WebPageWithAspNetMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<WebPageWithAspNetMVC.Models.User> User { get; set; }
        public DbSet<WebPageWithAspNetMVC.Models.Book> Book { get; set; }
    }
}
