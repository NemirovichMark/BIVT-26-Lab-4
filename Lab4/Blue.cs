using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }
            int sum = 0;

            for (int i = maxIndex + 1; i < array.Length; i++)
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
            int lastPositive = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lastPositive = i;
                }
            }
            if (lastPositive == -1)
            {
                answer = new int[array.Length];
            }
            else
            {
                answer = new int[array.Length + 1];
            }
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                j++;

                if (i == lastPositive)
                {
                    answer[j] = P;
                    j++;
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
            if (minIndex == -1)
            {
                answer = new int[array.Length];
            }
            else
            {
                answer = new int[array.Length - 1];
            }
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != minIndex)
                {
                    answer[j] = array[i];
                    j++;
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

            double average = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - average;
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

            double average = sum / array.Length;

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    count++;
                }
            }

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
            int increasing = 1;
            int decreasing = 1;

            count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    increasing++;
                }
                else
                {
                    increasing = 1;
                }

                if (array[i] <= array[i - 1])
                {
                    decreasing++;
                }
                else
                {
                    decreasing = 1;
                }

                if (increasing > count)
                {
                    count = increasing;
                }

                if (decreasing > count)
                {
                    count = decreasing;
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

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                answer[j + 1] = array[i];

                j += 2;
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

            if (min == max)
            {
                return null;
            }

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = ((double)array[i] - min) / ((double)max - min);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            Array.Sort(array);

            int left = 0;
            int right = array.Length - 1;

            index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

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

                    if (count <= int.MaxValue)
                    {
                        array = new int[(int)count];

                        long number = a;

                        for (int i = 0; i < array.Length; i++)
                        {
                            array[i] = (int)number;
                            number += b;
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
                long maxSum = (long)magazine[0] + magazine[1] + magazine[2];
                int maxIndex = 0;

                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    long sum = (long)magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxIndex = i;
                    }
                }

                indexes = new int[3];

                indexes[0] = maxIndex;
                indexes[1] = maxIndex + 1;
                indexes[2] = maxIndex + 2;
            }
            // end

            return indexes;
        }
    }
}