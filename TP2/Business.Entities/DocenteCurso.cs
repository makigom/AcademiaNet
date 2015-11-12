using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
    {
    public class DocenteCurso : BusinessEntity
        {
        private string _TipoCargo;

        private int _IDCurso;
        
        private int _IDDocente;


        public string TipoCargo
        {
            get
            {
                return _TipoCargo;
            }
            set
            {
                _TipoCargo = value;
            }
        }
        
        public int IDCurso 
        {

            get
            {
            return _IDCurso;
            }
            set 
            {
            _IDCurso = value;
            }
        }

        public int IDDocente
            {

            get
                {
                return _IDDocente;
                }
            set
                {
                _IDDocente = value;
                }
            } 
        }
    }
