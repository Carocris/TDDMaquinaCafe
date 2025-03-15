using System;

namespace SistemaCafe
{
    class SimuladorCafe
    {
        static void Main1()
        {
            var maquinaCafe = new ExpendedorCafe();

            Console.WriteLine("Indique el tamaño del recipiente (Pequeño, Mediano, Grande):");
            string opcionVaso = Console.ReadLine();
            Console.WriteLine(maquinaCafe.ElegirVaso(opcionVaso, true)); 
            Console.WriteLine("Especifique cuántas cucharadas de azúcar desea (0-5):");
            if (!int.TryParse(Console.ReadLine(), out int nivelAzucar) || nivelAzucar < 0 || nivelAzucar > 5)
            {
                Console.WriteLine("Error: Introduzca un valor entre 0 y 5");
                return;
            }
            Console.WriteLine(maquinaCafe.ConfigurarAzucar(nivelAzucar, true)); 

            Console.WriteLine(maquinaCafe.DispensarCafe(opcionVaso, nivelAzucar, true)); 
        }
    }
}
