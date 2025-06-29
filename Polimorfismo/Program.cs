using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
   
        public class Herramienta
        {
            public virtual void Usar()
            {
                Console.WriteLine("Usas una herramienta genérica.");
            }
        }

        public class Pico : Herramienta
        {
            public override void Usar()
            {
                Console.WriteLine("Picas piedra con el pico.");
            }
        }

        public class Pala : Herramienta
        {
            public override void Usar()
            {
                Console.WriteLine("Cavas tierra con la pala.");
            }
        }

        public class Hacha : Herramienta
        {
            public override void Usar()
            {
                Console.WriteLine("Cortas madera con el hacha.");
            }
        }

        class Program
        {
            static void UsarHerramientas(List<Herramienta> herramientas)
            {
                foreach (Herramienta h in herramientas)
                {
                    h.Usar(); // Polimorfismo dinámico
                }
            }

            static void Main(string[] args)
            {
                List<Herramienta> mochila = new List<Herramienta>
            {
                new Pico(),
                new Pala(),
                new Hacha()
            };

            Console.WriteLine("=== POLIMORFISMO DINAMICO ===");
            Console.WriteLine("Usando herramientas de Minecraft:");
                UsarHerramientas(mochila);


                Calculadora calc = new Calculadora();

                Console.WriteLine("=== POLIMORFISMO ESTATICO ===");
                Console.WriteLine("Suma de 2 enteros: " + calc.Sumar(5, 3));
                Console.WriteLine("Suma de 2 dobles: " + calc.Sumar(2.5, 4.1));
                Console.WriteLine("Suma de 3 enteros: " + calc.Sumar(1, 2, 3));

                Console.WriteLine("\nPresiona una tecla para salir...");
                Console.ReadKey();

            }
        }
}