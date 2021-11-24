using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IAributosModel: IModel<Atributos>
    {

        decimal Principal(decimal Monto, decimal Tasa, decimal Terminos);
        decimal Interes(decimal Monto, decimal Tasa, decimal Terminos);
        decimal Cuota(decimal a, decimal b);
        string GetAtrAsJson();
    }
}
