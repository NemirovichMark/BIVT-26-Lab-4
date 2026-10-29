using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int n = array.Length;
            int maxIndex = 0;
            int negIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    negIndex = i;
                    break;
                }
            }

            if (negIndex == -1) return;

            int s = 0;

            for (int i = maxIndex + 1; i < n; i++)
            {
                s += array[i];
            }

            array[negIndex] = s;
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            int n = array.Length;
            int posIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    posIndex = i;
                }
            }

            if (posIndex == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n + 1];
                for (int i = 0; i <= posIndex; i++)
                {
                    answer[i] = array[i];
                }

                answer[posIndex + 1] = P;

                for (int i = posIndex + 1; i < n; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            
            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            int n = array.Length;
            int minIndex = -1;
            
            for (int i = 0; i < n; i++)
            {
                if ((array[i] > 0) && (minIndex == -1 || array[i] < array[minIndex]))
                {
                    minIndex = i;
                }
            }

            if (minIndex == -1)
            {
                answer = new int[n];
                for (int  i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n - 1];
                for (int i = 0; i < minIndex; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = minIndex + 1; i < n; i++)
                {
                    answer[i-1] = array[i];
                }
            }

            return answer;
        }
        public void Task4(double[] array)
        {
            double s = 0;
            double n = array.Length;

            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }

            double avg = s / n;

            for (int i = 0; i < n; i++)
            {
                array[i] -= avg;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            int lenA = A.Length;
            int lenB = B.Length;

            if (lenA != lenB) return 0;

            for (int i = 0; i < lenA; i++)
            {
                sum += A[i] * B[i];
            }
            
            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;
            double s = 0;
            double n = array.Length;

            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }
            double avg = s / n;

            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < avg)
                {
                    c++;
                }
            }

            indexes = new int[c];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < avg)
                {
                    indexes[k] = i;
                    k++;
                }
            }

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;
            int n = array.Length;
            if (n == 0) return 0;
            if (n == 1) return 1;
            int dec = 1;
            int inc = 1;
            int max = 0;

            for (int i = 1; i < n; i++)
            {
                if (array[i-1] <= array[i])
                {
                    inc++;
                }
                else
                {
                    inc = 1;
                }

                if (array[i - 1] >= array[i])
                {
                    dec++;
                }
                else
                {
                    dec = 1;
                }

                if (inc > max) max = inc;
                if (dec > max) max = dec;
            }

            count = max;
            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;
            int n = array.Length;
            answer = new int[n*2];

            for (int i = 0; i < n; i++)
            {
                answer[i*2] = array[i];
                answer[i*2+1] = array[i];
            }
            
            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;
            int n = array.Length;
            if (n == 0) return null;

            bool flag = true;
            for (int i = 1; i < n; i++)
            {
                if (array[i] != array[0])
                {
                    flag = false;
                    break;
                }
            }
            if (flag) return null;

            int min = array[0], max = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            normalized = new double[n];
            for (int i = 0; i < n; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }
            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = -1;

            int i = 1, n = array.Length;
            while (i < n)
            {
                if (i == 0 || array[i] >= array[i - 1])
                    i++;
                else
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    i--;
                }
            }

            int low = 0, high = array.Length - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;
            if (b < 0) return null;
            int k = 0;
            if (a <= c) { k = (c - a) / b + 1; }

            array = new int[k];

            for (int i = 0; i < k; i++)
            {
                array[i] = a + b * i;
            }

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;
            int n = magazine.Length;

            if (n < 3)
            {
                indexes = new int[n];
                for (int i = 0;i < n;i++)
                {
                    indexes[i] = i;
                }
                return indexes;
            }

            int maxS = int.MinValue;
            int index = 0;
            for (int i = 2; i < n; i++)
            {
                int s = (magazine[i] + magazine[i - 1] + magazine[i - 2]);
                if (s > maxS)
                {
                    maxS = s;
                    index = i-2;
                }
            }

            indexes = new int[] { index, index + 1, index + 2 };
            return indexes;
        }
    }
}
