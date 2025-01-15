using System;
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
	public partial class FrmCity : Form
	{
		public FrmCity()
		{
			InitializeComponent();
		}

		SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=DbCustomer;integrated security=true");

		private void btnList_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("select * from TblCity",sqlConnection);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("insert into TblCity (CityName,CityCountry) values (@cityName,@cityCountry)",sqlConnection);
			command.Parameters.AddWithValue("@cityName",txtCityName.Text);
			command.Parameters.AddWithValue("@cityCountry",txtCityCountry.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir eklendi");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("delete from TblCity where CityId=@cityId", sqlConnection);
			command.Parameters.AddWithValue("@cityId",txtCityId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir silindi","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("update TblCity set CityName=@cityName, CityCountry=@cityCountry where CityId=@cityId", sqlConnection);
			command.Parameters.AddWithValue("@cityName", txtCityName.Text);
			command.Parameters.AddWithValue("@cityCountry", txtCityCountry.Text);
			command.Parameters.AddWithValue("@cityId", txtCityId.Text);
			command.ExecuteNonQuery();
			sqlConnection.Close();
			MessageBox.Show("Şehir güncellendi","Uyarı!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("select * from TblCity where CityName=@cityName", sqlConnection);
			command.Parameters.AddWithValue("@cityName", txtCityName.Text);
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
			sqlConnection.Close();
		}
	}
}
