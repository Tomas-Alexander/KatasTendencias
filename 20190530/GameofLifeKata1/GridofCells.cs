using System;
using System.IO;

namespace GameofLifeKata1Tests
{
    public class GridofCells
    {
        public int NumOfRows { get; set; }
        public int NumOfColumns { get; set; }
        public string[] Grid { get; set; }

        public GridofCells(string path)
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
            string result = "Generation 2:\r\n" +
                NumOfRows + " " + NumOfColumns;
            for (int i = 0; i < NumOfRows; i++)
            {
                result += "\r\n";
                for (int j = 0; j < NumOfColumns; j++)
                {
                    int neighbors = GetLivingNeighbors(i, j);
                    if (neighbors < 2 || neighbors > 3)
                    {
                        result += ".";
                    }
                    else
                    {
                        result += Grid[i][j];
                    }

                }
            }

            return result;
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
                            if (Grid[i][j] == '*' && !(i==row && j==column))
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