using System;

namespace classwork {
    class Card {
        public string Bankname { get; set; }
        public string Fullname { get; set; }
        public string PAN { get; set; }
        public string PIN { get; set; }
        public int CVC { get; set; }
        public DateTime ExpireDate { get; set; }
        public double Balance { get; set; }
        public Card(string bankname, string fullname, string pan, string pin)
        {
            Random r = new Random();
            Bankname = bankname;
            Fullname = fullname;
            PAN = pan;
            PIN = pin;
            CVC = r.Next(100, 1000);
            ExpireDate = DateTime.Now.AddDays(r.Next(-50000, -10000));
            Balance = r.Next(10000) + r.NextDouble();
        }
        public void show()
        {
            Console.WriteLine($"Bankname {Bankname}\n Fullname {Fullname}\n PAN {PAN}\n PIN {PIN}\n CVC {CVC}\n ExpireDate {ExpireDate}\n Balance {Balance}\n");
        }
    }
}