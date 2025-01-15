﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdonetCustomerProject
{
	public partial class FrmCustomer : Form
	{
		public FrmCustomer()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");
		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner Join TblCity on TblCity.CityId=TblCustomer.CustomerCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void btnProcedure_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("execute CustomerListWithCity", sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void FrmCustomer_Load(object sender, EventArgs e)
		{
			SqlCommand command = new SqlCommand("select * from TblCity", sqlConnection);
			SqlDataAdapter adapter=new SqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCity.ValueMember = "CityId";
			cmbCity.DisplayMember = "CityName";
			cmbCity.DataSource = dataTable;

		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into TblCustomer (CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CustomerCity) values (@customerName,@customerSurname,@customerBalance,@customerStatus,@customerCity)", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);

			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);

			}

			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);

			}

			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("delete from TblCustomer where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri silindi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("update TblCustomer set CustomerName=@customerName,CustomerSurname=@customerSurname,CustomerBalance=@customerBalance,CustomerStatus=@customerStatus,CustomerCity=@customerCity where CustomerId=@customerId", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			command.Parameters.AddWithValue("@customerSurname", txtCustomerSurname.Text);
			command.Parameters.AddWithValue("@customerBalance", txtCustomerBalance.Text);
			command.Parameters.AddWithValue("@customerCity", cmbCity.SelectedValue);
			command.Parameters.AddWithValue("@customerId", txtCustomerId.Text);

			if (rdbActive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", true);

			}

			if (rdbPassive.Checked)
			{
				command.Parameters.AddWithValue("@customerStatus", false);

			}

			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Müşteri güncellendi");
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("select CustomerId,CustomerName,CustomerSurname,CustomerBalance,CustomerStatus,CityName from TblCustomer Inner Join TblCity on TblCity.CityId=TblCustomer.CustomerCity where CustomerName=@customerName", sqlConnection);
			command.Parameters.AddWithValue("@customerName", txtCustomerName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}
	}
}
