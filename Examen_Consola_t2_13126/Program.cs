using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using ExamenT2_FunAlg_13126;


namespace Examen_Consola_t2_13126
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su saldo: ");
            float saldo = 0;
            saldo = float.Parse(Console.ReadLine());
            if (saldo < 0)
            {
                Console.WriteLine("Ingrese un monto vàlido...");
            }
            else
            {
                Console.Clear();
                int opcion;
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("MENU DE OPCIONES");
                    Console.WriteLine("1.Depositar");
                    Console.WriteLine("2.Retirar");
                    Console.WriteLine("3.Consultar Saldo");
                    Console.WriteLine("4.Salir");
                    Console.WriteLine("Seleccione una opciòn(1-4)...");
                    opcion = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el monto a depositar: ");
                            Console.WriteLine("Se le cobraràn s/.2,00 por comision");
                            Console.WriteLine("Monto màximo(s/.1000)");
                            float deposito = float.Parse(Console.ReadLine());
                            if (deposito > 1000)
                            {
                                Console.WriteLine("No es posible realizar esta acciòn");
                            }
                            else
                            {
                                saldo = saldo + (deposito - 2);
                                Console.WriteLine("Depòsito realizado con exito....");
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el monto a retirar: ");
                            Console.WriteLine("Retiro màximo(s/.500)");
                            Console.WriteLine("Se le cobraràn s/.8,00 por comision");
                            float retiro = float.Parse(Console.ReadLine());
                            if (retiro > 500)
                            {
                                Console.WriteLine("No es posible realizar esta acciòn..");
                            }
                            else
                            {
                                if (retiro > (saldo-8))
                                {
                                    Console.WriteLine("Saldo insuficiente..");
                                }
                                else
                                {
                                    saldo = saldo - retiro - 8;
                                    Console.WriteLine("Retiro realizado con exito....");
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Su saldo es: " + saldo);
                            break;
                        case 4:
                            Console.WriteLine("Saliendo.....");
                            break;
                        default:
                            Console.WriteLine("Seleccione una opcion correcta...");
                            break;
                    }

                } while (opcion != 4);
            }
        }
        
    }
}
