using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        private string ruta = "Persona.txt";
        private List<Persona> perso;
        public void Guardar(Persona persona)
        {
            FileStream file = new FileStream(ruta, FileMode.Append);
            StreamWriter escritor = new StreamWriter(file);

            escritor.WriteLine($"{persona.Identificacion};" +
                $"{persona.nombre};" +
                $"{persona.sexo};" +
                $"{persona.edad};" +
                $"{persona.pulsacion};");
            escritor.Close();
            file.Close();


            Consultar();
            Console.ReadKey();
        }
        public List<Persona> Consultar() 
        {
            Console.WriteLine("--------------------");
            perso = new List<Persona>();
            string linea = string.Empty;
            FileStream stream = new FileStream(ruta, FileMode.Truncate);
            StreamReader reader = new StreamReader(stream);

            while((linea = reader.ReadLine()) != null)
            {

                Persona persona = new Persona();
                char delimiter = ',';
                string[] list = linea.Split(delimiter);
                persona.Identificacion = list[0];
                persona.nombre = list[1];
                persona.edad = Convert.ToInt32(list[2]);
                persona.pulsacion = Convert.ToDecimal(list[3]);

                perso.Add(persona);
                Console.WriteLine(persona);
            }
            
            reader.Close();
            stream.Close();

            
            return perso;
        }


    }
}


