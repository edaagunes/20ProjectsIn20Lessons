using Dapper;
using DapperProject.Dtos.CategoryDtos;
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

namespace DapperProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection connection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=Db5Project20;integrated security=true");
		private async void btnCategoryList_Click(object sender, EventArgs e)
		{
			string query = "Select * From Categories";
			var values =await connection.QueryAsync<ResultCategoryDto>(query);
			dataGridView1.DataSource = values;
		}

		private async void btnCreateCategory_Click(object sender, EventArgs e)
		{
			string query = "insert into Categories(CategoryName,Description) values (@p1,@p2)";
			var parameters = new DynamicParameters();
			parameters.Add("@p1", txtCategoryId.Text);
			parameters.Add("@p2", txtCategoryName.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void btnCategoryDelete_Click(object sender, EventArgs e)
		{
			string query = "delete from Categories where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryId",txtCategoryId.Text);
			await connection.ExecuteAsync(query,parameters);
		}

		private async void btnCategoryUpdate_Click(object sender, EventArgs e)
		{
			string query = "Update Categories set CategoryName=@categoryName,Description=@description where CategoryId=@categoryId";
			var parameters = new DynamicParameters();
			parameters.Add("@categoryName",txtCategoryName.Text);
			parameters.Add("@description",txtCategoryDescription.Text);
			parameters.Add("@categoryId", txtCategoryId.Text);
			await connection.ExecuteAsync(query, parameters);
		}

		private async void Form1_Load(object sender, EventArgs e)
		{
			// Kategori Sayısı
			string query = "Select Count(*) From Categories";
			var categoryCount = await connection.ExecuteScalarAsync<int>(query);
			lblCategoryCount.Text = "Toplam Kategori Sayısı: " + categoryCount.ToString();

			// Ürün Sayısı
			string query2 = "Select Count(*) From Products";
			var productCount = await connection.ExecuteScalarAsync<int>(query2);
			lblProductCount.Text = "Toplam Ürün Sayısı: " + productCount.ToString();

			//Ortalama Ürün Stok Sayısı
			string query3 = "select Avg(UnitsInStock) from Products";
			var avgProductStock=await connection.ExecuteScalarAsync<int>(query3);
			lblAvgProductStock.Text = "Ortalama Ürün Stok Sayısı: " + avgProductStock.ToString();

			//Deniz Ürünleri Toplam Fiyatı
			string query4 = "Select Sum(UnitPrice) from Products where CategoryId=(Select CategoryId from Categories where CategoryName='SeaFood')";
			var totalSeaFoodPrice=await connection.ExecuteScalarAsync<decimal>(query4);
			lblSeafoodProductTotalPrice.Text = "Deniz Ürünleri Toplam Fiyatı: " + totalSeaFoodPrice.ToString("0.00");
		}
	}
}
