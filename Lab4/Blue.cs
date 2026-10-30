using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int m = 0;
            for (int i = 1; i < array.Length; i++) if (array[i] > array[m]) m = i;
            int s = 0;
            for (int i = m + 1; i < array.Length; i++) s += array[i];
            int answer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = s;
                    answer = array[i];
                    break;
                }

            }

            // end

        }   
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            //code here
            int l = -1;
            for (int i = 0; i < array.Length; i++) if (array[i] > 0) l = i;
            if (l == -1) return array;
            int[] r = new int[array.Length + 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                r[j++] = array[i];
                if (i == l) r[j++] = P;
            }
            return r;
            //end


            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            //code here
            int m = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (m == -1 || array[i] < array[m]) m = i;
                }
            }
            if (m == -1) return array;
            int[] r = new int[array.Length - 1];
            int j = 0;
            for (int i = 0; i < array.Length; i++) if (i != m) r[j++] = array[i];
            return r;
            //end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                double s = 0;
                for (int i = 0; i < array.Length; i++) s += array[i];
                double a = s / array.Length;
                for (int i = 0; i < array.Length; i++) array[i] -= a;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A != null && B != null && A.Length == B.Length && A.Length > 0)
            {
                int s = 0;
                for (int i = 0; i < A.Length; i++) s += A[i] * B[i];
                sum = s;
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double s = 0;
            for (int i = 0; i < array.Length; i++) s += array[i];
            double a = s / array.Length;
            int c = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < a) c++;
            int[] r = new int[c];
            int j = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < a) r[j++] = i;
            return r;
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array != null && array.Length > 0)
            {
                int m = 1, x = 1, y = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] >= array[i - 1]) x++; else x = 1;
                    if (array[i] <= array[i - 1]) y++; else y = 1;
                    if (x > m) m = x;
                    if (y > m) m = y;
                }
                count = m;
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array != null)
            {
                answer = new int[array.Length * 2];
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    answer[j++] = array[i];
                    answer[j++] = array[i];
                }
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double min = array[0], max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            if (min == max) return null;
            double[] r = new double[array.Length];
            for (int i = 0; i < array.Length; i++) r[i] = (array[i] - min) / (max - min);
            return r;
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                index = 0;
            }
            else
            {
                index = -1;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            int t = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = t;
                        }
                    }
                }
                int l = 0, h = array.Length - 1;
                while (l <= h)
                {
                    int m = l + (h - l) / 2;
                    if (array[m] == P)
                    {
                        index = m;
                        break;
                    }
                    else if (array[m] < P)
                    {
                        l = m + 1;
                    }
                    else
                    {
                        h = m - 1;
                    }
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
                int n = 0;
                for (long v = a; v <= c; v += b) n++;
                array = new int[n];
                int j = 0;
                for (long v = a; v <= c; v += b) array[j++] = (int)v;
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
                int[] r = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++) r[i] = i;
                return r;
            }
            int m = -1, x = 0;
            for (int i = 0; i <= magazine.Length - 3; i++)
            {
                int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                if (s > m) { m = s; x = i; }
            }
            return new int[] { x, x + 1, x + 2 };
            // end

            return indexes;
        }
    }
}
