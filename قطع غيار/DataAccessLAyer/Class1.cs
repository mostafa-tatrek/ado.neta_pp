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
                @"INSERT INTO Customers (CustomerName, CustomerAddress, CustomerPhone, CustomerEmail) 
          VALUES (@CustomerName, @CustomerAddress, @CustomerPhone, @CustomerEmail)",
                sql);
            insertCommand.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100, "CustomerName");
            insertCommand.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar, 200, "CustomerAddress");
            insertCommand.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar, 15, "CustomerPhone");
            insertCommand.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar, 100, "CustomerEmail");
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Customers 
          SET CustomerName = @CustomerName, 
              CustomerAddress = @CustomerAddress, 
              CustomerPhone = @CustomerPhone, 
              CustomerEmail = @CustomerEmail 
          WHERE CustomerID = @CustomerID",
                sql);
            updateCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 0, "CustomerID");
            updateCommand.Parameters.Add("@CustomerName", SqlDbType.NVarChar, 100, "CustomerName");
            updateCommand.Parameters.Add("@CustomerAddress", SqlDbType.NVarChar, 200, "CustomerAddress");
            updateCommand.Parameters.Add("@CustomerPhone", SqlDbType.NVarChar, 15, "CustomerPhone");
            updateCommand.Parameters.Add("@CustomerEmail", SqlDbType.NVarChar, 100, "CustomerEmail");
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Customers WHERE CustomerID = @CustomerID",
                sql);
            deleteCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 0, "CustomerID");
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }
        public static SqlDataAdapter GetpPartsDataAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Parts ( PartName,  Price,  Quantitiy,SuppliersID ) 
                  VALUES (@PartName, @Price, @Quantitiy, @SuppliersID)",
                 sql);
            insertCommand.Parameters.Add("@PartName", SqlDbType.NVarChar, 100, "PartName");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 10, "Price");
            insertCommand.Parameters.Add("@Quantitiy", SqlDbType.Int,0, "Quantitiy");
            insertCommand.Parameters.Add("@SuppliersID", SqlDbType.Int, 0, "SuppliersID");
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Parts 
          SET PartName = @PartName, 
              Price = @Price, 
              Quantitiy = @Quantitiy, 
              SuppliersID = @SuppliersID 
          WHERE  PartID = @ PartID",
                sql);
            updateCommand.Parameters.Add("@PartID", SqlDbType.Int, 0, "PartID");
            updateCommand.Parameters.Add("@PartName", SqlDbType.NVarChar, 100, "PartName");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 10, "Price");
            updateCommand.Parameters.Add("@Quantitiy", SqlDbType.Int, 0, "Quantitiy");
            updateCommand.Parameters.Add("@SuppliersID", SqlDbType.Int, 0, "SuppliersID");
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Parts WHERE PartID = @PartID",
                sql);
            deleteCommand.Parameters.Add("@PartID", SqlDbType.Int, 0, "PartID");
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }
        public static SqlDataAdapter GetInvoicesDataAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Invoices (Invoicedate, CustomerID) 
                VALUES (@Invoicedate, @CustomerID)",
                sql);
            insertCommand.Parameters.Add("@Invoicedate", SqlDbType.Date, 100, "Invoicedate");
            insertCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 200, "CustomerID");
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Invoices 
                SET Invoicedate = @Invoicedate, 
               CustomerID = @CustomerID, 
              WHERE InvoicesID = @InvoicesID",
                sql);
            updateCommand.Parameters.Add("@Invoicedate", SqlDbType.Date, 100, "Invoicedate");
            updateCommand.Parameters.Add("@CustomerID", SqlDbType.Int, 100, "CustomerID");
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Invoices WHERE InvoicesID = @InvoicesID",
                sql);
            deleteCommand.Parameters.Add("@InvoicesID", SqlDbType.Int, 0, "InvoicesID");
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }
        public static SqlDataAdapter GetInvoices_DetailsAdapter()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Invoices_Details (TotelPrice, Quantitiy,PartID,InvoicesID) 
                VALUES (@TotelPrice, @Quantitiy,@PartID,InvoicesID)",
                sql);
            insertCommand.Parameters.Add("@TotelPrice", SqlDbType.Decimal, 100, "TotelPrice");
            insertCommand.Parameters.Add("@Quantitiy", SqlDbType.Int, 200, "Quantitiy");
            insertCommand.Parameters.Add("@PartID", SqlDbType.Int, 100, "PartID");
            insertCommand.Parameters.Add("@InvoicesID", SqlDbType.Int, 200, "InvoicesID");
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Invoices_Details 
                SET TotelPrice = @TotelPrice, 
               Quantitiy = @Quantitiy, 
                InvoicesID = @InvoicesID,
                 PartID = @PartID
              WHERE DeatailsID = @DeatailsID",
                sql);
            updateCommand.Parameters.Add("@TotelPrice", SqlDbType.Decimal, 100, "TotelPrice");
            updateCommand.Parameters.Add("@Quantitiy", SqlDbType.Int, 100, "Quantitiy");
            updateCommand.Parameters.Add("@InvoicesID", SqlDbType.Decimal, 100, "InvoicesID");
            updateCommand.Parameters.Add("@PartID", SqlDbType.Int, 100, "PartID");
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Invoices_Details WHERE DeatailsID = @DeatailsID",
                sql);
            deleteCommand.Parameters.Add("@DeatailsID", SqlDbType.Int, 0, "DeatailsID");
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
        public static SqlDataAdapter GetPartsAdapter()
        {
            
            SqlDataAdapter adapter = new SqlDataAdapter();

            
            SqlCommand insertCommand = new SqlCommand(
                @"INSERT INTO Parts (PartName, Price, Quantitiy, SuppliersID) 
          VALUES (@PartName, @Price, @Quantitiy, @SuppliersID)",
                sql);
            insertCommand.Parameters.Add("@PartName", SqlDbType.NVarChar, 50, "PartName");
            insertCommand.Parameters.Add("@Price", SqlDbType.Decimal, 18, "Price");
            insertCommand.Parameters.Add("@Quantitiy", SqlDbType.Int, 4, "Quantitiy");
            insertCommand.Parameters.Add("@SuppliersID", SqlDbType.Int, 4, "SuppliersID");

           
            SqlCommand updateCommand = new SqlCommand(
                @"UPDATE Parts 
          SET PartName = @PartName, Price = @Price, Quantitiy = @Quantitiy, SuppliersID = @SuppliersID 
          WHERE PartID = @PartID",
                sql);
            updateCommand.Parameters.Add("@PartName", SqlDbType.NVarChar, 50, "PartName");
            updateCommand.Parameters.Add("@Price", SqlDbType.Decimal, 18, "Price");
            updateCommand.Parameters.Add("@Quantitiy", SqlDbType.Int, 4, "Quantitiy");
            updateCommand.Parameters.Add("@SuppliersID", SqlDbType.Int, 4, "SuppliersID");
            updateCommand.Parameters.Add("@PartID", SqlDbType.Int, 4, "PartID");

          
            SqlCommand deleteCommand = new SqlCommand(
                @"DELETE FROM Parts WHERE PartID = @PartID",
                sql);
            deleteCommand.Parameters.Add("@PartID", SqlDbType.Int, 4, "PartID");

            
            adapter.InsertCommand = insertCommand;
            adapter.UpdateCommand = updateCommand;
            adapter.DeleteCommand = deleteCommand;

            return adapter;
        }


    }
}