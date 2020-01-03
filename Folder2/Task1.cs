using System;
using System.Collections.Generic;

namespace Task1
{
    class Task1
    {
        public enum ArticleType
        {
            consumerProducts,
            manufacturedProducts,
            services
        }

        public struct Article
        {

            private int productID;
            private string productName;
            private int productPrice;
            private ArticleType productType;

            public Article(int productID, string productName, int productPrice, ArticleType productType)
            {
                this.productID = productID;
                this.productName = productName;
                this.productPrice = productPrice;
                this.productType = productType;
            }

            public void Print()
            {
                Console.WriteLine($"Код продукта = {productID}.");
                Console.WriteLine($"Название продукта = {productName}.");
                Console.WriteLine($"Цена продукта = {productPrice}.");
                Console.WriteLine($"Цена продукта = {productType}.");
            }
        }

        static void Main(string[] args)
        {
            List<Article> articles1 = new List<Article>();
            Article one = new Article(productID: 1, productName: "product1", productPrice: 100, ArticleType.consumerProducts);
            Article two = new Article(productID: 2, productName: "product2", productPrice: 200, ArticleType.manufacturedProducts);
            Article three = new Article(productID: 3, productName: "product3", productPrice: 300, ArticleType.services);

            articles1.Add(one);
            articles1.Add(two);
            articles1.Add(three);

            foreach (Article article in articles1)
            {
                article.Print();
                Console.WriteLine();
            }
        }
    }
}
