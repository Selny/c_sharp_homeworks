using System;

namespace classwork {
    class Program {
        static void Main(string[] args)
        {
            Card[] cards = new Card[3]
            {
                new Card("Bank2", "Steve Vojniak", "1234 1234 1234 1234","1234"),
                new Card("Bank3", "Brain Smith", "2345 2345 2345 2345", "2345"),
                new Card("Bank3", "Scot Cawton", "3456 3456 3456 3456", "3456")
            };

            Client[] clients = new Client[3]
            {
                new Client(1, "Steve", "Vojniak", 47, 2000, cards[0]),
                new Client(2, "Brain", "Smith", 25, 3000, cards[1]),
                new Client(3, "Scot", "Cawton", 23, 4000, cards[2])
            };

            Bank nobank = new Bank(clients);
            nobank.showBalance();
        } 
    }
}