using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instanciando la clase SuperHeroe
            SuperHeroe superHeroe = new SuperHeroe();

            for (int i = 0; i < 3; i++) 
            {
                Console.Write("Ingrese el nombre del super heroe:");
                superHeroe.Nombre = Console.ReadLine();
                Console.Write("Ingrese la identidad secreta del super heroe:");
                superHeroe.IdentidadSecreta = Console.ReadLine();
                Console.Write("Ingrese la ciudad del super heroe:");
                superHeroe.Ciudad = Console.ReadLine();
                Console.Write("Ingrese si puede volar (si/no):");
                superHeroe.PuedeVolar = Console.ReadLine();
                Console.Write("Ingrese el super poder:");
                superHeroe.SuperPoder.Nombre = Console.ReadLine();
                Console.Write("Ingrese la descripción del super poder:");
                superHeroe.SuperPoder.Descripcion = Console.ReadLine();
                Console.Write("Ingrese el nivel:");
                superHeroe.SuperPoder.Nivel = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Imprimiendo...");
                superHeroe.Imprimir();
                Console.WriteLine("--------------------------------------");
            }


           

        }
    }
}
