using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Repositorios
{
    class Repo_roles
    {

        public Model.Rol rolSeleccionado;
        public static Repo_roles instancia;
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();

        public static Repo_roles getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_roles();
                return instancia;
            }
        }

        public List<Model.Rol> getRoles() {

            DataTable tablaRoles;
            List<Model.Rol> listaDeRoles = new List<Model.Rol>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getRoles");

            DBhelper.abrirConexion();

            tablaRoles = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaRoles.Rows)
            {

                Model.Rol rol = new Model.Rol();

                rol.setNombre((String)row["Nombre_Rol"]);
                rol.setId((Int32)row["IdRol"]);
                rol.setEstado(Convert.ToInt16(row["Estado_Rol"]));

                listaDeRoles.Add(rol);
            }

            return listaDeRoles;

        }

        public void setRolSeleccionado(Model.Rol rol) {

            this.rolSeleccionado = rol;
        
        }



    }
}
