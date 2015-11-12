using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
    {
    public class BusinessEntity
        {

        //Enumeración
        public enum States {Deleted, New, Modified, Unmodified }

        public BusinessEntity() 
        {
        this.State = States.New;     
        }

        private int _ID;

        //Propiedad llamada ID
        public int ID
        {
        get {
            return _ID;
            }
        set
            {
            _ID = value;
            }     
        }

        private States _State;

        //Propiedad llamada State
        
        public States State
        {
        get {
            return _State;
            }
        set
            {
            _State = value;
            }     
        }
    
   }
 }
