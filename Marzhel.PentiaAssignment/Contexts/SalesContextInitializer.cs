using System;
using System.Collections.Generic;
using System.Data.Entity;
using Marzhel.PentiaAssignment.Models;

namespace Marzhel.PentiaAssignment.Contexts
{
    public class SalesContextInitializer : DropCreateDatabaseIfModelChanges<SalesContext>
    {
        protected override void Seed(SalesContext context)
        {
            #region Sales People

            var spArtur = new SalesPerson()
            {
                Address = new Address()
                {
                    City = "København F",
                    Country = "DK",
                    Line1 = "Gammeltorv 8",
                    Line2 = "",
                    ZipCode = "1456"
                },
                JobTitle = "Junior Sales",
                Name = "Artur Newton",
                Salary = 400_000
            };

            var spWesley = new SalesPerson()
            {
                Address = new Address()
                {
                    City = "København K",
                    Country = "DK",
                    Line1 = "Købmagergade 5",
                    Line2 = "",
                    ZipCode = "1150"
                },
                JobTitle = "Junior Sales",
                Name = "Wesley Hill",
                Salary = 400_000
            };

            var spBurke = new SalesPerson()
            {
                Address = new Address()
                {
                    City = "Hellerup",
                    Country = "DK",
                    Line1 = "Valbirkvej 17",
                    Line2 = "",
                    ZipCode = "2900"
                },
                JobTitle = "Senior Sales",
                Name = "Burke Rich",
                Salary = 600_000
            };

            context.SalesPeople.Add(spArtur);
            context.SalesPeople.Add(spWesley);
            context.SalesPeople.Add(spBurke);

            #endregion Sales People

            #region Cars

            var carPlayExtra = new CarExtra() { Name = "Apple CarPlay" };
            var carbonBreaksExtra = new CarExtra() { Name = "Carbon breaks" };
            context.CarExtras.Add(carPlayExtra);
            context.CarExtras.Add(carbonBreaksExtra);

            var polo1 = new Car()
            {
                Color = "Black",
                Make = "VW",
                Model = "Polo",
                RecommendedPrice = 300_000
            };

            var golf1 = new Car()
            {
                Color = "Red",
                Extras = new List<CarExtra>() { carPlayExtra },
                Make = "VW",
                Model = "Golf",
                RecommendedPrice = 400_000
            };

            var a41 = new Car()
            {
                Color = "White",
                Extras = new List<CarExtra>() { carPlayExtra, carbonBreaksExtra },
                Make = "Audi",
                Model = "A4",
                RecommendedPrice = 500_000
            };

            var polo2 = new Car()
            {
                Color = "Black",
                Make = "VW",
                Model = "Polo",
                RecommendedPrice = 300_000
            };

            var golf2 = new Car()
            {
                Color = "Red",
                Extras = new List<CarExtra>() { carPlayExtra },
                Make = "VW",
                Model = "Golf",
                RecommendedPrice = 400_000
            };

            var a42 = new Car()
            {
                Color = "White",
                Extras = new List<CarExtra>() { carPlayExtra, carbonBreaksExtra },
                Make = "Audi",
                Model = "A4",
                RecommendedPrice = 500_000
            };

            context.Cars.Add(polo1);
            context.Cars.Add(golf1);
            context.Cars.Add(a41);
            context.Cars.Add(polo2);
            context.Cars.Add(golf2);
            context.Cars.Add(a42);

            #endregion Cars

            #region Customers

            var cJacob1 = new Customer()
            {
                Address = new Address()
                {
                    City = "Hellerup",
                    Country = "DK",
                    Line1 = "Høyrups Alle 35",
                    Line2 = "",
                    ZipCode = "2900"
                },
                Birthday = new DateTime(1988, 12, 25),
                Name = "Jacob",
                Surname = "Siene",
                Created = DateTime.Now
            };

            var cJacob2 = new Customer()
            {
                Address = new Address()
                {
                    City = "Hellerup",
                    Country = "DK",
                    Line1 = "Hambros Alle 25",
                    Line2 = "",
                    ZipCode = "2900"
                },
                Birthday = new DateTime(1978, 4, 10),
                Name = "Jacob",
                Surname = "Charman",
                Created = DateTime.Now
            };

            var cGerry = new Customer()
            {
                Address = new Address()
                {
                    City = "Hellerup",
                    Country = "DK",
                    Line1 = "Lemchesvej 27",
                    Line2 = "",
                    ZipCode = "2900"
                },
                Birthday = new DateTime(1960, 6, 1),
                Name = "Gerry",
                Surname = "Kuller",
                Created = DateTime.Now
            };

            context.Customers.Add(cJacob1);
            context.Customers.Add(cJacob2);
            context.Customers.Add(cGerry);

            #endregion Customers

            #region Purchases

            var p1 = new CarPurchase()
            {
                Car = polo1,
                Customer = cJacob1,
                OrderDate = new DateTime(2017, 5, 22),
                PricePaid = 290_000,
                SalesPerson = spArtur,
            };

            var p2 = new CarPurchase()
            {
                Car = polo2,
                Customer = cGerry,
                OrderDate = new DateTime(2017, 5, 25),
                PricePaid = 290_000,
                SalesPerson = spArtur,
            };

            var p3 = new CarPurchase()
            {
                Car = golf1,
                Customer = cJacob2,
                OrderDate = new DateTime(2017, 6, 22),
                PricePaid = 390_000,
                SalesPerson = spBurke,
            };

            var p4 = new CarPurchase()
            {
                Car = golf2,
                Customer = cGerry,
                OrderDate = new DateTime(2015, 3, 10),
                PricePaid = 390_000,
                SalesPerson = spArtur,
            };

            var p5 = new CarPurchase()
            {
                Car = a41,
                Customer = cJacob1,
                OrderDate = new DateTime(2018, 2, 4),
                PricePaid = 400_000,
                SalesPerson = spWesley,
            };

            var p6 = new CarPurchase()
            {
                Car = a42,
                Customer = cGerry,
                OrderDate = new DateTime(2014, 9, 10),
                PricePaid = 390_000,
                SalesPerson = spWesley,
            };

            context.CarPurchases.Add(p1);
            context.CarPurchases.Add(p2);
            context.CarPurchases.Add(p3);
            context.CarPurchases.Add(p4);
            context.CarPurchases.Add(p5);
            context.CarPurchases.Add(p6);

            #endregion Purchases
        }
    }
}
