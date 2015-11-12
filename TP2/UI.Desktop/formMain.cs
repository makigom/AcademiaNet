using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace UI.Desktop
{
    public partial class formMain : Form
    {
        public formMain(Usuario usr)
        {
            InitializeComponent();
            this._UsuarioActual = usr;
        }

        private Usuario _UsuarioActual;

        public Usuario UsuarioActual
        {
            get { return _UsuarioActual; }
        }

        private void formMain_Load(object sender,EventArgs e)
        {
            this.tsbsUsuarios.Text = this.UsuarioActual.NombreUsuario;
            this.permisos();
        }

        private void permisos()
        {
            try
            {
                ModuloUsuarioLogic mul = new ModuloUsuarioLogic();
                List<ModuloUsuario> modusu = new List<ModuloUsuario>();
                modusu = mul.GetPermisos(UsuarioActual.ID);
                Persona perUsu = new Persona();
                PersonasLogic ul = new PersonasLogic();
                perUsu = ul.GetOne(UsuarioActual.IDPersona);

                if (perUsu.TiposPersona == "Alumno")
                {
                    this.mnuRegistrarAlumno.Visible = true; 
                }
                else if (perUsu.TiposPersona == "Docente")
                {
                    this.mnuAlumnosInscripciones.Visible = true;
                }
                else if (perUsu.TiposPersona == "No docente")
                {
                    //this.mnuReportes.Visible = true;
                }

                foreach (ModuloUsuario mu in modusu)
                {
                    Modulo m = new Modulo();
                    ModuloLogic ml = new ModuloLogic();
                    m = ml.GetOne(mu.IDModulo);                    

                    if (m.Descripcion.ToLower() == "usuarios")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuUsuarios.Visible = true;
                    }
                    else if (m.Descripcion == "personas")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuPersonas.Visible = true;
                    }
                    else if (m.Descripcion == "planes")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuPlanes.Visible = true;
                    }
                    else if (m.Descripcion == "materias")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuMaterias.Visible = true;
                    }
                    else if (m.Descripcion == "especialidades")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuEspecialidades.Visible = true;
                    }
                    else if (m.Descripcion == "cursos")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuCursos.Visible = true;
                    }
                    else if (m.Descripcion == "comisiones")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuComisiones.Visible = true;
                    }
                    else if (m.Descripcion == "docentescursos")
                    {
                        if (mu.PermiteAlta || mu.PermiteBaja || mu.PermiteConsulta || mu.PermiteModificacion)
                            this.mnuDocenteCurso.Visible = true;
                    }

                }

            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       /* private void formMain_Shown(object sender, EventArgs e)
        {
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }

        }*/

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios(this.UsuarioActual);
            u.ShowDialog();
        }

        private void mnuComisiones_Click(object sender, EventArgs e)
        {
            Comisiones c = new Comisiones(this.UsuarioActual);
            c.MdiParent = this;
            c.Show();
        }

        private void mnuAlumnosInscripciones_Click(object sender, EventArgs e)
        {
            AlumnosInscripciones ai = new AlumnosInscripciones(); //NO HAY QUE PASARLE NADA POR PARAMETRO
            ai.MdiParent = this;
            ai.Show();
        }

        private void mnuCursos_Click(object sender, EventArgs e)
        {
            Cursos c = new Cursos(this.UsuarioActual);
            c.MdiParent = this;
            c.Show();
        }

        private void mnuDocentesCursos_Click(object sender, EventArgs e)
        {
            DocentesCursos dc = new DocentesCursos(this.UsuarioActual);
            dc.ShowDialog();
        }

        private void mnuEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades(this.UsuarioActual);
            esp.MdiParent = this;
            esp.Show();
        }

        private void mnuMaterias_Click(object sender, EventArgs e)
        {
            Materias m = new Materias(this.UsuarioActual);
            m.MdiParent = this;
            m.Show();
        }


        private void mnuPersonas_Click(object sender, EventArgs e)
        {
            Personas p = new Personas(this.UsuarioActual);
            p.MdiParent = this;
            p.Show();
        }

        private void mnuPlanes_Click(object sender, EventArgs e)
        {
            Planes p = new Planes(this.UsuarioActual);
            p.MdiParent = this;
            p.Show();
        }

        private void mnuUsuarios_Click_1(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios(this.UsuarioActual);
            u.MdiParent = this;
            u.Show();
        }

        private void mnuArchivo_Click(object sender, EventArgs e)
        {
            //se puso sin querer, no va
        }

        private void mnuCerrarSesion_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Dispose();
            }
            this.Visible = false;
            Login login = new Login();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this._UsuarioActual = login.UsuarioActual;
                this.permisos();
                this.Visible = true;
                this.tsbsUsuarios.Text = this._UsuarioActual.NombreUsuario;
            }
            else
            {
                this.Close();
            }
        }

        private void mnuRegistrarAlumno_Click(object sender, EventArgs e)
        {
            RegistrarAlumnoDesktop rad = new RegistrarAlumnoDesktop();
            rad.MdiParent = this;
            rad.Show();

        }

    }
}
