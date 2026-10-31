using System;
using System.Collections.Generic;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            // code here
            double sumSquare = 0;
            foreach (int num in vector)
            {
                sumSquare += num * num;
            }
            length = Math.Sqrt(sumSquare);
            // end
            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            // code here
            int minBorder = Math.Min(P, Q);
            int maxBorder = Math.Max(P, Q);
            foreach (int num in array)
            {
                if (num > minBorder && num < maxBorder)
                {
                    count++;
                }
            }
            // end
            return count;
        }

        public void Task3(int[] array)
        {
            // code here
            if (array.Length <= 1)
                return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int startPos = maxIndex + 1;
            if (startPos >= array.Length)
                return;

            int minAfterIndex = startPos;
            for (int i = startPos; i < array.Length; i++)
            {
                if (array[i] < array[minAfterIndex])
                {
                    minAfterIndex = i;
                }
            }
            int temp = array[maxIndex];
            array[maxIndex] = array[minAfterIndex];
            array[minAfterIndex] = temp;
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            int maxValue = int.MinValue;
            int idx = -1;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    idx = i;
                }
            }
            if (idx != -1)
            {
                array[idx] = idx;
            }
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;
            // code here
            index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end
            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array.Length <= 1)
                return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            for (int i = 0; i < maxIndex - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end
        }

        public int[] Task7(int[] array)
        {
            int[] answer = null;
            // code here
            List<int> list = new List<int>();
            foreach (var num in array)
            {
                if (num >= 0)
                {
                    list.Add(num);
                }
            }
            answer = list.ToArray();
            // end
            return answer;
        }

        public void Task8(int[] array)
        {
            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end
        }

        public void Task9(int[] array)
        {
            // code here
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            // end
        }

        public int[] Task10(int[] A, int[] B)
        {
            int[] answer = null;
            // code here
            List<int> list = new List<int>();
            int i = 0;
            while (i < A.Length && i < B.Length)
            {
                list.Add(A[i]);
                list.Add(B[i]);
                i++;
            }
            while (i < A.Length)
            {
                list.Add(A[i]);
                i++;
            }
            while (i < B.Length)
            {
                list.Add(B[i]);
                i++;
            }
            answer = list.ToArray();
            // end
            return answer;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] answer = null;
            // code here
            if (a == b)
            {
                if (n == 1)
                {
                    answer = new double[] { a };
                }
                else
                {
                    answer = null;
                }
            }
            else
            {
                answer = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    answer[i] = a + step * i;
                }
            }
            // end
            return answer;
        }

        public int[] Task12(int[] raw)
        {
            int[] restored = null;
            // code here
            restored = (int[])raw.Clone();
            if (raw.Length < 3)
            {
                return restored;
            }
            for (int i = 1; i < raw.Length - 1; i++)
            {
                if (raw[i] == -1)
                {
                    int left = raw[i - 1];
                    int right = raw[i + 1];
                    if (left != -1 && right != -1)
                    {
                        restored[i] = (left + right) / 2;
                    }
                }
            }
            // end
            return restored;
        }
    }
}
