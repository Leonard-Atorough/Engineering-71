using System;
using System.Collections.Generic;

namespace SafariPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person leonard = new Person("Leonard", "Atorough");
            //leonard.Age = 23;
            //Console.WriteLine(leonard.GetFullName());

            //Person raheel;
            //raheel = new Person("Raheel", "Ahmed") { Age = -24 };
            //Console.WriteLine(raheel.GetFullName());

            //Spartan lenny = new Spartan("Lenny", "Ato");
            //Console.WriteLine($"{lenny.FirstName} {lenny.LastName}");

            //ShoppingList list = new ShoppingList() { Bread = 3 };
            //list.Milk = 43;

            //var newList = new ShoppingList();
            //list.Bread = 12;
            //list.Lemon = 31;

            //Person mansib = new Person("Mansib", "Raham") { Age = 20 };

            //Point3D p3d = new Point3D(3, 4, 9);

            //MyMethod(p3d, mansib);


            //static void MyMethod (Point3D p3, Person p)
            //{
            //    p3.y = 1000;
            //    p.Age = 92;
            //}

            //Hunter bill = new Hunter("Bill", "Clinton", "Lecia") { Age = 62 };

            //Console.WriteLine(gino.Shoot());

            //var billy = new Hunter("Billy", "Hilly", "Canon") { Age = 42 };

            //Console.WriteLine($"Bill equal Billy? {bill.Equals(billy)}");
            //Console.WriteLine($"Bill's hascode: {bill.GetHashCode()}");
            //Console.WriteLine($"Billy's type: {billy.GetType()}");
            //Console.WriteLine($"Billy to string: {billy.ToString()}");


            //List<IMovable> gameObjects = new List<IMovable>()
            //{
            //    new Person ("Leon", "Vance"),
            //    new Airplane(300, "Lufthansa", 800),
            //    new Vehicle(20, 80, 40)

            //};

            //foreach (var gameObject in gameObjects)
            //{
            //    Console.WriteLine(gameObject.Move());
            //}

            //foreach (var gameObject in gameObjects)
            //{
            //    Console.WriteLine(gameObject.Move(4));
            //}

            //    var topCat = new Person("Top", "Cat");

            //    var hunterCat = topCat as Hunter;

            //}

            //static void SpartaWrite (object obj)
            //{
            //    Console.WriteLine(obj.ToString());

            //    if (obj is Hunter)
            //    {
            //        var hunter = (Hunter)obj;
            //        Console.WriteLine(hunter.Shoot());
            //}

            //var shooters = new List<IShootable>()
            //{
            //    new LaserGun("Bolt SMG"),
            //    new LaserGun("M-Star"),
            //    new WaterPistol("BubbleMax 2000"),
            //    new WaterPistol("Jetsteam X"),
            //    new Hunter("Alan", "Quartermaine", new LaserGun("LR-77")),
            //    new Hunter("Steve", "Backshaw", new Camera("Kenon Scenefinder"))
            //};

            //foreach (var item in shooters)
            //{
            //    Console.WriteLine(item.Shoot());
            //}
            //Console.WriteLine();

            //foreach (var item in shooters)
            //{
            //    Console.WriteLine(item.ToString());
            //}

            Hunter alan = new Hunter("Alan", "Quartermaine", new LaserGun("HeatGun"));
            Hunter rish = new Hunter("Rish", "Sunak", new Camera("Nikon")) { Health = 2 };

            Console.WriteLine($"Rish's health is {rish.Health}");

            alan.Shoot(rish);
            rish.Shoot(alan);

            Console.WriteLine($"Rish's health is {rish.Health}");

        }
    }
}
