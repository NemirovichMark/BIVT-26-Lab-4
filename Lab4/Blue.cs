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

            for (int i = 0; i < array.Length; i = i + 1)
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

            int sum = 0;

            for (int i = maxIndex + 1; i < array.Length; i = i + 1)
            {
                sum = sum + array[i];
            }

            if (negativeIndex != -1)
            {
                array[negativeIndex] = sum;
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            int last = -1;

            for (int i = 0; i < array.Length; i = i + 1)
            {
                if (array[i] > 0)
                {
                    last = i;
                }
            }

            if (last == -1)
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i = i + 1)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length + 1];

                for (int i = 0; i <= last; i = i + 1)
                {
                    answer[i] = array[i];
                }

                answer[last + 1] = P;

                for (int i = last + 1; i < array.Length; i = i + 1)
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

            int minIndex = -1;

            for (int i = 0; i < array.Length; i = i + 1)
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
                size = size - 1;
            }

            answer = new int[size];
            int j = 0;

            for (int i = 0; i < array.Length; i = i + 1)
            {
                if (i != minIndex)
                {
                    answer[j] = array[i];
                    j = j + 1;
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

                for (int i = 0; i < array.Length; i = i + 1)
                {
                    sum = sum + array[i];
                }

                double average = sum / array.Length;

                for (int i = 0; i < array.Length; i = i + 1)
                {
                    array[i] = array[i] - average;
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
                for (int i = 0; i < A.Length; i = i + 1)
                {
                    sum = sum + A[i] * B[i];
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

            for (int i = 0; i < array.Length; i = i + 1)
            {
                sum = sum + array[i];
            }

            double average = 0;

            if (array.Length > 0)
            {
                average = sum / array.Length;
            }

            int amount = 0;

            for (int i = 0; i < array.Length; i = i + 1)
            {
                if (array[i] < average)
                {
                    amount = amount + 1;
                }
            }

            indexes = new int[amount];
            int j = 0;

            for (int i = 0; i < array.Length; i = i + 1)
            {
                if (array[i] < average)
                {
                    indexes[j] = i;
                    j = j + 1;
                }
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

                for (int i = 1; i < array.Length; i = i + 1)
                {
                    if (array[i] >= array[i - 1])
                    {
                        up = up + 1;
                    }
                    else
                    {
                        up = 1;
                    }

                    if (array[i] <= array[i - 1])
                    {
                        down = down + 1;
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

            for (int i = 0; i < array.Length; i = i + 1)
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
                double min = array[0];
                double max = array[0];

                for (int i = 1; i < array.Length; i = i + 1)
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

                    for (int i = 0; i < array.Length; i = i + 1)
                    {
                        normalized[i] = (array[i] - min) / (max - min);
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

            for (int i = 0; i < array.Length - 1; i = i + 1)
            {
                for (int j = 0; j < array.Length - 1 - i; j = j + 1)
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
                int size = 0;
                long value = a;

                while (value <= c)
                {
                    size = size + 1;
                    value = value + b;
                }

                array = new int[size];
                value = a;

                for (int i = 0; i < size; i = i + 1)
                {
                    array[i] = (int)value;
                    value = value + b;
                }
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            int amount = 3;

            if (magazine.Length < 3)
            {
                amount = magazine.Length;
            }

            int start = 0;
            long bestSum = 0;

            for (int i = 0; i < amount; i = i + 1)
            {
                bestSum = bestSum + magazine[i];
            }

            for (int i = 1; i <= magazine.Length - amount; i = i + 1)
            {
                long sum = 0;

                for (int j = 0; j < amount; j = j + 1)
                {
                    sum = sum + magazine[i + j];
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    start = i;
                }
            }

            indexes = new int[amount];

            for (int i = 0; i < amount; i = i + 1)
            {
                indexes[i] = start + i;
            }

            // end

            return indexes;
        }
    }
}