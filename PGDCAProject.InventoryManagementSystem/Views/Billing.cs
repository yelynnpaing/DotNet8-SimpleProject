﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        string PaymentType;

        private void Connection()
        {
            str = "Data Source=DESKTOP-L3SMK21\\SQLEXPRESS;Initial Catalog=ElectronicsDb;Persist Security Info=True;User ID=sa;Password=sasa@123;Trust Server Certificate=True";
            consql = new SqlConnection(str);
            consql.Open();
        }

        private void Clear()
        {
            cboItems.Text = "";
            txtPrice.Text = "";
            txtSerialNo.Text = "";
            txtQuantity.Text = "";
            txtTotalCost.Text = "";
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
            string query = "SELECT CustomerId, CustomerName FROM TblCustomers";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "cbocustomers");
            dt = dataSet.Tables["cbocustomers"]!;

            cboCustomers.DataSource = dt;
            cboCustomers.DisplayMember = dt.Columns["CustomerName"]!.ToString();
            cboCustomers.ValueMember = dt.Columns["CustomerId"]!.ToString();
        }

        private void fillCboPaymentStatus()
        {
            string query = "SELECT PsId, Type FROM TblPaymentStatus";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "cboPaymentStatus");
            dt = dataSet.Tables["cboPaymentStatus"]!;

            cboPaymentStatus.DataSource = dt;
            cboPaymentStatus.DisplayMember = dt.Columns["Type"]!.ToString();
            cboPaymentStatus.ValueMember = dt.Columns["PsId"]!.ToString();
        }

        private void fillCboOrderStatus()
        {
            string query = "SELECT OId, OrderType FROM TblOrderStatus";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dataSet = new DataSet();
            DataTable dt = new DataTable();
            adapter.Fill(dataSet, "cboOrderStatus");
            dt = dataSet.Tables["cboOrderStatus"]!;

            cboOrderStatus.DataSource = dt;
            cboOrderStatus.DisplayMember = dt.Columns["OrderType"]!.ToString();
            cboOrderStatus.ValueMember = dt.Columns["OId"]!.ToString();
        }

        private void GenerateInvoiceNo()
        {
            string IvName;
            int IvID;

            string query = "SELECT InvoiceId FROM TblInvoices ORDER BY InvoiceId";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "Orders");

            if (dset.Tables["Orders"]!.Rows.Count > 0)
            {
                IvName = dset.Tables["Orders"]!.Rows[^1][0].ToString()!;
                IvID = int.Parse(IvName.Substring(5, (IvName.Length - 5)));
                txtInvoiceNum.Text = "IVNO-" + (IvID + 1).ToString("00000000");
                txtBillInvoiceNum.Text = "IVNO-" + (IvID + 1).ToString("00000000");
            }
            else
            {
                txtInvoiceNum.Text = "IVNO-00000001";
                txtBillInvoiceNum.Text = "IVNO-00000001";
            }
        }

        private void ListViewColHeaderFill()
        {
            lvOrderList.Columns.Add("#", 80);
            lvOrderList.Columns.Add("ItemName", 300);
            lvOrderList.Columns.Add("Price", 170);
            lvOrderList.Columns.Add("Quantity", 130);
            lvOrderList.Columns.Add("Total", 150);
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            Connection();
            FillCboItems();
            txtInvoiceNum.Focus();
            FillDgItems();
            fillCboCustomers();
            fillCboPaymentStatus();
            fillCboOrderStatus();
            ListViewColHeaderFill();
        }

        private void InvoiceNoBtn_Click(object sender, EventArgs e)
        {
            Clear();
            GenerateInvoiceNo();
        }

        private void cboItems_Leave(object sender, EventArgs e)
        {
            string query = "SELECT ItemId, ItemPrice FROM TblItems WHERE ItemId = '" + cboItems.SelectedValue + "'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, consql);
            DataSet dset = new DataSet();
            adapter.Fill(dset, "Price");
            txtSerialNo.Text = dset.Tables["Price"]!.Rows[0][0].ToString();
            txtPrice.Text = dset.Tables["Price"]!.Rows[0][1].ToString();
            txtQuantity.Focus();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotalCost.Text = (Convert.ToDecimal(txtPrice.Text) * Convert.ToDecimal(txtQuantity.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Please Fill into Quantity", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddToBillBtn_Click(object sender, EventArgs e)
        {
            if (txtSerialNo.Text == "")
            {
                MessageBox.Show("Please Select Items First", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    ListViewItem lvOrderItems = new ListViewItem(
                        txtSerialNo.Text
                    );
                    lvOrderItems.SubItems.Add(cboItems.Text.ToString());
                    lvOrderItems.SubItems.Add(txtPrice.Text);
                    lvOrderItems.SubItems.Add(txtQuantity.Text);
                    lvOrderItems.SubItems.Add(txtTotalCost.Text);

                    lvOrderList.Items.Add(lvOrderItems);
                    txtTotalBill.Text = (Convert.ToDecimal(txtTotalCost.Text) + Convert.ToDecimal(txtTotalBill.Text)).ToString();
                    Clear();
                }
                catch
                {
                    MessageBox.Show("Something Wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Decimal totalBill, amount;
                totalBill = Convert.ToDecimal(txtTotalBill.Text);
                amount = Convert.ToDecimal(lvOrderList.Items[lvOrderList.FocusedItem.Index].SubItems[4].Text);
                txtTotalBill.Text = (totalBill - amount).ToString();
                lvOrderList.Items[lvOrderList.FocusedItem.Index].Remove();
            }
            catch
            {
                MessageBox.Show("Error", "Something wrong!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void radioCash_CheckedChanged_1(object sender, EventArgs e)
        {
            PaymentType = "Cash";
            txtPaymentType.Text = PaymentType;
        }

        private void radioCard_CheckedChanged_1(object sender, EventArgs e)
        {
            PaymentType = "Cards";
            txtPaymentType.Text = PaymentType;
        }

        private void radioEMoney_CheckedChanged_1(object sender, EventArgs e)
        {
            PaymentType = "Emoney";
            txtPaymentType.Text = PaymentType;
        }

        private void SaveBillBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string OrderQuery = "INSERT INTO TblOrders VALUES ('" + cboCustomers.SelectedValue + "', " +
                    "'" + InvoicedateTimePicker.Text + "', '" + cboOrderStatus.Text + "')";
                SqlCommand OrderCmd = new SqlCommand(OrderQuery, consql);
                OrderCmd.ExecuteNonQuery();

                string SelectOderId = "SELECT MAX(OrderId) OrderId FROM TblOrders";
                SqlDataAdapter adapter = new SqlDataAdapter(SelectOderId, consql);
                DataSet dset = new DataSet();
                DataTable dt = new DataTable();
                adapter.Fill(dset, "Id");
                dt = dset.Tables["Id"]!;

                string OrderId = dt.Rows[0][0].ToString()!;

                string InvoiceId = txtBillInvoiceNum.Text;
                string paymentStatus = txtPaymentType.Text;
                for (int i = 0; i <= lvOrderList.Items.Count - 1; i++)
                {
                    string ItemId = lvOrderList.Items[i].SubItems[0].Text;
                    string ItemName = lvOrderList.Items[i].SubItems[1].Text;
                    string ItemPrice = lvOrderList.Items[i].SubItems[2].Text;
                    string ItemQuantity = lvOrderList.Items[i].SubItems[3].Text;
                    string TotalAmount = lvOrderList.Items[i].SubItems[4].Text;

                    string OrderDetailQuery = "INSERT INTO TblOrderDetails VALUES ('" + OrderId + "', '" + ItemId + "', " +
                        "'" + ItemQuantity + "', '" + ItemPrice + "')";
                    SqlCommand OrderDetailcmd = new SqlCommand(OrderDetailQuery, consql);
                    OrderDetailcmd.ExecuteNonQuery();
                }

                string InvoiceQuery = "INSERT INTO TblInvoices VALUES ('" + txtBillInvoiceNum.Text + "', '" + OrderId + "', " +
                    "'" + InvoicedateTimePicker.Text + "', '" + txtTotalBill.Text + "', '" + cboPaymentStatus.Text + "', " +
                    "'" + txtPaymentType.Text + "')";
                SqlCommand InvoiceCmd = new SqlCommand(InvoiceQuery, consql);
                InvoiceCmd.ExecuteNonQuery();

                MessageBox.Show("Invoice Datas saving is success.", "Finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Something wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
