using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса Magazine
    /// </summary>
    [TestFixture]
    class MagazineTest
    {
        /// <summary>
        /// Тесты для параметра NameMag
        /// </summary>
        /// <param name="mameMag">Значение параметра NameMag</param>
        [Test]
        [TestCase("Название", TestName = "1_Корректное назвние")]
        [TestCase("Название из нескольких слов", TestName = "2_Корректное назвние")]
        [TestCase("Название с числом 42", TestName = "3_Корректное назвние")]
        [TestCase(" ", TestName = "4_Некорректное назвние")]
        [TestCase("", TestName = "5_Некорректное назвние")]
        public void NameMagTest(string mameMag)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            int number = 4;
            var book = new Magazine(fio, name, year, mameMag, number);
        }

        /// <summary>
        /// Тесты для параметра Number
        /// </summary>
        /// <param name="number">Значение параметра Number</param>
        [Test]
        [TestCase(-5, TestName = "1_Неорректный номер")]
        [TestCase(0, TestName = "2_Некорректный номер")]
        [TestCase(1, TestName = "3_Корректный номер")]
        [TestCase(23, TestName = "4_Корректный номер")]
        [TestCase(143, TestName = "5_Корректный номер")]
        public void NumberTest(int number)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string mameMag = "Корректное название журнала";
            var book = new Magazine(fio, name, year, mameMag, number);
        }
    }
}
