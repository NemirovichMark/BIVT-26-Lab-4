using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex]) maxIndex = i;

            int sum = 0;
            for (int i = maxIndex + 1; i < array.Length; i++)
                sum += array[i];

            int firstNegative = -1;
            for (int i = 0; i < array.Length && firstNegative == -1; i++)
                if (array[i] < 0) firstNegative = i;

            if (firstNegative != -1) array[firstNegative] = sum;
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int insertIndex = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) insertIndex = i + 1;

            if (insertIndex == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < insertIndex) answer[i] = array[i];
                    else if (i == insertIndex) answer[i] = P;
                    else answer[i] = array[i - 1];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minPositive = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0 && (minPositive == -1 || array[i] < array[minPositive]))
                    minPositive = i;

            if (minPositive == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                    if (i != minPositive) answer[j++] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double mean = 0;
            for (int i = 0; i < array.Length; i++)
                mean += array[i];
            mean /= array.Length;

            for (int i = 0; i < array.Length; i++)
                array[i] -= mean;
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
            double mean = 0;
            for (int i = 0; i < array.Length; i++)
                mean += array[i];
            mean /= array.Length;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < mean) count++;

            indexes = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < mean) indexes[j++] = i;
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count = 1;
            int increasing = 1;
            int decreasing = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    increasing++;
                    decreasing = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    decreasing++;
                    increasing = 1;
                }
                else
                {
                    increasing++;
                    decreasing++;
                }
                if (increasing > count) count = increasing;
                if (decreasing > count) count = decreasing;
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
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max)
            {
                normalized = null;
            }
            else
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                    normalized[i] = (double)(array[i] - min) / (max - min);
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

            int left = 0;
            int right = array.Length - 1;
            index = -1;
            while (left <= right && index == -1)
            {
                int middle = (left + right) / 2;
                if (array[middle] == P) index = middle;
                else if (array[middle] < P) left = middle + 1;
                else right = middle - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0)
            {
                array = null;
            }
            else
            {
                int count = 0;
                int current = a;
                while (current <= c)
                {
                    count++;
                    current += b;
                }

                array = new int[count];
                current = a;
                for (int i = 0; i < count; i++)
                {
                    array[i] = current;
                    current += b;
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
                    indexes[i] = i;
            }
            else
            {
                int bestSum = magazine[0] + magazine[1] + magazine[2];
                int bestStart = 0;
                for (int i = 1; i + 2 < magazine.Length; i++)
                {
                    int currentSum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestStart = i;
                    }
                }

                indexes = new int[3] { bestStart, bestStart + 1, bestStart + 2 };
            }
            // end

            return indexes;
        }
    }
}