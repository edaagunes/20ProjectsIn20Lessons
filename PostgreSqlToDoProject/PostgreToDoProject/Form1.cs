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
using System.Xml.Linq;

namespace PostgreToDoProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnCategoryList_Click(object sender, EventArgs e)
		{
			FrmCategory frm= new FrmCategory();
			frm.Show();
		}
		string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123456aA-;Database=DbProject10ToDoApp";
		void ToDoList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Select * From todolists order by todolistid";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		void CategoryList()
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Select * From categories order by CategoryId";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			cmbCategory.DisplayMember = "categoryName";
			cmbCategory.ValueMember = "categoryId";
			cmbCategory.DataSource = dataTable;
			connection.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ToDoList();
			CategoryList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			ToDoList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			int categoryId=int.Parse(cmbCategory.SelectedValue.ToString());
			string title = txtTitle.Text;
			string description = txtDescription.Text;
			string priority = txtPriority.Text;
			//bool status=false;
			//if (rdbCompleted.Checked)
			//{
			//	status = true;
			//}
			//if (rdbContinue.Checked)
			//{
			//	status = false;
			//}


			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Insert Into todolists (title,description,status,priority,categoryId) Values (@title,@description,B'1',@priority,@categoryId)";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@title", title);
				command.Parameters.AddWithValue("@description", description);
				//command.Parameters.AddWithValue("@status", );
				command.Parameters.AddWithValue("@priority", priority);
				command.Parameters.AddWithValue("@categoryId", categoryId);
				command.ExecuteNonQuery();
				MessageBox.Show("Görev Eklendi");
				ToDoList();
			}
			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtId.Text);
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Delete From todolists Where todolistid=@todolistId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@todolistId", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Görev Silindi");
				ToDoList();
			}
			connection.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int categoryId = int.Parse(cmbCategory.SelectedValue.ToString());
			string title = txtTitle.Text;
			string description = txtDescription.Text;
			string priority = txtPriority.Text;
			int id = int.Parse(txtId.Text);

			var connection = new NpgsqlConnection(connectionString);
			connection.Open();
			string query = "Update todolists Set title=@title,description=@description,categoryId=@categoryId,priority=@priority Where todolistid=@todolistId";
			using (var command = new NpgsqlCommand(query, connection))
			{
				command.Parameters.AddWithValue("@title", title);
				command.Parameters.AddWithValue("@description", description);
				command.Parameters.AddWithValue("@priority", priority);
				command.Parameters.AddWithValue("@categoryId", categoryId);
				command.Parameters.AddWithValue("@todolistId", id);
				command.ExecuteNonQuery();
				MessageBox.Show("Görev Güncellendi");
				ToDoList();
			}
			connection.Close();
		}

		private void btnAllList_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "select todolistid,title,description,status,priority,categoryname from todolists inner join categories on todolists.categoryid=categories.categoryid";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnCompleted_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Select * From todolists where status='1' order by todolistid ";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}

		private void btnContinue_Click(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Select * From todolists where status='0' order by todolistid ";
			var command = new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataTable = new DataTable();
			adapter.Fill(dataTable);
			dataGridView1.DataSource = dataTable;
			connection.Close();
		}
	}
}
