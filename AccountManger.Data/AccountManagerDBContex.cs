using AccountManger.Data.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AccountManger.Data
{
  public  class AccountManagerDBContex: DbContext 
    {
        public AccountManagerDBContex(
            DbContextOptions<AccountManagerDBContex> options) : base(options)
        {
        }

        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Account>  Accounts { get; set; }

        





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AccountType>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Account>()
                .HasKey(p => p.Id);

            modelBuilder.Entity<Account>()
                .HasOne(p => p.AccountType)
                .WithMany(p => p.Accounts)
                .OnDelete(DeleteBehavior.Restrict);
                
        }


    }
}
