using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Spreadsheet
    {   public struct Cell
        {
          public  int cellValue;
            public Cell(int value)
            {
                cellValue = value;
            }
        }
        public Cell[,] field { get; private set; }
        private int rows;
        private int columns;
        Spreadsheet(int userRows, int userColumn)
        {
            field = new Cell[userRows, userColumn];
            rows = userRows;
            columns = userColumn;
        }
        void Put(int row, int column, int value)
        {
            Cell buffCell = new Cell(value);
            field[row, column] = buffCell;
        }
        Spreadsheet InsertRow(int rowIndex)
        {
            Spreadsheet newSpreadsheet = new Spreadsheet(rows + 1, columns);
            for (int i = 0; i < rows + 1; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i<rowIndex)
                    {
                        newSpreadsheet.field[i, j] = field[i, j];
                    }
                    if (i > rowIndex)
                    {
                        newSpreadsheet.field[i, j] = field[i-1, j];
                    }
                }
            }
                    return newSpreadsheet;
        }
        Spreadsheet InsertColumn(int columnIndex)
        {
            Spreadsheet newSpreadsheet = new Spreadsheet(rows, columns + 1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns + 1; j++)
                {
                    if (j < columnIndex)
                    {
                        newSpreadsheet.field[i, j] = field[i, j];
                    }
                    if (j > columnIndex)
                    {
                        newSpreadsheet.field[i, j] = field[i, j-1];
                    }
                }
            }
            return newSpreadsheet;
        }
        int Get(int row, int column)
        {
            Cell buffCell = new Cell();
            field[row, column] = buffCell;
            return buffCell.cellValue;
        }
    }
}
