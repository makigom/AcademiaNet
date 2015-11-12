using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class AlumnoInscripcionAdapter : Adapter
    {         
        public List<AlumnoInscripciones> GetAll()
        {
            //instanciamos el objeto lista a retornar

            List<AlumnoInscripciones> alumnosInscripciones = new List<AlumnoInscripciones>();

            try
            {
                this.OpenConnection();

                /*creo el obje sqlcommand que sera la sentencia SQl que vamos a ejecutar
                  contra la BD. (los datos de la bd: usario, contraseña, etc estan en connection
                  string.*/
                
                SqlCommand cmdAlumnosInscripciones = new SqlCommand("select * from alumnos_inscripciones", sqlConn);

                //instancio un obj datareader que va a ser el que recupere los datos de la BD
                
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();

                /*read() lee una fila de las devueltas por el comando sql, carga los datos
                  en drUsurios para pdoer accederlos, devuelve erdadero meintras haya podido
                  leer datos y avanza a la fila siguiente para el proximo read.*/
                
                while (drAlumnosInscripciones.Read())
                {
                    /*creo un obj usuario de la capa de entidades para copiar los datos 
                      de la fila del datareader al objeto de entidades.*/
                   
                    AlumnoInscripciones aluInsc = new AlumnoInscripciones();

                    //copio los datos de la fila al obj
                    
                    aluInsc.ID = (int)drAlumnosInscripciones["id_inscripcion"];
                    aluInsc.IDAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    aluInsc.IDCurso = (int)drAlumnosInscripciones["id_curso"];
                    aluInsc.Nota = (int)drAlumnosInscripciones["nota"];
                    aluInsc.Condicion = (string)drAlumnosInscripciones["condicion"];

                    //agrego el objeto con datos a la lista que devuelvo
                    
                    alumnosInscripciones.Add(aluInsc);
                }

                //cerramos el datareader y la conexion a la BD

                drAlumnosInscripciones.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }

            return alumnosInscripciones;

        }


        public AlumnoInscripciones GetOne(int ID)
        {
            AlumnoInscripciones aluInsc = new AlumnoInscripciones();
            try
            {
                this.OpenConnection();

                SqlCommand cmdAlumnosInscripciones = new SqlCommand("SELECT * from alumnos_inscripciones where id_inscripcion=@id_inscripcion", sqlConn);
                cmdAlumnosInscripciones.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnosInscripciones = cmdAlumnosInscripciones.ExecuteReader();

                if (drAlumnosInscripciones.Read())
                {
                    aluInsc.ID = (int)drAlumnosInscripciones["id_inscripcion"];
                    aluInsc.IDAlumno = (int)drAlumnosInscripciones["id_alumno"];
                    aluInsc.IDCurso = (int)drAlumnosInscripciones["id_curso"];
                    aluInsc.Nota = (int)drAlumnosInscripciones["nota"];
                    aluInsc.Condicion = (string)drAlumnosInscripciones["condicion"];
                }
                
                drAlumnosInscripciones.Close();
                
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {               
                this.CloseConnection();
            }
            return aluInsc;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete alumnos_inscripciones where id_inscripcion=@id_inscripcion", sqlConn);

                cmdDelete.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = ID;
                
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


        protected void Update(AlumnoInscripciones alumnoInscripciones)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE alumnos_inscripciones SET id_alumno=@id_alumno,"
                    + "id_curso=@id_curso, nota=@nota, condicion=@condicion " +
                    "WHERE id_inscripcion=@id_inscripcion", sqlConn);

                cmdSave.Parameters.Add("@id_inscripcion", SqlDbType.Int).Value = alumnoInscripciones.ID;
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumnoInscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumnoInscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumnoInscripciones.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumnoInscripciones.Nota;

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

        protected void Insert(AlumnoInscripciones alumnoInscripciones)
        {
            try
            {
                this.OpenConnection();
        
                SqlCommand cmdSave = new SqlCommand(
                    "insert into alumnos_inscripciones (id_alumno, id_curso, condicion, nota) " +
                    "values (@id_alumno, @id_curso, @condicion, @nota) " +
                    "select @@identity", sqlConn);
                
                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumnoInscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumnoInscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = alumnoInscripciones.Condicion;
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = alumnoInscripciones.Nota;
                alumnoInscripciones.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void InsertRegistroAlumno(AlumnoInscripciones alumnoInscripciones)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into alumnos_inscripciones (id_alumno, id_curso, condicion, nota) " +
                    "values (@id_alumno, @id_curso, @condicion, @nota) " +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id_alumno", SqlDbType.Int).Value = alumnoInscripciones.IDAlumno;
                cmdSave.Parameters.Add("@id_curso", SqlDbType.Int).Value = alumnoInscripciones.IDCurso;
                cmdSave.Parameters.Add("@condicion", SqlDbType.VarChar, 50).Value = "Inscripto";
                cmdSave.Parameters.Add("@nota", SqlDbType.Int).Value = null;
                alumnoInscripciones.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void Save(AlumnoInscripciones alumnoInscripcion)
        {
            if (alumnoInscripcion.State == BusinessEntity.States.Deleted)
            {
                this.Delete(alumnoInscripcion.ID);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.New)
            {
                this.Insert(alumnoInscripcion);
            }
            else if (alumnoInscripcion.State == BusinessEntity.States.Modified)
            {
                this.Update(alumnoInscripcion);
            }    
            alumnoInscripcion.State = BusinessEntity.States.Unmodified;
        }
    }

    }
