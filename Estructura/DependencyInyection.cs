using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Estructura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
namespace App.Estructura
{
  public static class DependencyInyection
  {
    public static IServiceCollection AddEstructureDI(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
          options.UseSqlServer("Server=localhost,1433;Database=testDb;User Id=sa;Password=12345678Asd");
        });

      return services;
      
    }
  }


}