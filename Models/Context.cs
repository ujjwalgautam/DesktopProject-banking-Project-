﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winFormApplicaton.Models
{
    internal class Context : DbContext
    {
        public DbSet<adminLogin> AdminLogin { get; set; }
        public DbSet<AccountDetails> AccountDetails { get; set; }
        public DbSet<Debit> Debit { get; set; }
        public DbSet<Depositt> Deposit { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Transferr> Transfer { get; set; }
        public DbSet<UserTable> UserTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=UJJWAL\SQLEXPRESS;Initial Catalog=BankData;Integrated Security=true;trustServerCertificate=True;");
        }

    }
}
