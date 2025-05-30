using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExamenT2_FunAlg_13126
{
    public class ClassCajero
    {
        public void Monto()
        { 
            Random random = new Random();
            int monto = random.Next(1,1000000);
            Console.WriteLine("Su saldo es: "+monto);
            Console.ReadKey();
        }
    }
}
