﻿namespace MailRegister
{
	partial class FrmMailConfirm
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
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtConfirmCode = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnConfirmActivate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtEmail
			// 
			this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtEmail.Location = new System.Drawing.Point(276, 61);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(265, 30);
			this.txtEmail.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(127, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 25);
			this.label1.TabIndex = 2;
			this.label1.Text = "Email Adresi:";
			// 
			// txtConfirmCode
			// 
			this.txtConfirmCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtConfirmCode.Location = new System.Drawing.Point(276, 119);
			this.txtConfirmCode.Name = "txtConfirmCode";
			this.txtConfirmCode.Size = new System.Drawing.Size(265, 30);
			this.txtConfirmCode.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(127, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "6 Haneli Kod:";
			// 
			// btnConfirmActivate
			// 
			this.btnConfirmActivate.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.btnConfirmActivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnConfirmActivate.Location = new System.Drawing.Point(288, 182);
			this.btnConfirmActivate.Name = "btnConfirmActivate";
			this.btnConfirmActivate.Size = new System.Drawing.Size(241, 52);
			this.btnConfirmActivate.TabIndex = 6;
			this.btnConfirmActivate.Text = "Aktivasyonu Tamamla";
			this.btnConfirmActivate.UseVisualStyleBackColor = false;
			this.btnConfirmActivate.Click += new System.EventHandler(this.btnConfirmActivate_Click);
			// 
			// FrmMailConfirm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnConfirmActivate);
			this.Controls.Add(this.txtConfirmCode);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.label1);
			this.Name = "FrmMailConfirm";
			this.Text = "Mail Aktivasyon Formu";
			this.Load += new System.EventHandler(this.FrmMailConfirm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtConfirmCode;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnConfirmActivate;
	}
}