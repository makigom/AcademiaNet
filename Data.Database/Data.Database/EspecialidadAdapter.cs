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
    public class EspecialidadAdapter : Adapter
    {
        public List<Especialidad> GetAll()
        {

            List<Especialidad> especialidades = new List<Especialidad>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("select * from especialidades", sqlConn);


                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                while (drEspecialidades.Read())
                {

                    Especialidad e = new Especialidad();
               
                    e.ID = (int)drEspecialidades["id_especialidad"];
                    e.Descripcion = (string)drEspecialidades["desc_especialidad"]; //en la pc de maki funciona con desc_especialidad, si lo cambian avisar

                    especialidades.Add(e);
                }

                drEspecialidades.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return especialidades;

        }


        public Especialidad GetOne(int ID)
        {

            Especialidad e = new Especialidad();

            try
            {
                this.OpenConnection();

                SqlCommand cmdEspecialidades = new SqlCommand("SELECT * from especialidades where id_especialidad=@id_especialidad", sqlConn);
                cmdEspecialidades.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidades = cmdEspecialidades.ExecuteReader();

                if (drEspecialidades.Read())
                {
                    e.ID = (int)drEspecialidades["id_especialidad"];
                    e.Descripcion = (string)drEspecialidades["desc_especialidad"];
                }

                drEspecialidades.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return e;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDelete = new SqlCommand("delete especialidades where id_especialidad=@id_especialidad", sqlConn);
                cmdDelete.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = ID;
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


        protected void Update(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE especialidades SET desc_especialidad=@desc_especialidad WHERE id_especialidad=@id_especialidad", sqlConn);

                cmdSave.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = especialidad.ID;
                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
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


        protected void Insert(Especialidad especialidad)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into especialidades (desc_especialidad) " +
                    "values (@desc_especialidad)" +
                    " select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_especialidad", SqlDbType.VarChar, 50).Value = especialidad.Descripcion;
                especialidad.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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


        public void Save(Especialidad especialidad)
        {
            if (especialidad.State == BusinessEntity.States.Deleted)
            {
                this.Delete(especialidad.ID);
            }
            else if (especialidad.State == BusinessEntity.States.New)
            {
                this.Insert(especialidad);
            }
            else if (especialidad.State == BusinessEntity.States.Modified)
            {
                this.Update(especialidad);
            }
            especialidad.State = BusinessEntity.States.Unmodified;
        }
    }
}
