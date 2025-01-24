using BusinessLogicLAyer.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLAyer
{
    public class BLL{

        #region Customers

        public static DataTable GetCustomers() {
            var query = "select * from Customers";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }

        public static int InsertCustomers(Customer c)
        {
            var query = "insert into Customers values(@CustName , @CustAddress , @CustPhone , @CustEmail)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@CustName" , c.CustomerName),
                new SqlParameter("@CustAddress" , c.Address),
                new SqlParameter("@CustPhone" , c.Phone),
                new SqlParameter("@CustEmail" , c.Email),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int UpdateCustomers(Customer c)
        {
            var query = "UPDATE Customers SET CustomerName = @CustName, Adress = @CustAddress, Phone = @CustPhone, Email = @CustEmail WHERE CustomerID = @CustID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@CustName" , c.CustomerName),
                new SqlParameter("@CustAddress" , c.Address),
                new SqlParameter("@CustPhone" , c.Phone),
                new SqlParameter("@CustEmail" , c.Email),
                new SqlParameter("@CustID" , c.CustomerID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int DeleteCustomer(int customerId)
        {
            var query = "DELETE FROM Customers WHERE CustomerID = @CustID";
            SqlParameter[] sp = new SqlParameter[]
            {
        new SqlParameter("@CustID", customerId)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static void SyncCustomer(DataTable dt)
        {
            SqlDataAdapter adapter = Data_Access_Layer.DBManager.GetCustomerDataAdapter();

            try
            {
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error syncing data: " + ex.Message);
            }
        }
        #endregion


        #region Suppliers
        public static DataTable GetAllSuppliers()
        {
            var query = "select * from Suppliers";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }

        public static int InsertSuppliers(Supplier supplier)
        {
            var query = "insert into Suppliers values(@SupName , @SubPhone, @SubEmail)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@SupName" ,supplier.Name),
                new SqlParameter("@SubPhone" , supplier.Phone),
                new SqlParameter("@SubEmail" , supplier.Email)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp) ;
            return rowsAffected;

        }


        public static int UpdateSuppliers(Supplier supplier)
        {
            var query = @"update Suppliers
set SupplierName = @name,
Email = @email, Phone = @phone
where SuppliersID = @ID
";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@name" , supplier.Name),
                new SqlParameter("@email" , supplier.Email),
                new SqlParameter("@phone" , supplier.Phone),
                new SqlParameter("@ID"  , supplier.ID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery (query, sp) ;
            return rowsAffected;
        }

        public static int DeleteSuppliers(Supplier supplier)
        {
            var query = @"delete Suppliers
where SuppliersID = @ID
";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@ID"  , supplier.ID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static void SyncSuppliers(DataTable dt)
        {
            SqlDataAdapter adapter = Data_Access_Layer.DBManager.GetSuppliersDataAdapter();

            try
            {
                adapter.Update(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error syncing data: " + ex.Message);
            }
        }


        #endregion



    }

}
