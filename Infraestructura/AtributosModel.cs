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
    public class AtributosModel : IAributosModel
    {
       private  Atributos[] atr;

        #region CRUDS
        public void Create(Atributos t)
        {
            Add(t, ref atr);

        }

        public int Update(Atributos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            atr[index] = t;
            return index;
        }

        public bool Delete(Atributos t)
        {
            if (t == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }

            int index = GetIndexById(t.Id);
            if (index < 0)
            {
                throw new Exception($"El producto con id {t.Id} no se encuentra.");
            }

            if (index != atr.Length - 1)
            {
                atr[index] = atr[atr.Length - 1];
            }

            Atributos[] tmp = new Atributos[atr.Length - 1];
            Array.Copy(atr, tmp, tmp.Length);
            atr = tmp;

            return atr.Length == tmp.Length;
        }

        public Atributos[] FindAll()
        {
            return atr;
        }
        #endregion

        #region Metodos
        public decimal Interes(decimal Monto, decimal Tasa, decimal Terminos)
        {
           decimal x = (Monto*(1+Tasa)/Terminos);
            return x;
        }

        public decimal Principal(decimal Monto, decimal Tasa, decimal Terminos)
        {
            decimal x = (Monto * Tasa) / Terminos;
            return x;
        }
      
        public decimal Cuota(decimal a, decimal b)
        {
            decimal x = (a + b);
            return x;
        }
        #endregion

        #region Privados

        private void Add(Atributos p, ref Atributos[] pds)
        {
            if (pds == null)
            {
                pds = new Atributos[1];
                pds[pds.Length - 1] = p;
                return;
            }

            Atributos[] tmp = new Atributos[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = p;
            pds = tmp;
        }

        private int GetIndexById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("El id no puede ser negativo o cero.");
            }

            int index = int.MinValue, i = 0;
            if (atr == null)
            {
                return index;
            }

            foreach (Atributos p in atr)
            {
                if (p.Id == id)
                {
                    index = i;
                    break;
                }
                i++;
            }

            return index;
        }

        public string GetAtrAsJson()
        {
            return JsonConvert.SerializeObject(atr);
        }
        #endregion

    }
}
