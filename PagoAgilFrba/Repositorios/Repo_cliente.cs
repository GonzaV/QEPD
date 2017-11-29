using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace PagoAgilFrba.Model{

    public class Repo_cliente{
        
        
        public Utils.DBhelper DBhelper = Utils.DBhelper.getInstancia();
        public List<Cliente> listaDeClientes = new List<Cliente>();
        public static Repo_cliente instancia;
        public Cliente clienteSeleccionado;

        public static Repo_cliente getInstancia()
        {

            if (instancia != null)
            {
                return instancia;
            }
            else
            {
                instancia = new Repo_cliente();

                return instancia;
            }
        }

        public Cliente getClienteSeleccionado(){

            return this.clienteSeleccionado;
        
        }
        
        public void setClienteSeleccionado(Cliente clienteSeleccionado){

            this.clienteSeleccionado = clienteSeleccionado;
        
        }

        public List<Cliente> getClientes(){

            DataTable tablaClientes;

            List<Model.Cliente> listaDeRoles = new List<Model.Cliente>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getClientes");
            
            DBhelper.abrirConexion();

            tablaClientes = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaClientes.Rows){

                Model.Cliente cliente = new Cliente();

                cliente.setNombre((String)row["Nombre_Cliente"]);
                cliente.setApellido((String)row["Apellido_Cliente"]);
                cliente.setEmail((String)row["Email_Cliente"]);
                cliente.setFnacimiento((DateTime)row["Fecha_Nac_Cliente"]);
                cliente.setId((Int32)row["IdCliente"]);
                //cliente.setTelefono((Int32)row["Telefono_Cliente"]);  Problema de tipados
                //cliente.setIdDomicilio((Int32)row["idDomicilio"]);
                cliente.setEstado(Convert.ToInt16(row["Estado_Cliente"]));

                listaDeClientes.Add(cliente);
            }

            return listaDeClientes;
 
        }

        public DataTable getTablaClientesFiltrados(String nombre, String dni, Boolean estado) {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getClientesFiltrados");
            cmd.Parameters.Add("@Nombre_Cliente", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Dni_Cliente", SqlDbType.NVarChar).Value = dni;
            cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;

            DBhelper.abrirConexion();

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            return tablaClientesFiltrados;
        
        }


        public void newCliente(String nombre, String apellido, Int32 dni, String email, Int32 telefono, DateTime fnacimiento, String direccion, Int32 cp)
        {

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.newCliente");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            cmd.Parameters.Add("@fnacimiento", SqlDbType.DateTime).Value = fnacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@cp", SqlDbType.Int).Value = cp;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();
        }
        
        public void modificarCliente(String nombre, String apellido, Int32 dni, String email, Int32 telefono, DateTime fnacimiento, String direccion, Int32 cp){

            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.newCliente");
            cmd.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@dni", SqlDbType.Int).Value = dni;
            cmd.Parameters.Add("@fnacimiento", SqlDbType.DateTime).Value = fnacimiento;
            cmd.Parameters.Add("@direccion", SqlDbType.NVarChar).Value = direccion;
            cmd.Parameters.Add("@cp", SqlDbType.Int).Value = cp;
            cmd.Parameters.Add("@mail", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@telefono", SqlDbType.Int).Value = telefono;

            DBhelper.abrirConexion();

            cmd.ExecuteNonQuery();


        }
        

        public void eliminarCliente(Int32 idCliente){
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.eliminarCliente");
            cmd.Parameters.Add("@idCLiente", SqlDbType.NVarChar).Value = idCliente;
        }

            
        }
    }
