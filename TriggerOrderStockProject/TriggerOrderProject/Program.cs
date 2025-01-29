using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerOrderProject.Data;

namespace TriggerOrderProject
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Db11Project20Entities context = new Db11Project20Entities();

			string number;
			Console.WriteLine("SİPARİŞ STOK SİSTEMİ");
			Console.WriteLine();
			Console.WriteLine("1- Ürün Listesi");
			Console.WriteLine("2- Sipariş Listesi");
			Console.WriteLine("3- Kasa Durumu");
			Console.WriteLine("4- Yeni Ürün Satışı");
			Console.WriteLine("5- İşlem Sayacı");
			Console.WriteLine("6- Ürün Stok Güncelleme");
			Console.WriteLine();
			Console.Write("Seçiminizi yapınız: ");
			number = Console.ReadLine();
			Console.WriteLine("***************");

			if (number=="1")
			{
				Console.WriteLine("---- Ürün Listesi ----");

				var values = context.TblProduct.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.ProductId + "-" + item.ProductName + " Stok Sayısı: " + item.ProductStock + " Fiyatı:" +item.ProductPrice + "TL");
				}
			}
			if (number == "2")
			{
				Console.WriteLine("---- Sipariş Listesi ----");
				var values = context.TblOrder.ToList();
				foreach (var item in values)
				{
					Console.WriteLine(item.OrderId + "-" + item.TblProduct.ProductName + " Birim Fiyat: " + item.UnitPrice + " Adet:" + item.Quantity + " Toplam Fiyat: " +item.TotalPrice +"TL");
				}
			}
			if (number == "3")
			{
				Console.WriteLine("---- Kasa Durumu ----");
				var values = context.TblCashRegister.Select(x=>x.Balance).FirstOrDefault();
				Console.WriteLine("Kasadaki Toplam Tutar: " + values + "TL");
			}
			if (number == "4")
			{
				Console.WriteLine("---- Yeni Ürün Satışı ----");
				Console.Write("Müşteri Adı: ");
				string customerName = Console.ReadLine();
				Console.Write("Ürün Adı: ");
				int productId = int.Parse(Console.ReadLine());
				Console.Write("Adet: ");
				int quantity = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Console.WriteLine("---- Ürün Bilgileri ----");

				var productName = context.TblProduct.Where(x => x.ProductId == productId).Select(x => x.ProductName).FirstOrDefault();
				Console.WriteLine("Ürün Adı: " + productName);


				var productUnitPrice = context.TblProduct.Where(x => x.ProductId == productId).Select(x => x.ProductPrice).FirstOrDefault();
				Console.WriteLine("Birim Fiyat: " + productUnitPrice);

				decimal totalPrice = decimal.Parse(productUnitPrice.ToString()) * quantity;
				Console.WriteLine("Toplam Fiyat: " + totalPrice);

				TblOrder tblOrder = new TblOrder();
				tblOrder.Customer = customerName;
				tblOrder.ProductId = productId;
				tblOrder.Quantity = quantity;
				tblOrder.UnitPrice = productUnitPrice;
				tblOrder.TotalPrice = totalPrice;

				context.TblOrder.Add(tblOrder);
				context.SaveChanges();
			}
			if (number == "5")
			{
				Console.WriteLine("---- İşlem Sayacı ----");
				var value = context.TblProcess.Select(x=>x.Process).FirstOrDefault();
				Console.WriteLine("Toplam İşlem Sayısı: " + value);
			}
			if (number == "6")
			{
				Console.WriteLine("---- Ürün Stok Güncelleme ----");
				Console.Write("Ürün Adı: ");
				string productName = Console.ReadLine();
				Console.Write("Yeni Stok Sayısı: ");
				int newStock = int.Parse(Console.ReadLine());
				Console.WriteLine();
				var product = context.TblProduct.Where(x => x.ProductName == productName).FirstOrDefault();
				product.ProductStock = newStock;
				context.SaveChanges();
				Console.WriteLine("Stok Güncellendi.");
			}
			Console.Read();
		}
	}
}
