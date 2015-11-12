using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
    {
    public class Usuario : BusinessEntity
        {
        private string _NombreUsuario;
        private string _Clave;
        private bool _Habilitado;
        private int _IDPersona;
      
        public int IDPersona
        {
            get { return _IDPersona; }
            set { _IDPersona = value; }
        }

        public string NombreUsuario 
        {
        get { return _NombreUsuario; }
        set { _NombreUsuario = value; }
        }

        public string Clave
        {
            get { return _Clave; }
            set { _Clave = value; }
        }

        public bool Habilitado
        {
            get { return _Habilitado; }
            set { _Habilitado = value; }
        }
        }
    }
