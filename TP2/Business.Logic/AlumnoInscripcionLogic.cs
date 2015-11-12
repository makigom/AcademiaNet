using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic : BusinessLogic
    {
        private AlumnoInscripcionAdapter _AIData;

        public AlumnoInscripcionAdapter AIData
            {
                
             get{
                 return _AIData;
                 }
            }
                
        public AlumnoInscripcionLogic()
            {
            _AIData = new AlumnoInscripcionAdapter();
            }


        public List<AlumnoInscripciones> GetAll()
        {
        return AIData.GetAll();
        }

        public AlumnoInscripciones GetOne(int ID)       
        {
        return AIData.GetOne(ID);
        }

        public void InsertRegistroAlumno(AlumnoInscripciones alumnoInscripciones)
        {
            AIData.InsertRegistroAlumno(alumnoInscripciones);
        }

        public void Delete( int ID)
        {
        AIData.Delete(ID); 
        }


        public void Save( AlumnoInscripciones alumnoInscripcion)
        {
        AIData.Save(alumnoInscripcion);   
        }
    }
}
