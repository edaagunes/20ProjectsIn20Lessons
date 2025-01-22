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
	public partial class FrmToDoListApp : Form
	{
		public FrmToDoListApp()
		{
			InitializeComponent();
		}
		string connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=123456aA-;Database=DbProject10ToDoApp";
		private void FrmToDoListApp_Load(object sender, EventArgs e)
		{
			var connection = new NpgsqlConnection(connectionString);
			connection.Open();

			string query = "Select * From todolists";
			var command=new NpgsqlCommand(query, connection);
			var adapter = new NpgsqlDataAdapter(command);
			DataTable dataSet = new DataTable();
			adapter.Fill(dataSet);
			dataGridView1.DataSource = dataSet;
			connection.Close();
		}
	}
}
