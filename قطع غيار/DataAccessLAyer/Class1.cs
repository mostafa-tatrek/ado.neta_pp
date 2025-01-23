using Microsoft.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace Data_Access_Layer
{
    public class DBManager
    {
        static SqlConnection sql = new SqlConnection(ConfigurationManager.ConnectionStrings["ITI_db"].ConnectionString);

        public static DataTable ExecuteQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }

        public static DataTable ExecuteQuery(string query, SqlParameter[] parameters)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }
        public static object ExecuteScalar(string query, SqlParameter[] parameters = null)
        {
            object result = null;

            try
            {
                sql.Open();

                SqlCommand command = new SqlCommand(query, sql);

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                result = command.ExecuteScalar();

            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while executing the query.", ex);
            }


            return result;
        }





        public static int ExecuteNonQuery(string query, SqlParameter[] parameters)
        {
            int rowsAffetcted = -1;
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(parameters);
            try
            {
                if (sql.State == ConnectionState.Closed)
                    sql.Open();

                rowsAffetcted = cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sql.State != ConnectionState.Closed)
                    sql.Close();
            }
            return rowsAffetcted;
        }

        public static DataTable ExecuteQueryList(string query, SqlParameter[] sp)
        {
            SqlCommand cmd = new SqlCommand(query, sql);
            cmd.Parameters.AddRange(sp);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;

        }

        


    }
}