using Dominio.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Atributos
    {
        public int Id { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public decimal Monto_Del_Prestamo { get; set; }
       
        
        public decimal Principal{ get; set; }
        public decimal Interes { get; set; }
        public decimal Cuota { get; set; }
        
        public decimal terminos { get; set; }
        public decimal Tasa { get; set; }
        public Estado Estados { get; set; }
        public DateTime Fecha_De_Pago { get; set; }
        
        public bool PrincipalPagado { get; set; }
        public bool InteresPAgado { get; set; }
        public bool CuotaPagada { get; set; }
    }
}
