using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfStatisticsProject
{
	public partial class Form1 : Form
	{
		Db3Project20Entities db = new Db3Project20Entities();
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			//Toplam Kategori Sayısı
			int categoryCount = db.TblCategory.Count();
			lblCategoryCount.Text = categoryCount.ToString();

			//Toplam Ürün Sayısı
			int productCount = db.TblProduct.Count();
			lblProductCount.Text = productCount.ToString();

			//Toplam Müşteri Sayısı
			int customerCount = db.TblCustomer.Count();
			lblCustomerCount.Text = customerCount.ToString();

			//Toplam Sipariş Sayısı
			int orderCount = db.TblOrder.Count();
			lblOrderCount.Text = orderCount.ToString();

			//Toplam Stok Sayısı
			var totalProductStockCount = db.TblProduct.Sum(x => x.ProductStock);
			lblProductTotalStock.Text = totalProductStockCount.ToString();

			//Ortalama Ürün Fiyatı
			var averageProductPrice = db.TblProduct.Average(x => x.ProductPrice);
			lblProductAvgPrice.Text = averageProductPrice.ToString() + "₺";

			//Meyve Kategorisi Stok Sayısı
			var totalProductCountByCategoryIsFruit = db.TblProduct.Where(x => x.CategoryId == 1).Sum(y => y.ProductStock);
			lblProductCountByCategoryIsFruit.Text = totalProductCountByCategoryIsFruit.ToString();

			//Gazoz Toplam İşlem Hacmi
			var totalPriceByProductNameGazozGetStock = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductStock).FirstOrDefault();
			var totalPriceByProductNameGazozGetUnitPrice = db.TblProduct.Where(x => x.ProductName == "Gazoz").Select(y => y.ProductPrice).FirstOrDefault();
			var totalPriceByProductNameGazoz = totalPriceByProductNameGazozGetStock * totalPriceByProductNameGazozGetUnitPrice;
			lblTotalPriceByProductNameIsGazoz.Text = totalPriceByProductNameGazoz.ToString() + "₺";

			//Stok Sayısı 100den Az Ürünler
			var productCountByStockCountSmallerThan100 = db.TblProduct.Where(x => x.ProductStock < 100).Count();
			lblProductStockSmallerThan100.Text = productCountByStockCountSmallerThan100.ToString();

			//Kategorisi Sebze ve Durumu Aktif Olan Ürün Stok
			int id = db.TblCategory.Where(x => x.CategoryName == "Sebze").Select(y => y.CategoryId).FirstOrDefault();
			var productStockCountByCategoryNameIsSebzeAndStatusIsTrue = db.TblProduct.Where(w => w.CategoryId == id && w.ProductStatus == true).Sum(y => y.ProductStock);
			lblProductCountByCategoryStatusTrue.Text = productStockCountByCategoryNameIsSebzeAndStatusIsTrue.ToString();

			//Türkiye'den Yapılan Siparişler SQL Query
			var orderCountFromTurkiye = db.Database.SqlQuery<int>("select count(*) from TblOrder where CustomerId In (select CustomerId From TblCustomer where CustomerCountry='Türkiye')").FirstOrDefault();
			lblOrderCountFromTurkiye.Text = orderCountFromTurkiye.ToString();

			//Türkiye'den Yapılan Siparişler Ef
			var turkishCustomerIds = db.TblCustomer.Where(x => x.CustomerCountry == "Türkiye")
												   .Select(y => y.CustomerId)
												   .ToList();
			var orderCountFromTurkiyeWithEf = db.TblOrder.Count(z => turkishCustomerIds.Contains(z.CustomerId.Value));
			lblOrderCountFromTurkiyeByEf.Text = orderCountFromTurkiyeWithEf.ToString();

			//Kategorisi Meyve Olan Ürünlerin Toplam Satış Fiyatı SQL
			var orderTotalPriceByCategoryNameIsFruit = db.Database.SqlQuery<decimal>("select sum(o.TotalPrice) from TblOrder o join TblProduct p on o.ProductId=p.ProductId join TblCategory c on p.CategoryId=c.CategoryId where c.CategoryName='Meyve'").FirstOrDefault();
			lblOrderTotalPriceByCategoryIsFruit.Text = orderTotalPriceByCategoryNameIsFruit.ToString() + "₺";

			//Kategorisi Meyve Olan Ürünlerin Toplam Satış Fiyatı EF
			var orderTotalPriceByCategoryNameIsFruitWithEf = (from o in db.TblOrder join p in db.TblProduct on o.ProductId equals p.ProductId join c in db.TblCategory on p.CategoryId equals c.CategoryId where c.CategoryName == "Meyve" select o.TotalPrice).Sum();
			lblorderTotalPriceByCategoryNameIsFruitEf.Text = orderTotalPriceByCategoryNameIsFruitWithEf.ToString() + "₺";

			//Son Eklenen Ürün Adı
			var lastProductName = db.TblProduct.OrderByDescending(x => x.ProductId).Select(x => x.ProductName).FirstOrDefault();
			lblLastProductName.Text = lastProductName.ToString();

			//Son Eklenen Ürünün Kategorisi
			var lastProductCategoryId = db.TblProduct.OrderByDescending(x => x.ProductId).Select(x => x.CategoryId).FirstOrDefault();
			var lastProductCategoryName = db.TblCategory.Where(x => x.CategoryId == lastProductCategoryId).Select(y => y.CategoryName).FirstOrDefault();
			lblLastProductCategoryName.Text = lastProductCategoryName.ToString();

			//Aktif Ürün Sayısı
			var activeProductCount = db.TblProduct.Where(x => x.ProductStatus == true).Count();
			lblActiveProductCount.Text = activeProductCount.ToString();

			//Toplam Kola Stok Satışlarından Kazanılan Kazanç
			var colaStock = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y=>y.ProductStock).FirstOrDefault();
			var colaPrice = db.TblProduct.Where(x => x.ProductName == "Kola").Select(y => y.ProductPrice).FirstOrDefault();
			var totalColaStockPrice = colaStock * colaPrice;
			lblTotalPriceWithStockByCola.Text = totalColaStockPrice + "₺";

			//Son Sipariş Veren Müşteri Adı
			var lastCustomerId = db.TblOrder.OrderByDescending(x => x.OrderId).Select(x => x.CustomerId).FirstOrDefault();
			var lastCustomerName = db.TblCustomer.Where(x => x.CustomerId==lastCustomerId).Select(x => x.CustomerName).FirstOrDefault();
			lblLastCustomer.Text = lastCustomerName.ToString();

			// Ülke Sayısı
			var countryDifferentCount=db.TblCustomer.Select(x=>x.CustomerCountry).Distinct().Count();
			lblDifferentCountry.Text = countryDifferentCount.ToString();
		}
	}
}
