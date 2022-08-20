using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ASP_FinalExam_Net6;
using ASP_FinalExam_Net6.Models;


namespace ASP_FinalExam_Net6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ASP_FinalExam_Net6.Models.Employee>? Employee { get; set; }
        public DbSet<ASP_FinalExam_Net6.Models.Department>? Department { get; set; }
       
    }
}