using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int imax = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                    imax = i;
            }

            int sum = 0;

            for (int i = imax + 1; i < array.Length; i++)
                sum += array[i];

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
            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    last = i;
            }

            if (last == -1)
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length + 1];

                for (int i = 0; i <= last; i++)
                    answer[i] = array[i];

                answer[last + 1] = P;

                for (int i = last + 1; i < array.Length; i++)
                    answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int imin = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (imin == -1 || array[i] < array[imin])
                        imin = i;
                }
            }

            if (imin == -1)
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length - 1];

                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < imin)
                        answer[i] = array[i];
                    else
                        answer[i] = array[i + 1];
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
                sum += array[i];

            double average = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
                array[i] -= average;
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                    sum += A[i] * B[i];
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
                sum += array[i];

            double average = sum / array.Length;

            int count = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] < average)
                    count++;

            indexes = new int[count];

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int up = 1;
            int down = 1;

            count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                    up++;
                else
                    up = 1;

                if (array[i] <= array[i - 1])
                    down++;
                else
                    down = 1;

                if (up > count)
                    count = up;

                if (down > count)
                    count = down;
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
            double min = array[0];
            double max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];

                if (array[i] > max)
                    max = array[i];
            }

            if (max != min)
            {
                normalized = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                    normalized[i] = (array[i] - min) / (max - min);
            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            index = -1;

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }

                if (array[mid] < P)
                    left = mid + 1;
                else
                    right = mid - 1;
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

                    if (count <= int.MaxValue)
                    {
                        array = new int[(int)count];

                        for (int i = 0; i < array.Length; i++)
                            array[i] = (int)(a + (long)i * b);
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
            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];

                for (int i = 0; i < magazine.Length; i++)
                    indexes[i] = i;
            }
            else
            {
                int start = 0;

                long maxSum = (long)magazine[0]
                            + magazine[1] + magazine[2];

                for (int i = 1; i < magazine.Length - 2; i++)
                {
                    long sum = (long)magazine[i]
                             + magazine[i + 1] + magazine[i + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        start = i;
                    }
                }

                indexes = new int[3];

                for (int i = 0; i < 3; i++)
                    indexes[i] = start + i;
            }
            // end

            return indexes;
        }
    }
}
