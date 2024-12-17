namespace ClassLibr_6_2
{
    public class Class6_2
    {
        public static double[] MinSt(double[,] mas)
        {
            double minSum = double.MaxValue;
            int stIndex = -1;
            for (int i = 0; i < mas.GetLength(1); i++)
            {
                double sumSt = 0;
                for (int j = 0; j < mas.GetLength(0); j++)
                {
                    sumSt += Math.Abs(mas[j, i]);
                }
                if (sumSt < minSum)
                {
                    minSum = sumSt;
                    stIndex = i;
                }
            }
            double[] vector = new double[3];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                vector[i] = mas[i, stIndex];
            }
            return vector;
        }
        public static double Rez(double[] mas)
        {
            double proizv = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (i % 2 == 0) proizv *= mas[i];
            }
            return proizv;
        }
    }
}
