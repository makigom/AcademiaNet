using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class DocenteCursoLogic : BusinessLogic
    {
        private DocenteCursoAdapter _DocenteCursoData;

        public DocenteCursoAdapter DocenteCursoData
            {
                
             get{
                 return _DocenteCursoData;
                 }
            }
                
        public DocenteCursoLogic()
            {
            _DocenteCursoData = new DocenteCursoAdapter();
            }


        public List<DocenteCurso> GetAll()
        {
        return DocenteCursoData.GetAll();
        }

        public DocenteCurso GetOne(int ID) 
      
        {
        return DocenteCursoData.GetOne(ID);
        }


        public void Delete( int ID)
        {
        DocenteCursoData.Delete(ID); 
        }


        public void Save( DocenteCurso DocenteCurso)
        {
        DocenteCursoData.Save(DocenteCurso);   
        }

    }
}

