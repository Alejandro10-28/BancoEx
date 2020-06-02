using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoEx
{
   public  class CurrentAccount:Cuenta
    {
        //Relacion de Herencia
    

            public void Reintegro(Cuenta P)
            {
               Console.WriteLine("Ingresa cantidad que desees retirar:");
               decimal Retirar = Convert.ToDecimal(Console.ReadLine());

            if (Retirar < P.Saldo)
            {
                P.Saldo -= Retirar;
                Console.WriteLine("Tu operación ha sido procesada"+"\n"+"Saldo actual:{0}", P.Saldo);


            }
            else
            {
                Console.WriteLine("Saldo insuficiente");
            }

            }
        
    }
}

