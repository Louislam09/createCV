using System;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio c = new Inicio();
            c.datos();

        }
    }

    class Inicio
    {
        public void datos()
        {
            Console.Clear();
            Console.Write("Escribe tu dia de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Escribe tu mes de nacimiento: ");
            int mes = int.Parse(Console.ReadLine());
            Console.Write("Escribe tu año de nacimiento: ");
            int año = int.Parse(Console.ReadLine());

            int edad = DateTime.Now.Year - año;

            Console.Write("Tu edad es : "+edad+"años");
        }
    }
}
