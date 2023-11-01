using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotnetapp.Models;

public class ApplicationDbContext:DbContext
{
    public virtual DbSet<Dealer>Dealers{get;set;}

    public ApplicationDbContext(){}
    public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options)
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("User ID:sa;password=examlyMssql@123;server=localhost;Database=ApplicationDb;trusted_connection=false;Persist Security Info=False;Encrypt=False;");
        }
    }
}