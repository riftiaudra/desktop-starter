using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starter
{
    public class DB
    {
        private static readonly string seckey = "Ab11 Cd22 Ef33 Gh44 Ij55 Kl66 Mn77 Op88".Replace(" ", string.Empty);

        public static string Userid
        {
            get => crypto.Security.Decrypt(Program.AppSettings("userid"), seckey, null);
            set => Program.AppSettings("userid", crypto.Security.Encrypt(value, seckey, null));
        }

        public static string Password
        {
            get => crypto.Security.Decrypt(Program.AppSettings("password"), seckey, null);
            set => Program.AppSettings("password", crypto.Security.Encrypt(value, seckey, null));
        }

        #region MSSQL

        /// <summary>
        /// Address of MSSQL
        /// </summary>
        public static string MSSQLConnectionString =
            $"Data Source={Program.AppSettings("datasource")};" +
            $"Initial Catalog={Program.AppSettings("database")};" +
            //$"User ID=;" +
            $"User ID={Userid};" +
            //$"Password=";
            $"Password={Password}";

        /// <summary>
        /// Connection to MSSQL
        /// </summary>
        public static SqlConnection MSSQLConnection;

        public static string MSSQLCreateConnection()
        {
            MSSQLConnection = new SqlConnection(MSSQLConnectionString);
            MSSQLConnection.Open();
            return "Connection Create! " + DateTime.Now;
        }

        public static string MSSQLCloseConnection()
        {
            MSSQLConnection.Close();
            return "Connection Closed! " + DateTime.Now;
        }

        public static string MSSQLCheckConnection()
        {
            return MSSQLConnection.State == ConnectionState.Open ?
              "Connection is Open! " + DateTime.Now : "Fail!!!";
        }

        /// <summary>
        /// Fill Dataset/Datatable from MSSQL
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static SqlDataAdapter MSSQLAdapter(string query)
        {
            return new SqlDataAdapter(query, DB.MSSQLConnection);
        }

        #endregion

        /// <summary>
        /// Execute MSSQL Transaction Statement
        /// </summary>
        /// <param name="dml"></param>
        /// <param name="query"></param>
        /// <returns>success get "", fail get ex.Message</returns>
        public static string DMLExecute(string query)
        {
            SqlTransaction transaction = DB.MSSQLConnection.BeginTransaction();

            SqlCommand command = new SqlCommand(query, DB.MSSQLConnection, transaction);

            try
            {
                command.ExecuteNonQuery();

                transaction.Commit();

                return "";
            }
            catch (Exception ex)
            {
                transaction.Rollback();

                return ex.Message;
            }
        }

        public static string MultiplyNULL(int max)
        {
            string str = "";

            for (int i = 0; i < max; i++)
                str += ", null";

            return str;
        }




    }
}
