using DB_993.Classes;
using NUnit.Framework;
using UnitTestRecommendationProject;

namespace RecommendationProject2
{
    [TestFixture]
    internal class TestDBSQLite
    {
        [Test]
        public void AvailabilityDB() //Наличие БД
        {
            using (var context = new TestDBContext())
            {
                context.ApplicationContext();
                Assert.That(File.Exists("ProectDB2.db"), Is.True);
            }
        }
        [Test]
        public void InputDataInDb() // Ввод данных и их вывод
        {

            using (var context = new TestDBContext())
            {
                context.ApplicationContext();
                var existingUser = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                if (existingUser != null)
                {
                    return;
                }
                var newUser = new User
                {
                    Name = "Даник",
                    Email = "Gg@",
                    Password = "12345"
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                var existingUser2 = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                Assert.That(existingUser2 != null, Is.True);
            }
        }
        [Test]
        public void UpdateDB() // Обновление данных
        {
            using (var context = new TestDBContext())
            {
                context.ApplicationContext();
                var existingUser = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                if (existingUser != null)
                {
                    return;
                }
                var newUser = new User
                {
                    Name = "Даник",
                    Email = "Gg@",
                    Password = "12345"
                };
                context.Users.Add(newUser);
                context.SaveChanges();
                var user = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                if (user != null)
                {
                    user.Name = "Пупсик";
                    user.Email = "Giga@";
                    user.Password = "54321";
                    context.SaveChanges();
                }
                var existingUser2 = context.Users.FirstOrDefault(user => user.Email == "Giga@");
                Assert.That(existingUser2 != null, Is.True);

            }

        }
        [Test]
        public void DeleteDataBD() // Удаление данных из БД
        {
            using (var context = new TestDBContext())
            {
                context.ApplicationContext();
                var existingUser = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                if (existingUser != null)
                {
                    return;
                }
                var newUser = new User
                {
                    Name = "Даник",
                    Email = "Gg@",
                    Password = "12345"
                };
                context.Users.Add(newUser);
                context.SaveChanges();


                var user = context.Users.FirstOrDefault(user => user.Email == "Gg@");
                if (user != null)
                {
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                var existingUser2 = context.Users.FirstOrDefault(user => user.Email == "Gg@");

                Assert.That(existingUser2 == null, Is.True);
            }
        }
    }

}
