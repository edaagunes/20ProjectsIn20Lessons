using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailRegister
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		Db16Project20Entities context = new Db16Project20Entities();
		private void btnRegister_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int confirmCode = random.Next(100000, 1000000);
			TblUser user = new TblUser();

			user.Name = txtName.Text;
			user.Surname = txtSurname.Text;
			user.Email = txtEmail.Text;
			user.Password = txtPassword.Text;
			user.IsConfirm = false;
			user.ConfirmCode = confirmCode.ToString();

			context.TblUser.Add(user);
			context.SaveChanges();

			#region Mail Gönderme
			MimeMessage mimeMessage = new MimeMessage();
			MailboxAddress mailboxAddressFrom = new MailboxAddress("Admin Register", "traversalcoreeda@gmail.com");
			mimeMessage.From.Add(mailboxAddressFrom);

			MailboxAddress mailboxAddressTo = new MailboxAddress("User", txtEmail.Text);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.HtmlBody = "<h1>Merhaba " + txtName.Text + " " + txtSurname.Text + "</h1>" +
				"<h2>Kaydınızı tamamlamak için aşağıdaki kodu kullanınız.</h2>" +
				"<h2>Doğrulama Kodunuz: " + confirmCode + "</h2>";
			mimeMessage.Body = bodyBuilder.ToMessageBody();

			mimeMessage.Subject = "Email Konfirmasyon Kodu";

			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("traversalcoreeda@gmail.com", "jhox qthr olgi ejlr");
			client.Send(mimeMessage);
			client.Disconnect(true);

			MessageBox.Show("Kaydınız başarıyla oluşturuldu. Lütfen mail adresinizi kontrol ediniz.");

			FrmMailConfirm frmMailConfirm = new FrmMailConfirm();
			frmMailConfirm.email = txtEmail.Text;
			frmMailConfirm.Show();
			#endregion
		}
	}
}
