using Dominio.Entidades;
using Dominio.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
  public   class AtributosList : IAributosModel
    {
        private List<Atributos> atr;

       
        
        public void Create(Atributos t)
        {
            atr.Add(t);
        }

        public bool Delete(Atributos t)
        {
            return atr.Remove(t);
        }

        public Atributos[] FindAll()
        {
            return atr.ToArray();
        }

        public int Update(Atributos t)
        {
            return atr.Count;
        }





        public decimal Cuota(decimal a, decimal b)
        {
            decimal x = (a+b);
            return x;
        }
        
        public decimal Interes(decimal Monto, decimal Tasa, decimal Terminos)
        {
            decimal x = ((Monto *  + Tasa) / Terminos);
            return x;
        }

        public decimal Principal(decimal Monto, decimal Tasa, decimal Terminos)
        {
            decimal x = (Monto * (1 + Tasa) / Terminos);
            return x;
        }

        public string GetAtrAsJson()
        {
            return JsonConvert.SerializeObject(atr);
        }
    }
}
