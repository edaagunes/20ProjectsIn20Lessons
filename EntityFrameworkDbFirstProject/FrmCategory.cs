using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDbFirstProject
{
	public partial class FrmCategory : Form
	{
		Db2Project20Entities db = new Db2Project20Entities();

		public FrmCategory()
		{
			InitializeComponent();
		}
		
		void CategoryList()
		{
			dataGridView1.DataSource = db.TblCategory.ToList();
		}

		private void btnList_Click(object sender, EventArgs e)
		{
			CategoryList();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			TblCategory tblCategory = new TblCategory();
			tblCategory.CategoryName=txtCategoryName.Text;
			db.TblCategory.Add(tblCategory);
			db.SaveChanges();
			CategoryList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var id=Convert.ToInt32(txtCategoryId.Text);
			var value=db.TblCategory.Find(id);
			db.TblCategory.Remove(value);
			db.SaveChanges();
			CategoryList();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			var id = Convert.ToInt32(txtCategoryId.Text);
			var value = db.TblCategory.Find(id);
			value.CategoryName=txtCategoryName.Text;
			db.SaveChanges();
			CategoryList();
		}
	}
}
