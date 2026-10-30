using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            int maxx = -9999999;
            int s = 0;
            int ind = 1000000;
            int m = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if ((m == -1) && (array[i] < 0))
                {
                    m = i;
                }

                if (i > ind)
                {
                    s += array[i];
                }
                
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    ind = i;
                    s = 0;
                }

                if ((i+1 == array.Length) && (m != -1))
                {
                    array[m] = s;
                }

            }

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            int ind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) ind = i;
            }

            if (ind == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length + 1];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    answer[j] = array[i];
                    j++;
                    if (i == ind)
                    {
                        answer[j] = P;
                        j++;
                    }
                }
            }

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            int minn = 9999999;
            int ind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minn)
                {
                    minn = array[i];
                    ind = i;
                }
            }

            if (ind == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length - 1];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != ind)
                    {
                        answer[j] = array[i];
                        j++;
                    }
                }
            }

            return answer;
        }
        public void Task4(double[] array)
        {

            double s = 0;
            for (int i = 0; i < array.Length; i++)
                s += array[i];

            s = s / array.Length;

            for (int i = 0; i < array.Length; i++)
                array[i] = array[i] - s;

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            double s = 0;
            for (int i = 0; i < array.Length; i++)
                s += array[i];

            s = s / array.Length;
            int c = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < s) c++;
            }

            indexes = new int[c];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < s)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            int maxx = 1;
            int c1 = 1;
            int c2 = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1]) c1++;
                else c1 = 1;

                if (array[i] <= array[i - 1]) c2++;
                else c2 = 1;

                if (c1 > maxx) maxx = c1;
                if (c2 > maxx) maxx = c2;
            }

            count = maxx;

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            answer = new int[array.Length * 2];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                j++;
                answer[j] = array[i];
                j++;
            }

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            int minn = array[0];
            int maxx = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minn) minn = array[i];
                if (array[i] > maxx) maxx = array[i];
            }

            if (minn == maxx)
            {
                normalized = null;
            }
            else
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (double)(array[i] - minn) / (maxx - minn);
                }
            }

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

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
            int l = 0;
            int r = array.Length - 1;

            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid - 1;
                }
            }

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            bool stop = false;
            int m = a;
            int count = 0;

            if (b < 0)
            {
                stop = true;
            }

            if (a > c && !stop)
            {
                array = new int[0];
                stop = true;
            }

            if (!stop)
            {
                int k = (c - a) / b + 1;
                array = new int[k];
                while (m <= c)
                {
                    array[count] = m;
                    count++;
                    m += b;
                }
            }

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                    indexes[i] = i;
            }
            else
            {
                int maxx = 0;
                int ind = 0;

                for (int i = 0; i <= magazine.Length - 3; i++)
                {
                    int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (s > maxx)
                    {
                        maxx = s;
                        ind = i;
                    }
                }

                indexes = new int[] { ind, ind + 1, ind + 2 };
            }

            return indexes;
        }
    }
}
