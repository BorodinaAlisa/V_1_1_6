using DB_993.Classes;
using design;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestRecommendationProject
{
    [TestFixture]
    internal class TestFillRecommendation
    {
        [Test]
        public void TestFillListRecommendationMethod()
        {
            using (var conext = new DB_993.Classes.ApplicationContextBD())
            {
                var listR = new List<Realty>();
                var newRealrt1 = new Realty
                {
                    Price = 2300000,
                    Square = 210,
                    Floor = 3,
                    Rooms = 5,
                    City = "c. Зеленое",
                    Type = "Дом",
                    ForWhat = "Купить",
                };
                var newRealrt2 = new Realty
                {
                    Price = 1700000,
                    Square = 110,
                    Floor = 1,
                    Rooms = 3,
                    City = "c. Зеленое",
                    Type = "Дом",
                    ForWhat = "Купить",
                };
                conext.Realtys.Add(newRealrt1);
                conext.Realtys.Add(newRealrt2);
                conext.SaveChanges();
                listR.Add(newRealrt1);
                listR.Add(newRealrt2);
                var listRealty = conext.Realtys.ToList();
                var getRecommendation = new GetRecommendation(listR);
                var mainWindow = new MainWindow();
                mainWindow.FullListRecommendation(getRecommendation);
                Assert.That(mainWindow.DictRecom!.Count == listRealty.Count, Is.True);
            }
        }
    }
}
