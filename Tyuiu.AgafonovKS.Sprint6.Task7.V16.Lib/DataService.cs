using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;

namespace Tyuiu.AgafonovKS.Sprint6.Task7.V16.Lib
{
    public class DataService : ISprint6Task7V16
    {
        public int[,] GetMatrix(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    array[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int rows_1 = array.GetUpperBound(0) + 1;
            int columns_1 = array.GetUpperBound(1) + 1;
            for (int c = 0; c < columns_1; c++)
            {
                if (array[5, c] % 2 != 0)
                {
                    array[5, c] = -1;
                }
            }
            return array;
        }
    }
}
