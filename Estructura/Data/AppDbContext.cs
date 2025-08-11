using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;
using App.Dominio.Entities;
namespace App.Estructura.Data
{
  public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
  { 
    public DbSet<EmployesEntity> Employes { get; set; }
    
  }
  
}