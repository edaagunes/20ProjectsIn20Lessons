using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostgreToDoProject
{
	public partial class FrmCategory : Form
	{
		public FrmCategory()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123456aA-;Database=DbProject10ToDoApp";

		void CategoryList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Select * From categories order by CategoryId";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void FrmCategory_Load(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Insert Into categories (categoryName) Values (@categoryName)";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryName", txtName.Text);
				command.ExecuteNonQuery();
				MessageBox.Show("Kategori Eklendi");
				CategoryList();
			}
			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id=int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Delete From categories Where categoryId=@categoryId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryId", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Kategori Silindi");
				CategoryList();
			}
			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Update categories Set categoryName=@categoryName Where categoryId=@categoryId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryName", txtName.Text);
				command.Parameters.AddWithValue("@categoryId", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Kategori Güncellendi");
				CategoryList();
			}
			connection.Close();
		}

		private void btnGetById_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From categories Where categoryId=@categoryId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@categoryId", id);
				using (var adapter=new NpgsqlDataAdapter(command))
				{
					DataTable dataTable = new DataTable();
					adapter.Fill(dataTable);
					dataGridView1.DataSource = dataTable;
				}
			}
			connection.Close();
		}
	}
}
