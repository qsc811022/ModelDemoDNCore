using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModelDemoDNCore.Models;

namespace ModelDemoDNCore.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Item> Item { get;set;}
        public DbSet<Expense> Expenses { get; set; }

        public DbSet<ExpenseType> ExpensesType { get; set; }
    }
}
