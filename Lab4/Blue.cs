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
            {
                if (array[i] > array[maxIndex])
                {
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
            int last = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) last = i;
            }

            if (last == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++) answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i <= last; i++) answer[i] = array[i];
                answer[last + 1] = P;
                for (int i = last + 1; i < array.Length; i++) answer[i + 1] = array[i];
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
                if (array[i] > 0 && (minIndex == -1 || array[i] < array[minIndex]))
                {
                    minIndex = i;
                }
            }

            if (minIndex == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++) answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length - 1];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i != minIndex)
                    {
                        answer[k] = array[i];
                        k++;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here

            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = sum / array.Length;
            for (int i = 0; i < array.Length; i++) array[i] -= avg;

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here

            if (A.Length != B.Length) return 0;
            for (int i = 0; i < A.Length; i++) sum += A[i] * B[i];

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            double total = 0;
            for (int i = 0; i < array.Length; i++) total += array[i];
            double avg = total / array.Length;

            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg) cnt++;
            }

            indexes = new int[cnt];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    indexes[k] = i;
                    k++;
                }
            }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            count = 1;
            int inc = 1, dec = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1]) inc++; else inc = 1;
                if (array[i] <= array[i - 1]) dec++; else dec = 1;
                if (inc > count) count = inc;
                if (dec > count) count = dec;
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

            int min = array[0], max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max) return null;

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
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
            index = -1;
            int lo = 0, hi = array.Length - 1;
            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P) lo = mid + 1;
                else hi = mid - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            if (b <= 0) return null;
            if (a > c) return new int[0];

            int cnt = (c - a) / b + 1;
            array = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                array[i] = a + i * b;
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
                for (int i = 0; i < magazine.Length; i++) indexes[i] = i;
                return indexes;
            }

            int bestStart = 0;
            int bestSum = magazine[0] + magazine[1] + magazine[2];
            for (int i = 1; i + 2 < magazine.Length; i++)
            {
                int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                if (s > bestSum)
                {
                    bestSum = s;
                    bestStart = i;
                }
            }
            indexes = new int[] { bestStart, bestStart + 1, bestStart + 2 };

            // end

            return indexes;
        }
    }
}