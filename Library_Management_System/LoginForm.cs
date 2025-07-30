using Microsoft.Data.SqlClient;

namespace Library_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text.Trim();
            string password = passwordtxt.Text.Trim();

            if (username == "" || username == "Username" || password == "" || password == "Password")
            {
                error.Text = "*Please enter your username and password";
                return;



            }

            SqlConnection con = new SqlConnection
                (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LibraryDB;Integrated Security=True");
            {
                con.Open();

                // Admin table Check
                string adminQuery = "SELECT COUNT(*) FROM Admins WHERE Username=@username AND UserPassword=@password";
                SqlCommand adminCmd = new SqlCommand(adminQuery, con);

                adminCmd.Parameters.AddWithValue("@username", username);
                adminCmd.Parameters.AddWithValue("@password", password);

                int adminCount = (int)adminCmd.ExecuteScalar();

                if(adminCount>0)
                {
                    //Redirect to Admin Dashboard
                    AdminDashboard admin = new AdminDashboard();
                    admin.Show();
                    this.Hide();
                    return;
                }


                ////Member table Check
                
                string memberQuery = "SELECT COUNT(*) FROM Members WHERE Username=@username AND UserPassword=@password";
                SqlCommand memberCmd = new SqlCommand(memberQuery, con);

                memberCmd.Parameters.AddWithValue("@username", username);
                memberCmd.Parameters.AddWithValue("@password", password);

                int memberCount = (int)memberCmd.ExecuteScalar();
                if(memberCount>0)
                {
                    MemberDashboard member = new MemberDashboard();
                    member.Show();
                    this.Hide();

                }
                else
                {
                    error.Text = "*Invalid Username and Password";
                }

            }
           
          

        }
    }
}
