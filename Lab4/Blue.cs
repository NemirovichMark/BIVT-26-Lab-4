using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int mx = 0;
            int ng = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[mx]) mx = i;
                if (ng == -1 && array[i] < 0) ng = i;
            }
            if (ng != -1)
            {
                int s = 0;
                for (int i = mx + 1; i < array.Length; i++)
                    s += array[i];
                array[ng] = s;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int lp = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0) lp = i;
            }
            if (lp == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[n + 1];
                for (int i = 0; i <= lp; i++)
                    answer[i] = array[i];
                answer[lp + 1] = P;
                for (int i = lp + 1; i < n; i++)
                    answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int mp = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0 && (mp == -1 || array[i] < array[mp])) mp = i;
            }
            if (mp == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[n - 1];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i != mp)
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
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
                avg += array[i];
            avg /= array.Length;
            for (int i = 0; i < array.Length; i++)
                array[i] -= avg;
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
            double avg = 0;
            for (int i = 0; i < array.Length; i++)
                avg += array[i];
            avg /= array.Length;
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
            int up = 1;
            int dn = 1;
            count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1]) up++;
                else up = 1;
                if (array[i] <= array[i - 1]) dn++;
                else dn = 1;
                if (up > count) count = up;
                if (dn > count) count = dn;
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
            int mn = array[0];
            int mx = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < mn) mn = array[i];
                if (array[i] > mx) mx = array[i];
            }
            if (mx != mn)
            {
                normalized = new double[array.Length];
                double d = (double)mx - mn;
                for (int i = 0; i < array.Length; i++)
                    normalized[i] = (array[i] - (double)mn) / d;
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
                int t = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > t)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = t;
            }
            int lo = 0;
            int hi = array.Length - 1;
            index = -1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                if (array[mid] < P) lo = mid + 1;
                else hi = mid - 1;
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
                    long cnt = ((long)c - a) / b + 1;
                    array = new int[cnt];
                    for (int i = 0; i < cnt; i++)
                        array[i] = a + i * b;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int n = magazine.Length;
            if (n < 3)
            {
                indexes = new int[n];
                for (int i = 0; i < n; i++)
                    indexes[i] = i;
            }
            else
            {
                int bst = 0;
                int bs = magazine[0] + magazine[1] + magazine[2];
                for (int i = 1; i + 2 < n; i++)
                {
                    int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (s > bs)
                    {
                        bs = s;
                        bst = i;
                    }
                }
                indexes = new int[] { bst, bst + 1, bst + 2 };
            }
            // end

            return indexes;
        }
    }
}
