namespace MovieProject
{
	partial class FrmMovie
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
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtMovieName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMovieId = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtDuration = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.mskDate = new System.Windows.Forms.MaskedTextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.btnMovieListWithCategory = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(359, 131);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(105, 24);
			this.btnUpdate.TabIndex = 20;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(359, 164);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(105, 24);
			this.btnSearch.TabIndex = 19;
			this.btnSearch.Text = "Ara";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(359, 98);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(105, 24);
			this.btnDelete.TabIndex = 18;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(359, 65);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(105, 24);
			this.btnCreate.TabIndex = 17;
			this.btnCreate.Text = "Ekle";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtMovieName
			// 
			this.txtMovieName.Location = new System.Drawing.Point(127, 58);
			this.txtMovieName.Name = "txtMovieName";
			this.txtMovieName.Size = new System.Drawing.Size(153, 22);
			this.txtMovieName.TabIndex = 16;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(63, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 16);
			this.label2.TabIndex = 15;
			this.label2.Text = "Film Adı:";
			// 
			// txtMovieId
			// 
			this.txtMovieId.Location = new System.Drawing.Point(127, 27);
			this.txtMovieId.Name = "txtMovieId";
			this.txtMovieId.Size = new System.Drawing.Size(153, 22);
			this.txtMovieId.TabIndex = 14;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(31, 230);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(723, 226);
			this.dataGridView1.TabIndex = 13;
			// 
			// btnList
			// 
			this.btnList.Location = new System.Drawing.Point(359, 30);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(105, 24);
			this.btnList.TabIndex = 12;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = true;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(72, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Film Id:";
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(127, 121);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(153, 22);
			this.txtDescription.TabIndex = 24;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 16);
			this.label3.TabIndex = 23;
			this.label3.Text = "Film Açıklaması:";
			// 
			// txtDuration
			// 
			this.txtDuration.Location = new System.Drawing.Point(127, 90);
			this.txtDuration.Name = "txtDuration";
			this.txtDuration.Size = new System.Drawing.Size(153, 22);
			this.txtDuration.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(45, 90);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Film Süresi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 183);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(60, 16);
			this.label5.TabIndex = 27;
			this.label5.Text = "Kategori:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(28, 152);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 16);
			this.label6.TabIndex = 25;
			this.label6.Text = "İzlenme Tarihi:";
			// 
			// mskDate
			// 
			this.mskDate.Location = new System.Drawing.Point(127, 152);
			this.mskDate.Mask = "00/00/0000";
			this.mskDate.Name = "mskDate";
			this.mskDate.Size = new System.Drawing.Size(153, 22);
			this.mskDate.TabIndex = 28;
			this.mskDate.ValidatingType = typeof(System.DateTime);
			// 
			// cmbCategory
			// 
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(127, 183);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(153, 24);
			this.cmbCategory.TabIndex = 29;
			// 
			// btnMovieListWithCategory
			// 
			this.btnMovieListWithCategory.Location = new System.Drawing.Point(503, 30);
			this.btnMovieListWithCategory.Name = "btnMovieListWithCategory";
			this.btnMovieListWithCategory.Size = new System.Drawing.Size(105, 24);
			this.btnMovieListWithCategory.TabIndex = 30;
			this.btnMovieListWithCategory.Text = "Listele 2";
			this.btnMovieListWithCategory.UseVisualStyleBackColor = true;
			this.btnMovieListWithCategory.Click += new System.EventHandler(this.btnMovieListWithCategory_Click);
			// 
			// FrmMovie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 468);
			this.Controls.Add(this.btnMovieListWithCategory);
			this.Controls.Add(this.cmbCategory);
			this.Controls.Add(this.mskDate);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtDuration);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtMovieName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtMovieId);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.label1);
			this.Name = "FrmMovie";
			this.Text = "FrmMovie";
			this.Load += new System.EventHandler(this.FrmMovie_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtMovieName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtMovieId;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtDuration;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.MaskedTextBox mskDate;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Button btnMovieListWithCategory;
	}
}