using System;

namespace test_project_oop
{
    public class Human
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Cat[] Pets { get; set; }

        public Human(string name, int age, Cat cat) { Name = name; Age = age; Pets = new Cat[]{ cat }; }
        public override string ToString()
        {
            return $"Имя: {Name}, возраст: {Age}, Питомцы: {Pets}";
        }

        public void FeedPets(string meal)
        {
            foreach (var p in Pets) 
            {
                p.Eat(meal);
            }
        }

    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public int Satiety { get; set; }
        public string Owner { get; set; }

        public Cat(string name, 
            int age, 
            string breed,
            string owner, 
            int satiety) 
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
            this.Satiety = satiety;
            this.Owner = owner;
        }

        public void Eat(string meal)
        {
            Console.WriteLine($"{Name} eating {meal}");
            Satiety++;
        }
        //public void getInfo(string a)
        //{
        //    Console.WriteLine($"Имя: {name}, порода: {breed}, возраст: {age} месяцев, хозяин: {owner}. \n Текущий уровень сытости: {satiety} единиц.");
        //}
        

    }


    class Program
    {

        static void feedPets(string ownerName, string petName, string meal, Human[] people)
        {
            foreach (var p in people)
            {
                if (ownerName != p.Name)
                {
                    continue;
                }
                foreach (var pet in p.Pets)
                {
                    if (petName == pet.Name)
                    {
                        pet.Eat(meal);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            var people = new Human[]
            {
                new Human("Kirill", 23, new Cat("Alfie", 13, "bengal", "Kirill", 50)),
                new Human("Nastya", 24, new Cat("Simon", 19, "unknown", "Victor", 90)),
                new Human("Victor", 29, new Cat("Marty", 98, "unknown", "Nastya", 25))
            };
            feedPets("Kirill", "Alfie", "stuff", people);
            var kirill = people[0];
            kirill.FeedPets("stuff");
        }
    }
}
