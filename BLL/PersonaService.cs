using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Entity;
namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personarepository;
        public void CalcularPulsacion(Persona perso)
        {
     
            if (perso.sexo.ToUpper().Equals("F"))
            {
                perso.pulsacion = ((220 - perso.edad) / 10);
            }
            else if (perso.sexo.ToUpper().Equals("M"))
            {
                perso.pulsacion = ((210 - perso.edad) / 10);
            }
            else
            {
                perso.pulsacion = 0;
            }

            
        }
        public void Guardar(Persona persona)
        {
            personarepository.Guardar(persona);


        }
        public void Consultar()
        {
            personarepository.Consultar();
        }
        public PersonaService()
        {
           personarepository = new PersonaRepository();
        }
    }
    
}
