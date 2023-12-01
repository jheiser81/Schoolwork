using Club.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace Club.Controllers
{
    public class ClubController : Controller
    {
        public string ConnectionString() //made a function to return the connection string, instead of having to type it out every time
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ClubInfo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            //had to remove the spaces between TrustServerCertificate, ApplicationIntent, and MultiSubnetFailover for the connection string to work. Not really sure why???
            return connString; //returns the connection string. Without the return, the function would not return anything when called
        }

        [HttpGet] //this tells the method to only be called when the user is requesting info from the server
        public IActionResult Index() //IActionResult is an interface in ASP.Net that is used to return different types of resuts, depending on the type of request. Index is the default method that is called when the user navigates to the page
        {
            return View(GetInfoFromDB()); //View is a default method that returns a view to the user. It is used to display the data from the database
        }

        #region GetInfoFromDB

        [HttpGet]
        public List<ClubInfo> GetInfoFromDB()
        {
            #region Instructions

            //1.Create an empty list called "listObject" to hold the results of the database query.
            //2.Define a connection string to connect to the database. This includes the name of the database, the server
            //name, and security credentials to access the database.
            //3.Open a connection to the database using the connection string.
            //4.Create a command object called "cmd" that will be used to execute the SQL query against the database.
            //5.Set the command object's connection property to the open connection to the database.
            //6.Execute the SQL query using the command object, and retrieve the results as a data reader object called "sdr".
            //7.Loop through each row in the data reader object using a while loop.
            //8.For each row, create a new instance of the "ClubMembers" class, and assign the values of the row's fields to the properties of the "ClubMembers" object.
            //9. Add the "ClubMembers" object to the list "listObject".
            //10. Close the data reader object, the command object, and the database connection.
            //11. Return the list "listObject" containing the data retrieved from the database.

            #endregion Instructions

            List<ClubInfo> clubMemberList = new List<ClubInfo>(); //list to hold the club members from the database
            //ClubInfo is the name of the class that holds the properties for the club members
            //clubMemberList is the name of the list that will hold the club members

            string connString = ConnectionString(); //calls the function to return the connection string
            using (SqlConnection connObj = new SqlConnection(connString)) //creating a new connection object, and passing the connection string to it
            {
                try
                {
                    connObj.Open(); //opens the connection to the database
                    SqlCommand cmd = new SqlCommand("SELECT * FROM ClubInfo", connObj);
                    using (SqlDataReader sdr = cmd.ExecuteReader()) //uses the data reader to read the data from the database
                    {
                        while (sdr.Read()) //creates a while loop with the data reader
                        {
                            ClubInfo clubMember = new ClubInfo(); //creates a new instance of the ClubInfo class

                            clubMember.ID = Convert.ToInt32(sdr["ID"]);
                            clubMember.FirstName = sdr["FirstName"].ToString();
                            clubMember.LastName = sdr["LastName"].ToString();
                            clubMember.Rank = sdr["Rank"].ToString();
                            clubMember.DOB = sdr["DOB"].ToString();
                            //These are technically database objects which is why they need to be converted to the specific type we want them to output as

                            clubMemberList.Add(clubMember); //this adds the club member to the list
                        }
                    }
                }
                catch (SqlException ex)
                {
                    ViewBag.ErrorMessage = "Unable to retrieve data" + ex.Message;
                }
            }
            return clubMemberList; //returns the list
        }

        #endregion GetInfoFromDB

        #region Create

        [HttpGet] //this tells the method to only be called when the user is requesting info from the server
        public ActionResult Create()
        {
            return View(); //returns the view to the user, which is the form to create a new club member
        }

        //Having separate functions for GET and POST requests allows you to handle the different stages of form submission in a clean and organized manner.
        //The GET method is used to display the form to the user, and the POST method is used to handle the form submission.

        [HttpPost] //this tells the method to only be called when the user is submitting info to the server
        public ActionResult Create(ClubInfo clubMember)
        //ActionResult is similar to IActionResult, but is a class that implements the IActionResult. In most cases, they are interchangeable.
        //ClubInfo and clubMember are used here as parameters to pass the data from the form to the database
        {
            #region Instructions

            //1.Begin by creating a new method called "Create" with an HTTPGET attribute.This method will be used to display a view to
            //the user.
            //2.Inside the "Create" method, return a "View" object that displays an empty form for creating a new club member.
            //3.Create a new method called "Create" with an HTTP POST attribute.This method will be used to handle the form
            //submission.
            //4.Define a connection string to connect to the database.This includes the name of the database, the server name, and
            //security credentials to access the database.
            //5.Define an SQL query string that inserts a new row into the "ClubMembers" table with the form data submitted by the user.
            //6.Inside the HTTP POST method, create an instance of the "ClubMembers" class and pass the form data submitted by the
            //user to this object.
            //7. Open a connection to the database using the connection string.
            //8. Create a command object called "cmd" that will be used to execute the SQL query against the database.
            //9. Set the command object's connection property to the open connection to the database.
            //10. Execute the SQL query using the command object to insert the new club member data into the database.
            //11. Close the database connection.
            //12. Return a "View" object that displays the "Index" view and the updated data retrieved from the database by calling the
            //"GetInfoFromDB" method.

            #endregion Instructions

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("INSERT INTO ClubInfo (FirstName, LastName, Rank, DOB) VALUES (@FirstName, @LastName, @Rank, @DOB)", connObj);

                    cmd.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", clubMember.LastName);
                    cmd.Parameters.AddWithValue("@Rank", clubMember.Rank);
                    cmd.Parameters.AddWithValue("@DOB", clubMember.DOB);
                    //Member ID is left out here, because it will be automatically incremented

                    cmd.ExecuteNonQuery(); //this is used to execute the SQL query
                }
                return RedirectToAction("Index", GetInfoFromDB());
                //Takes you back to the index page after you submit the form
                //RedirectToAction is a method that redirects to a specific view, in this case the "Index" view
                //we can return it here even though the method isn't declared, since it is a default method in ASP.NET MVC
                //can also just use View, but RedirectToAction is preferred when redirecting from one view to a different view
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + " " + ex.Message;
                return View("Error", ex.Message);
            }
        }

        #endregion Create

        #region Edit (GET)

        [HttpGet] //this is the get part of the edit method
        public ActionResult Edit(int id) //declaring new int 'id' as a parameter, which corresponds to the "ID" primary key in the database and passes to the Edit view
        {
            #region Instructions

            //1.Create a new method called "Edit" with an HTTP GET attribute.This method will be used to display a view to the user.
            //2.Inside the "Edit" method, define a connection string to connect to the database.This includes the name of the database, the server name, and security credentials to access the database.
            //3.Open a connection to the database using the connection string.
            //4.Create a command object called "cmd" that will be used to execute the SQL query against the database.
            //5.Set the command object's connection property to the open connection to the database.
            //6.Execute the SQL query using the command object, and retrieve the results as a data reader object called "sdr".
            //7.Loop through each row in the data reader object using a while loop.
            //8.For each row, create a new instance of the "ClubMembers" class, and assign the values of the row's fields to the properties of the "ClubMembers" object.
            //9.Close the data reader object, the command object, and the database connection.
            //10.Return a "View" object that displays the "Edit" view and the "ClubMembers" object containing the data retrieved from the database.

            #endregion Instructions

            ClubInfo clubMember = new ClubInfo(); //creates a new instance of the ClubInfo class
            //ClubInfo is the name of the class contained in the list, and clubMember is the name of the object

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM ClubInfo WHERE ID = @ID", connObj);
                    cmd.Parameters.AddWithValue("@ID", id); //here is where the 'id' parameter is passed to the database

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            clubMember.ID = Convert.ToInt32(sdr["ID"]);
                            clubMember.FirstName = sdr["FirstName"].ToString();
                            clubMember.LastName = sdr["LastName"].ToString();
                            clubMember.Rank = sdr["Rank"].ToString();
                            clubMember.DOB = sdr["DOB"].ToString();
                            //again converting these to the specific data type we want
                            //ID is included here because it is the primary key, which is needed to update the correct row in the database
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + " " + ex.Message;
                //return View("Error", ex.Message);
            }
            return View(clubMember); //sends the club member data to the "Edit" view, so the user can see and edit the existing information
        }

        #endregion Edit (GET)

        #region Edit (POST)

        [HttpPost] //this is the post part of the edit method
        public ActionResult Edit(ClubInfo clubMember)
        {
            #region Instructions

            //1.add a connection object - the connection string variable i created
            //2.then open the connection -establish sql connection with connObj and connString
            //3.now make a Command with a query to find the data of the member you want to edit --this is basically the same as the "Update" function from the bank project
            //4.Now use a data reader to read the data
            //5.Execte query
            //6.Redirect to /Club

            #endregion Instructions

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE ClubInfo SET FirstName = @FirstName, LastName = @LastName, Rank = @Rank, DOB = @DOB WHERE ID = @ID", connObj);

                    cmd.Parameters.AddWithValue("@FirstName", clubMember.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", clubMember.LastName);
                    cmd.Parameters.AddWithValue("@Rank", clubMember.Rank);
                    cmd.Parameters.AddWithValue("@DOB", clubMember.DOB);
                    cmd.Parameters.AddWithValue("@ID", clubMember.ID);
                    //Primary Key ID is not included here, because we don't want to change it only use it to find the correct entry in the database

                    cmd.ExecuteNonQuery();
                }
                return RedirectToAction("Index");
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + ex.Message;
                return View(ex.Message);
            }
        }

        #endregion Edit (POST)

        #region Delete (GET)

        [HttpGet] //get part of the delete method
        public ActionResult Delete(int id)
        {
            #region Instructions

            //    // this is the same idea as the first edit function, But now we just want to delete.
            //    // we get the Delete view so we can see the page (this is done by [HTTPGET])
            //    // then we need to make a member object
            //    //then a connection object
            //    //then open the connection
            //    //now make a Command with a query to find the data of the member you want to delete
            //    // Now use a data reader to read the data
            //    // put the data into our member object
            //    //now return the View with your member profile
            //    // When you run your program you will see the input fields filled with your member data

            #endregion Instructions

            ClubInfo clubMember = new ClubInfo();

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("SELECT FROM ClubInfo WHERE ID = @ID", connObj);
                    cmd.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            clubMember.ID = Convert.ToInt32(sdr["ID"]); //primary key ID is included here, since we use it to find the correct entry in the database
                            clubMember.FirstName = sdr["FirstName"].ToString();
                            clubMember.LastName = sdr["LastName"].ToString();
                            clubMember.Rank = sdr["Rank"].ToString();
                            clubMember.DOB = sdr["DOB"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + ex.Message;
            }
            return View(clubMember);
        }

        #endregion Delete (GET)

        #region Delete (POST)

        [HttpPost] //post part of the delete method
        public ActionResult Delete(ClubInfo clubMember)
        {
            #region Instructions

            //    //then a connection object
            //    //then open the connection
            //    //now make a Command with a query to find the data of the member you want to Delete
            //    // Now use a data reader to read the data
            //    // Execte query
            //    // redirect to /Club

            #endregion Instructions

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM ClubInfo WHERE ID = @ID", connObj);
                    cmd.Parameters.AddWithValue("@ID", clubMember.ID);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + ex.Message;
            }
            return RedirectToAction("Index");
        }

        #endregion Delete (POST)

        #region Details

        [HttpGet] //we only need the GET part of the details method because we are not editing the data, just looking at it
        public ActionResult Details(int id) //the id parameter is passed to the Details view from the "Index" view
        {
            #region Instructions

            // this is the same idea as the first edit function, But now we just want to get Details.
            // we get the Details view so we can see the page (this is done by [HTTPGET])
            // then we need to make a member object
            // then a connection object
            // then open the connection
            // now make a Command with a query to find the data of the member you want to See
            // Now use a data reader to read the data
            // put the data into our member object
            // now return the View with your member profile
            // When you run your program you will see the your member data
            // we only need the one function for details becuse we wont be altering the data, just looking

            #endregion Instructions

            ClubInfo clubMember = new ClubInfo();

            try
            {
                string connString = ConnectionString();
                using (SqlConnection connObj = new SqlConnection(connString))
                {
                    connObj.Open();

                    SqlCommand cmd = new SqlCommand("SELECT * FROM ClubInfo WHERE ID = @ID", connObj); //searches the database for the member with a specific primary key ID
                    cmd.Parameters.AddWithValue("@ID", id);

                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while (sdr.Read())
                        {
                            clubMember.ID = Convert.ToInt32(sdr["ID"]);
                            clubMember.FirstName = sdr["FirstName"].ToString();
                            clubMember.LastName = sdr["LastName"].ToString();
                            clubMember.Rank = sdr["Rank"].ToString();
                            clubMember.DOB = sdr["DOB"].ToString();
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                ViewBag.ErrorMessage = "Unable to retrieve data" + ex.Message;
            }
            return View(clubMember); //returns the view with the member data
        }

        #endregion Details
    }
}