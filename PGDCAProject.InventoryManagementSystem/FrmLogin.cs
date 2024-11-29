using System.Data;
using Microsoft.Data.SqlClient;
using System.Reflection.Metadata;


namespace PGDCAProject.InventoryManagementSystem
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet Dset;

        void Clear()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
            txtPassword.Focus();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;Persist Security Info=True;User ID=sa;Password=sasa@123;Trust Server Certificate=True";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName, password;
            userName = txtUserName.Text;
            password = txtPassword.Text;

            try
            {
                string query = "SELECT * FROM TblUsers WHERE UserName='" + txtUserName.Text + "' AND Password= '" + txtPassword.Text + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
                DataSet dset = new DataSet();
                adapter.Fill(dset, "users");

                if (dset.Tables["users"]!.Rows.Count > 0)
                {
                    userName = txtUserName.Text;
                    password = txtPassword.Text;

                    Items items = new Items();
                    items.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Clear();
                }
            }
            catch
            {
                MessageBox.Show("User Does not exit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                consql.Close();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
