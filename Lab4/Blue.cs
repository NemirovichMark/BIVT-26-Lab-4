using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxIndex = 0;
            int negativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }

                if (array[i] < 0 && negativeIndex == -1)
                {
                    negativeIndex = i;
                }
            }

            if (negativeIndex != -1)
            {
                int sum = 0;

                for (int i = maxIndex + 1; i < array.Length; i++)
                {
                    sum += array[i];
                }

                array[negativeIndex] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int lastPositive = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lastPositive = i;
                }
            }

            int size = array.Length;

            if (lastPositive != -1)
            {
                size++;
            }

            answer = new int[size];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[k] = array[i];
                k++;

                if (i == lastPositive)
                {
                    answer[k] = P;
                    k++;
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (minIndex == -1 || array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }
            }

            int size = array.Length;

            if (minIndex != -1)
            {
                size--;
            }

            answer = new int[size];
            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != minIndex)
                {
                    answer[k] = array[i];
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array.Length > 0)
            {
                double sum = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }

                double average = sum / array.Length;

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] -= average;
                }
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

            int count = 0;

            if (array.Length > 0)
            {
                double average = sum / array.Length;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < average)
                    {
                        count++;
                    }
                }

                indexes = new int[count];
                int k = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < average)
                    {
                        indexes[k] = i;
                        k++;
                    }
                }
            }
            else
            {
                indexes = new int[0];
            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array.Length > 0)
            {
                int up = 1;
                int down = 1;
                count = 1;

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
            if (array.Length > 0)
            {
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

                if (min != max)
                {
                    normalized = new double[array.Length];

                    for (int i = 0; i < array.Length; i++)
                    {
                        normalized[i] =
                            ((double)array[i] - min) / ((double)max - min);
                    }
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
                int value = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > value)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = value;
            }

            index = -1;
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int middle = left + (right - left) / 2;

                if (array[middle] == P)
                {
                    index = middle;
                    break;
                }
                else if (array[middle] < P)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
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
                    long size = ((long)c - a) / b + 1;

                    if (size <= int.MaxValue)
                    {
                        array = new int[(int)size];

                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = (int)(a + (long)i * b);
                        }
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
            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];

                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                long maxSum =
                    (long)magazine[0] + magazine[1] + magazine[2];

                int bestStart = 0;

                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    long sum =
                        (long)magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        bestStart = i;
                    }
                }

                indexes = new int[3];
                indexes[0] = bestStart;
                indexes[1] = bestStart + 1;
                indexes[2] = bestStart + 2;
            }
            // end

            return indexes;
        }
    }
}