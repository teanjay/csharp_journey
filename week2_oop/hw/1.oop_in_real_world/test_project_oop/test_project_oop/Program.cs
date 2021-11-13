using System;

namespace test_project_oop
{
    public class Human
    {
        public int age { get; set; }
        public string name { get; set; }
        public string ownPets { get; set; }

        public Human(string n, int a, string b) { name = n; age = a; ownPets = b; }
        public void getInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст: {age}, Питомцы: {ownPets}");
        }

    }

    public class Cat
    {
        public string name { get; set; }
        public int age { get; set; }
        public string breed { get; set; }
        public int satiety { get; set; }
        public string owner { get; set; }

        public Cat(string nameString, int ageInt, string breedString, string ownerString, int satietyInt) { name = nameString; breed = breedString; age = ageInt; owner = ownerString; satiety = satietyInt; }
        public void getInfo(string a)
        {
            Console.WriteLine($"Имя: {name}, порода: {breed}, возраст: {age} месяцев, хозяин: {owner}. \n Текущий уровень сытости: {satiety} единиц.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Human K = new Human("Kirill", 23, "Alfie");
            Human N = new Human("Nastya", 24, "Marty");
            Human V = new Human("Victor", 29, "Simon");
            Cat Alfie = new Cat("Alfie", 13, "bengal", "Kirill", 50);
            Cat Simon = new Cat("Simon", 19, "unknown", "Victor", 90);
            Cat Marty = new Cat("Marty", 98, "unknown", "Nastya", 25);

            string[] humans = { "Kirill", "Nastya", "Victor" };
            string[] pets = { "Alfie", "Marty", "Simon" };

            void feedPets(string owner, string petName, int satietyCount)
            {
                if (owner == Alfie.owner && petName == Alfie.name)
                {
                    Alfie.satiety += satietyCount;
                }
                else if (owner == Marty.owner && petName == Marty.name)
                {
                    Marty.satiety += satietyCount;
                }
                else
                {
                    Console.WriteLine("Ошибка. Неверный питомец и/или хозяин.");
                }
            }
            while (true)
            {
                Console.WriteLine("Напиши своё имя");
                string owner = Console.ReadLine();
                Console.WriteLine("Напиши имя питомца");
                string petName = Console.ReadLine();
                for (int i = 0; i < humans.Length; i++)
                {
                    if (owner == humans[i] && petName == pets[i])
                    {
                        Console.WriteLine("OK");        // понять, как здесь по pets[i] вызвать метод feedPets
                        break;
                    }
                    if (i+1 == humans.Length)
                    {
                        Console.WriteLine("Ошибка. Неверный питомец и/или хозяин.");
                    }
                }
              
                Console.WriteLine("------------\n");
            }
        }
    }
}
