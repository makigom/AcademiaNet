using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
    {
    public class Usuario
        {

        UsuarioLogic _UsuarioNegocio;

        public UsuarioLogic UsuarioNegocio
        { 
            get{return _UsuarioNegocio;} 
        }
        
        public Usuario()
            {

            _UsuarioNegocio = new UsuarioLogic();

            }


        public void Menu()
            {
             try
                {
                
                Console.WriteLine("MENU:\n1)Listado General\n2)Consulta\n3)Agregar\n4)Modificar\n5)Eliminar\n6)Salir\n");

                int opcion = int.Parse(Console.ReadLine());

                do
                    {
                    switch (opcion)
                        {
                        case 1:
                                {
                                ListadoGeneral();
                                Console.WriteLine("Presione una tecla para continuar.\n");
                                Console.ReadKey();
                                }
                            break;
                        case 2: Consultar();
                            break;
                        case 3:
                                {
                                Agregar();
                                Console.WriteLine("Presione una tecla para continuar.\n");
                                Console.ReadKey();
                                }
                            break;
                        case 4: Modificar();
                            break;
                        case 5: Eliminar();
                            break;
                        case 6: Environment.Exit(0);
                            break;
                        default: Console.WriteLine("La opción ingresada es incorrecta, por favor ingresela nuevamente.\n");
                            break;
                        }

                    Console.WriteLine("MENU:\n1)Listado General\n2)Consulta\n3)Agregar\n4)Modificar\n5)Eliminar\n6)Salir\n");

                    opcion = int.Parse(Console.ReadLine());

                    } while ((opcion >= 1) && (opcion < 6));
                }
            catch (FormatException)
                {

                Console.WriteLine();

                Console.WriteLine("La opción ingresada es un número entero, por favor vuelva a ingresarla.\n");
                }
            finally 
                {

                Console.WriteLine();

                 Menu();
                
                }

        }

        public void ListadoGeneral()
            {
            Console.Clear();

            foreach (Business.Entities.Usuario usr in UsuarioNegocio.GetAll())
                {
                MostrarDatos(usr);
                }
            }

        public void MostrarDatos(Business.Entities.Usuario usr)
            {
            Console.WriteLine("\t\tUsuario: {0}", usr.ID);
                        
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            
            Console.WriteLine("\t\tClave: {0}", usr.Clave);

            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            
            Console.WriteLine();
            }

        public void Consultar()
        
            {
            try
                {
                Console.Clear();

                Console.WriteLine("Ingrese el ID del usuario a consultar:\n");

                int ID = int.Parse(Console.ReadLine());

                this.MostrarDatos(UsuarioNegocio.GetOne(ID));

                }
            catch (FormatException)
            
                {

                Console.WriteLine();
 
                Console.WriteLine("La ID ingresada debe ser un número entero.\n");

                }

            catch (Exception e)
                {

                Console.WriteLine(e.Message);

                }

            finally
                {
                
                Console.WriteLine("Presione una tecla para continuar.\n");

                Console.ReadKey();

                }

            }

        public void Modificar()
           
            {

            try
                {
                Console.WriteLine("Ingrese el ID del usuario que desea editar:\n");

                int ID = int.Parse(Console.ReadLine());

                Business.Entities.Usuario usuario = UsuarioNegocio.GetOne(ID);

                Console.WriteLine("\nIngrese Nombre Usuario:\n");

                usuario.NombreUsuario = Console.ReadLine();

                Console.WriteLine("\nIngrese Clave:\n");

                usuario.Clave = Console.ReadLine();

                Console.WriteLine("\nIngrese Habilitación Usuario (1- Si / Otro- No):\n");

                usuario.Habilitado = (Console.ReadLine() == "1");

                usuario.State = BusinessEntity.States.Modified;

                UsuarioNegocio.Save(usuario);

                }

            catch(FormatException)
                {

                Console.WriteLine();

                Console.WriteLine("La ID ingresada debe ser un númeor entero.\n");

                }
            catch (Exception e)
                {

                Console.WriteLine(e.Message);

                }

            finally
                {

                Console.WriteLine("Presione una tecla para continuar.\n");

                Console.ReadKey();

                }

            }

        public void Agregar()
        
            {
            Business.Entities.Usuario usuario = new Business.Entities.Usuario();

            Console.Clear();

            Console.WriteLine("Ingrese Nombre Usuario:\n");

            usuario.NombreUsuario = Console.ReadLine();

            Console.WriteLine("Ingrese Clave:\n");

            usuario.Clave = Console.ReadLine();

            Console.WriteLine("Ingrese Habilitación Usuario (1- Si / Otro- No):\n");

            usuario.Habilitado = (Console.ReadLine() == "1");

            usuario.State = BusinessEntity.States.New;

            UsuarioNegocio.Save(usuario);

            Console.WriteLine();

            Console.WriteLine("ID: {0}", usuario.ID);

            
            }
        public void Eliminar()
        
            {

            try
                {
                Console.WriteLine("Ingrese el ID del usuario que desea eliminar:\n");

                int ID = int.Parse(Console.ReadLine());

                UsuarioNegocio.Delete(ID);

                }

            catch(FormatException)
                {

                Console.WriteLine();

                Console.WriteLine("La ID ingresada debe ser un númeor entero.\n");

                }
            catch (Exception e)
                {

                Console.WriteLine(e.Message);

                }

            finally
                {

                Console.WriteLine("Presione una tecla para continuar.\n");

                Console.ReadKey();

                }

            }

        }
    }
