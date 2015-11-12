using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PersonaLogic : BusinessLogic
    {
        private PersonaAdapter _PersonaData;

        public PersonaAdapter PersonaData
            {               
             get{ return _PersonaData; }
            }

        public PersonaLogic()
            {
            _PersonaData = new PersonaAdapter();
            }


        public List<Persona> GetAll()
        {
            return PersonaData.GetAll();
        }

        public Persona GetOne(int ID)    
        {
            return PersonaData.GetOne(ID);
        }

        public void Delete( int ID)
        {
            PersonaData.Delete(ID); 
        }

        public void Save(Persona persona)
        {
            PersonaData.Save(persona);   
        }
    }
}
