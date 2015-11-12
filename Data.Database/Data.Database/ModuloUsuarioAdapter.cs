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
    public class ModuloUsuarioAdapter:Adapter
    {
        public List<ModuloUsuario> GetAll()
        {
            List<ModuloUsuario> modulosUsuarios = new List<ModuloUsuario>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdModuloUsuarios = new SqlCommand("select * from modulos_usuarios", sqlConn);

                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();

                while (drModuloUsuarios.Read())
                {
                    ModuloUsuario mu = new ModuloUsuario();

                    mu.ID = (int)drModuloUsuarios["id_modulo_usuario"];
                    mu.IDModulo = (int)drModuloUsuarios["id_modulo"];
                    mu.IDUsuario = (int)drModuloUsuarios["id_usuario"];
                    mu.PermiteAlta = (bool)drModuloUsuarios["alta"];
                    mu.PermiteBaja = (bool)drModuloUsuarios["baja"];
                    mu.PermiteConsulta = (bool)drModuloUsuarios["consulta"];
                    mu.PermiteModificacion = (bool)drModuloUsuarios["modificacion"];

                    modulosUsuarios.Add(mu);
                }
                drModuloUsuarios.Close();

            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar lista de modulos usuarios", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
            return modulosUsuarios;
        }

        public ModuloUsuario GetOne(int ID)
        {
            ModuloUsuario mu = new ModuloUsuario();

            try
            {
                this.OpenConnection();

                SqlCommand cmdModuloUsuarios = new SqlCommand("SELECT * from modulos_usuarios where id_modulo_usuario=@id_modulo_usuario", sqlConn);

                cmdModuloUsuarios.Parameters.Add("@id_modulo_usuario", SqlDbType.Int).Value = ID;

                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();

                if (drModuloUsuarios.Read())
                {
                    mu.ID = (int)drModuloUsuarios["id_modulo_usuario"];
                    mu.IDModulo = (int)drModuloUsuarios["id_modulo"];
                    mu.IDUsuario = (int)drModuloUsuarios["id_usuario"];
                    mu.PermiteAlta = (bool)drModuloUsuarios["alta"];
                    mu.PermiteBaja = (bool)drModuloUsuarios["baja"];
                    mu.PermiteConsulta = (bool)drModuloUsuarios["consulta"];
                    mu.PermiteModificacion = (bool)drModuloUsuarios["modificacion"];
                }

                drModuloUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de modulo usuarios", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }
            return mu;
        }

        public ModuloUsuario GetOneByUsuario(string modulo, int usuario)
        {
            ModuloUsuario mu = new ModuloUsuario();

            try
            {
                this.OpenConnection();

                SqlCommand cmdModuloUsuarios = new SqlCommand("SELECT * from modulos_usuarios mod_usu inner join modulos mod on mod.id_modulo = mod_usu.id_modulo" +
                "  where id_usuario=@id_usuario" +
                " and desc_modulo=@desc_modulo", sqlConn);

                cmdModuloUsuarios.Parameters.Add("@desc_modulo", SqlDbType.VarChar).Value = modulo;
                cmdModuloUsuarios.Parameters.Add("@id_usuario", SqlDbType.Int).Value = usuario;

                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();
                drModuloUsuarios.Read();                 
                    mu.ID = (int)drModuloUsuarios["id_modulo_usuario"];
                    mu.IDModulo = (int)drModuloUsuarios["id_modulo"];
                    mu.IDUsuario = (int)drModuloUsuarios["id_usuario"];
                    mu.PermiteAlta = (bool)drModuloUsuarios["alta"];
                    mu.PermiteBaja = (bool)drModuloUsuarios["baja"];
                    mu.PermiteConsulta = (bool)drModuloUsuarios["consulta"];
                    mu.PermiteModificacion = (bool)drModuloUsuarios["modificacion"];
                   
                drModuloUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar datos de modulo usuarios", Ex);

                throw ExcepcionManejada;
            }

            finally
            {
                this.CloseConnection();
            }

            return mu;
        }


        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete modulos_usuarios where id_modulo_usuario=@id_modulo_usuario", sqlConn);

                cmdDelete.Parameters.Add("@id_modulo_usuario", SqlDbType.Int).Value = ID;

                cmdDelete.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al eliminar modulo usuarios", Ex);

                throw ExcepcionManejeada;
            }
            finally
            {
                this.CloseConnection();
            }
        }


        protected void Update(ModuloUsuario moduloUsuario)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE modulos_usuarios SET id_modulo=@id_modulo, id_usuario=@id_usuario, alta=@alta, baja=@baja," +
                    "consulta=@consulta, modificacion=@modificacion " +
                    "WHERE id_modulo_usuario=@id_modulo_usuario", sqlConn);

                cmdSave.Parameters.Add("@id_modulo_usuario", SqlDbType.Int).Value = moduloUsuario.ID;
                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = moduloUsuario.IDModulo;
                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = moduloUsuario.IDUsuario;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = moduloUsuario.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = moduloUsuario.PermiteBaja;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = moduloUsuario.PermiteConsulta;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Bit).Value = moduloUsuario.PermiteModificacion;

                cmdSave.ExecuteNonQuery();
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al modificar modulo usuarios", Ex);

                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }


        protected void Insert(ModuloUsuario moduloUsuario)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into modulos_usuarios(id_modulo,id_usuario,alta,baja,consulta,modificacion)" +
                    "values (@id_modulo, @id_usuario,@alta,@baja,@consulta,@modificacion)" +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = moduloUsuario.IDModulo;
                cmdSave.Parameters.Add("@id_usuario", SqlDbType.Int).Value = moduloUsuario.IDUsuario;
                cmdSave.Parameters.Add("@alta", SqlDbType.Bit).Value = moduloUsuario.PermiteAlta;
                cmdSave.Parameters.Add("@baja", SqlDbType.Bit).Value = moduloUsuario.PermiteBaja;
                cmdSave.Parameters.Add("@consulta", SqlDbType.Bit).Value = moduloUsuario.PermiteConsulta;
                cmdSave.Parameters.Add("@modificacion", SqlDbType.Bit).Value = moduloUsuario.PermiteModificacion;

                moduloUsuario.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
            }

            catch (Exception Ex)
            {
                Exception ExcepcionManejeada = new Exception("Error al crear modulo usuarios", Ex);

                throw ExcepcionManejeada;
            }

            finally
            {
                this.CloseConnection();
            }
        }

        public List<ModuloUsuario> GetPermisos(int id)
        {
            List<ModuloUsuario> modulosUsuarios = new List<ModuloUsuario>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdModuloUsuarios = new SqlCommand("select * from modulos_usuarios WHERE id_usuario=@id_usuario", sqlConn);
                cmdModuloUsuarios.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id;
                SqlDataReader drModuloUsuarios = cmdModuloUsuarios.ExecuteReader();

                while (drModuloUsuarios.Read())
                {
                    ModuloUsuario mu = new ModuloUsuario();

                    mu.ID = (int)drModuloUsuarios["id_modulo_usuario"];
                    mu.IDModulo = (int)drModuloUsuarios["id_modulo"];
                    mu.IDUsuario = (int)drModuloUsuarios["id_usuario"];
                    mu.PermiteAlta = (bool)drModuloUsuarios["alta"];
                    mu.PermiteBaja = (bool)drModuloUsuarios["baja"];
                    mu.PermiteConsulta = (bool)drModuloUsuarios["consulta"];
                    mu.PermiteModificacion = (bool)drModuloUsuarios["modificacion"];

                    modulosUsuarios.Add(mu);
                }
                drModuloUsuarios.Close();

            }

            catch (Exception Ex)
            {
                Console.Write(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return modulosUsuarios;
        }

        public void Save(ModuloUsuario moduloUsuario)
        {
            if (moduloUsuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(moduloUsuario.ID);
            }
            else if (moduloUsuario.State == BusinessEntity.States.New)
            {
                this.Insert(moduloUsuario);
            }
            else if (moduloUsuario.State == BusinessEntity.States.Modified)
            {
                this.Update(moduloUsuario);
            }
            moduloUsuario.State = BusinessEntity.States.Unmodified;
        }
    }
}
