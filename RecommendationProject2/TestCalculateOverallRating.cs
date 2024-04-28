using DB_993.Classes;
using design;
using NUnit.Framework;

namespace UnitTestRecommendationProject
{
    [TestFixture]
    public class TestCalculateOverallRating
    {
        [Test]
        public void CalculateOverallRatingMethod()
        {
            using (var context = new DB_993.Classes.ApplicationContextBD())
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
                var newRealrt3 = new Realty
                {
                    Price = 2500000,
                    Square = 250,
                    Floor = 2,
                    Rooms = 5,
                    Mark = 5,
                    City = "c. Зеленое",
                    Type = "Квартира",
                    ForWhat = "Купить",
                };
                listR.Add(newRealrt1);
                listR.Add(newRealrt2);
                GetRecommendation getRecommendation = new GetRecommendation(listR);
                MainWindow mainWindow = new MainWindow();
                var testValue = mainWindow.CalculateOverallRating(getRecommendation, newRealrt3);
                Assert.That(testValue == 0.78M, Is.True);

            }
        }
    }
}
