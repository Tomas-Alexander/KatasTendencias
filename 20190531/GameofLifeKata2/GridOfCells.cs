using System;
using System.IO;

namespace GameofLifeKata2Tests
{
    public class GridOfCells
    {
        public int NumOfRows;
        public int NumOfColumns;
        public string[] Grid { get; set; }

        public GridOfCells(string path)
        {
            if (File.Exists(path))
            {
                if (new FileInfo(path).Length == 0)
                {
                    throw new ArgumentException();
                }

                string[] file = File.ReadAllLines(path);
                string[] size = file[1].Split(" ");
                NumOfRows = Int32.Parse(size[0]);
                NumOfColumns = Int32.Parse(size[1]);
                Grid = new string[NumOfRows];
                Array.Copy(file, 2, Grid, 0, NumOfRows);
            }
            else
            {
                throw new FileNotFoundException();
            }

        }

        public string CalculateNextGeneration()
        {
            int neighbors;
            string gen2 = "Generation 2:\r\n" +
                NumOfRows + " " + NumOfColumns;
            for (int i = 0; i < NumOfRows; i++)
            {
                gen2 += "\r\n";
                for (int j = 0; j < NumOfColumns; j++)
                {
                    neighbors = GetLivingNeighbors(i, j);
                    if (neighbors < 2 || neighbors > 3)
                    {
                        gen2 += ".";
                    }
                    else if (neighbors == 3)
                    {
                        gen2 += "*";
                    }
                    else
                    {
                        gen2 += Grid[i][j];
                    }

                }
            }
            return gen2;
        }

        public int GetLivingNeighbors(int row, int column)
        {
            int counter = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if (i >= 0 && i < NumOfRows)
                    {
                        if (j >= 0 && j < NumOfColumns)
                        {
                            if (Grid[i][j] == '*' && !(i == row && j == column))
                            {
                                counter++;
                            }
                        }
                    }
                }
            }

            return counter;
        }
    }
}