namespace JwtToken
{
	partial class FrmTokenGenerator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCreateToken = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// txtUsername
			// 
			this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUsername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtUsername.Location = new System.Drawing.Point(169, 44);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(334, 28);
			this.txtUsername.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.Window;
			this.label1.Location = new System.Drawing.Point(49, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 22);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kullanıcı Adı:";
			// 
			// btnCreateToken
			// 
			this.btnCreateToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateToken.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCreateToken.Location = new System.Drawing.Point(186, 242);
			this.btnCreateToken.Name = "btnCreateToken";
			this.btnCreateToken.Size = new System.Drawing.Size(161, 33);
			this.btnCreateToken.TabIndex = 4;
			this.btnCreateToken.Text = "Token Oluştur";
			this.btnCreateToken.UseVisualStyleBackColor = true;
			this.btnCreateToken.Click += new System.EventHandler(this.btnCreateToken_Click);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtName.Location = new System.Drawing.Point(169, 92);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(334, 28);
			this.txtName.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.ForeColor = System.Drawing.SystemColors.Window;
			this.label2.Location = new System.Drawing.Point(121, 92);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(41, 22);
			this.label2.TabIndex = 7;
			this.label2.Text = "Adı:";
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSurname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtSurname.Location = new System.Drawing.Point(169, 142);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(334, 28);
			this.txtSurname.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.ForeColor = System.Drawing.SystemColors.Window;
			this.label3.Location = new System.Drawing.Point(92, 142);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(70, 22);
			this.label3.TabIndex = 9;
			this.label3.Text = "Soyadı:";
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.txtEmail.Location = new System.Drawing.Point(169, 187);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(334, 28);
			this.txtEmail.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.ForeColor = System.Drawing.SystemColors.Window;
			this.label4.Location = new System.Drawing.Point(103, 187);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 22);
			this.label4.TabIndex = 11;
			this.label4.Text = "Email:";
			// 
			// richTextBox1
			// 
			this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 295);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(512, 185);
			this.richTextBox1.TabIndex = 13;
			this.richTextBox1.Text = "";
			// 
			// FrmTokenGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Thistle;
			this.ClientSize = new System.Drawing.Size(536, 492);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSurname);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreateToken);
			this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.Name = "FrmTokenGenerator";
			this.Text = "FrmTokenGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCreateToken;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}