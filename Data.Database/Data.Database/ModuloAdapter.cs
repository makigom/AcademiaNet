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
    public class ModuloAdapter : Adapter
    {
        public List<Modulo> GetAll()
        {
            List<Modulo> modulos = new List<Modulo>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdModulos = new SqlCommand("select * from modulos", sqlConn);

                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                while (drModulos.Read())
                {
                    Modulo m = new Modulo();

                    m.ID = (int)drModulos["id_modulo"];
                    m.Descripcion=(String)drModulos["desc_modulo"];
                    m.Ejecuta = (String)drModulos["ejecuta"];

                    modulos.Add(m);
                }
                drModulos.Close();

            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return modulos;
        }

        public Modulo GetOne(int ID)
        {
            Modulo m = new Modulo();
            
            try
            {
                this.OpenConnection();
                SqlCommand cmdModulos = new SqlCommand("SELECT * from modulos where id_modulo=@id_modulo", sqlConn);

                cmdModulos.Parameters.Add("@id_modulo", SqlDbType.Int).Value = ID;
                
                SqlDataReader drModulos = cmdModulos.ExecuteReader();

                if (drModulos.Read())
                {
                    m.ID = (int)drModulos["id_modulo"];
                    m.Descripcion = (String)drModulos["desc_modulo"];
                    m.Ejecuta = (String)drModulos["ejecuta"];
                }

                drModulos.Close();
            }

            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }

            finally
            {
                this.CloseConnection();
            }
            return m;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdDelete = new SqlCommand("delete modulos where id_modulo=@id_modulo", sqlConn);
                cmdDelete.Parameters.Add("@id_modulo", SqlDbType.Int).Value = ID;
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


        protected void Update(Modulo modulo)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE modulos SET desc_modulo=@desc_modulo, ejecuta=@ejecuta " +
                    "WHERE id_modulo=@id_modulo", sqlConn);

                cmdSave.Parameters.Add("@id_modulo", SqlDbType.Int).Value = modulo.ID;
                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulo.Ejecuta;

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


        protected void Insert(Modulo modulo)
        {
            try
            {
                this.OpenConnection();

                SqlCommand cmdSave = new SqlCommand(
                    "insert into modulos(desc_modulo, ejecuta) " +
                    "values (@desc_modulo, @ejecuta) " +
                    "select @@identity", sqlConn);

                cmdSave.Parameters.Add("@desc_modulo", SqlDbType.VarChar, 50).Value = modulo.Descripcion;
                cmdSave.Parameters.Add("@ejecuta", SqlDbType.VarChar, 50).Value = modulo.Ejecuta;
                modulo.ID = Decimal.ToInt32((decimal)cmdSave.ExecuteScalar());
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

        public void Save(Modulo modulo)
        {
            if (modulo.State == BusinessEntity.States.Deleted)
            {
                this.Delete(modulo.ID);
            }
            else if (modulo.State == BusinessEntity.States.New)
            {
                this.Insert(modulo);
            }
            else if (modulo.State == BusinessEntity.States.Modified)
            {
                this.Update(modulo);
            }
            modulo.State = BusinessEntity.States.Unmodified;
        }
    }
}
