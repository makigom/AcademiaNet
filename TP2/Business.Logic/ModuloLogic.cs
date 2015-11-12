using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class ModuloLogic : BusinessLogic
    {
        private ModuloAdapter _ModuloData;

        public ModuloAdapter ModuloData
            {               
             get{ return _ModuloData; }
            }
                
        public ModuloLogic()
            {
            _ModuloData = new ModuloAdapter();
            }


        public List<Modulo> GetAll()
        {
        return ModuloData.GetAll();
        }

        public Modulo GetOne(int ID)    
        {
        return ModuloData.GetOne(ID);
        }


        public void Delete( int ID)
        {
        ModuloData.Delete(ID); 
        }

        public void Save( Modulo Modulo)
        {
        ModuloData.Save(Modulo);   
        }    
    }
}

