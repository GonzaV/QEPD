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

        public List<Cliente> getClientes()
        {

            DataTable tablaClientes;

            List<Model.Cliente> listaDeClientes = new List<Model.Cliente>();

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getClientes");

            DBhelper.abrirConexion();

            tablaClientes = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tablaClientes.Rows)
            {

                Model.Cliente cliente = new Cliente();

                cliente.setNombre((String)row["Nombre_Cliente"]);
                cliente.setApellido((String)row["Apellido_Cliente"]);
                cliente.setEmail((String)row["Email_Cliente"]);
                cliente.setFnacimiento((DateTime)row["Fecha_Nac_Cliente"]);
                cliente.setId((Int32)row["IdCliente"]);
                cliente.setDni((decimal)row["Dni_Cliente"]);
                cliente.setTelefono((decimal)row["Telefono_Cliente"]);
                cliente.setEstado(Convert.ToInt16(row["Estado_Cliente"]));

                Int32 idDomicilio = (Int32)row["idDomicilio"];

                cliente.setDomicilio(this.getDomiclio(idDomicilio));

                listaDeClientes.Add(cliente);
            }

            DBhelper.cerrarConexion();

            return listaDeClientes;

        }


        public DataTable getTablaClientesFiltrados(String nombre, String dni, Boolean estado) {

            DataTable tablaClientesFiltrados;

            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getClientesFiltrados");
            cmd.Parameters.Add("@Nombre_Cliente", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Dni_Cliente", SqlDbType.Decimal).Value = Convert.ToDecimal(dni);
            cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;

            DBhelper.abrirConexion();

            tablaClientesFiltrados = DBhelper.obtenerTabla(cmd);

            DBhelper.cerrarConexion();

            return tablaClientesFiltrados;

            }


        public Model.Cliente getCliente(decimal dni)
        {
            DBhelper.crearConexion();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getCliente");
            cmd.Parameters.Add("@Dni_Cliente", SqlDbType.NVarChar).Value = Convert.ToString(dni);

            DBhelper.abrirConexion();

            DataTable tablaCliente = DBhelper.obtenerTabla(cmd);

            Model.Cliente cliente = new Cliente();

            foreach (DataRow row in tablaCliente.Rows)
            {
                cliente.setNombre((String)row["Nombre_Cliente"]);
                cliente.setApellido((String)row["Apellido_Cliente"]);
                cliente.setEmail((String)row["Email_Cliente"]);
                cliente.setFnacimiento((DateTime)row["Fecha_Nac_Cliente"]);
                cliente.setId((Int32)row["IdCliente"]);
                cliente.setTelefono((decimal)row["Telefono_Cliente"]);
                cliente.setDni((decimal)row["Dni_Cliente"]);
                cliente.setEstado(Convert.ToInt16(row["Estado_Cliente"]));

                Int32 idDomicilio = (Int32)row["idDomicilio"];

                cliente.setDomicilio(this.getDomiclio(idDomicilio));
            }

            DBhelper.cerrarConexion();

            return cliente;
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

            DBhelper.cerrarConexion();
        }

        public void modificarCliente(String nombre, String apellido, Int32 dni, String email, Int32 telefono, DateTime fnacimiento, String direccion, Int32 cp)
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

            DBhelper.cerrarConexion();
        }

        /*public void eliminarCliente(Int32 idCliente){
            DBhelper.crearConexion();
            SqlCommand cmd = DBhelper.crearCommand("QEPD.eliminarCliente");
            cmd.Parameters.Add("@idCLiente", SqlDbType.NVarChar).Value = idCliente;
        }*/

        private Model.Domicilio getDomiclio(Int32 id)
        {
            Model.Domicilio domicilio = new Model.Domicilio();

            SqlCommand cmd = DBhelper.crearCommand("QEPD.getDomicilio");
            cmd.Parameters.Add("@idDomicilio", SqlDbType.Int).Value = id;

            DataTable tabla = DBhelper.obtenerTabla(cmd);

            foreach (DataRow row in tabla.Rows)
            {
                domicilio.setId(id);
                domicilio.setCod_Postal((String)row["Cod_Postal"]);
                domicilio.setDireccion((String)row["Direccion"]);
            }

            return domicilio;
        }
            
        }
    }
