namespace BoringTetris
{
    internal class Model
    {
        private int numRows;
        private int numCols;
        private bool[,] matrix;

        public Model(int numRows, int numCols)
        {
            this.numRows = numRows;
            this.numCols = numCols;
            matrix = new bool[numRows, numCols];
        }

        public bool Get(int row, int col)
        {
            return matrix[row, col];
        }

        public void Set(int row, int col)
        {
            matrix[row, col] = true;
            clearAnyCompleteRows();
        }

        public void Clear()
        {
            for (int row = 0; row < numRows; row++)
            {
                clearRow(row);
            }
        }

        public int NumRows()
        {
            return numRows;
        }

        public int NumCols()
        {
            return numCols;
        }

        private void clearAnyCompleteRows()
        {
            for (int row = 0; row < numRows; row++)
            {
                if (isRowComplete(row))
                {
                    clearRow(row);
                }
            }
        }

        private bool isRowComplete(int row)
        {
            for (int col = 0; col < numCols; col++)
            {
                if (matrix[row, col] == false)
                {
                    return false;
                }
            }
            return true;
        }

        private void clearRow(int row)
        {
            for (int col = 0; col < numCols; col++)
            {
                matrix[row, col] = false;
            }
        }
    }
}
