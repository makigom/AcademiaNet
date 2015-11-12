using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
    {
    public class Materia : BusinessEntity
        {

        private string _Descripcion;

        private int _HsSemanales;

        private int _HsTotales;

        private int _IDPlan;

        public string Descripcion
            {

            get
                {
                return _Descripcion;
                }
            set
                {
                _Descripcion = value;
                }
            }

        public int HsSemanales
            {

            get
                {
                return _HsSemanales;
                }
            set
                {
                _HsSemanales = value;
                }
            }

        public int HsTotales
            {

            get
                {
                return _HsTotales;
                }
            set
                {
                _HsTotales = value;
                }
            }

        public int IDPlan
            {

            get
                {
                return _IDPlan;
                }
            set
                {
                _IDPlan = value;
                }
            } 

        }
    }
