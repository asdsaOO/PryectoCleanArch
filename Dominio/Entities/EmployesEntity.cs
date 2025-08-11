using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
namespace App.Dominio.Entities
{
  public class EmployesEntity
  {
    public Guid id { get; set; }
    public string name { get; set; } = null!;
    public string  email { get; set; }
    public int  phone { get; set; }
  }



}