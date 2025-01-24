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

        #region Parts
        public static DataTable GetParts()
        {
            var query = "select * from Parts";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }
        public static int InsertParts(Parts p)
        {
            var query = "insert into Parts values(@PartName , @Price , @Quantitiy , @SuppliersID , @CategoryID)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@PartName" , p.Name),
                new SqlParameter("@Price" , p.Price),
                new SqlParameter("@Quantitiy" , p.Quantity),
                new SqlParameter("@SuppliersID" , p.SuplierID),
                new SqlParameter("@CategoryID" , p.CategoryID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int UpdateParts(Parts p)
        {
            var query = "UPDATE Parts SET PartName = @PartName, Price = @Price, Quantitiy = @Quantitiy, SuppliersID = @SuppliersID WHERE PartID = @PartID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@PartName" , p.Name),
                new SqlParameter("@Price" , p.Price),
                new SqlParameter("@Quantitiy" , p.Quantity),
                new SqlParameter("@SuppliersID" , p.SuplierID),
                new SqlParameter("@PartID" , p.PartID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int DeleteParts(int PartID)
        {
            var query = "DELETE FROM Parts WHERE PartID = @PartID";
            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@PartID", PartID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static void SyncParts(DataTable dt)
        {
            SqlDataAdapter adapter = Data_Access_Layer.DBManager.GetpPartsDataAdapter();

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

        #region Invoices
        public static DataTable GetInvoices()
        {
            var query = "select * from Invoices";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }
        public static int InsertInvoices(Invoices n)
        {
            var query = "insert into Invoices values(@Invoicedate , @CustomerID )";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Invoicedate" , n.InvoiceDate),
                new SqlParameter("@CustomerID" , n.CustomerID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int UpdateInvoices(Invoices n)
        {
            var query = "UPDATE Invoices SET Invoicedate = @Invoicedate, CustomerID = @CustomerID WHERE InvoicesID = @InvoicesID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@Invoicedate" , n.InvoiceDate),
                new SqlParameter("@CustomerID" , n.CustomerID),
                new SqlParameter("@InvoicesID" , n.ID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int DeleteInvoices(int ID)
        {
            var query = "DELETE FROM Invoices WHERE InvoicesID= @InvoicesID";
            SqlParameter[] sp = new SqlParameter[]
            {
               new SqlParameter("@InvoicesID", ID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        #endregion

        #region Details
        public static DataTable GetInvoices_Details()
        {
            var query = "select * from Invoices_Details";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }

        public static int InsertInvoices_Details(InvoicesDetails d)
        {
            var query = "insert into Invoices_Details values(@TotelPrice , @Quantitiy , @PartID , @InvoicesID)";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@TotelPrice" , d.TotalPrice),
                new SqlParameter("@Quantitiy" , d.Quantity),
                new SqlParameter("@PartID" , d.PartID),
                new SqlParameter("@InvoicesID" , d.InvoiceID),
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        public static int UpdateInvoices_Details(InvoicesDetails d)
        {
            var query = "UPDATE Invoices_Details SET TotelPrice = @TotelPrice, Quantitiy = @Quantitiy, PartID = @PartID, InvoicesID = @InvoicesID WHERE DeatailsID = @DeatailsID";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@TotelPrice" , d.TotalPrice),
                new SqlParameter("@Quantitiy" , d.Quantity),
                new SqlParameter("@PartID" , d.PartID),
                new SqlParameter("@InvoicesID" , d.InvoiceID),
                new SqlParameter("@Invoices_Details" ,d.ID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }
        public static int DeleteInvoices_Details(int DeatailsID)
        {
            var query = "DELETE FROM Invoices_Details WHERE DeatailsID = @DeatailsID";
            SqlParameter[] sp = new SqlParameter[]
            {
        new SqlParameter("@DeatailsID", DeatailsID)
            };
            int rowsAffected = Data_Access_Layer.DBManager.ExecuteNonQuery(query, sp);
            return rowsAffected;
        }

        #endregion

        #region Categories
        public static DataTable GetAllGategories()
        {
            var query = "select * from Categories";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;

        }

        #endregion

        #region Parts
        public static DataTable GetAllParts()
        {
            var query = "select * from Parts";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }

        #endregion


        public static DataTable GetReports() {

            var query = @"select P.PartName , P.Price , P.Quantitiy,TotelPrice , Invoicedate , CustomerName , Adress ,Phone , Email
            from Invoices_Details ID join Parts P
            on P.PartID = ID.PartID
            join Invoices I on 
            ID.InvoicesID = I.InvoicesID
            join Customers 
            on Customers.CustomerID = I.CustomerID";
            DataTable dt = Data_Access_Layer.DBManager.ExecuteQuery(query);
            return dt;
        }


    }

}
