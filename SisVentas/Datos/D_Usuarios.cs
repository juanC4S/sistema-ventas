using MySql.Data.MySqlClient;
using SisVentas.Entidades;
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
        public string Guardar_us(int nOpcion, E_Usuarios oPro)
        {
            string Rpta = "";
            MySqlConnection Sqlcon = new MySqlConnection();
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_guardar_us", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nOpcion", MySqlDbType.Int32).Value = nOpcion;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = oPro.Codigo_us;
                Comando.Parameters.Add("cLogin_us", MySqlDbType.VarChar).Value = oPro.Login_us;
                Comando.Parameters.Add("cPassword_us", MySqlDbType.VarChar).Value = oPro.Password_us;
                Comando.Parameters.Add("cNombre_us", MySqlDbType.VarChar).Value = oPro.Nombre_us;
                Comando.Parameters.Add("nCodigo_ru", MySqlDbType.Int32).Value = oPro.Codigo_ru;

                MySqlParameter ParCodigo = new MySqlParameter();
                ParCodigo.ParameterName = "nCodigo_ou";
                ParCodigo.MySqlDbType = MySqlDbType.Int32;
                ParCodigo.Direction = ParameterDirection.Output;
                Comando.Parameters.Add(ParCodigo);
                Sqlcon.Open();
                Comando.ExecuteNonQuery();
                Rpta = Convert.ToString(ParCodigo.Value);

            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if(Sqlcon.State==ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
        public string Activo_us(int nCodigo_us)
        {
            string Rpta = "";
            MySqlConnection Sqlcon = new MySqlConnection();
            try
            {
                Sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_activo_us", Sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("nCodigo_us", MySqlDbType.Int32).Value = nCodigo_us;
                Sqlcon.Open();
                Rpta = Comando.ExecuteNonQuery() >= 1 ? "OK" : "No se realizo el proceso";
            }
            catch (Exception ex)
            {
                Rpta = ex.Message;
            }
            finally
            {
                if (Sqlcon.State == ConnectionState.Open) Sqlcon.Close();
            }
            return Rpta;
        }
    }
}
