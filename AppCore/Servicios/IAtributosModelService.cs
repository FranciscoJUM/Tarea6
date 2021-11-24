using AppCore.Interfaces;
using Dominio.Entidades;
using Dominio.Interfaces;
using Infraestructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Servicios
{
    public class IAtributosModelService : IAtributosServices
    {
        IAributosModel atr;

        public IAtributosModelService(IAributosModel atr)
        {

            this.atr = atr;
        }

        public void Create(Atributos t)
        {
            atr.Create(t);
        }

        public decimal Cuota(decimal a, decimal b)
        {
            return atr.Cuota(a, b);
        }

        public bool Delete(Atributos t)
        {
            return atr.Delete(t);
        }

        public Atributos[] FindAll()
        {
            return atr.FindAll();
        }

        public string GetAtrAsJson()
        {
            return atr.GetAtrAsJson();
        }

        public decimal Interes(decimal Monto, decimal Tasa, decimal Terminos)
        {
            return atr.Interes(Monto, Tasa, Terminos);
        }

        public decimal Principal(decimal Monto, decimal Tasa, decimal Terminos)
        {
            return atr.Principal(Monto, Tasa, Terminos);
        }

        public int Update(Atributos t)
        {
            return atr.Update(t);
        }
    }
}
