using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Drawing;
using System;
using System.Linq.Expressions;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        public string ConnectionString()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Library;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryBooks;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return connString;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(GetInfoFromDB());
        }

        [HttpGet]
        public List<BookInfo> GetInfoFromDB()
        {
            List<BookInfo> libraryBooks = new List<BookInfo>();
            string connString = ConnectionString();
            using (SqlConnection connObj = new SqlConnection(connString))
            {
                try
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LibraryBooks", connObj);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BookInfo book = new BookInfo();

                            book.ISBN = reader["ISBN"].ToString();
                            book.Title = reader["Title"].ToString();
                            book.Author = reader["Author"].ToString();
                            book.Publisher = reader["Publisher"].ToString();
                            book.Pub_Date = reader["Pub_Date"].ToString();
                            book.Genre = reader["Genre"].ToString();

                            libraryBooks.Add(book);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    ViewBag.Error = ex.Message;
                }
            }
            return libraryBooks;
        }

        [HttpGet]
        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(BookInfo book) //I am passing in the book object from the form, and the BookInfo class is the model for the form
        {
            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO LibraryBooks (ISBN, Title, Author, Publisher, Pub_Date, Genre) VALUES (@ISBN, @Title, @Author, @Publisher, @Pub_Date, @Genre)", connObj);

                    cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                    cmd.Parameters.AddWithValue("Title", book.Title);
                    cmd.Parameters.AddWithValue("Author", book.Author);
                    cmd.Parameters.AddWithValue("Publisher", book.Publisher);
                    cmd.Parameters.AddWithValue("Pub_Date", book.Pub_Date);
                    cmd.Parameters.AddWithValue("Genre", book.Genre);
                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index", GetInfoFromDB());
            }
            catch (SqlException sqlEx)
            {
                ViewBag.ErrorMessage = sqlEx.Message;
                return View("Index", GetInfoFromDB());
            }
        }
    }
}