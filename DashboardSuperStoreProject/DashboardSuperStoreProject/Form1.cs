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

namespace DashboardSuperStoreProject
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=Db17Project20;integrated security=true");
		private void Form1_Load(object sender, EventArgs e)
		{
			#region Widgets
			sqlConnection.Open();
			SqlCommand sqlCommand = new SqlCommand("select Count(*) from superstore", sqlConnection);
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			while (sqlDataReader.Read())
			{
				lblProductCount.Text = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();

			SqlCommand sqlCommand2 = new SqlCommand("Select Count(Distinct(State)) From superstore", sqlConnection);
			SqlDataReader sqlDataReader2 = sqlCommand2.ExecuteReader();
			while (sqlDataReader2.Read())
			{
				lblCityCount.Text = sqlDataReader2[0].ToString();
			}
			sqlDataReader2.Close();

			SqlCommand sqlCommand3 = new SqlCommand("select Count(*) from superstore where country='Turkey'", sqlConnection);
			SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
			while (sqlDataReader3.Read())
			{
				lblTurkiyeCount.Text = sqlDataReader3[0].ToString();
			}
			sqlDataReader3.Close();

			SqlCommand sqlCommand4 = new SqlCommand("select Sum(quantity) from superstore", sqlConnection);
			SqlDataReader sqlDataReader4 = sqlCommand4.ExecuteReader();
			while (sqlDataReader4.Read())
			{
				lblOrderCount.Text = sqlDataReader4[0].ToString();
			}
			sqlDataReader4.Close();
			#endregion

			#region charts

			SqlCommand sqlCommand5 = new SqlCommand("select top(7) country, Count(*) from superstore group by country order by count(*) desc", sqlConnection);
			SqlDataReader sqlDataReader5 = sqlCommand5.ExecuteReader();
			while (sqlDataReader5.Read())
			{
				chart1.Series["Series1"].Points.AddXY(sqlDataReader5[0], sqlDataReader5[1]);
			}
			sqlDataReader5.Close();

			SqlCommand sqlCommand6 = new SqlCommand("select top(3) country, sum(quantity) from superstore group by country order by sum(quantity) desc", sqlConnection);
			SqlDataReader sqlDataReader6 = sqlCommand6.ExecuteReader();
			while (sqlDataReader6.Read())
			{
				chart2.Series["Series1"].Points.AddXY(sqlDataReader6[0], sqlDataReader6[1]);
			}
			sqlDataReader6.Close();


			SqlCommand sqlCommand7 = new SqlCommand("select order_priority,count(*) from superstore group by order_priority order by order_priority desc", sqlConnection);
			SqlDataReader sqlDataReader7 = sqlCommand7.ExecuteReader();
			while (sqlDataReader7.Read())
			{
				chart3.Series["Series1"].Points.AddXY(sqlDataReader7[0], sqlDataReader7[1]);
			}
			sqlDataReader7.Close();


			#endregion
		}

		
	}
}
