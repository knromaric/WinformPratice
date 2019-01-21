﻿using System;
using System.IO;
using System.Linq;

namespace SudokuSolver.Workers
{
    class SudokuFileReader
    {
        public int[,] ReadFile(string fileName)
        {
            int[,] sudokuBoard = new int[9, 9];
            try
            {
                var sudokuBoardLines = File.ReadAllLines(fileName);

                int row = 0;

                foreach (var sudokuBoardLine in sudokuBoardLines)
                {
                    var sudokuLineElements = sudokuBoardLine.Split('|').Skip(1).Take(9).ToArray();
                    int col = 0;

                    foreach(var sudokuLineElement in sudokuLineElements)
                    {
                        sudokuBoard[row, col] =sudokuLineElement.Equals(" ") ? 0 : Convert.ToInt16(sudokuLineElement);
                        col++;
                    }

                    row++;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong while reading the file: " + ex.Message);
            }

            return sudokuBoard; 
        }
    }
}
