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

        public static SqlDataAdapter GetCustomerDataAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Customers (CustomerName, Adress, Phone, Email) 
          VALUES (@CustomerName, @CustomerAddress, @CustomerPhone, @CustomerEmail)",
                sql);
            insertCommand.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100, "CustomerName");
            insertCommand.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar, 200, "Adress");
            insertCommand.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar, 15, "Phone");
            insertCommand.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar, 100, "Email");
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Customers 
          SET CustomerName = @CustomerName, 
              Adress = @CustomerAddress, 
              Phone = @CustomerPhone, 
              Email = @CustomerEmail 
          WHERE CustomerID = @CustomerID",
                sql);
            updateCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 0, "CustomerID");
            updateCommand.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100, "CustomerName");
            updateCommand.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar, 200, "Adress");
            updateCommand.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar, 15, "Phone");
            updateCommand.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar, 100, "Email");
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Customers WHERE CustomerID = @CustomerID",
                sql);
            deleteCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 0, "CustomerID");
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }

        public static SqlDataAdapter GetSuppliersDataAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertCommand = new SqlCommand(
                @"insert into Suppliers values(@SupName , @SubPhone, @SubEmail)",
                sql);
            insertCommand.Parameters.Add("@SupName", SqlDbType.NVarChar, 100, "SupplierName");
            insertCommand.Parameters.Add("@SubPhone", SqlDbType.NVarChar, 200, "Phone");
            insertCommand.Parameters.Add("@SubEmail", SqlDbType.NVarChar, 15, "Email");
            SqlCommand updateCommand = new SqlCommand(
                @"update Suppliers
set SupplierName = @name,
Email = @email, Phone = @phone
where SuppliersID = @ID",
                sql);
            updateCommand.Parameters.Add("@name", SqlDbType.Int, 0, "SupplierName");
            updateCommand.Parameters.Add("@email", SqlDbType.NVarChar, 100, "Email");
            updateCommand.Parameters.Add("@phone", SqlDbType.NVarChar, 200, "Phone");
            updateCommand.Parameters.Add("@ID", SqlDbType.NVarChar, 15, "SuppliersID");
            SqlCommand deleteCommand = new SqlCommand(
                @"delete Suppliers
where SuppliersID = @ID",
                sql);
            deleteCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "SuppliersID");
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;

        }

    }
}