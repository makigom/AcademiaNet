using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);               
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                while (drPlanes.Read())
                {
                    Plan p = new Plan();

                    p.ID = (int)drPlanes["id_plan"];
                    p.Descripcion = (string)drPlanes["desc_plan"];
                    p.IDEspecialidad = (int)drPlanes["id_especialidad"];

                    planes.Add(p);
                }
                drPlanes.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return planes;

        }

        public Plan GetOne(int ID)
        {

            Plan p = new Plan();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPlanes = new SqlCommand("SELECT * from planes where id_plan=@id_plan", sqlConn);

                cmdPlanes.Parameters.Add("@id_plan", SqlDbType.Int).Value = ID;

                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();

                if (drPlanes.Read())
                {
                    p.ID = (int)drPlanes["id_plan"];
                    p.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    p.Descripcion = (string)drPlanes["desc_plan"];
                }

                drPlanes.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return p;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                
                SqlCommand cmdDelete = new SqlCommand("delete planes where id_plan=@id_plan", sqlConn);
                
                cmdDelete.Parameters.Add("@id_plan", SqlDbType.Int).Value = ID;
                
                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Update(Plan plan)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes SET id_especialidad=@id_especialidad, desc_plan=@desc_plan "
                    + "WHERE id_plan=@id_plan", sqlConn);

                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = plan.ID;
                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;

                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(Plan plan)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "insert into planes (desc_plan, id_especialidad)" +
                    "values (@desc_plan, @id_especialidad)" +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_plan", SqlDbType.VarChar, 50).Value = plan.Descripcion;
                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = plan.IDEspecialidad;

                plan.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public void Save(Plan plan)
        {
            if (plan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(plan.ID);
            }
            else if (plan.State == BusinessEntity.States.New)
            {
                this.Insert(plan);
            }
            else if (plan.State == BusinessEntity.States.Modified)
            {
                this.Update(plan);
            }    
            plan.State = BusinessEntity.States.Unmodified;
        }
    }
}

