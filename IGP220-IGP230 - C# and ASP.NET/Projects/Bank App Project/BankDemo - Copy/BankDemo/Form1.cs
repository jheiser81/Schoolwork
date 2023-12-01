using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic;

namespace BankDemo
{
    public partial class Form1 : Form
    {
        SqlConnection connObj;

        string fName;
        string lName;
        string streetNo;
        string streetName;
        string City;
        string province;
        string Postal;
        string Country;
        string phoneNo;
        string email;
        string DOB;
        int currentID;
        public Form1()
        {
            fName = "";
            lName = "";
            streetNo = "";
            streetName = "";
            City = "";
            province = "";
            Postal = "";
            Country = "";
            phoneNo = "";
            email = "";
            DOB = "";
            currentID = 0;
            connObj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\repos\Teaching\C#\Winter2023\BankDemo\BankDemo\Bank.mdf;Integrated Security=True");
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)//Required step 1
        {
           //connection open
        }
        private void Insert_click(object sender, EventArgs e)//Required step 2
        {
            // ------------This is a requierment--------------//
            //You should have a connection to the data base on your form load
            // Using SqlCommand and SqlDataReader do the following

            //make sure all of the textboxes are filled in
            //search if the record already exists (use sqlCommand to make the query, SqlDataReader go through the data)
            //    if it doesn't exist proceed to adding the record 
            //    if it does then tell the user it already exists 
            //instert the data into the database    (use sqlCommand to insert data and a function that is part of the sqlCommand called .ExecuteNonQuery())
            //Let the user know it was successful
            //----------Optional--------//
            //add another form that connects to accounts so you can add a chequing account for the user

        }
     

       
        private void Update_Click(object sender, EventArgs e)//Required step 3
        {
            //-------- this is a requierment ---//
            //You should have a connection to the data base on your form load
            // Using SqlCommand and SqlDataReader do the following

            //make sure all of the textboxes are filled in
                //if not ask them to fill it in
            //Use an sql statement to update the data (use sqlCommand to Update data and a function that is part of the sqlCommand called .ExecuteNonQuery())
            //Let the user know it was successful   
        }
        private void Find_Click(object sender, EventArgs e)//Required step 4
        {
            //-------- this is a requierment ---//
            //if the customer ID is empty, let the user know to fill it in and leave the function
            //Search for the record
            //if found add to the textboxes using DataReader
            //if not found let the user know          


        }
        private void Delete_Click(object sender, EventArgs e)//Required step 5
        {
            //-------- this is a requierment ---//
            // ask the user if they are sure they want to 
            //    if they dont want to delete, leave the function
            //    if they do proceed to the next step
            //search for the record
            //if you find it delete it
            //inform the user it had successfuly been deleted
            // clear data form form
        }
        private void Clear_Form()//Required step 6
        {
            //clear all textboxes
        }
        private void Previous_Click(object sender, EventArgs e)//Optional
        {
            
            //search the Database for the first customer that who Has an ID less than the current customer
            //if there is not ID less than the current, let the user know they are at the beginning of the file
            //If you do find the data, Display in the Texboxes   
        }
        private void Read_Click(object sender, EventArgs e)
        {
            //-------- this is not a requierment but can be fun to add to your form ---//
            // show all customers in a new form 
        }


        private void Next_Click(object sender, EventArgs e)//Optional
        {
            //-------- this is a requierment ---//
            //search the Database for the first customer that who Has an ID Greater than the current customer
            //if there is no ID greater than the current, let the user know they are at the end of the file
            //If you do find the data, Display in the Texboxes          


        }

        private bool Find_Data(string sql = "SELECT * from Customers")//Optional, you are welcome to do everthing in the button fuction and then remove duplicated code after
        {
            //-------- this function was made to prevent duplication of code-----// this is not a requierment
            // use SqlCommand
            // use data reader to find search for data
            //read data from data readerand output to textboxes           
            return true;
        }

        private void Get_Accounts_Click(object sender, EventArgs e)
        {
            
            //-------- this is not a requierment but can be fun to add to your form ---//
            //// You would open a new form to get accounts
        }
      
       
        private bool FillVariables()//Required
        {
            //-------- this function was made to prevent duplication of code-----// this is not a requierment
            //fill the variables 
            return false;
        }
    }
}
