using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class ModuloUsuarioLogic : BusinessLogic
    {
        private ModuloUsuarioAdapter _ModuloUsuarioData;

        public ModuloUsuarioAdapter ModuloUsuarioData
            {               
             get{ return _ModuloUsuarioData; }
            }

        public ModuloUsuarioLogic()
            {
                _ModuloUsuarioData = new ModuloUsuarioAdapter();
            }


        public List<ModuloUsuario> GetAll()
        {
            return ModuloUsuarioData.GetAll();
        }

        public List<ModuloUsuario> GetPermisos(int id)
        {
            return ModuloUsuarioData.GetPermisos(id);
        }

        public ModuloUsuario GetOne(int ID)    
        {
            return ModuloUsuarioData.GetOne(ID);
        }

        public ModuloUsuario GetOneByUsuario(string modulo, int usuario)
        {
            return ModuloUsuarioData.GetOneByUsuario(modulo, usuario);
        }

        public void Delete( int ID)
        {
            ModuloUsuarioData.Delete(ID); 
        }

        public void Save( ModuloUsuario ModuloUsuario)
        {
            ModuloUsuarioData.Save(ModuloUsuario);   
        }   
    }
}
