using System;

namespace classwork {
    class Client {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public double Salary { get; set; }
        public Card BankAccount { get; set; }

        public Client(int id, string name, string surname, byte age, double salary, Card bankaccount)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
            Salary = salary;
            BankAccount = bankaccount;
        }
    }
}