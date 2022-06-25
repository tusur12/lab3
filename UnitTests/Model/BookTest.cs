using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса Book
    /// </summary>
    [TestFixture]
    class BookTest
    {
        /// <summary>
        /// Тесты для параметра Publisher
        /// </summary>
        /// <param name="publisher">Значение параметра Publisher</param>
        [Test]
        [TestCase("Издательство", TestName = "1_Корректное издательство")]
        [TestCase("Изд", TestName = "2_Корректное издательство")]
        [TestCase("Изд2", TestName = "3_Корректное издательство")]
        [TestCase(" ", TestName = "4_Некорректное издательство")]
        [TestCase("", TestName = "5_Некорректное издательство")]
        public void PublisherTest(string publisher)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string city = "Город";
            int pages = 300;
            var book = new Book(fio, name, year, publisher, city, pages);
        }

        /// <summary>
        /// Тесты для параметра City
        /// </summary>
        /// <param name="city">Значение параметра City</param>
        [Test]
        [TestCase("Город", TestName = "1_Корректный город")]
        [TestCase("Город-2", TestName = "2_Корректный город")]
        [TestCase("Гор од", TestName = "3_Корректный город")]
        [TestCase(" ", TestName = "4_Некорректный город")]
        [TestCase("", TestName = "5_Некорректный город")]
        public void CityTest(string city)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string publisher = "Издательство";
            int pages = 300;
            var book = new Book(fio, name, year, publisher, city, pages);
        }

        /// <summary>
        /// Тесты для параметра Pages
        /// </summary>
        /// <param name="pages">Значение параметра Pages</param>
        [Test]
        [TestCase(-5, TestName = "1_Неорректные страницы")]
        [TestCase(0, TestName = "2_Некорректные страницы")]
        [TestCase(1, TestName = "3_Корректные страницы")]
        [TestCase(23, TestName = "4_Корректные страницы")]
        [TestCase(2888, TestName = "5_Корректные страницы")]
        public void PagesTest(int pages)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string publisher = "Издательство";
            string city = "Город";
            var book = new Book(fio, name, year, publisher, city, pages);
        }

    }
}
