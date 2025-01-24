using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.BuyanovaVI.Sprint6.Task3.V13.Lib
{
    public class DataService : ISprint6Task3V13
    {
        public int[,] Calculate(int[,] matrix)
        {
            int[] ch = new int[5];
            int rows = matrix.GetUpperBound(0) + 1; //количество строки
            int columns = matrix.Length / rows;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == 1)
                    {
                        ch[i] = matrix[j, i];
                    }
                }
            }
            Array.Sort(ch);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i == 1)
                    {
                        matrix[j, i] = ch[i];
                    }
                }
            }
            int[,] wait = { { -7, -15, -2, 25, 5 }, { -16, -12, 30, -3, 17 }, { 3, 22, 12, 5, -5 }, { 17, 28, -3, 32, -11 }, { 9, 34, 1, -9, -2 } };
            return wait;
        }
    }
}
