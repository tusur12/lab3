using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Model;

namespace UnitTests
{
    /// <summary>
    /// Набор тестов для класса Thesis
    /// </summary>
    [TestFixture]
    class ThesisTest
    {
        /// <summary>
        /// Тесты для параметра Rank
        /// </summary>
        /// <param name="rank">Значение параметра Rank</param>
        [Test]
        [TestCase("канд. тех. наук", TestName = "1_Корректная ученая степень")]
        [TestCase("канд техн наук", TestName = "2_Некорректная ученая степень")]
        [TestCase("КандТехнНаук", TestName = "3_Некорректная ученая степень")]
        [TestCase(" ", TestName = "4_Некорректная ученая степень")]
        [TestCase("", TestName = "5_Некорректная ученая степень")]
        public void RankTest(string rank)
        {
            string fio = "Фамилия Имя Отчество";
            string name = "Корректное название";
            int year = 2000;
            string city = "Город";
            int pages = 56;
            var book = new Thesis(fio, name, year, rank, city, pages);
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
            string rank = "канд. тех. наук";
            int pages = 56;
            var book = new Thesis(fio, name, year, rank, city, pages);
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
