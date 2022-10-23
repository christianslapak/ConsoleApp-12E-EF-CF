using System;
using System.Linq;

namespace ConsoleApp_12E_EF_CF
{
    class Program
    {
        static void Main(string[] args)
        {
            var contexto = new EscuelaContext();

            var materias = contexto.Cursos.ToList();

            foreach (var mate in materias)
            {
                Console.WriteLine("Nombre materia:" + mate.Nombre);
            }
            Console.ReadKey();
        }
    }
}
