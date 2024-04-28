using DB_993.Classes;
using NUnit.Framework;

namespace UnitTestRecommendationProject
{
    [TestFixture]
    internal class TestRecommendationFunction
    {
        [Test]
        public void GetRecommendationTest()
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
                listR.Add(newRealrt1);
                listR.Add(newRealrt2);
                GetRecommendation getRecommendation = new GetRecommendation(listR);
                Assert.That(getRecommendation.RatingPrice == 2000000 && getRecommendation.RatingFloоr == 2 && getRecommendation.RatingRooms == 4 &&
                    getRecommendation.RatingSquare == 160 && getRecommendation.RatingCity == "c. Зеленое" && getRecommendation.RatingType == "Дом" &&
                    getRecommendation.RatingForWhat == "Купить", Is.True);
            }
        }
    }
}
