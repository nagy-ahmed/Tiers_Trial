using BLL.Entities;
using BLL.EntityLists;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.EntityManager
{
    public class ProductManager
    {
        static DBManager DB = new DBManager();

        public static ProductList SelectAllProducts()
        {
            try
            {
                return DataTableToProductList(DB.ExecuteReader("SelectAllProducts"));
            }
            catch (Exception)
            {
                Debug.WriteLine("Error in SelectAllProducts");
            }
            return null;
        }

        public static bool DeleteProductById(int ProductID)
        {
            try
            {
                Dictionary<string, object> Params = new Dictionary<string, object>()
                {
                    ["ProductID"] = ProductID
                };

                if (DB.ExecuteNonQuery("DeleteProductById",Params)>0)
                    return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return false;
        }
        #region mapping
        internal static Product DataRowToProduct(DataRow DR) 
        {
            Product product = new Product();
            try
            {
                product.ProductID = (int)DR["ProductID"];
                product.ProductName = DR["ProductName"].ToString();
                product.SupplierID = DR["SupplierID"] as int?;
                product.CategoryID = DR["CategoryID"] as int?;
                product.QuantityPerUnit = DR["QuantityPerUnit"].ToString();
                product.UnitPrice = DR["UnitPrice"] as decimal?;
                product.UnitsInStock = DR["UnitsInStock"] as short?;
                product.UnitsOnOrder = DR["UnitsOnOrder"] as short?;
                product.ReorderLevel = DR["ReorderLevel"] as short?;
                product.Discontinued = (bool)DR["Discontinued"];
                product.State = EntityState.Unchanged;

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in DataRowToProduct");
                Debug.WriteLine(ex.Message);
            }
           return product;
        }
        internal static ProductList DataTableToProductList(DataTable DT)
        {
            ProductList products = new ProductList();
            try
            {
                if (DT?.Rows?.Count > 0)
                {
                    foreach (DataRow dr in DT.Rows) { 
                        products.Add(DataRowToProduct(dr));
                    }
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Error in DataTableToProductList");
            }
            return products;

        }
        #endregion
    }
}
