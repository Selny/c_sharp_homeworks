using System;

namespace c_sharp_homeworks
{
    class Program
    {
        class Cat
        {
            public string Nickname { get; set; }
            public int Age { get; set; }
            public bool Gender { get; set; }
            public int Energy { get; set; }
            public int Price { get; set; }
            public int MealQuantity { get; set; }

            public Cat(string nickname, int age, bool gender, int energy, int price, int mealQuantity)
            {
                Nickname = nickname;
                Age = age;
                Gender = gender;
                Energy = energy;
                Price = price;
                MealQuantity = mealQuantity;
            }

            public void Eat() 
            {
                Energy += 2;
                Price += 5;
            }
            public void Sleep() 
            {
                Energy += 10;
            }
            public void Play()
            {
                Energy -= 5;
                if (Energy <= 0) Sleep();
            }

        }

        class CatHouse
        {
            public Cat[] Cats { get; set; }
            public int CatCount { get; set; }
            public CatHouse(Cat[] cats, int catCount)
            {
                Cats = cats;
                CatCount = catCount;
            }
        }

        class PetShop
        {
            public CatHouse[] CatHouses { get; set; }
            public int CatHouseCount { get; set; }

            public PetShop(CatHouse[] catHouses, int catHouseCount)
            {
                CatHouses = catHouses;
                CatHouseCount = catHouseCount;
            }

            public void Show(Cat cat)
            {
                Console.WriteLine($"Nickname: {cat.Nickname}");
                Console.WriteLine($"Age: {cat.Age}");
                Console.WriteLine($"Gender: {cat.Gender}");
                Console.WriteLine($"Energy: {cat.Energy}");
                Console.WriteLine($"Price: {cat.Price}");
                Console.WriteLine($"MealQuantity: {cat.MealQuantity}\n");
            }

        }

        static void Main(string[] args)
        {
            Cat[] cats_1 = new Cat[3]
            {
                new Cat("Jerry", 4, true, 20, 20, 5),
                new Cat("Tom", 6, false, 10, 15, 8),
                new Cat("Snowball", 2, false, 40, 10, 10)
            };

            Cat[] cats_2 = new Cat[2]
            {
                new Cat("Meow", 2, true, 10, 5, 30),
                new Cat("Hauw", 7, false, 5, 5, 15)
            };

            CatHouse[] FluffyShop = new CatHouse[2]
            {
                new CatHouse(cats_1, 3),
                new CatHouse(cats_2, 2)
            };

            PetShop shop = new PetShop(FluffyShop, 2);

            int action = 20;

            while (action != 0) 
            {
                foreach (var house in FluffyShop) 
                {
                    foreach (var cat in house.Cats) 
                        {
                            cat.Eat();
                            cat.Play();
                            cat.Play();
                            cat.Sleep();
                            cat.Play();
                            shop.Show(cat);
                        }
                        System.Threading.Thread.Sleep(400);
                        Console.Clear();
                    }
                action--;
            }
        }
    }
}
