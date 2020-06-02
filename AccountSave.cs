using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
    public class AccountSave:Cuenta
    {
        //se encapsulan los atributos que tendra la clase Accounsave
        public DateTime Vencimiento { get; set; }
        public decimal IngresoxMes { get; set; }
        // Se crea metodo ingreso por mes
        public Decimal IngresoPorMes(Cuenta IpM)
        {
            IngresoxMes=Convert.ToInt32(IpM.Saldo)*5;
            
            return IngresoxMes;
        }
    }
}
