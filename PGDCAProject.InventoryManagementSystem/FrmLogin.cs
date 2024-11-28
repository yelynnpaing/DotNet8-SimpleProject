using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;


namespace PGDCAProject.InventoryManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;Persist Security Info=True;User ID=sa;Password=sasa@123");
        

        void Clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
            txtPassword.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;
            userName = txtUserName.Text;
            password = txtPassword.Text;

            try
            {
                string query = "SELECT * FROM TblUsers WHERE UserName='" + txtUserName.Text + "' AND Password= '" + txtPassword.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                if (dataTable.Rows.Count > 0)
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;

                    Items items = new Items();
                    items.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Error", "Invalid Login!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
