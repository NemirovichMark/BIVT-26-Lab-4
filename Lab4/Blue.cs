using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max = int.MinValue, maxInd = 0, maxSum = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > max)
                {
                    max = array[i];
                    maxInd = i;
                }
            }

            for (int j = maxInd+1; j < array.Length; j++)
            {
                maxSum += array[j];
            }

            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < 0)
                {
                    array[k] = maxSum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length+1];
            int lastPosInd = -1;
            for (int i = array.Length-1; i >= 0; i--)
            {
                if (array[i] > 0) {
                    lastPosInd = i;
                    break;
                }
            }
            if (lastPosInd == -1)
            {
                answer = new int[array.Length];
                for (int a = 0; a < array.Length; a++)
                {
                    answer[a] = array[a];
                }
                return answer;
            }
            for (int j = 0; j <= lastPosInd; j++)
            {
                answer[j] = array[j];
            }
            answer[lastPosInd + 1] = P;
            for (int k = lastPosInd+1; k < array.Length; k++)
            {
                answer[k+1] = array[k];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minInd = -1, min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] > 0)
                {
                    min = array[i];
                    minInd = i;
                }
            }
            if (minInd == -1)
            {
                int[] copy = new int[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    copy[j] = array[j];
                }
                return copy;
            }

            answer = new int[array.Length - 1];
            for (int k = 0; k < minInd; k++)
            {
                answer[k] = array[k];
            }
            for (int k = minInd + 1; k < array.Length; k++)
            {
                answer[k - 1] = array[k];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            int len = array.Length, sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            double avg = (double)sum / len;
            for (int i = 0; i < len; i++)
            {
                array[i] = array[i] - avg;
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
            int len = array.Length, sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            double avg = (double)sum / len;
            int counter = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] < avg)
                {
                    counter++;
                }
            }
            indexes = new int[counter];
            int j = 0;
            for (int i = 0; i < len; i++)
            {
                if (array[i] < avg)
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
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int maxLen = 1;

            int current = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    current++;
                }
                else
                {
                    current = 1;
                }
                if (current > maxLen) maxLen = current;
            }

            current = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    current++;
                }
                else
                {
                    current = 1;
                }
                if (current > maxLen) maxLen = current;
            }

            count = maxLen;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 0; i < array.Length; i += 1)
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
            bool isEqual = true;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    isEqual = false;
                }
            }
            if (isEqual)
            {
                return null;
            }
            int max = int.MinValue, min = int.MaxValue;
            foreach (int i in array)
            {
                if (i > max)
                {
                    max = i;
                }
                if (i < min)
                {
                    min = i;
                }
            }
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / ((double)max - min);
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
                if (array[middle] == P)
                {
                    index = middle;
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
            if (b < 0)
            {
                return null;
            }
            if (a < 0 && c < 0)
            {
                return new int[] { };
            }
            int len = (c - a) / b + 1;
            array = new int[len];
            int j = -1, a2 = a;
            for (; a2 <= c; a2 += b)
            {
                array[++j] = a2;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int n = magazine.Length;
            int[] result;

            if (n <= 3)
            {
                result = new int[n];
                for (int i = 0; i < n; i++)
                {
                    result[i] = i;
                }
                return result;
            }

            long maxSum = 0;
            for (int i = 0; i < 3; i++)
            {
                maxSum += magazine[i];
            }

            long currentSum = maxSum;
            int bestStartIndex = 0;
            for (int i = 1; i <= n - 3; i++)
            {
                currentSum = currentSum - magazine[i - 1] + magazine[i + 2];
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    bestStartIndex = i;
                }
            }
            indexes = new int[] { bestStartIndex, bestStartIndex + 1, bestStartIndex + 2 };
            // end

            return indexes;
        }
    }
}