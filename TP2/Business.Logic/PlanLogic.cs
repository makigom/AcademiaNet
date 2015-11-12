using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;


namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter _PlanData;

        public PlanAdapter PlanData
            {
                
             get{
                 return _PlanData;
                 }
            }
                
        public PlanLogic()
            {
            _PlanData = new PlanAdapter();
            }


        public List<Plan> GetAll()
        {
        return PlanData.GetAll();
        }

        public Plan GetOne(int ID)  
        {
        return PlanData.GetOne(ID);
        }


        public void Delete( int ID)
        {
        PlanData.Delete(ID); 
        }


        public void Save( Plan Plan)
        {
        PlanData.Save(Plan);   
        }
    }

}
