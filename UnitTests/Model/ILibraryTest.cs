using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса ILibrary
    /// </summary>
    [TestFixture]
    class ILibraryTest
    {
        /// <summary>
        /// Тесты для параметра Fio
        /// </summary>
        /// <param name="fio">Значение параметра Fio</param>
        [Test]
        [TestCase("Фамилия Имя Отчество", TestName = "1_Корректное ФИО")]
        [TestCase("ФамилияИмя Отчество", TestName = "2_Некорректное ФИО")]
        [TestCase("ФамилияИмяОтчество", TestName = "3_Некорректное ФИО")]
        [TestCase(" ", TestName = "4_Некорректное ФИО")]
        [TestCase("", TestName = "5_Некорректное ФИО")]
        public void FioTest(string fio)
        {
            string name = "Корректное название";
            int year = 2000;
            string publisher = "Издательство";
            string city = "Город";
            int pages = 300;
            var book = new Book(fio, name, year, publisher, city, pages);
        }

        /// <summary>
        /// Тесты для параметра Name
        /// </summary>
        /// <param name="name">Значение параметра Name</param>
        [Test]
        [TestCase("Название", TestName = "1_Корректное название")]
        [TestCase("Название из нескольких слов", TestName = "2_Корректное название")]
        [TestCase("Название с числами 12443", TestName = "3_Корректное название")]
        [TestCase(" ", TestName = "4_Некорректное название")]
        [TestCase("", TestName = "5_Некорректное название")]
        public void NameTest(string name)
        {
            string fio = "Фамилия Имя Отчество";
            int year = 2000;
            string publisher = "Издательство";
            string city = "Город";
            int pages = 300;
            var book = new Book(fio, name, year, publisher, city, pages);
        }

        /// <summary>
        /// Тесты для параметра Year
        /// </summary>
        /// <param name="year">Значение параметра Year</param>
        [Test]
        [TestCase(-5, TestName = "1_Неорректный год")]
        [TestCase(0, TestName = "2_Некорректный год")]
        [TestCase(555, TestName = "3_Корректный год")]
        [TestCase(2021, TestName = "4_Корректный год")]
        [TestCase(2056, TestName = "5_Некорректный год")]
        public void YearTest(int year)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            string publisher = "Издательство";
            string city = "Город";
            int pages = 300;
            var book = new Book(fio, name, year, publisher, city, pages);
        }
    }
}
