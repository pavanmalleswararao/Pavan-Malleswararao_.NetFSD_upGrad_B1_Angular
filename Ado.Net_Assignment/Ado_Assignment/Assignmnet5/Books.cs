using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Ado_Assignment.Assignmnet5
{
    internal class BookDetails
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
    }
    internal interface IBook
    {
        void AddBook(BookDetails book);
        List<BookDetails> GetAllBooks();
        void UpdateBook(int id, BookDetails book);
        void DeleteBook(int id);
        List<BookDetails> SearchBook(string title);
    }
    internal class Books:IBook
    {
        private SqlConnection? con = null;
        private SqlCommand? cmd = null;
        private string connectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=LibraryDB;Integrated Security=True;Trust Server Certificate=True";

        public Books()
        {
            con = new SqlConnection(connectionString);
        }

        // Add Book
        public void AddBook(BookDetails book)
        {
            try
            {
                string qry = "INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);

                con?.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con?.Close();
            }
        }

        // Get All Books
        public List<BookDetails> GetAllBooks()
        {
            List<BookDetails> books = new List<BookDetails>();

            try
            {
                string qry = "SELECT * FROM Books";
                cmd = new SqlCommand(qry, con);

                con?.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new BookDetails()
                    {
                        BookId = Convert.ToInt32(reader["BookId"]),
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"])
                    });
                }
            }
            finally
            {
                con?.Close();
            }

            return books;
        }

        // Update Book
        public void UpdateBook(int id, BookDetails book)
        {
            try
            {
                string qry = "UPDATE Books SET Title=@Title, Author=@Author, Price=@Price WHERE BookId=@Id";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Title", book.Title);
                cmd.Parameters.AddWithValue("@Author", book.Author);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@Id", id);

                con?.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con?.Close();
            }
        }

        //Delete Book
        public void DeleteBook(int id)
        {
            try
            {
                string qry = "DELETE FROM Books WHERE BookId=@Id";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Id", id);

                con?.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                con?.Close();
            }
        }

        // Search Book
        public List<BookDetails> SearchBook(string title)
        {
            List<BookDetails> books = new List<BookDetails>();

            try
            {
                string qry = "SELECT * FROM Books WHERE Title LIKE @Title";
                cmd = new SqlCommand(qry, con);

                cmd.Parameters.AddWithValue("@Title", "%" + title + "%");

                con?.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    books.Add(new BookDetails()
                    {
                        BookId = Convert.ToInt32(reader["BookId"]),
                        Title = reader["Title"].ToString(),
                        Author = reader["Author"].ToString(),
                        Price = Convert.ToDecimal(reader["Price"])
                    });
                }
            }
            finally
            {
                con?.Close();
            }

            return books;
        }
    }
    class Test_Book
    {
        static void Main()
        {
            try
            {
                Books b = new Books();

                do
                {
                    Console.WriteLine("\n--- Library Management ---");
                    Console.WriteLine("1. Add Book");
                    Console.WriteLine("2. View Books");
                    Console.WriteLine("3. Update Book");
                    Console.WriteLine("4. Delete Book");
                    Console.WriteLine("5. Search Book");
                    Console.WriteLine("6. Exit");

                    int ch = int.Parse(Console.ReadLine());

                    switch (ch)
                    {
                        case 1:
                            BookDetails book = new BookDetails();
                            Console.Write("Title: ");
                            book.Title = Console.ReadLine();

                            Console.Write("Author: ");
                            book.Author = Console.ReadLine();

                            Console.Write("Price: ");
                            book.Price = decimal.Parse(Console.ReadLine());

                            b.AddBook(book);
                            break;

                        case 2:
                            var books = b.GetAllBooks();
                            foreach (var item in books)
                            {
                                Console.WriteLine($"{item.BookId} {item.Title} {item.Author} {item.Price}");
                            }
                            break;

                        case 3:
                            Console.Write("Enter Id: ");
                            int id = int.Parse(Console.ReadLine());

                            BookDetails update = new BookDetails();
                            Console.Write("New Title: ");
                            update.Title = Console.ReadLine();

                            Console.Write("New Author: ");
                            update.Author = Console.ReadLine();

                            Console.Write("New Price: ");
                            update.Price = decimal.Parse(Console.ReadLine());

                            b.UpdateBook(id, update);
                            break;

                        case 4:
                            Console.Write("Enter Id: ");
                            int delId = int.Parse(Console.ReadLine());
                            b.DeleteBook(delId);
                            break;

                        case 5:
                            Console.Write("Enter Title: ");
                            string title = Console.ReadLine();

                            var result = b.SearchBook(title);
                            foreach (var item in result)
                            {
                                Console.WriteLine($"{item.BookId} {item.Title} {item.Author} {item.Price}");
                            }
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
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
