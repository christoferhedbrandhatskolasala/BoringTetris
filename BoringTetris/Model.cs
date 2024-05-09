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
            removeAnyCompleteRows();
        }

        public void Reset()
        {
            for (int row = 0; row < numRows; row++)
            {
                resetRow(row);
            }
        }

        private void removeAnyCompleteRows()
        {
            for (int row = 0; row < numRows; row++)
            {
                if (isRowComplete(row))
                {
                    resetRow(row);
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

        private void resetRow(int row)
        {
            for (int col = 0; col < numCols; col++)
            {
                matrix[row, col] = false;
            }
        }
    }
}
