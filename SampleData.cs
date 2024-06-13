using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalShelter.Models;

namespace AnimalShelter
{
    public class SampleData
    {
        public static void Initialize(ShoppingContext context)
        {
            if (context.Animals.Any() || context.Roles.Any() || context.Customers.Any() || context.Questionnaries.Any())
            {
                return;   // DB has been seeded
            }

            context.Animals.AddRange(
                new Animal
                {
                    Name = "Baffy",
                    Description = "Big boy for you.",
                    Age = 4,
                    Health = true,
                    IsAlergen = true,
                    NeedMoney = NeedMoney.Few,
                    NeedAttention = NeedAttention.Many,
                    Gender = Gender.Male,
                    Breed = Breed.Dog,
                    Img = "/img/shenok.jpg"
                },
                new Animal
                {
                    Name = "Masha",
                    Description = "Fluffy white cat, can easily get sick, requires periodic examination by a doctor",
                    Age = (int)1.5,
                    Health = true,
                    IsAlergen = true,
                    NeedMoney = NeedMoney.ALot,
                    NeedAttention = NeedAttention.Many,
                    Gender = Gender.Female,
                    Breed = Breed.Cat,
                    Img = "/img/Kot.jpg"
                },
                new Animal
                {
                    Name = "Bob",
                    Description = "handsome and talkative, without rigth leg",
                    Age = 2,
                    Health = false,
                    IsAlergen = false,
                    NeedMoney = NeedMoney.Middle,
                    NeedAttention = NeedAttention.Little,
                    Gender = Gender.Male,
                    Breed = Breed.Parrot,
                    Img = "/img/parrot.jpg"
                }
            );
            context.SaveChanges();
            
            context.Roles.AddRange(
                new Role { Name = "admin" },
                new Role { Name = "client" }
            );
            context.SaveChanges();

            context.Questionnaries.AddRange(
                new Questionnarie
                {
                    CanSpendTime = CanSpendTime.Avarage2,
                    IsAlergic = true,
                    Money = Money.Good,
                    PreferredAgeOfAnimal = PreferredAgeOfAnimal.LessThanFive,
                    PreferredHealthOfAnimal = true
                },
                new Questionnarie
                {
                    CanSpendTime = CanSpendTime.Many3,
                    IsAlergic = false,
                    Money = Money.Bad,
                    PreferredAgeOfAnimal = PreferredAgeOfAnimal.MoreThanFive,
                    PreferredHealthOfAnimal = false
                }
            ) ;
            context.SaveChanges();

            context.Customers.AddRange(
                new Customer
                {
                    FirstName = "Admin",
                    Email = "admin@gmail.com",
                    Password = "admin123",
                    LastName = "Admin",
                    Number = "+380 99 629 5577",
                    Age = 19,
                    Role = context.Roles.FirstOrDefault(r => r.Name == "admin")
                },
                new Customer
                {
                    QuestionnarieId = 1,
                    FirstName = "Ostap",
                    LastName = "Bendera",
                    Number = "+380 66 600 1488",
                    Age = 19,
                    Role = context.Roles.FirstOrDefault(r => r.Name == "client")

                },
                new Customer
                {
                    QuestionnarieId = 2,
                    FirstName = "Sasha",
                    LastName = "Ivanova",
                    Number = "+380 50 247 1337",
                    Age = 19,
                    Role = context.Roles.FirstOrDefault(r => r.Name == "client")
                }
            );
            context.SaveChanges();

            context.Roles.AddRange(
                new Role { Name = "admin" },
                new Role { Name = "Client" }
            );
            context.SaveChanges();
        }   
    }
}
 
