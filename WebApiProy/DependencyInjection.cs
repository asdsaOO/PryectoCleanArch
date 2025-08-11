using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.Extensions.DependencyInjection;
using App.Estructura;

namespace App.WebApiProy
{
  public static class DependencyInjection
  {
    public static IServiceCollection AddWebApiDI(this IServiceCollection services)
    {
      services.AddEstructureDI();
      return services;
      
    }


  }
}
