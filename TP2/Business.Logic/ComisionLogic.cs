using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ComisionLogic : BusinessLogic
    {
        private ComisionAdapter _ComisionData;

        public ComisionAdapter ComisionData
            {               
             get{ return _ComisionData; }
            }
                
        public ComisionLogic()
            {
            _ComisionData = new ComisionAdapter();
            }


        public List<Comision> GetAll()
        {
        return ComisionData.GetAll();
        }

        public Comision GetOne(int ID)    
        {
        return ComisionData.GetOne(ID);
        }

        public void Delete( int ID)
        {
        ComisionData.Delete(ID); 
        }

        public void Save(Comision comision)
        {
        ComisionData.Save(comision);   
        }
    }
}
 