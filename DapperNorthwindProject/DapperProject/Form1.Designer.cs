namespace DapperProject
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
			this.btnCategoryList = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.txtCategoryId = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.btnCreateCategory = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtCategoryDescription = new System.Windows.Forms.TextBox();
			this.btnCategoryUpdate = new System.Windows.Forms.Button();
			this.btnCategoryDelete = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblCategoryCount = new System.Windows.Forms.Label();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblAvgProductStock = new System.Windows.Forms.Label();
			this.lblSeafoodProductTotalPrice = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCategoryList
			// 
			this.btnCategoryList.Location = new System.Drawing.Point(456, 50);
			this.btnCategoryList.Name = "btnCategoryList";
			this.btnCategoryList.Size = new System.Drawing.Size(150, 35);
			this.btnCategoryList.TabIndex = 0;
			this.btnCategoryList.Text = "Listele";
			this.btnCategoryList.UseVisualStyleBackColor = true;
			this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 260);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(649, 178);
			this.dataGridView1.TabIndex = 1;
			// 
			// txtCategoryId
			// 
			this.txtCategoryId.Location = new System.Drawing.Point(222, 50);
			this.txtCategoryId.Name = "txtCategoryId";
			this.txtCategoryId.Size = new System.Drawing.Size(170, 22);
			this.txtCategoryId.TabIndex = 2;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(222, 94);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(170, 22);
			this.txtCategoryName.TabIndex = 3;
			// 
			// btnCreateCategory
			// 
			this.btnCreateCategory.Location = new System.Drawing.Point(456, 94);
			this.btnCreateCategory.Name = "btnCreateCategory";
			this.btnCreateCategory.Size = new System.Drawing.Size(150, 35);
			this.btnCreateCategory.TabIndex = 4;
			this.btnCreateCategory.Text = "Kategori Ekle";
			this.btnCreateCategory.UseVisualStyleBackColor = true;
			this.btnCreateCategory.Click += new System.EventHandler(this.btnCreateCategory_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(138, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 16);
			this.label1.TabIndex = 5;
			this.label1.Text = "Kategori Id:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(132, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 16);
			this.label2.TabIndex = 6;
			this.label2.Text = "Kategori Ad:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(83, 129);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 16);
			this.label3.TabIndex = 7;
			this.label3.Text = "Kategori Açıklaması:";
			// 
			// txtCategoryDescription
			// 
			this.txtCategoryDescription.Location = new System.Drawing.Point(222, 129);
			this.txtCategoryDescription.Multiline = true;
			this.txtCategoryDescription.Name = "txtCategoryDescription";
			this.txtCategoryDescription.Size = new System.Drawing.Size(170, 82);
			this.txtCategoryDescription.TabIndex = 8;
			// 
			// btnCategoryUpdate
			// 
			this.btnCategoryUpdate.Location = new System.Drawing.Point(456, 176);
			this.btnCategoryUpdate.Name = "btnCategoryUpdate";
			this.btnCategoryUpdate.Size = new System.Drawing.Size(150, 35);
			this.btnCategoryUpdate.TabIndex = 9;
			this.btnCategoryUpdate.Text = "Kategori Güncelle";
			this.btnCategoryUpdate.UseVisualStyleBackColor = true;
			this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
			// 
			// btnCategoryDelete
			// 
			this.btnCategoryDelete.Location = new System.Drawing.Point(456, 135);
			this.btnCategoryDelete.Name = "btnCategoryDelete";
			this.btnCategoryDelete.Size = new System.Drawing.Size(150, 35);
			this.btnCategoryDelete.TabIndex = 10;
			this.btnCategoryDelete.Text = "Kategori Sil";
			this.btnCategoryDelete.UseVisualStyleBackColor = true;
			this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.lblSeafoodProductTotalPrice);
			this.groupBox1.Controls.Add(this.lblAvgProductStock);
			this.groupBox1.Controls.Add(this.lblProductCount);
			this.groupBox1.Controls.Add(this.lblCategoryCount);
			this.groupBox1.Location = new System.Drawing.Point(692, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(626, 388);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Dapper İstatistikler";
			// 
			// lblCategoryCount
			// 
			this.lblCategoryCount.AutoSize = true;
			this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblCategoryCount.Location = new System.Drawing.Point(54, 44);
			this.lblCategoryCount.Name = "lblCategoryCount";
			this.lblCategoryCount.Size = new System.Drawing.Size(99, 36);
			this.lblCategoryCount.TabIndex = 0;
			this.lblCategoryCount.Text = "label4";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblProductCount.Location = new System.Drawing.Point(54, 102);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(79, 29);
			this.lblProductCount.TabIndex = 1;
			this.lblProductCount.Text = "label4";
			// 
			// lblAvgProductStock
			// 
			this.lblAvgProductStock.AutoSize = true;
			this.lblAvgProductStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblAvgProductStock.Location = new System.Drawing.Point(54, 165);
			this.lblAvgProductStock.Name = "lblAvgProductStock";
			this.lblAvgProductStock.Size = new System.Drawing.Size(79, 29);
			this.lblAvgProductStock.TabIndex = 2;
			this.lblAvgProductStock.Text = "label5";
			// 
			// lblSeafoodProductTotalPrice
			// 
			this.lblSeafoodProductTotalPrice.AutoSize = true;
			this.lblSeafoodProductTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblSeafoodProductTotalPrice.Location = new System.Drawing.Point(54, 220);
			this.lblSeafoodProductTotalPrice.Name = "lblSeafoodProductTotalPrice";
			this.lblSeafoodProductTotalPrice.Size = new System.Drawing.Size(79, 29);
			this.lblSeafoodProductTotalPrice.TabIndex = 3;
			this.lblSeafoodProductTotalPrice.Text = "label6";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1358, 450);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCategoryDelete);
			this.Controls.Add(this.btnCategoryUpdate);
			this.Controls.Add(this.txtCategoryDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCreateCategory);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.txtCategoryId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnCategoryList);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCategoryList;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox txtCategoryId;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.Button btnCreateCategory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoryDescription;
		private System.Windows.Forms.Button btnCategoryUpdate;
		private System.Windows.Forms.Button btnCategoryDelete;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label lblCategoryCount;
		private System.Windows.Forms.Label lblSeafoodProductTotalPrice;
		private System.Windows.Forms.Label lblAvgProductStock;
		private System.Windows.Forms.Label lblProductCount;
	}
}

