using Microsoft.AspNetCore.Mvc;
using Microsoft.Data;
using Microsoft.Data.SqlClient;
using Club.Models;

namespace Club.Controllers
{
    public class ClubController : Controller
    {
        // in Program.cs you will find this 
        //    app.MapControllerRoute(
        //        name: "default",
        //pattern: "{controller=Home}/{action=Index}/{id?}");
        // Change controller=Home to controller=Club


        public IActionResult Index()
        {
            // right click on Index() ^ above and add view
            // select option 2 Raser View -  this will do alot of the heavy lifting
            // For the first time:            
            //view name =  index
            //template = List
            //model class = ClubInfo (Club.models)
            //Do this 4 more times with Edit, Create, Details, Delete
            //change the view name To Edit, Create, Details, Delete
            // change the template name To Edit, Create, Details, Delete
            return View(GetInfo());
            // add GetInfo() ^^ as a parameter to the the return View() when you make the function;
        }
        // in the club folder go to index.cshtml change primary key to ID
        // @Html.ActionLink("Edit", "Edit", new {  /*id=item.PRIMARYKEY*/  }) |
        //@Html.ActionLink("Details", "Details", new { /* id=item.PRIMARYKEY*/  }) |
        //        @Html.ActionLink("Delete", "Delete", new {  /*id=item.PRIMARYKEY*/  })
        [HttpGet]
        // the purpose of [HTTPGET] is to get database data and pass it to the view
        public List<ClubInfo> GetInfo(ClubInfo Member)
        {
            //First we need to create an empty list that will hold Club Member Objects

            List<ClubInfo> list = new List<ClubInfo>();
            //then a connection object with our connection string
            SqlConnection conn = new SqlConnection("SELECT * FROM club");
            conn.Open();
            //open connection string
            // use a SQLcommand to make an sql statement
            //Use data reader to read
            //add all the member details to an object
            // add each object to a list
            //return the list 
            return list;
        }
        [HttpGet]
        public ActionResult Create()
        {

            //this returns our View() for create, make sure to return View()

        }

        public ActionResult Create(ClubInfo Memeber)
        {
            //now we are on the create page we will beable to input the member we want to add
            //Make a connection object with our connection string
            //open connection string
            // use a SQLcommand to make an sql statement
            //Execute your query
            //redirect to /club

        }
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    // this is the same idea as the first create function , just a different purpose.
        //    // we get the edit view so we can see the page (this is done by [HTTPGET])
        //    // then we need to make a member object
        //    //then a connection object
        //    //then open the connection
        //    //now make a Command with a query to find the data of the member you want to edit
        //    // Now use a data reader to read the data
        //    // put the data into our member object
        //    //now return the View with your member profile
        //    // When you run your program you will see the input fields filled with your member data

        //}

        //public ActionResult Edit(ClubInfo Member)
        //{
        //    //then a connection object
        //    //then open the connection
        //    //now make a Command with a query to find the data of the member you want to edit
        //    // Now use a data reader to read the data
        //    // Execte query
        //    // redirect to /Club

        //}
        //[HttpGet]
        //public ActionResult Delete(int id)
        //{
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

        //}
        //public ActionResult Delete(ClubInfo Member)
        //{
        //    //then a connection object
        //    //then open the connection
        //    //now make a Command with a query to find the data of the member you want to Delete
        //    // Now use a data reader to read the data
        //    // Execte query
        //    // redirect to /Club

        //}
        //[HttpGet]
        //public ActionResult Details(int id)
        //{
        //    // this is the same idea as the first edit function, But now we just want to Details.
        //    // we get the Details view so we can see the page (this is done by [HTTPGET])
        //    // then we need to make a member object
        //    //then a connection object
        //    //then open the connection
        //    //now make a Command with a query to find the data of the member you want to See
        //    // Now use a data reader to read the data
        //    // put the data into our member object
        //    //now return the View with your member profile
        //    // When you run your program you will see the your member data

        }
        //    // we only need the one function for details becuse we wont be altering the data, just looking

    }
