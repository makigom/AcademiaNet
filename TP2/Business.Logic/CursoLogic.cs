using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class CursoLogic : BusinessLogic
    {
        private CursoAdapter _CursoData;

        public CursoAdapter CursoData
            {
                
             get{
                 return _CursoData;
                 }
            }
                
        public CursoLogic()
            {
            _CursoData = new CursoAdapter();
            }


        public List<Curso> GetAll()
        {
        return CursoData.GetAll();
        }

        public Curso GetOne(int ID) 
      
        {
        return CursoData.GetOne(ID);
        }


        public void Delete( int ID)
        {
        _CursoData.Delete(ID); 
        }


        public void Save( Curso Curso)
        {
        _CursoData.Save(Curso);   
        }
    
    }

}


