using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppDay10.Models;
using WebAppDay10.DTOs;

namespace WebAppDay10.Data
{
    public class MyDbContext :IdentityDbContext<ApplicationUser> // remember pass the  ApplicationUser
    {
        public MyDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<PatientHistory> PatientHistory { get; set; }

        public DbSet<WebAppDay10.DTOs.RoleStore>? RoleStore { get; set; }
    }
}
