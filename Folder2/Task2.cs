using System;
using System.Collections.Generic;

namespace Task2
{
    class Task2
    {
        public enum ClientType
        {
            bronzeСlient,
            silverClient,
            goldClient,
            platinumClient
        }

        public struct Client
        {
            private int idClient;
            private string fullNameClient;
            private string adressClient;
            private string phoneClient;
            private int numberOrdersCarriedClient;
            private int totalOrdersClient;
            private ClientType clientType;

            public Client(int idClient, string fullNameClient, string adressClient, string phoneClient, int numberOrdersCarriedClient, int totalOrdersClient, ClientType clientType)
            {
                this.idClient = idClient;
                this.fullNameClient = fullNameClient;
                this.adressClient = adressClient;
                this.phoneClient = phoneClient;
                this.numberOrdersCarriedClient = numberOrdersCarriedClient;
                this.totalOrdersClient = totalOrdersClient;
                this.clientType = clientType;
            }

            public void PrintClient()
            {
                Console.WriteLine($"Id: {idClient}");
                Console.WriteLine($"Full name: {fullNameClient}");
                Console.WriteLine($"Locate: {adressClient}");
                Console.WriteLine($"Phone: {phoneClient}");
                Console.WriteLine($"Number of orders carried out by the client: {numberOrdersCarriedClient}");
                Console.WriteLine($"The total amount of orders: {totalOrdersClient}");
                Console.WriteLine($"Важность клиента: {clientType}");
            }

        }

        static void Main(string[] args)
        {
            List<Client> list1 = new List<Client>();

            Client cl1 = new Client(1, "Клиент1", "адрес1", String.Format("{0: #-(###)-###-##-##}", 89005551212), 10, 30, ClientType.bronzeСlient);
            Client cl2 = new Client(2, "Клиент2", "адрес2", String.Format("{0: #-(###)-###-##-##}", 89005003366), 100, 330, ClientType.silverClient);
            Client cl3 = new Client(3, "Клиент3", "адрес3", String.Format("{0: #-(###)-###-##-##}", 89005001254), 100, 330, ClientType.goldClient);
            Client cl4 = new Client(4, "Клиент4", "адрес4", String.Format("{0: #-(###)-###-##-##}", 89005066623), 100, 330, ClientType.platinumClient);

            list1.Add(cl1);
            list1.Add(cl2);
            list1.Add(cl3);
            list1.Add(cl4);

            foreach (Client client in list1)
            {
                client.PrintClient();
                Console.WriteLine();
            }

        }
    }
}
