using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter : Adapter
    {
         public List<Curso> GetAll()
        {
            //instanciamos el objeto lista a retornar

            List<Curso> cursos = new List<Curso>();

            try
            {
                this.OpenConnection();

                /*creo el obje sqlcommand que sera la sentencia SQl que vamos a ejecutar
                  contra la BD. (los datos de la bd: usario, contraseña, etc estan en connection
                  string.*/
                
                SqlCommand cmdCursos = new SqlCommand("select * from cursos", sqlConn);

                //instancio un obj datareader que va a ser el que recupere los datos de la BD

                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                /*read() lee una fila de las devueltas por el comando sql, carga los datos
                  en drCursos para pdoer accederlos, devuelve erdadero meintras haya podido
                  leer datos y avanza a la fila siguiente para el proximo read.*/

                while (drCursos.Read())
                {
                    /*creo un obj curso de la capa de entidades para copiar los datos 
                      de la fila del datareader al objeto de entidades.*/
                   
                    Curso cur = new Curso();

                    //copio los datos de la fila al obj

                    cur.ID = (int)drCursos["id_curso"];
                    cur.Cupo = (int)drCursos["cupo"];
                    //cur.Descripcion = (string)drCursos["descripcion"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                    

                    //agrego el objeto con datos a la lista que devuelvo

                    cursos.Add(cur);
                }

                //cerramos el datareader y la conexion a la BD

                drCursos.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return cursos;

        }


        public Curso GetOne(int ID)
        {

            Curso cur = new Curso();

            try
            {
                this.OpenConnection();

                SqlCommand cmdCursos = new SqlCommand("SELECT * from cursos where id_curso=@id_curso", sqlConn);
                cmdCursos.Parameters.Add("@id_curso", SqlDbType.Int).Value = ID;
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                if (drCursos.Read())
                {
                    cur.ID = (int)drCursos["id_curso"];
                    cur.Cupo = (int)drCursos["cupo"];
                    cur.IDComision = (int)drCursos["id_comision"];
                    cur.IDMateria = (int)drCursos["id_materia"];
                    cur.AnioCalendario = (int)drCursos["anio_calendario"];
                }

                drCursos.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return cur;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete cursos where id_curso=@id_curso", sqlConn);

                cmdDelete.Parameters.Add("@id_curso", SqlDbType.Int).Value = ID;
                
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


        protected void Update(Curso curso)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos SET id_materia=@id_materia, "
                    + "id_comision=@id_comision, anio_calendario=@anio_calendario, cupo=@cupo " +
                    "WHERE id_curso=@id_curso", sqlConn);

                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
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


        protected void Insert(Curso curso)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "insert into cursos (id_materia, id_comision, anio_calendario, cupo)" +
                    "values (@id_materia, @id_comision, @anio_calendario, @cupo)" +
                    "select @@identity", sqlConn);
               
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                curso.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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


        public void Save(Curso curso)
        {
            if (curso.State == BusinessEntity.States.Deleted)
            {
                this.Delete(curso.ID);
            }
            else if (curso.State == BusinessEntity.States.New)
            {
                this.Insert(curso);
            }
            else if (curso.State == BusinessEntity.States.Modified)
            {
                this.Update(curso);
            }
            curso.State = BusinessEntity.States.Unmodified;
        }
    
    }
}
