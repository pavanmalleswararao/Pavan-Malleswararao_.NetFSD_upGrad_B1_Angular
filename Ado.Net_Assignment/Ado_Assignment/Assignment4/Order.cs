using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Ado_Assignment.Assignment4
{
    public class OrderDetails
    {
        public int OrderId { get; set; }
        public string? CustomerName { get; set; }
        public decimal TotalAmount { get; set; }
    }
    public class OrderItemDetails
    {
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
    }
    public interface IOrder
    {
        void AddOrder(OrderDetails orderDetails);
        public List<OrderDetails> GetOrders();
        public void Updateorder(int id, decimal amount);
        void DeleteOrder(int id);
        void AddOrderItem(OrderItemDetails orderItemDetails);
        public List<OrderItemDetails> GetItems(int OrderId);
    }
    internal class Order:IOrder
    {
        private SqlConnection? con=null;
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=OrderDB;Integrated Security=True;Trust Server Certificate=True";

        public Order()
        {
            con=new SqlConnection(connectionString);
        }

        public void AddOrder(OrderDetails orderDetails)
        {
            try
            {
                string qry = "Insert into Orders (CustomerName, TotalAmount) values(@Name,@Amount)";
                SqlCommand cmd=new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@Name", orderDetails.CustomerName);
                cmd.Parameters.AddWithValue("@Amount", orderDetails.TotalAmount);
                con?.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public void AddOrderItem(OrderItemDetails orderItemDetails)
        {
            try
            {
                string qry = "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@OrderId, @Product, @Qty)";
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@OrderId", orderItemDetails.OrderId);
                cmd.Parameters.AddWithValue("@Product", orderItemDetails.ProductName);
                cmd.Parameters.AddWithValue("@Qty", orderItemDetails.Quantity);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public void DeleteOrder(int id)
        {
            try
            {
                string qry = "DELETE FROM Orders WHERE OrderId=@Id";
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public List<OrderItemDetails> GetItems(int OrderId)
        {
            List<OrderItemDetails> items=new List<OrderItemDetails>();
            try
            {
                string qry = "SELECT * FROM OrderItems WHERE OrderId=@OrderId";
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@OrderId", OrderId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items.Add(new OrderItemDetails()
                    {
                        ItemId = Convert.ToInt32(reader["ItemId"]),
                        OrderId = Convert.ToInt32(reader["OrderId"]),
                        ProductName = reader["ProductName"].ToString(),
                        Quantity = Convert.ToInt32(reader["Quantity"])
                    });
                }
                return items;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con?.Close();
            }
            
        }

        public List<OrderDetails> GetOrders()
        {
            List<OrderDetails> orders = new List<OrderDetails>();
            try
            {
                string qry = "SELECT * FROM Orders";
                SqlCommand cmd = new SqlCommand(qry, con);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    orders.Add(new OrderDetails()
                    {
                        OrderId = Convert.ToInt32(reader["OrderId"]),
                        CustomerName = reader["CustomerName"].ToString(),
                        TotalAmount = Convert.ToDecimal(reader["TotalAmount"])
                    });
                }
                return orders;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con?.Close();
            }
        }

        public void Updateorder(int id, decimal amount)
        {
            try
            {
                string qry = "UPDATE Orders SET TotalAmount=@Amount WHERE OrderId=@Id";
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Amount", amount);
                cmd.Parameters.AddWithValue("@Id", id);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                con?.Close();
            }
        }
    }
    class Test_Order
    {
        static void Main()
        {
            Order o = new Order();

            try
            {
                do
                {
                    Console.WriteLine("\n--- Order Management ---");
                    Console.WriteLine("1. Add Order");
                    Console.WriteLine("2. View Orders");
                    Console.WriteLine("3. Update Order");
                    Console.WriteLine("4. Delete Order");
                    Console.WriteLine("5. Add Order Item");
                    Console.WriteLine("6. View Order Items");
                    Console.WriteLine("7. Exit");

                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            {
                                OrderDetails order = new OrderDetails();

                                Console.Write("Customer Name: ");
                                order.CustomerName = Console.ReadLine();

                                Console.Write("Total Amount: ");
                                order.TotalAmount = decimal.Parse(Console.ReadLine());

                                o.AddOrder(order);
                            }
                            break;

                        case 2:
                            {
                                var orders = o.GetOrders();
                                foreach (var item in orders)
                                {
                                    Console.WriteLine($"{item.OrderId} {item.CustomerName} {item.TotalAmount}");
                                }
                            }
                            break;

                        case 3:
                            {
                                Console.Write("Enter Id: ");
                                int Id = int.Parse(Console.ReadLine() ?? "0");

                                Console.Write("New Amount: ");
                                decimal amt = decimal.Parse(Console.ReadLine() ?? "0");

                                o.Updateorder(Id, amt);
                            }
                            break;

                        case 4:
                            {
                                Console.Write("Enter Id: ");
                                int delId = int.Parse(Console.ReadLine());

                                o.DeleteOrder(delId);
                            }
                            break;

                        case 5:
                            {
                                OrderItemDetails itemObj = new OrderItemDetails();

                                Console.Write("Order Id: ");
                                itemObj.OrderId = int.Parse(Console.ReadLine());

                                Console.Write("Product Name: ");
                                itemObj.ProductName = Console.ReadLine();

                                Console.Write("Quantity: ");
                                itemObj.Quantity = int.Parse(Console.ReadLine());

                                o.AddOrderItem(itemObj);
                            }
                            break;

                        case 6:
                            {
                                Console.Write("Enter Order Id: ");
                                int oid = int.Parse(Console.ReadLine()??"0");

                                var items = o.GetItems(oid);
                                foreach (var it in items)
                                {
                                    Console.WriteLine($"{it.ItemId} {it.ProductName} {it.Quantity}");
                                }
                            }
                            break;

                        case 7:
                            Environment.Exit(0);
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
