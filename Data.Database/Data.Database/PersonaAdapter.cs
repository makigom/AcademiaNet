using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;


namespace Data.Database
{
    public class PersonaAdapter : Adapter
    {
        public List<Persona> GetAll()
        {
            //instanciamos el objeto lista a retornar

            List<Persona> personas = new List<Persona>();

            try
            {
                this.OpenConnection();

                /*creo el obje sqlcommand que sera la sentencia SQl que vamos a ejecutar
                  contra la BD. (los datos de la bd: usario, contraseña, etc estan en connection
                  string.*/

                SqlCommand cmdPersonas = new SqlCommand("select * from personas", sqlConn);

                //instancio un obj datareader que va a ser el que recupere los datos de la BD

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                /*read() lee una fila de las devueltas por el comando sql, carga los datos
                  en drUsurios para pdoer accederlos, devuelve erdadero meintras haya podido
                  leer datos y avanza a la fila siguiente para el proximo read.*/

                while (drPersonas.Read())
                {
                    /*creo un obj usuario de la capa de entidades para copiar los datos 
                      de la fila del datareader al objeto de entidades.*/

                    Persona per = new Persona();

                    //copio los datos de la fila al obj

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Telefono = (string)drPersonas["telefono"];
                    switch((int)drPersonas["tipo_persona"])
                    {
                        case 1:
                            per.TiposPersona = "No Docente";
                            break;
                        case 2:
                            per.TiposPersona = "Alumno";
                            break;
                        case 3:
                            per.TiposPersona = "Docente";
                            break;
                        case 4:
                            per.TiposPersona = "Administrador";
                            break;
                    }
                    
                    //agrego el objeto con datos a la lista que devuelvo                   
                    personas.Add(per);
                }

                //cerramos el datareader y la conexion a la BD

                drPersonas.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return personas;
        }


        public Persona GetOne(int ID)
        {
            Persona per = new Persona();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * from personas where id_persona=@id_persona", sqlConn);
                cmdPersonas.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                if (drPersonas.Read())
                {
                    per.ID = (int)drPersonas["id_persona"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Telefono = (string)drPersonas["telefono"];
                    switch ((int)drPersonas["tipo_persona"])
                    {
                        case 1:
                            per.TiposPersona = "No Docente";
                            break;
                        case 2:
                            per.TiposPersona = "Alumno";
                            break;
                        case 3:
                            per.TiposPersona = "Docente";
                            break;
                        case 4:
                            per.TiposPersona = "Administrador";
                            break;
                    }

                }
                drPersonas.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return per;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete personas where id_persona=@id_persona", sqlConn);
                cmdDelete.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
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


        protected void Update(Persona persona)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE personas SET apellido=@apellido, nombre=@nombre, direccion=@direccion, telefono=@telefono, "
                    + "fecha_nac=@fecha_nac, legajo=@legajo, tipo_persona=@tipo_persona, email=@email, id_plan=@id_plan WHERE id_persona=@id_persona", sqlConn);

                cmdSave.Parameters.Add("@id_persona", SqlDbType.Int).Value = persona.ID;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                switch (persona.TiposPersona)
                {
                    case "No docente":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
                        break;
                    case "Alumno":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
                        break;
                    case "Docente":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 3;
                        break;
                }
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
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


        protected void Insert(Persona persona)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into personas (apellido, nombre, fecha_nac, direccion, telefono, email, legajo, tipo_persona, id_plan) " +
                    "values (@apellido, @nombre, @fecha_nac, @direccion, @telefono, @email, @legajo, @tipo_persona, @id_plan) " +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = persona.Apellido;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = persona.Nombre;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.DateTime, 50).Value = persona.FechaNacimiento;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = persona.Direccion;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = persona.Telefono;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = persona.Email;
                cmdSave.Parameters.Add("@legajo", SqlDbType.Int).Value = persona.Legajo;
                switch (persona.TiposPersona)
                {
                    case "No docente":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 1;
                        break;
                    case "Alumno":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 2;
                        break;
                    case "Docente":
                        cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = 3;
                        break;
                }
                cmdSave.Parameters.Add("@id_plan", SqlDbType.Int).Value = persona.IDPlan;
                persona.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public List<Persona> GetDocentes()
        {
            //instanciamos el objeto lista a retornar

            List<Persona> personas = new List<Persona>();

            try
            {
                this.OpenConnection();

                /*creo el obje sqlcommand que sera la sentencia SQl que vamos a ejecutar
                  contra la BD. (los datos de la bd: usario, contraseña, etc estan en connection
                  string.*/

                SqlCommand cmdPersonas = new SqlCommand("select * from personas WHERE tipo_persona=3", sqlConn);

                //instancio un obj datareader que va a ser el que recupere los datos de la BD

                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                /*read() lee una fila de las devueltas por el comando sql, carga los datos
                  en drUsurios para pdoer accederlos, devuelve erdadero meintras haya podido
                  leer datos y avanza a la fila siguiente para el proximo read.*/

                while (drPersonas.Read())
                {
                    /*creo un obj usuario de la capa de entidades para copiar los datos 
                      de la fila del datareader al objeto de entidades.*/

                    Persona per = new Persona();

                    //copio los datos de la fila al obj

                    per.ID = (int)drPersonas["id_persona"];
                    per.Nombre = (string)drPersonas["nombre"];
                    per.Apellido = (string)drPersonas["apellido"];
                    per.Direccion = (string)drPersonas["direccion"];
                    per.Email = (string)drPersonas["email"];
                    per.FechaNacimiento = (DateTime)drPersonas["fecha_nac"];
                    per.IDPlan = (int)drPersonas["id_plan"];
                    per.Legajo = (int)drPersonas["legajo"];
                    per.Telefono = (string)drPersonas["telefono"];
                    switch ((int)drPersonas["tipo_persona"])
                    {
                        case 1:
                            per.TiposPersona = "No Docente";
                            break;
                        case 2:
                            per.TiposPersona = "Alumno";
                            break;
                        case 3:
                            per.TiposPersona = "Docente";
                            break;
                    }

                    //agrego el objeto con datos a la lista que devuelvo                   
                    personas.Add(per);
                }

                //cerramos el datareader y la conexion a la BD

                drPersonas.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return personas;
        }

        public void Save(Persona persona)
        {
            if (persona.State == BusinessEntity.States.Deleted)
            {
                this.Delete(persona.ID);
            }
            else if (persona.State == BusinessEntity.States.New)
            {
                this.Insert(persona);
            }
            else if (persona.State == BusinessEntity.States.Modified)
            {
                this.Update(persona);
            }
            persona.State = BusinessEntity.States.Unmodified;
        }
    }
}
