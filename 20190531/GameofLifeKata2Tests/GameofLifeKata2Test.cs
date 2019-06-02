using NUnit.Framework;
using System;
using System.IO;

namespace GameofLifeKata2Tests
{
    [TestFixture]
    public class GameofLifeKata2Test
    {
        public string testfilespath = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\";
        [Test]
        public void CreatingGridOfCells_WithNonExistingFile_ShouldThrowAFileNotFOundException()
        {
            string path = testfilespath + "NoFile.txt";
            Assert.Throws(typeof(FileNotFoundException), delegate { new GridOfCells(path); });
        }

        [Test]
        public void CreatingGridOfCells_WithEmptyFile_ShouldThrowAnArgumentException()
        {
            string path = testfilespath + "EmptyFile.txt";
            Assert.Throws(typeof(ArgumentException), delegate { new GridOfCells(path); });
        }

        [Test]
        public void CalculatingNextGeneration_WithJust1DeadCell_ShouldThrow1DeadCell()
        {
            string expected = File.ReadAllText(testfilespath + "Expected1.txt");
            string path = testfilespath + "Prueba1.txt";
            GridOfCells grid = new GridOfCells(path);
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With4DeadCells_ShouldReturn4DeadCells()
        {
            string expected = File.ReadAllText(testfilespath + "Expected2.txt");
            string path = testfilespath + "Prueba2.txt";
            GridOfCells grid = new GridOfCells(path);
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With5LivingCells_ShouldReturn4LivingCells()
        {
            string expected = File.ReadAllText(testfilespath + "Expected3.txt");
            string path = testfilespath + "Prueba3.txt";
            GridOfCells grid = new GridOfCells(path);
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With9LivingCells_ShouldReturn4LivingCells()
        {
            string expected = File.ReadAllText(testfilespath + "Expected4.txt");
            string path = testfilespath + "Prueba4.txt";
            GridOfCells grid = new GridOfCells(path);
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With6LivingCells_ShouldReturn8LivingCells9()
        {
            string expected = File.ReadAllText(testfilespath + "Expected5.txt");
            string path = testfilespath + "Prueba5.txt";
            GridOfCells grid = new GridOfCells(path);
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

    }
}
