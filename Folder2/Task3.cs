using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Task3
    {
        public enum PayType
        {
            visa,
            sberbank,
            masterCard,
            webMoney,
            cashPayment
        }

        public struct RequestItem
        {
            private string product;
            private int amountProduct;
            private int countProduct;

            public RequestItem(string product, int amountProduct, int countProduct)
            {
                this.product = product;
                this.amountProduct = amountProduct;
                this.countProduct = countProduct;
            }

            public void RequestItemPrint()
            {
                Console.WriteLine($"Товар {countProduct} = {product}");
                Console.WriteLine($"Количество товара  = {amountProduct}");
            }
        }

        public struct Request
        {
            private int orderId;
            private string orderClient;
            private DateTime orderDate;
            private string[] orderList;
            private int[] orderCost;
            private int totalAllOrders;
            private PayType payType;

            public Request(int orderId, string orderClient, DateTime orderDate, string[] orderList, int[] orderCost, PayType payType)
            {
                this.orderId = orderId;
                this.orderClient = orderClient;
                this.orderDate = orderDate;
                this.orderList = orderList;
                this.orderCost = orderCost;
                this.payType = payType;
                this.totalAllOrders = orderCost.Sum();
            }

            public void PrintRequest()
            {
                Console.WriteLine($"Id: {orderId}");
                Console.WriteLine($"Клиент: {orderClient}");
                Console.WriteLine($"Дата: {orderDate.ToString("D")}");
                Console.WriteLine($"Тип платежа: {payType}");
                Console.WriteLine();
                Console.WriteLine("Перечень заказанных товаров: ");
                Console.WriteLine();
                for (int i = 0; i < orderList.Length; i++)
                {
                    Console.WriteLine($"\tТовар: {orderList[i]}. Цена: {orderCost[i]}.");
                }
                Console.WriteLine($"\nСумма заказа: {totalAllOrders}\n");
            }
        }

        static void Main(string[] args)
        {
            int count = 0;

            List<RequestItem> RequestItemList = new List<RequestItem>();
            List<Request> RequesList = new List<Request>();

            string[] items1 = { "Смартфон1", "Пк1", "Принтер1" };
            int[] units1 = { 18000, 55000, 10000 };
            DateTime itemsDate1 = new DateTime(2019, 10, 25);

            string[] items2 = { "Смартфон2", "Пк2", "Принтер2" };
            int[] units2 = { 15000, 77000, 11000 };
            DateTime itemsDate2 = new DateTime(2019, 10, 26);


            RequestItem requestItem1 = new RequestItem("product1", 3, 1);
            RequestItem requestItem2 = new RequestItem("product2", 3, 2);
            Request request1 = new Request(1, "Name1", itemsDate1, items1, units1, PayType.cashPayment);
            Request request2 = new Request(2, "Name2", itemsDate2, items2, units2, PayType.masterCard);

            RequestItemList.Add(requestItem1);
            RequestItemList.Add(requestItem2);

            RequesList.Add(request1);
            RequesList.Add(request2);

            foreach (RequestItem requestItem in RequestItemList)
            {
                requestItem.RequestItemPrint();
                Console.WriteLine();
                RequesList[count].PrintRequest();
                count++;
            }
            Console.ReadLine();
        }
    }
}
