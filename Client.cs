using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Client
    {
        //Fields
        private string clientNum;
        private string clientName;
        private string clientAdd;
        protected int cheqAccNum;
        protected int saveAccNum;

        //Properties
        public string ClientName
        {
            get { return ClientName; }
            set { clientName = value; }
        }
        public string ClientAdd
        {
            get { return clientAdd; }
            set { clientAdd = value; }
        }
        public string ClientNum
        {
            get { return clientNum; }
            set { clientNum = value; }
        }
        protected int CheqAccNum
        {
            get { return cheqAccNum; }
            set { cheqAccNum = value; }
        }
        protected int SaveAccNum
        {
            get { return saveAccNum; }
            set { saveAccNum = value; }
        }

        //Constructor
        public Client()
        {

        }
        public Client(string clientName, string clientAdd, string clientNum, int cheqAccNum, int saveAccNum)
        {
            this.clientName = clientName;
            this.clientAdd = clientAdd;
            this.clientNum = clientNum;
            this.cheqAccNum = cheqAccNum;
            this.saveAccNum = saveAccNum;
        }

        //Methods
        public void ClientInfo()
        {
            Console.WriteLine("=========== Client Info ===========");
            Console.WriteLine("Client Name: " + clientName + "\n");
            Console.WriteLine("Client Adress: " + clientAdd + "\n");
            Console.WriteLine("Client Phone Number: " + clientNum + "\n");
            Console.WriteLine("Press ENTER to continue.");
            Console.WriteLine("===================================");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }

    }
}
