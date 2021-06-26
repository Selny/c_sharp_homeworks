using System;

namespace classwork {
    class Bank 
    {
        public Client[] Clients { get; set; }

        public Bank(Client[] clients)
        {
            Clients = clients;
        }

        public void showBalance(){
            foreach(var client in Clients)
            {
                client.BankAccount.show();
            }
        }

    }
}