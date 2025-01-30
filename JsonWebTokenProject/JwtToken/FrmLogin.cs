using JwtToken.JWT;
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

namespace JwtToken
{
	public partial class FrmLogin : Form
	{
		public FrmLogin()
		{
			InitializeComponent();
		}
		SqlConnection sqlConnection = new SqlConnection("server=DESKTOP-3OD251U\\SQLEXPRESS;initial catalog=Db12Project20;integrated security=true");
		public string token;
		private void btnLogin_Click(object sender, EventArgs e)
		{
			TokenGenerator tokenGenerator = new TokenGenerator();
			sqlConnection.Open();
			SqlCommand command = new SqlCommand("SELECT * FROM TblUser WHERE Username=@p1 AND Password=@p2", sqlConnection);
			command.Parameters.AddWithValue("@p1", txtUsername.Text);
			command.Parameters.AddWithValue("@p2", txtPassword.Text);

			SqlDataReader sqlDataReader=command.ExecuteReader();
			if (sqlDataReader.Read())
			{
				string token=tokenGenerator.GenerateToken2(txtUsername.Text);
				//MessageBox.Show("Giriş Başarılı Token: " + token);
				FrmEmployee frmEmployee = new FrmEmployee();
				frmEmployee.tokenGet = token;
				frmEmployee.Show();
			}
			else
			{
				MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre ");
				txtPassword.Clear();
				txtUsername.Clear();
				txtUsername.Focus();
			}
			sqlConnection.Close();
		}
	}
}
