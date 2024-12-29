
using CSharpEgitimKampi601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi601.Services
{
    public class CustomerOperations
    {

        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();

            var document = new MongoDB.Bson.BsonDocument
            {
                { "CustomerName", customer.CustomerName },
                { "CustomerSurname", customer.CustomerSurname },
                { "CustomerCity", customer.CustomerCity },
                { "CustomerBalance", customer.CustomerBalance },
                { "CustomerShoppingCount", customer.CustomerShoppingCount }
            };

            customerCollection.InsertOne(document);
            Console.WriteLine("Customer added.");
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var customers = customerCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var customer in customers)
            {
                customerList.Add(new Customer
                {
                    CustomerId = customer.GetValue("_id").ToString(),
                    CustomerName = customer.GetValue("CustomerName").AsString,
                    CustomerSurname = customer.GetValue("CustomerSurname").AsString,
                    CustomerCity = customer.GetValue("CustomerCity").AsString,
                    CustomerBalance = customer.GetValue("CustomerBalance").AsDecimal,
                    CustomerShoppingCount = customer.GetValue("CustomerShoppingCount").AsInt32
                });

            }
            return customerList;
        }

        public void DeleteCustomer(string customerId)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            customerCollection.DeleteOne(filter);
            Console.WriteLine("Müşteri Silindi.");
        }

        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var update = Builders<BsonDocument>.Update
                .Set("CustomerName", customer.CustomerName)
                .Set("CustomerSurname", customer.CustomerSurname)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);
            customerCollection.UpdateOne(filter, update);
        }

        public Customer GetCustomerById(string customerId)
        {
            var connection = new MongoDbConnection();
            var customerCollection = connection.GetCustomersCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            var customer = customerCollection.Find(filter).FirstOrDefault();
            return new Customer
            {
                CustomerId = customer.GetValue("_id").ToString(),
                CustomerName = customer.GetValue("CustomerName").AsString,
                CustomerSurname = customer.GetValue("CustomerSurname").AsString,
                CustomerCity = customer.GetValue("CustomerCity").AsString,
                CustomerBalance = customer.GetValue("CustomerBalance").AsDecimal,
                CustomerShoppingCount = customer.GetValue("CustomerShoppingCount").AsInt32
            };
        }
    }
}
