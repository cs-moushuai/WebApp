using System;
namespace WebApp.AppCode
{
    public class Caculator
    {
        private int[] arr;
        public Caculator(int[] arr)
        {
            this.arr = arr;
        }
        public int Sum()
        {
            int res = 0;
            foreach (int i in arr) res += i;
            return res;
        }
        public int Min()
        {
            //return arr.Min();
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++) min = Math.Min(min, arr[i]);
            return min;
        }
        public int Max()
        {
            //return arr.Max();
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++) max = Math.Max(max, arr[i]);
            return max;
        }
        public double Avg()
        {
            //return arr.Average();
            return 1.0 * Sum() / arr.Length;
        }
        public double Var()
        {
            double res = 0;
            foreach (int i in arr)
            {
                double avg = Avg();
                res += (i - avg) * (i - avg);
            }
            return res / arr.Length;
        }
    }
}