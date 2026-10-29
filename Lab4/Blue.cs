using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

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
                sum = sum + array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
        }

        public int[] Task2(int[] array, int P)
        {
            if (array == null)
            {
                return new int[0];
            }

            int last = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    last = i;
                }
            }

            if (last == -1)
            {
                return (int[])array.Clone();
            }

            int[] answer = new int[array.Length + 1];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                j = j + 1;

                if (i == last)
                {
                    answer[j] = P;
                    j = j + 1;
                }
            }

            return answer;
        }

        public int[] Task3(int[] array)
        {
            if (array == null)
            {
                return new int[0];
            }

            int mini = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (mini == -1 || array[i] < array[mini])
                    {
                        mini = i;
                    }
                }
            }

            if (mini == -1)
            {
                return (int[])array.Clone();
            }

            int[] answer = new int[array.Length - 1];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != mini)
                {
                    answer[j] = array[i];
                    j = j + 1;
                }
            }

            return answer;
        }

        public void Task4(double[] array)
        {
            if (array == null || array.Length == 0)
            {
                return;
            }

            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            double avg = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - avg;
            }
        }

        public int Task5(int[] A, int[] B)
        {
            if (A == null || B == null || A.Length != B.Length)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sum = sum + A[i] * B[i];
            }

            return sum;
        }

        public int[] Task6(int[] array)
        {
            if (array == null)
            {
                return new int[0];
            }

            if (array.Length == 0)
            {
                return new int[0];
            }

            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            double avg = sum / array.Length;
            int length = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    length = length + 1;
                }
            }

            int[] inx = new int[length];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    inx[j] = i;
                    j = j + 1;
                }
            }

            return inx;
        }

        public int Task7(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            int up = 1;
            int dwn = 1;
            int lng = 1;

            for (int i = 1; i < array.Length; i++)
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
                    dwn = dwn + 1;
                }
                else
                {
                    dwn = 1;
                }

                if (up > lng)
                {
                    lng = up;
                }

                if (dwn > lng)
                {
                    lng = dwn;
                }
            }

            return lng;
        }

        public int[] Task8(int[] array)
        {
            if (array == null)
            {
                return new int[0];
            }

            int[] answer = new int[array.Length * 2];

            for (int i = 0; i < array.Length; i++)
            {
                answer[2 * i] = array[i];
                answer[2 * i + 1] = array[i];
            }

            return answer;
        }

        public double[] Task9(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                return null;
            }

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

            double[] a = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                a[i] = ((double)array[i] - min) / ((double)max - min);
            }

            return a;
        }

        public int Task10(int[] array, int P)
        {
            if (array == null)
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
            int index = -1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }

                if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return index;
        }

        public int[] Task11(int a, int b, int c)
        {
            if (b <= 0)
            {
                return null;
            }

            if (a > c)
            {
                return new int[0];
            }

            int length = (c - a) / b + 1;
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = a + i * b;
            }

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            if (magazine == null)
            {
                return new int[0];
            }

            int n = magazine.Length;

            if (n == 0)
            {
                return new int[0];
            }

            if (n < 3)
            {
                int[] inx = new int[n];

                for (int i = 0; i < n; i++)
                {
                    inx[i] = i;
                }

                return inx;
            }

            int start1 = 0;
            int sum1 = magazine[0] + magazine[1] + magazine[2];
            int sum = sum1;

            for (int i = 1; i <= n - 3; i++)
            {
                sum = sum - magazine[i - 1] + magazine[i + 2];

                if (sum > sum1)
                {
                    sum1 = sum;
                    start1 = i;
                }
            }

            int[] answer = new int[3];
            answer[0] = start1;
            answer[1] = start1 + 1;
            answer[2] = start1 + 2;

            return answer;
        }
    }
}
