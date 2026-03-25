using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Ado_Assignment.Assignment3_product_inventory
{
    public class ProductDetails
    {
        public int ProductId {  get; set; }
        public string? ProductName {  get; set; }
        public decimal Price {  get; set; }
        public int Stock {  get; set; }
    }
    public interface IProduct
    {
        void LoadData();
        void DisplayProducts();
        void AddProduct(ProductDetails product);
        void UpdateProduct(int id,decimal price);
        void DeleteProduct(int id);
        void SaveChanges();
    }
    internal class Product : IProduct
    {
        private SqlConnection? con = null;
        private SqlDataAdapter? da = null;
        private DataSet? ds = null;
        string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=NewPraticeDb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public Product()
        {
            con=new SqlConnection(connectionString);
            da = new SqlDataAdapter("Select * from Products", con);
            SqlCommandBuilder builder= new SqlCommandBuilder(da);
            ds = new DataSet();
        }
        public void AddProduct(ProductDetails product)
        {
            DataTable dt = ds.Tables["Products"];
            DataRow dr = dt.NewRow();
            dr["ProductName"] = product.ProductName;
            dr["Price"] = product.Price;
            dr["Stock"] = product.Stock;
            dt.Rows.Add(dr);
        }

        public void DeleteProduct(int id)
        {
            DataTable dt = ds.Tables["Products"];
            foreach(DataRow row in dt.Rows)
            {
                if ((int)row["ProductId"] == id)
                {
                    row.Delete();
                    return;
                }
            }
        }

        public void DisplayProducts()
        {
            DataTable dt = ds.Tables["Products"];
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"Id:{row["ProductId"]} Name:{row["ProductName"]} Price:{row["Price"]} Stock:{row["Stock"]}");
            }
        }

        public void LoadData()
        {
            ds.Clear();
            da.Fill(ds, "Products");
        }

        public void SaveChanges()
        {
            da.Update(ds, "Products");
        }

        public void UpdateProduct(int id, decimal price)
        {
            DataTable dt = ds.Tables["Products"];
            foreach(DataRow row in dt.Rows)
            {
                if ((int)row["ProductId"] == id)
                {
                    row["Price"] = price;
                    return;
                }
            }
        }
    }
    class Test_Products
    {
        static void Main()
        {
            try
            {
                Product product = new Product();
                product.LoadData();
                do 
                {
                    Console.WriteLine("\n--- Product Inventory System ---");
                    Console.WriteLine("1. View Products");
                    Console.WriteLine("2. Add Product");
                    Console.WriteLine("3. Update Price");
                    Console.WriteLine("4. Delete Product");
                    Console.WriteLine("5. Save Changes");
                    Console.WriteLine("6. Exit");
                    int ch = int.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case 1:
                            {
                                product.DisplayProducts();
                            }
                            break;
                        case 2:
                            {
                                ProductDetails productDetails= new ProductDetails();
                                Console.WriteLine("Enter Product Name:");
                                productDetails.ProductName= Console.ReadLine();
                                Console.WriteLine("Enter Price:");
                                productDetails.Price=decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Stock:");
                                productDetails.Stock=int.Parse(Console.ReadLine());
                                product.AddProduct(productDetails);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Enter Product Id:");
                                int Id=int.Parse(Console.ReadLine());
                                Console.WriteLine("New Price:");
                                decimal Price=decimal.Parse(Console.ReadLine());
                                product.UpdateProduct(Id, Price);
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("Enter Product Id:");
                                int Id = int.Parse(Console.ReadLine());
                                product.DeleteProduct(Id);
                            }
                            break;
                        case 5:
                            {
                                product.SaveChanges();
                            }
                            break;
                        case 6:
                            {
                                Environment.Exit(0);
                            }
                            break;
                        default:
                            {
                                Console.WriteLine("Invalid Choice");
                            }
                            break;
                    }
                } while (true);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
