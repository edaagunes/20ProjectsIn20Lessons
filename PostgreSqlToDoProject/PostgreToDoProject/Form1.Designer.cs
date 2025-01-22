namespace PostgreToDoProject
{
	partial class Form1
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnList = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPriority = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.rdbCompleted = new System.Windows.Forms.RadioButton();
			this.rdbContinue = new System.Windows.Forms.RadioButton();
			this.btnCreate = new System.Windows.Forms.Button();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAllList = new System.Windows.Forms.Button();
			this.btnCompleted = new System.Windows.Forms.Button();
			this.btnContinue = new System.Windows.Forms.Button();
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(32, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "İşlem Id:";
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.SystemColors.Info;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(389, 28);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(206, 36);
			this.btnList.TabIndex = 1;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(113, 30);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(204, 22);
			this.txtId.TabIndex = 2;
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(113, 58);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(204, 22);
			this.txtTitle.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(42, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 22);
			this.label2.TabIndex = 4;
			this.label2.Text = "Başlık:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(23, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(82, 22);
			this.label3.TabIndex = 6;
			this.label3.Text = "Kategori:";
			// 
			// txtPriority
			// 
			this.txtPriority.Location = new System.Drawing.Point(113, 117);
			this.txtPriority.Name = "txtPriority";
			this.txtPriority.Size = new System.Drawing.Size(204, 22);
			this.txtPriority.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(30, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 22);
			this.label4.TabIndex = 8;
			this.label4.Text = "Öncelik:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(113, 145);
			this.txtDescription.Multiline = true;
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(204, 117);
			this.txtDescription.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(20, 143);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 22);
			this.label5.TabIndex = 10;
			this.label5.Text = "Açıklama:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(39, 273);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 22);
			this.label6.TabIndex = 12;
			this.label6.Text = "Durum:";
			// 
			// rdbCompleted
			// 
			this.rdbCompleted.AutoSize = true;
			this.rdbCompleted.Location = new System.Drawing.Point(113, 276);
			this.rdbCompleted.Name = "rdbCompleted";
			this.rdbCompleted.Size = new System.Drawing.Size(104, 20);
			this.rdbCompleted.TabIndex = 13;
			this.rdbCompleted.TabStop = true;
			this.rdbCompleted.Text = "Tamamlandı";
			this.rdbCompleted.UseVisualStyleBackColor = true;
			// 
			// rdbContinue
			// 
			this.rdbContinue.AutoSize = true;
			this.rdbContinue.Location = new System.Drawing.Point(222, 276);
			this.rdbContinue.Name = "rdbContinue";
			this.rdbContinue.Size = new System.Drawing.Size(114, 20);
			this.rdbContinue.TabIndex = 14;
			this.rdbContinue.TabStop = true;
			this.rdbContinue.Text = "Devam Ediyor";
			this.rdbContinue.UseVisualStyleBackColor = true;
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.SystemColors.Info;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(389, 66);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(206, 36);
			this.btnCreate.TabIndex = 15;
			this.btnCreate.Text = "Oluştur";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// cmbCategory
			// 
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(113, 87);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(204, 24);
			this.cmbCategory.TabIndex = 16;
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(389, 108);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(206, 36);
			this.btnDelete.TabIndex = 17;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(389, 147);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(206, 36);
			this.btnUpdate.TabIndex = 18;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAllList
			// 
			this.btnAllList.BackColor = System.Drawing.SystemColors.Info;
			this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAllList.Location = new System.Drawing.Point(389, 189);
			this.btnAllList.Name = "btnAllList";
			this.btnAllList.Size = new System.Drawing.Size(206, 36);
			this.btnAllList.TabIndex = 19;
			this.btnAllList.Text = "Tüm Liste(Kategori)";
			this.btnAllList.UseVisualStyleBackColor = false;
			this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
			// 
			// btnCompleted
			// 
			this.btnCompleted.BackColor = System.Drawing.SystemColors.Info;
			this.btnCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCompleted.Location = new System.Drawing.Point(389, 231);
			this.btnCompleted.Name = "btnCompleted";
			this.btnCompleted.Size = new System.Drawing.Size(206, 36);
			this.btnCompleted.TabIndex = 20;
			this.btnCompleted.Text = "Tamamlananlar";
			this.btnCompleted.UseVisualStyleBackColor = false;
			this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
			// 
			// btnContinue
			// 
			this.btnContinue.BackColor = System.Drawing.SystemColors.Info;
			this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnContinue.Location = new System.Drawing.Point(389, 273);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(206, 36);
			this.btnContinue.TabIndex = 21;
			this.btnContinue.Text = "Devam Edenler";
			this.btnContinue.UseVisualStyleBackColor = false;
			this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.BackColor = System.Drawing.SystemColors.Info;
			this.btnCategoryList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCategoryList.Location = new System.Drawing.Point(389, 315);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(206, 36);
			this.btnCategoryList.TabIndex = 22;
			this.btnCategoryList.Text = "Kategoriler";
			this.btnCategoryList.UseVisualStyleBackColor = false;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(629, 33);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(930, 317);
			this.dataGridView1.TabIndex = 23;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.ClientSize = new System.Drawing.Size(1587, 404);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Controls.Add(this.btnContinue);
			this.Controls.Add(this.btnCompleted);
			this.Controls.Add(this.btnAllList);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.rdbContinue);
			this.Controls.Add(this.rdbCompleted);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtPriority);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "To Do Form";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPriority;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RadioButton rdbCompleted;
		private System.Windows.Forms.RadioButton rdbContinue;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnAllList;
		private System.Windows.Forms.Button btnCompleted;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

