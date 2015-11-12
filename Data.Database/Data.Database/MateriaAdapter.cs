using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            //instanciamos el objeto lista a retornar

            List<Materia> materias = new List<Materia>();

            try
            {
                this.OpenConnection();

                /*creo el obje sqlcommand que sera la sentencia SQl que vamos a ejecutar
                  contra la BD. (los datos de la bd: usario, contraseña, etc estan en connection
                  string.*/

                SqlCommand cmdMateria = new SqlCommand("select * from materias", sqlConn);

                //instancio un obj datareader que va a ser el que recupere los datos de la BD

                SqlDataReader drMaterias = cmdMateria.ExecuteReader();

                /*read() lee una fila de las devueltas por el comando sql, carga los datos
                  en drUsurios para pdoer accederlos, devuelve erdadero meintras haya podido
                  leer datos y avanza a la fila siguiente para el proximo read.*/

                while (drMaterias.Read())
                {
                    /*creo un obj usuario de la capa de entidades para copiar los datos 
                      de la fila del datareader al objeto de entidades.*/

                    Materia mat = new Materia();

                    //copio los datos de la fila al obj

                    mat.ID = (int)drMaterias["id_materia"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales = (int)drMaterias["hs_totales"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];


                    //agrego el objeto con datos a la lista que devuelvo                   
                    materias.Add(mat);
                }

                //cerramos el datareader y la conexion a la BD

                drMaterias.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return materias;
        }


        public Materia GetOne(int ID)
        {

            Materia mat = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * from materias where id_materia=@id_materia", sqlConn);
                cmdMaterias.Parameters.Add("@id_materia", SqlDbType.Int).Value = ID;
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                if (drMaterias.Read())
                {
                    mat.ID = (int)drMaterias["id_materia"];
                    mat.IDPlan = (int)drMaterias["id_plan"];
                    mat.HsSemanales = (int)drMaterias["hs_semanales"];
                    mat.HsTotales = (int)drMaterias["hs_totales"];
                    mat.Descripcion = (string)drMaterias["desc_materia"];
                }

                drMaterias.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return mat;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete materias where id_materia=@id_materia", sqlConn);
                cmdDelete.Parameters.Add("@id_materia", SqlDbType.Int).Value = ID;
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


        protected void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE materias SET desc_materia=@desc_materia, "
                    + "hs_semanales=@hs_semanales, hs_totales=@hs_totales, id_plan=@id_plan" +
                    " WHERE id_materia=@id_materia", sqlConn);

                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = materia.ID;
                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;

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


        protected void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into materias (desc_materia, hs_semanales, hs_totales, id_plan) " +
                    "values (@desc_materia, @hs_semanales, @hs_totales, @id_plan) " +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_materia", SqlDbType.VarChar, 50).Value = materia.Descripcion;
                cmdSave.Parameters.Add("@hs_semanales", SqlDbType.Int).Value = materia.HsSemanales;
                cmdSave.Parameters.Add("@hs_totales", SqlDbType.Int).Value = materia.HsTotales;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDPlan;
                materia.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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


        public void Save(Materia materia)
        {
            if (materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if (materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if (materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            materia.State = BusinessEntity.States.Unmodified;
        }
    }
}
