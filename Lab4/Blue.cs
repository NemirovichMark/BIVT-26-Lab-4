using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            int sum = 0;
            for (int i = max + 1; i < array.Length; i++)
            {
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int lastp = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lastp = i;
                }
            }

            if (lastp == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i <= lastp; i++)
                {
                    answer[i] = array[i];
                }
                answer[lastp + 1] = P;
                for (int i = lastp + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int min = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && (min == -1 || array[i] < array[min]))
                {
                    min = i;
                }
            }

            if (min == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length - 1];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != min)
                    {
                        answer[k] = array[i];
                        k++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mean = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= mean;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mean = sum / array.Length;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < mean)
                {
                    count++;
                }
            }

            indexes = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < mean)
                {
                    indexes[k] = i;
                    k++;
                }
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count = 1;
            int up = 1;
            int down = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    up++;
                }
                else
                {
                    up = 1;
                }

                if (array[i] <= array[i - 1])
                {
                    down++;
                }
                else
                {
                    down = 1;
                }

                if (up > count)
                {
                    count = up;
                }
                if (down > count)
                {
                    count = down;
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[2 * i] = array[i];
                answer[2 * i + 1] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            if (max != min)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (array[i] - (double)min) / ((double)max - min);
                }
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            index = -1;
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
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
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                if (a > c)
                {
                    array = new int[0];
                }
                else
                {
                    long count = ((long)c - a) / b + 1;
                    array = new int[(int)count];
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] = a + i * b;
                    }
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if(magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                int beststart = 0;
                int bestsum = magazine[0] + magazine[1] + magazine[2];
                for (int i = 1; i + 2 < magazine.Length; i++)
                {
                    int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (s > bestsum)
                    {
                        bestsum = s;
                        beststart = i;
                    }
                }

                indexes = new int[3];
                indexes[0] = beststart;
                indexes[1] = beststart + 1;
                indexes[2] = beststart + 2;
            }
            // end

            return indexes;
        }
    }
}