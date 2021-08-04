using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class UdemyRatingContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-GLNUG4P0\MSSQLSERVER2;Database=UdemyRating;Trusted_Connection=true");
        }

        public DbSet<Courses> Courses { get; set; }
        public DbSet<Ratings> Ratings { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<OperationClaims> OperationClaims { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserOperationClaims> UserOperationClaims { get; set; }


    }
}
