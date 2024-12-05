using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PGDCAProject.InventoryManagementSystem
{
    public partial class Billing : Form
    {
        public Billing()
        {
            InitializeComponent();
        }

        SqlConnection consql;
        string str;
        DataSet Dset;

        private void Connection()
        {
            str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;Persist Security Info=True;User ID=sa;Password=sasa@123;Trust Server Certificate=True";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void Clear()
        {
            txtInvoiceNum.Text = "";
            cboItems.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtTotalCost.Text = "";
            txtInvoiceNum.Focus();
        }

        private void FillCboItems()
        {
            string query = "SELECT ItemId, ItemName FROM TblItems ORDER BY ItemName";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "cboitems");
            dt = dataSet.Tables["cboitems"]!;
            cboItems.DataSource = dt;
            cboItems.DisplayMember = dt.Columns["ItemName"]!.ToString();
            cboItems.ValueMember = dt.Columns["ItemId"]!.ToString();
        }

        private void FillDgItems()
        {
            string query = "SELECT ItemId, ItemName, ItemPrice, ItemStock, ItemManufacturer FROM TblItems ORDER BY ItemId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "dgitems");

            dgItemList.DataSource = dataSet.Tables["dgitems"];
            dgItemList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9.75F, FontStyle.Bold);
            dgItemList.Columns[0].HeaderText = "ID";
            dgItemList.Columns[1].HeaderText = "Name";
            dgItemList.Columns[2].HeaderText = "Price";
            dgItemList.Columns[3].HeaderText = "Stock";
            dgItemList.Columns[4].HeaderText = "Manufacturer";

            dgItemList.Columns[0].Width = 80;
            dgItemList.Columns[3].Width = 70;
        }

        private void fillCboCustomers()
        {
            string query = "SELECT CustomerName FROM TblCustomers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "cbocustomers");
            dt = dataSet.Tables["cbocustomers"]!;

            cboCustomers.DataSource = dt;
            cboCustomers.DisplayMember = dt.Columns["CustomerName"]!.ToString();
        }

        private void GenerateInvoiceNo()
        {
            string IvName;
            int IvID;

            string query = "SELECT InvoiceNo FROM TblOrders ORDER BY InvoiceNo";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "Orders");

            if (dset.Tables["Orders"]!.Rows.Count > 0)
            {
                IvName = dset.Tables["Orders"]!.Rows[^1][0].ToString()!;
                IvID = int.Parse(IvName.Substring(5, (IvName.Length - 5)));
                txtInvoiceNum.Text = "IVNO-" + (IvID + 1).ToString("00000000");
                txtBillInvoiceNum.Text = "IVNo-" + (IvID + 1).ToString("00000000");
            }
            else
            {
                txtInvoiceNum.Text = "IVNO-00000001";
                txtBillInvoiceNum.Text = "IVNO-00000001";
            }
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            Clear();
            Connection();
            FillCboItems();
            FillDgItems();
            fillCboCustomers();
        }

        private void InvoiceNoBtn_Click(object sender, EventArgs e)
        {
            Clear();
            GenerateInvoiceNo();
        }

        private void FillOrderData()
        {

        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            FillOrderData();
            Clear();
        }

        private void cboItems_Leave(object sender, EventArgs e)
        {
            string query = "SELECT ItemPrice FROM TblItems WHERE ItemId = '" + cboItems.SelectedValue + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "Price");
            txtPrice.Text = dset.Tables["Price"]!.Rows[0][0].ToString();
            txtQuantity.Focus();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            txtTotalCost.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text)).ToString();
        }
    }
}
