namespace PostgreToDoProject
{
	partial class FrmCategory
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
			this.btnGetById = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnCreate = new System.Windows.Forms.Button();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnList = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnGetById
			// 
			this.btnGetById.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnGetById.Location = new System.Drawing.Point(395, 179);
			this.btnGetById.Name = "btnGetById";
			this.btnGetById.Size = new System.Drawing.Size(153, 36);
			this.btnGetById.TabIndex = 28;
			this.btnGetById.Text = "Getir";
			this.btnGetById.UseVisualStyleBackColor = false;
			this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnUpdate.Location = new System.Drawing.Point(395, 137);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(153, 36);
			this.btnUpdate.TabIndex = 27;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDelete.Location = new System.Drawing.Point(395, 106);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(153, 36);
			this.btnDelete.TabIndex = 26;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnCreate
			// 
			this.btnCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreate.Location = new System.Drawing.Point(395, 68);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(153, 36);
			this.btnCreate.TabIndex = 25;
			this.btnCreate.Text = "Oluştur";
			this.btnCreate.UseVisualStyleBackColor = false;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(119, 100);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(204, 22);
			this.txtName.TabIndex = 24;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label8.Location = new System.Drawing.Point(48, 98);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 22);
			this.label8.TabIndex = 23;
			this.label8.Text = "Başlık:";
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(119, 72);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(204, 22);
			this.txtId.TabIndex = 22;
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnList.Location = new System.Drawing.Point(395, 26);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(153, 36);
			this.btnList.TabIndex = 21;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label7.Location = new System.Drawing.Point(38, 70);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 22);
			this.label7.TabIndex = 20;
			this.label7.Text = "İşlem Id:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(31, 221);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(736, 217);
			this.dataGridView1.TabIndex = 29;
			// 
			// FrmCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnGetById);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.label7);
			this.Name = "FrmCategory";
			this.Text = "FrmCategory";
			this.Load += new System.EventHandler(this.FrmCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGetById;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}