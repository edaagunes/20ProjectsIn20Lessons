using MongoDB.Bson;
using MongoDB.Driver;
using MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDbOrder.Services
{
	public class OrderOperation
	{
		public void AddOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();

			var document = new BsonDocument
			{
				{ "CustomerName", order.CustomerName },
				{ "District", order.District },
				{ "City", order.City },
				{ "TotalPrice", order.TotalPrice }
			};

			orderCollection.InsertOne(document);
		}

		public List<Order> GetAllOrders()
		{
			var connection = new MongoDbConnection();
			var ordersCollection = connection.GetOrdersCollection();
			var orders=ordersCollection.Find(new BsonDocument()).ToList();

			List<Order> orderList=new List<Order>();

			foreach (var order in orders)
			{ 
				orderList.Add(new Order
				{
					OrderId = order["_id"].ToString(),
					City = order["City"].ToString(),
					CustomerName = order["CustomerName"].ToString(),
					District = order["District"].ToString(),
					TotalPrice =order["TotalPrice"].AsDecimal
				});
			}
			return orderList;
		}
	
		public void DeleteOrder(string orderId)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			orderCollection.DeleteOne(filter);
		}

		public void UpdateOrder(Order order)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
			var update = Builders<BsonDocument>.Update
				.Set("CustomerName", order.CustomerName)
				.Set("District", order.District)
				.Set("City", order.City)
				.Set("TotalPrice", order.TotalPrice);
			orderCollection.UpdateOne(filter, update);
		}

		public Order GetByIdOrder(string orderId)
		{
			var connection = new MongoDbConnection();
			var orderCollection = connection.GetOrdersCollection();
			var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(orderId));
			var order = orderCollection.Find(filter).FirstOrDefault();
			if (order!=null)
			{
				return new Order
				{
					City = order["City"].ToString(),
					CustomerName = order["CustomerName"].ToString(),
					District = order["District"].ToString(),
					TotalPrice = order["TotalPrice"].AsDecimal,
					OrderId = orderId
				};
			}
			else
			{
				return null;
			}
		}
	}
}
