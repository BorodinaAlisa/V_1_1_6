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
    internal class TestMarkUser
    {
        [Test]
        public void TestMarkUserMethod()
        {

            using (var context = new TestDBContext())
            {
                var newRealty = new Realty
                {
                    Price = 1700000,
                    Square = 110,
                    Floor = 1,
                    Rooms = 3,
                    City = "c. Зеленое",
                    Type = "Дом",
                    ForWhat = "Купить",
                };
                context.Add(newRealty);
                context.SaveChanges();
                var mark = new MarkWindow();
                mark.IdRealty = 1;
                mark.ValueMark = 5;
                mark.MarkInDb();
                var tableR = context.Realtys.FirstOrDefault(r => r.Id == mark.IdRealty);
                Assert.That(tableR!.Mark == 5, Is.True);
            }
        }
    }
}
