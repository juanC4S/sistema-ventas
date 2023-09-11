using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SisVentas.Datos
{
    public class D_Usuarios
    {
        public DataTable Login_us(string cLogin_us, string cPassword)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection Sqlcon = new MySqlConnection();
            try
            {
                Sqlcon=Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_login_us", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cLogin_us", MySqlDbType.VarChar).Value = cLogin_us;
                Comando.Parameters.Add("cPassword_us", MySqlDbType.VarChar).Value = cPassword;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch(Exception ex)
            {
                throw ex;
            
            }
            finally
            {
                if(Sqlcon.State==ConnectionState.Open) Sqlcon.Close();
            }
        }
        public DataTable Listado_us(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection Sqlcon = new MySqlConnection();
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_listado_us", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }

        public DataTable Listado_ru()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection Sqlcon = new MySqlConnection();
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_listado_ru", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
        }
    }
}
