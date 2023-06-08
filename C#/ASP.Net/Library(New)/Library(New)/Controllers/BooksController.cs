using Library_New_.Models;
using Microsoft.AspNetCore.DataProtection.AuthenticatedEncryption.ConfigurationModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Data.SqlClient;

namespace Library_New_.Controllers
{
    public class BooksController : Controller
    {
        public string ConnectionString()
        {
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Library"";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Library"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            return connString;
        }

        public int AutoIncrementID()
        {
            string connString = ConnectionString();
            Books books = new Books();

            using (SqlConnection connObj = new SqlConnection(connString))
            {
                connObj.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Book_ID) FROM Books", connObj);
                books.Book_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return ++books.Book_ID;
        }

        #region GetInfoFromDB

        [HttpGet]
        public IActionResult Index()
        {
            return View(GetInfoFromDB());
        }

        [HttpGet]
        public List<Books> GetInfoFromDB()
        {
            List<Books> booksList = new List<Books>();
            string connString = ConnectionString();

            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Books.Book_ID, Books.Title, Books.Genre, Books.Publisher, Books.Pub_Date, Authors.Author_ID, Authors.First_Name, Authors.Last_Name FROM Books INNER JOIN Authors ON Books.Author_ID = Authors.Author_ID ORDER BY Author_ID ASC", connObj);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            Books books = new Books();

                            books.Book_ID = Convert.ToInt32(reader["Book_ID"]);
                            books.Title = reader["Title"].ToString();
                            books.Genre = reader["Genre"].ToString();
                            books.Publisher = reader["Publisher"].ToString();
                            books.Pub_Date = reader["Pub_Date"].ToString();
                            books.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                            books.First_Name = reader["First_Name"].ToString();
                            books.Last_Name = reader["Last_Name"].ToString();
                            booksList.Add(books);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return booksList;
        }

        #endregion GetInfoFromDB

        #region AddBook

        [HttpGet]
        public ActionResult AddBook()
        {
            ViewBag.Authors = GetAuthorList(); //had to use the ViewBag to pass the list of authors to the view, and used the helper method GetAuthorList to populate the dropdown list
            return View();
        }

        private List<SelectListItem> GetAuthorList()
        //This is a helper method to populate the dropdown list with authors
        //I had to create a new list of select list items to populate the dropdown list with authors
        //Also had to modify the razor code in the view to use the new list
        //This method was also previously called GetInfoFromDB, which was the same name as the method in BooksController, which was causing issues.
        {
            string connString = ConnectionString();
            List<SelectListItem> authorList = new List<SelectListItem>();

            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", connObj);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        authorList.Add(new SelectListItem { Value = reader["Author_ID"].ToString(), Text = reader["First_Name"].ToString() + " " + reader["Last_Name"].ToString() });
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }

            return authorList;
        }

        [HttpPost]
        public ActionResult AddBook(Books books)
        {
            try
            {
                books.Book_ID = AutoIncrementID();
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Books (Book_ID, Title, Genre, Publisher, Pub_Date, Author_ID) VALUES (@Book_ID, @Title, @Genre, @Publisher, @Pub_Date, @Author_ID)", connObj); //author_id included here because it's a FK in the books table

                    cmd.Parameters.AddWithValue("@Book_ID", books.Book_ID);
                    cmd.Parameters.AddWithValue("@Title", books.Title);
                    cmd.Parameters.AddWithValue("@Genre", books.Genre);
                    cmd.Parameters.AddWithValue("@Publisher", books.Publisher);
                    cmd.Parameters.AddWithValue("@Pub_Date", books.Pub_Date);
                    cmd.Parameters.AddWithValue("@Author_ID", books.Author_ID);
                    //author_id included here because it's a FK in the books table

                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index", "Books");
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
                ViewBag.Authors = GetInfoFromDB();
                return View();
            }
        }

        #endregion AddBook

        #region Details

        [HttpGet]
        public ActionResult Details(int id)
        {
            Books books = new Books();
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Books.Book_ID, Books.Title, Books.Genre, Books.Publisher, Books.Pub_Date, Authors.Author_ID, Authors.First_Name, Authors.Last_Name FROM Books INNER JOIN Authors ON Books.Author_ID = Authors.Author_ID WHERE Book_ID = @Book_ID", connObj);
                    cmd.Parameters.AddWithValue("@Book_ID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        books.Book_ID = Convert.ToInt32(reader["Book_ID"]);
                        books.Title = reader["Title"].ToString();
                        books.Genre = reader["Genre"].ToString();
                        books.Publisher = reader["Publisher"].ToString();
                        books.Pub_Date = reader["Pub_Date"].ToString();
                        books.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                        books.First_Name = reader["First_Name"].ToString();
                        books.Last_Name = reader["Last_Name"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(books);
        }

        #endregion Details

        #region Edit

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Books books = new Books();
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Books.Book_ID, Books.Title, Books.Genre, Books.Publisher, Books.Pub_Date, Authors.Author_ID, Authors.First_Name, Authors.Last_Name FROM Books INNER JOIN Authors ON Books.Author_ID = Authors.Author_ID WHERE Book_ID = @Book_ID", connObj);

                    cmd.Parameters.AddWithValue("@Book_ID", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        books.Book_ID = Convert.ToInt32(reader["Book_ID"]);
                        books.Title = reader["Title"].ToString();
                        books.Genre = reader["Genre"].ToString();
                        books.Publisher = reader["Publisher"].ToString();
                        books.Pub_Date = reader["Pub_Date"].ToString();
                        books.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                        books.First_Name = reader["First_Name"].ToString();
                        books.Last_Name = reader["Last_Name"].ToString();
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(books);
        }

        [HttpPost]
        public ActionResult Edit(int id, Books books)
        {
            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE Books SET Title = @Title, Genre = @Genre, Publisher = @Publisher, Pub_Date = @Pub_Date WHERE Book_ID = @Book_ID", connObj);

                    cmd.Parameters.AddWithValue("@Book_ID", id);
                    cmd.Parameters.AddWithValue("@Title", books.Title);
                    cmd.Parameters.AddWithValue("@Genre", books.Genre);
                    cmd.Parameters.AddWithValue("@Publisher", books.Publisher);
                    cmd.Parameters.AddWithValue("@Pub_Date", books.Pub_Date);

                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index", "Books");
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
                return View();
            }
        }

        #endregion Edit

        #region Delete

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Books books = new Books();
            string connString = ConnectionString();

            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Books WHERE Book_ID = @Book_ID", connObj);
                    cmd.Parameters.AddWithValue("@Book_ID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            books.Book_ID = Convert.ToInt32(reader["Book_ID"]);
                            books.Title = reader["Title"].ToString();
                            books.Genre = reader["Genre"].ToString();
                            books.Publisher = reader["Publisher"].ToString();
                            books.Pub_Date = reader["Pub_Date"].ToString();
                            books.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(books);
        }

        [HttpPost]
        public ActionResult Delete(int? id)
        {
            string connString = ConnectionString();

            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE Book_ID = @Book_ID", connObj);
                    cmd.Parameters.AddWithValue("@Book_ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View("Index", GetInfoFromDB());
        }

        #endregion Delete
    }
}