using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Interfaces
{
   public  interface IAtributosServices : IModelService<Atributos>
    {
        decimal Principal(decimal Monto, decimal Tasa, decimal Terminos);
        decimal Interes(decimal Monto, decimal Tasa, decimal Terminos);
        decimal Cuota(decimal a, decimal b);
        string GetAtrAsJson();
    }
}
