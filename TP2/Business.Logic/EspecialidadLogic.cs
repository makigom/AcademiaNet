using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class EspecialidadLogic : BusinessLogic
    {
        private EspecialidadAdapter _EspecialidadData;

        public EspecialidadAdapter EspecialidadData
            {
                
             get{
                 return _EspecialidadData;
                 }
            }
                
        public EspecialidadLogic()
            {
            _EspecialidadData = new EspecialidadAdapter();
            }


        public List<Especialidad> GetAll()
        {
            return EspecialidadData.GetAll();
        }

        public Especialidad GetOne(int ID) 
      
        {
            return EspecialidadData.GetOne(ID);
        }


        public void Delete( int ID)
        {
            EspecialidadData.Delete(ID); 
        }


        public void Save( Especialidad Especialidades)
        {
            EspecialidadData.Save(Especialidades);   
        }

    }
}
