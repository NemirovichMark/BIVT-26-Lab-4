using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Principal;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int cntp = 0;
            double sum = 0;
            int end = array.Length;

            for (int i = 0; i < end; i++)
            {
                if (array[i] > 0)
                {
                    cntp++;
                    sum += array[i];
                }
            }

            if (cntp > 0)
            {
                double sr = sum / cntp;

                for (int i = 0; i < end; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = sr;
                    }
                }
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int cnt = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    cnt++;
                    break;
                }
                sum += array[i] * array[i];
            }
            // end
            if (cnt == 0) sum = 0;
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = array[0];
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);
            }
            int cmax = -1;
            int cmin = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == max && cmax == -1) cmax = i;
                if (array[i] == min && cmin == -1) cmin = i;
            }
            int schet = 0;
            for (int i = Math.Min(cmax, cmin) + 1; i < Math.Max(cmax, cmin); i++)
            {
                if (array[i] < 0)
                {
                    schet++;
                }
            }
            negatives = new int[schet];
            int index = 0;
            for (int i = Math.Min(cmax, cmin) + 1; i < Math.Max(cmax, cmin); i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end
            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = array[0];
            int cmax = 0;
            int cfirstminus = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    cmax = i;
                }
                if (cfirstminus == -1 && array[i] < 0) cfirstminus = i;
            }
            if (cfirstminus != -1)
            {
                int zna4 = array[cmax];
                array[cmax] = array[cfirstminus];
                array[cfirstminus] = zna4;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -2 * 100000;
            int count = 0;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = 0; i < array.Length; i++) if (array[i] == max) count++;
            int index = 0;
            answer = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -2 * 10000;
            int uvelichenie = 1;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += uvelichenie;
                    uvelichenie++;
                }
            }


            // end
        }
        public void Task7(int[] array)
        {

            // code here
            int max = -2 * 100000;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == max)
                {
                    int sum = 0;
                    for (int j = i - 1; j >= 0; j--) sum += array[j];
                    array[i] = sum;
                }
            }


            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int maxlength = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) length++;
                else
                {
                    if (length > maxlength) maxlength = length;
                    length = 1;
                }
            }
            if (length > maxlength) maxlength = length;
            // end

            return maxlength;
        }
        public void Task9(int[] array)
        {

            // code here
            int countchet = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 == 0) countchet++;
            int[] novi = new int[countchet];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    novi[index] = array[i];
                    index++;
                }
            }
            Array.Sort(novi);
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = novi[index];
                    index++;
                }
            }
                // end

            }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int nepovtor = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool est = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j]) est = true;
                    
                }
                if (est == false) nepovtor++;
            }
            cleared = new int[nepovtor];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool est = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j]) est = true;
                }
                if (est == false)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b) return null;

            A = new double[n];
            double sum = 0;
            double shag = (b - a) / (n - 1);
            int polozh = 0;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * shag;
                if (A[i] > 0)
                {
                    sum += A[i];
                    polozh++;
                }
            }
            if (polozh == 0) return new double[0];
            double sr = sum / polozh;
            int schet = 0;
            for (int i = 0; i < n; i++) if (A[i] > sr + 1e-9) schet++;
            B = new double[schet];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > sr + 1e-9)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shuler = new int[dices.Length];
            for (int i = 0; i < shuler.Length; i++)
            {
                if (i == 0) shuler[i] = 6;
                else shuler[i] = shuler[i - 1] > 1 ? shuler[i - 1] - 1 : 1;
            }

            int[] orig = (int[])dices.Clone();

            for (int i = 0; i < dices.Length; i++)
            {
                if (orig[i] == 6)
                {
                    for (int j = i + 1; j < dices.Length; j++) if (dices[j] > 1) dices[j]--; 
                }
                if (dices[i] > shuler[i]) wins++;
            }
            // end

            return wins;

        }
    }
}