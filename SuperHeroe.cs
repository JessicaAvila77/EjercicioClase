using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre {  get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad {  get; set; }
        public bool PuedeVolar { get; set; }
        //referencia a la clase SuperPoder
        public SuperPoder SuperPoder { get; set; }

        //Constructor
        public  SuperHeroe()
        {
            PuedeVolar = true;
            //cada vez que cree un nuevo objeto el inicializará la clase
            SuperPoder = new SuperPoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede Volar: {(PuedeVolar ? "Si" : "No")}");
            Console.WriteLine($"Super poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.Nivel}");

        }


    }
}
