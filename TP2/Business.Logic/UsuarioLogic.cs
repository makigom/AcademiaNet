using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic 
    {
        private UsuarioAdapter _UsuarioData;

        public UsuarioAdapter UsuarioData
            {               
                get{ return _UsuarioData; }
            }
                
        public UsuarioLogic()
            {
                _UsuarioData = new UsuarioAdapter();
            }


        public List<Usuario> GetAll()
        {
             return UsuarioData.GetAll();
        }

        public Usuario GetOne(int ID)    
        {
            return UsuarioData.GetOne(ID);
        }

        public void Delete( int ID)
        {
            UsuarioData.Delete(ID); 
        }

        public void Save( Usuario Usuario)
        {
            UsuarioData.Save(Usuario);   
        }

        public Usuario GetUsuarioForLogin(string user, string pass)
        {
            return UsuarioData.GetUsuarioForLogin(user, pass);
        }

     }
}
