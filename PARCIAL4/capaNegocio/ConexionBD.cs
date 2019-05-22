using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
namespace capaNegocio
{
    public class ConexionBD
    {
        String conex = "Data Source=LAPTOP-ONPRB48O;Initial Catalog=hospital;Integrated Security=True";
        SqlDataAdapter adaptador;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;
        public SqlDataAdapter da;

        public SqlConnection Conexion
        {
            get { return conexion; }
            set { conexion = value; }
        }
        public bool Conectar()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = conex;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

        // muestra si se realizo bien la consulta y viene de la capa negocio
        public void consultaSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                comando.ExecuteNonQuery();
                mensaje = " La consulta se realizo correctamente";
            }
            catch
            {
                mensaje = "Error en la consulta";
            }
        }

        public void mostrarSQL(String consulta)
        {
            String mensaje = "Error";
            try
            {
                comando = new SqlCommand(consulta, conexion);
                da = new SqlDataAdapter(comando);
                mensaje = " La consulta se realizo correctamente";
            }
            catch
            {
                mensaje = "Error en la consulta";
            }
        }

    }
}
