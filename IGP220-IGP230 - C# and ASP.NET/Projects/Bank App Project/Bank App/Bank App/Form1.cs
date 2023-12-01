using System.Data.SqlClient;
using System.Data;

namespace Bank_App
{
    public partial class Form1 : Form
    {
        private SqlConnection connObj;
        private string First_Name;
        private string Last_Name;
        private string Street_No;
        private string Street_Name;
        private string City;
        private string Province;
        private string Postal_Code;
        private string Phone_No;
        private string Email;
        private string DOB;
        private string Customer_ID;
        //private string Branch_ID;

        public Form1()
        {
            First_Name = "";
            Last_Name = "";
            Street_No = "";
            Street_Name = "";
            City = "";
            Province = "";
            Postal_Code = "";
            Phone_No = "";
            Email = "";
            DOB = "";
            Customer_ID = "";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;  // Gets the path for the executable file that started the application.
            string filePath = @"..\..\..\Bank.mdf";
            string absolutePath = Path.GetFullPath(filePath);
            //string relativePath = Path.GetRelativePath(appPath, filePath);
            connObj = new SqlConnection(@$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='{absolutePath}';Integrated Security=True"); //path had to be in single quotes from G: onwards
            connObj.Open();           //SqlCommand command = new SqlCommand("SELECT * FROM Customers;", connObj);
            //SqlDataReader reader = command.ExecuteReader(); //Not sure if this is needed, seems to interfere with the insert function
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {// ------------This is a requierment--------------//
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

            if (Fname_box.Text == "" || Lname_box.Text == "" || street_no_box.Text == "" || street_name_box.Text == "" || city_box.Text == "" || prov_box.Text == "" || pc_box.Text == "" || phone_box.Text == "" || email_box.Text == "" || dob_box.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                First_Name = Fname_box.Text.ToUpper();
                Last_Name = Lname_box.Text.ToUpper();
                Street_No = street_no_box.Text;
                Street_Name = street_name_box.Text.ToUpper();
                City = city_box.Text.ToUpper();
                Province = prov_box.Text.ToUpper();
                Postal_Code = pc_box.Text.ToUpper();
                Phone_No = phone_box.Text;
                Email = email_box.Text.ToUpper();
                DOB = dob_box.Text;
                //Customer_ID = Cust_ID_box.Text;

                SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Customer_ID = '" + Customer_ID + "'", connObj); //compares customer by looking if the unique ID is the same

                SqlDataReader reader = command.ExecuteReader();//wasn't working if i had a reader somewhere else
                bool customerExists = false;
                while (reader.Read())
                {
                    if (First_Name == reader["First_Name"].ToString() && Last_Name == reader["Last_Name"].ToString() && Email == reader["Email"].ToString() && Phone_No == reader["Phone_No"].ToString())

                    /* && Street_No == reader["Street_No"].ToString() && Street_Name == reader["Street_Name"].ToString() && City == reader["City"].ToString() && Province == reader["Province"].ToString() && Postal_Code == reader["Postal_Code"].ToString() && DOB == reader["DOB"].ToString())*/
                    //does't seem to be working, it's making a new customer every time
                    {
                        customerExists = true;
                        break; //exits loop if customer already exists. Not strictly necessary but recommended
                    }
                }
                reader.Close();
                if (customerExists)
                {
                    MessageBox.Show("Customer already exists");
                }
                else
                {
                    SqlCommand command2 = new SqlCommand("INSERT INTO Customers (First_Name, Last_Name, Street_No, Street_Name, City, Province, Postal_Code, Phone_No, Email, DOB) VALUES ('" + First_Name + "', '" + Last_Name + "', '" + Street_No + "', '" + Street_Name + "', '" + City + "', '" + Province + "', '" + Postal_Code + "', '" + Phone_No + "', '" + Email + "', '" + DOB + "');", connObj);
                    command2.ExecuteNonQuery();
                    MessageBox.Show("Customer added successfully");
                }
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {  //-------- this is a requierment ---//
           //You should have a connection to the data base on your form load
           // Using SqlCommand and SqlDataReader do the following

            //make sure all of the textboxes are filled in
            //if not ask them to fill it in
            //Use an sql statement to update the data (use sqlCommand to Update data and a function that is part of the sqlCommand called .ExecuteNonQuery())
            //Let the user know it was successful

            if (Fname_box.Text == "" || Lname_box.Text == "" || street_no_box.Text == "" || street_name_box.Text == "" || city_box.Text == "" || prov_box.Text == "" || pc_box.Text == "" || phone_box.Text == "" || email_box.Text == "" || dob_box.Text == "")
            {
                MessageBox.Show("Please fill in all fields");
            }
            else
            {
                First_Name = Fname_box.Text.ToUpper();
                Last_Name = Lname_box.Text.ToUpper();
                Street_No = street_no_box.Text;
                Street_Name = street_name_box.Text.ToUpper();
                City = city_box.Text.ToUpper();
                Province = prov_box.Text.ToUpper();
                Postal_Code = pc_box.Text.ToUpper();
                Phone_No = phone_box.Text;
                Email = email_box.Text.ToUpper();
                DOB = dob_box.Text;
                Customer_ID = Cust_ID_box.Text;
                SqlCommand command = new SqlCommand("UPDATE Customers SET First_Name = '" + First_Name + "', Last_Name = '" + Last_Name + "', Street_No = '" + Street_No + "', Street_Name = '" + Street_Name + "', City = '" + City + "', Province = '" + Province + "', Postal_Code = '" + Postal_Code + "', Phone_No = '" + Phone_No + "', Email = '" + Email + "', DOB = '" + DOB + "' WHERE Customer_ID = '" + Customer_ID + "';", connObj);
                command.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully");
            }
        }

        private void find_ID_btn_Click(object sender, EventArgs e)
        {
            //-------- this is a requierment ---//
            //if the customer ID is empty, let the user know to fill it in and leave the function
            //Search for the record
            //if found add to the textboxes using DataReader
            //if not found let the user know

            if (Cust_ID_box.Text == "")
            {
                MessageBox.Show("Please fill in the Customer ID");
            }
            else
            {
                Customer_ID = Cust_ID_box.Text;
                SqlCommand command = new SqlCommand("SELECT * FROM Customers WHERE Customer_ID = '" + Customer_ID + "'", connObj);
                SqlDataReader reader = command.ExecuteReader();

                bool customerFound = false;
                while (reader.Read())
                {
                    Fname_box.Text = reader["First_Name"].ToString();
                    Lname_box.Text = reader["Last_Name"].ToString();
                    street_no_box.Text = reader["Street_No"].ToString();
                    street_name_box.Text = reader["Street_Name"].ToString();
                    city_box.Text = reader["City"].ToString();
                    prov_box.Text = reader["Province"].ToString();
                    pc_box.Text = reader["Postal_Code"].ToString();
                    phone_box.Text = reader["Phone_No"].ToString();
                    email_box.Text = reader["Email"].ToString();
                    dob_box.Text = reader["DOB"].ToString();

                    customerFound = true;
                    break;
                }
                reader.Close();

                if (customerFound)
                {
                    // customer found, do nothing
                }
                else
                {
                    MessageBox.Show("Customer not found");
                }
            }
        }

        private void Read_Click(object sender, EventArgs e)
        {

        }
    }
}