using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxind = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxind])
                {
                    maxind = i;
                }
            }

            int minind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minind = i;
                    break;
                }
            }

            int sum = 0;
            for (int i = maxind + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (minind != -1)
            {
                array[minind] = sum;
            }




                // end

            }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            
           
            int pol = -1;
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pol = i;
                }
            }
            if (pol == -1)
            {
                answer = copy;
            }
            else
            {
                int[] result = new int[array.Length + 1];
                for (int i = 0; i < pol + 1; i++)
                {
                    result[i] = array[i];
                }
                result[pol + 1] = P;
                for (int i = pol + 1; i < array.Length; i++)
                {
                    result[i + 1] = array[i];
                }
                answer = result;
            }

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int malpol = -1;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < min) && (array[i] > 0))
                {
                    min = array[i];
                    malpol = i;
                }
            }
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            if (malpol == -1)
            {
                answer = copy;
            }
            else
            {
                int[] result = new int[array.Length - 1];
                for (int i = 0; i < malpol; i++)
                {
                    result[i] = array[i];
                }
                for (int i = malpol + 1; i < array.Length; i++)
                {
                    result[i - 1] = array[i];
                }
                answer = result;
            }

            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double avg = 0;
double sum = 0;
for (int i = 0; i < array.Length; i++)
{
    sum += array[i];
}
avg = sum / array.Length;
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] - avg;
}




            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            for (int i = 0; i < A.Length; i++)
            {
                if (A.Length == B.Length)
                {
                    sum += A[i] * B[i];
                }
                else
                {
                    return sum = 0;
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sr = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr = sum / array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    count++;
                }
            }
            indexes = new int[count];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexes[c] = i;
                    c++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int best = 0;
            int cur = 0;
            int best1 = 0;
            int cur1 = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] <= array[i + 1])
                {
                    cur++;
                    if (cur > best)
                    {
                        best = cur;
                    }
                }
                else
                {
                    cur = 0;
                }
            }
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] >= array[i + 1])
                {
                    cur1++;
                    if (cur1 > best1)
                    {
                        best1 = cur1;
                    }
                }
                else
                {
                    cur1 = 0;
                }
            }
            if (best > best1)
            {
                count = best + 1;
            }
            else
            {
                count = best1 + 1;
            }

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int[] copy = new int[array.Length * 2];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = array[i / 2];
            }
            answer = copy;

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int max = int.MinValue;
            int min = int.MaxValue;
            double[] copy = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            if (max != min)
            {
                normalized = copy;
                for (int i = 0; i < array.Length; i++)
                {
                    copy[i] = (double)(array[i] - min) / (max - min);
                }
                normalized = copy;
            }
            else
            {
                normalized = null;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                return -1;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == P)
                {
                    return mid;
                }
                else if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                int count = 0;
                int x = a;
                while (x <= c)
                {
                    count++;
                    x += b;
                }

                array = new int[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = a + i * b;
                }
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int len = 3;
            if (magazine.Length < 3)
            {
                len = magazine.Length;
            }

            int start = 0;
            if (magazine.Length >= 3)
            {
                int best = magazine[0] + magazine[1] + magazine[2];
                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (s > best)
                    {
                        best = s;
                        start = i;
                    }
                }
            }

            indexes = new int[len];
            for (int i = 0; i < len; i++)
            {
                indexes[i] = start + i;
            }

            // end

            return indexes;
        }
    }
}
