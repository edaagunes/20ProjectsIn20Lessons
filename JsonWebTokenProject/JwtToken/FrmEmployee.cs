using JwtToken.JWT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JwtToken
{
	public partial class FrmEmployee : Form
	{
		public FrmEmployee()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true");
		public string tokenGet;
		private void FrmEmployee_Load(object sender, EventArgs e)
		{
			TokenValidator tokenValidator = new TokenValidator();
			richTextBox1.Text = "Token: " + tokenGet;

			var principal = tokenValidator.ValidateJwtToken(tokenGet);

			if (principal != null)
			{
				string username = principal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
				MessageBox.Show("Hoşgeldin " + username);

				sqlConnection.Open();
				SqlCommand command = new SqlCommand("SELECT * FROM TblEmployee", sqlConnection);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				dataGridView1.DataSource = dt;
				sqlConnection.Close();
			}
			else
			{
				MessageBox.Show("Token Geçersizdir");
			}
		}
	}
}
