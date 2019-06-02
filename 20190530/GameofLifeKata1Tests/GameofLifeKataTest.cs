using NUnit.Framework;
using System;
using System.IO;

namespace GameofLifeKata1Tests
{
    [TestFixture]
    public class GameofLifeKataTest
    {
        [Test]
        public void CreatingGridOfCells_WithNonExistingFile_ShouldThrowFileNotFoundException()
        {
            string path = @"C:\Mi Carpeta\Noexisto.txt";
            Assert.Throws(typeof(FileNotFoundException), delegate { new GridofCells(path); });
        }

        [Test]
        public void CreatingGridOfCells_WithEmptyFile_ShouldThrowArgumentException()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\EmptyFile.txt";
            Assert.Throws(typeof(ArgumentException), delegate { new GridofCells(path); });
        }

        [Test]
        public void CalculatingNextGeneration_WithOnlyOneDeadCell_ShouldReturnOnlyOneDeadCell()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Prueba1.txt";
            GridofCells grid = new GridofCells(path);
            string expected = File.ReadAllText(@"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Expected1.txt");
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With4DeadCells_ShouldReturn4DeadCells()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Prueba2.txt";
            GridofCells grid = new GridofCells(path);
            string expected = File.ReadAllText(@"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Expected2.txt");
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With5LivingCells_ShouldReturn4LivingCells()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Prueba3.txt";
            GridofCells grid = new GridofCells(path);
            string expected = File.ReadAllText(@"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Expected3.txt");
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculatingNextGeneration_With9LivingCells_ShouldReturn4LivingCells()
        {
            string path = @"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Prueba4.txt";
            GridofCells grid = new GridofCells(path);
            string expected = File.ReadAllText(@"C:\Users\elcar\OneDrive\Escritorio\GameofLife Pruebas\Expected4.txt");
            string result = grid.CalculateNextGeneration();
            Assert.AreEqual(expected, result);
        }
    }
}
