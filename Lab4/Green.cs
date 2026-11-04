using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;
using System.Timers;
using System.Transactions;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int n = 0;
            double sum = 0;
            double avg = 0;
            foreach (double num in array)
            {
                if (num > 0)
                {
                    n++;
                    sum += num;
                }
            }
            avg = n != 0 ? sum / n : 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int neg_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg_i = i;
                    break;
                }
            }
            for (int i = 0; i < neg_i; i++)
            {
                sum += array[i] * array[i];
            }
            // end
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int imax = 0;
            int arraymax = array[0];
            int imin = 0;
            int arraymin = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arraymax)
                {
                    arraymax = array[i];
                    imax = i;
                }
                if (array[i] < arraymin)
                {
                    arraymin = array[i];
                    imin = i;
                }
            }
            int start = Math.Min(imin, imax);
            int end = Math.Max(imin, imax);
            int n = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            int[] b = new int[n];
            if (n == 0) return b;
            n = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    b[n++] = array[i];
                }
            }
            negatives = b;
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int arraymax = array[0];
            int imax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arraymax)
                {
                    arraymax = array[i];
                    imax = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    var arrayneg = array[i];
                    array[i] = array[imax];
                    array[imax] = arrayneg;
                    break;
                }
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int arraymax = array[0];
            int imax = 0;
            int cnt = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > arraymax)
                {
                    arraymax = array[i];
                    imax = i;
                    cnt = 1;
                }
                else if (array[i] == arraymax)
                {
                    cnt++;
                }
            }
            int[] b = new int[cnt];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == arraymax)
                {
                    b[index++] = i;
                }
            }
            answer = b;
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int arraymax = array[0];
            int imax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arraymax)
                {
                    arraymax = array[i];
                    imax = i;
                }
            }
            int index = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == arraymax)
                {
                    array[i] += index;
                    index++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int arraymax = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > arraymax)
                {
                    arraymax = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int a = array[i];
                if (a == arraymax)
                {
                    array[i] = sum;
                }
                sum += a;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int dlina = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    dlina += 1;
                    if (dlina > length)
                    {
                        length = dlina;
                    }
                }
                else if (array[i] <= array[i + 1])
                {
                    dlina = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = 0; j < array.Length - 2 - i; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] uniquelist = new int[array.Length];
            int unique_cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool repeated = false;
                for (int j = 0; j < unique_cnt; j++)
                {
                    if (array[i] == uniquelist[j])
                    {
                        repeated = true;
                        break;
                    }
                }
                if (!repeated)
                {
                    uniquelist[unique_cnt] = array[i];
                    unique_cnt++;
                }
            }
            cleared = new int[unique_cnt];
            for (int i = 0; i < unique_cnt; i++)
            {
                cleared[i] = uniquelist[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1)
            {
                return null;
            }
            if (a == b)
            {
                return null;
            }
            A = new double[n];
            double lenofstep = (b - a) / (n - 1);
            double sum = 0;
            int cnt = 0;
            double average;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * lenofstep;
            }
            foreach (double el in A)
            {
                if (el > 0)
                {
                    sum += el;
                    cnt++;
                }
            }
            if (cnt == 0)
                return new double[0];
            if (cnt > 0)
            {
                int countB = 0;
                average = sum / cnt;
                foreach (double el in A)
                {
                    if (el > average)
                    {
                        countB++;
                    }
                }
                B = new double[countB];
                int indexB = 0;
                foreach (double el in A)
                {
                    if (el > average)
                    {
                        B[indexB] = el;
                        indexB++;
                    }
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int curse = 0;
            int shulercurse = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int dice = dices[i];
                int current = dice - curse;
                if (current < 1)
                {
                    current = 1;
                }
                int shuler_current = 6 - shulercurse;
                if (shuler_current < 1)
                {
                    shuler_current = 1;
                }
                if (dice == 6)
                {
                    curse++;
                }
                shulercurse++;
                if (current > shuler_current)
                { 
                    wins++;
                }
            }
            // end

            return wins;

        }
    }
}
