using Library_New_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Library_New_.Controllers
{
    public class AuthorController : Controller
    {
        public string ConnectionString()
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Library"";Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=""New Library"";Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            return connString;
        }

        public int AutoIncrementID()
        {
            string connString = ConnectionString();
            Authors Authors = new Authors();

            using (SqlConnection connObj = new SqlConnection(connString))
            {
                connObj.Open();
                SqlCommand cmd = new SqlCommand("SELECT MAX(Author_ID) FROM Authors", connObj);
                Authors.Author_ID = Convert.ToInt32(cmd.ExecuteScalar());
            }
            return ++Authors.Author_ID;
        }

        #region GetAuthorsList

        [HttpGet]
        public IActionResult Index()
        {
            return View(GetAuthorsList());
        }

        [HttpGet]
        public List<Authors> GetAuthorsList()
        {
            List<Authors> authorList = new List<Authors>();
            string connString = ConnectionString();

            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Authors", connObj);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            Authors Authors = new Authors();

                            Authors.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                            Authors.First_Name = reader["First_Name"].ToString();
                            Authors.Last_Name = reader["Last_Name"].ToString();
                            authorList.Add(Authors);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return authorList;
        }

        #endregion GetAuthorsList

        #region AddAuthor

        [HttpGet]
        public ActionResult AddAuthor()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAuthor(Authors author)
        {
            //navigate to the books page to add a book (redirect)
            //every Authors needs to have a book
            //when you add a book, Author has to already exist
            //drop down menu to select current authors (look this up)
            string connString = ConnectionString();
            try
            {
                author.Author_ID = AutoIncrementID();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO Authors (Author_ID, First_Name, Last_Name) VALUES (@Author_ID, @First_Name, @Last_Name)", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", author.Author_ID);
                    cmd.Parameters.AddWithValue("@First_Name", author.First_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", author.Last_Name);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return RedirectToAction("AddBook", "Books");
        }

        #endregion AddAuthor

        #region Details

        [HttpGet]
        public ActionResult Details(int id)
        {
            Authors author = new Authors();
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Authors WHERE Author_ID = @Author_ID", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            author.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                            author.First_Name = reader["First_Name"].ToString();
                            author.Last_Name = reader["Last_Name"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(author);
        }

        #endregion Details

        #region Edit

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Authors author = new Authors();
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Authors WHERE Author_ID = @Author_ID", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            author.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                            author.First_Name = reader["First_Name"].ToString();
                            author.Last_Name = reader["Last_Name"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(author);
        }

        [HttpPost]
        public ActionResult Edit(int id, Authors author)
        {
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Authors SET First_Name = @First_Name, Last_Name = @Last_Name WHERE Author_ID = @Author_ID", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", id);
                    cmd.Parameters.AddWithValue("@First_Name", author.First_Name);
                    cmd.Parameters.AddWithValue("@Last_Name", author.Last_Name);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return RedirectToAction("Index");
        }

        #endregion Edit

        #region Delete

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Authors author = new Authors();
            string connString = ConnectionString();
            try
            {
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Authors WHERE Author_ID = @Author_ID", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            author.Author_ID = Convert.ToInt32(reader["Author_ID"]);
                            author.First_Name = reader["First_Name"].ToString();
                            author.Last_Name = reader["Last_Name"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return View(author);
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM Authors WHERE Author_ID = @Author_ID", connObj);
                    cmd.Parameters.AddWithValue("@Author_ID", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorInfo = ex.Message;
            }
            return RedirectToAction("Index", GetAuthorsList());
        }

        #endregion Delete
    }
}