using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShtolAA.Sprint6.Task3.V9.Lib
{
    public class DataService : ISprint6Task3V9
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            int[] temp = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                temp[i] = matrix[i, columns - 1];
            }
            Array.Sort(temp);
            for (int i = 0; i < rows; i++)
            {
                matrix[i, columns - 1] = temp[i];
            }
            return matrix;
        }
    }
}
