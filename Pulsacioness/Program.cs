using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
using System.IO;

namespace Pulsacioness
{
    class Program
    {

        static void Main(string[] args)
        {
            PersonaService personaservice = new PersonaService();
            
            Persona perso = new Persona();

            int eleccion = 0;
            Console.WriteLine("Quiere registrar una persona? 1 = si");
            eleccion = int.Parse(Console.ReadLine());
            if(eleccion == 1)
            {
                Console.WriteLine("Digite identificacion");
                perso.Identificacion = Console.ReadLine();
                Console.WriteLine("Digite su nombre");
                perso.nombre = Console.ReadLine();
                Console.WriteLine("Digite edad");
                perso.edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite sexo");
                perso.sexo = Console.ReadLine();
                personaservice.CalcularPulsacion(perso);
                personaservice.Guardar(perso);
                Console.WriteLine($"Su pulsacion es: {perso.pulsacion}");
                eleccion = 0;
            }

            Console.WriteLine("Quiere consultar una persona? 1 = si");
            eleccion = int.Parse(Console.ReadLine());
            if(eleccion == 1)
            {

                personaservice.Consultar();

            }

            
            Console.ReadKey();
            

        }
    }
}
