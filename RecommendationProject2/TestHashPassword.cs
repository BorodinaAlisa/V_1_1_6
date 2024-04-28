using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB_993.Classes;
using NUnit.Framework;

namespace UnitTestRecommendationProject
{
    [TestFixture]
    internal class TestHashPassword
    {
        [Test]
        public void Hash()
        {
            var hash = new HashPassword();
            string pas = "12345";
            Assert.That(hash.GetPassword(pas) == "zQXCKD9it8dJEQCN9qZhAdUe1csj5rS1yEr0vGDbDzo=", Is.True);
        }
    }
}
