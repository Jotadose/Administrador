using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Administrador
{
    public class Conexion
    {
        private string Base;
        private string Server;
        private string Port;
        private string User;
        private string Password;
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "bd_recursos_humanos";
            this.Server = "localhost";
            this.Port = "3306";
            this.User = "root";
            this.Password = "clave";
        }
        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = $"" +
                    $"server={this.Server};" +
                    $"port={this.Port};" +
                    $"user={this.User};" +
                    $"password={this.Password};" +
                    $"database={this.Base}";

                Cadena.Open();
            }
            catch(Exception ex)
            {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null )
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
