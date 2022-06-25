using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    /// <summary>
    /// Набор тестов для класса Collection
    /// </summary>
    [TestFixture]
    class CollectionTest
    {
        /// <summary>
        /// Тесты для параметра NameCol
        /// </summary>
        /// <param name="nameCol">Значение параметра NameCol</param>
        [Test]
        [TestCase("Название", TestName = "1_Корректное назвние")]
        [TestCase("Название из нескольких слов", TestName = "2_Корректное назвние")]
        [TestCase("Название с числом 42", TestName = "3_Корректное назвние")]
        [TestCase(" ", TestName = "4_Некорректное назвние")]
        [TestCase("", TestName = "5_Некорректное назвние")]
        public void NameColTest(string nameCol)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string city = "Город";
            var book = new Collection(fio, name, year, nameCol, city);
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
            string nameCol = "Корректное название сборника";
            var book = new Collection(fio, name, year, nameCol, city);
        }
    }
}
