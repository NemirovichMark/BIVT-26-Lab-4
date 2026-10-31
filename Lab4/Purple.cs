using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double maxzn = array[0];
            int maxind = 0;
            double sr = 0;
            for (int i = 0;i < array.Length;i++)
            {
                sr += array[i];
                if (maxzn < array[i])
                {
                    maxzn = array[i];
                    maxind = i;
                }
            }
            sr /= array.Length;
            for (int i = maxind+1; i < array.Length; i++)
                array[i] = sr;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int m1 = 0;
            int m2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    m1++;
                }
                else
                {
                    m2++;
                }
            }
            // добавляем нужное кол-во ячеек
            even = new int[m1];

            odd = new int[m2];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    m1--;

                    even[m1] = array[i];
                }
                else
                {
                    m2--;

                    odd[m2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double sum = 0;
            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr = sum / array.Length;

            int cls = 0;
            double difmin = Math.Abs(array[0] - sr);

            for (int i = 1; i < array.Length; i++)
            {
                double dif = Math.Abs(array[i] - sr);
                if (dif < difmin)
                {
                    difmin = dif;
                    cls = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                if (i <= cls)
                {
                    answer[i] = array[i];
                }
                else if (i == cls + 1)
                {
                    answer[i] = P;
                }
                else
                {
                    answer[i] = array[i - 1];
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int ind = 0;
            int[] x = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    x[ind] = array[i];
                    ind++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    x[ind] = array[i];
                    ind++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = x[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > A.Length)
                answer = A;
            else
            {
                k--;
                answer = new int[A.Length + B.Length];
                int bind = 0;
                int aind = 0;
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i > k && bind < B.Length)
                    {
                        answer[i] = B[bind];
                        bind++;
                    }
                    else
                    {
                        answer[i] = A[aind];
                        aind++;
                    }
                }
            }
                // end

                return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length)
                return (sum, dif);
            sum = new int[A.Length];
            dif = new int[B.Length];
            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int max = -1000000;
            int min = 1000000;

            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);

                min = Math.Min(min, array[i]);
            }

            if (min - max == 0) return normalized;

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (2*(array[i] - min)/(double)(max - min) - 1);
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int i1 = 1;
            int i2 = 1;
            int s = 0;
            int a = A.Length;

            while (i1 < a)
            {
                if ((i1 == 0) || (A[i1] <= A[i1 - 1]))
                    i1++;
                else
                {
                    (A[i1], A[i1 - 1]) = (A[i1 - 1], A[i1]);
                    i1--;
                }
            }
            int b = B.Length;
            while (i2 < b)
            {
                if (i2 == 0 || B[i2] <= B[i2 - 1])
                    i2++;
                else
                {
                    (B[i2], B[i2 - 1]) = (B[i2 - 1], B[i2]);
                    i2--;
                }
            }
            i1 = 0;
            i2 = 0;
            while (i1 < A.Length && i2 < B.Length)
            {
                if (A[i1] >= B[i2])
                    C[s++] = A[i1++];
                else
                    C[s++] = B[i2++];
            }
            while (i1 < A.Length)
                C[s++] = A[i1++];
            while (i2 < B.Length)
                C[s++] = B[i2++];

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int maxim = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxim])
                    maxim = i;
            }
            int a;
            for (int mx = maxim; mx > 0; mx--)
            {
                a = array[array.Length - 1];
                for (int i2 = array.Length - 1; i2 > 0; i2--)
                    array[i2] = array[i2 - 1];
                array[0] = a;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N <= 0 || N >= array.Length)
                N = 1;
            N = N - 1;
            int[] array2 = new int[N];
            int i2 = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                array2[i2] = array[i];
                i2++;
            }
            int i3 = 0;
            for (int i = N + 1; i < array.Length && i3 < array2.Length; i++)
            {
                array[i] = array2[i3];
                i3++;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a == b && n > 1 || a > b) 
                return (Xext, Yext);
            double x1 = Math.Min(a, b);
            X = new double[n];
            Y = new double[n];

            int cnt = 0;
            double step = (b - a) / (n - 1);
            for (int i = 0; i <= n - 1; i++)
            {
                X[i] = x1;
                Y[i] = Math.Cos(x1) + x1 * Math.Sin(x1);
                x1 += (b - a) / (n - 1);
            }
            for (int i = 1; i < Y.Length - 1; i++)
            {
                if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                {
                    cnt++;
                }
            }
            Xext = new double[cnt];
            Yext = new double[cnt];
            int j = 0;
            for (int i = 1; i < Y.Length - 1; i++)
            {
                if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                {
                    Yext[j] = Y[i];
                    Xext[j] = X[i];
                    j++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double avr = 0;
            double norm = 0;
            double sum = 0;
            int cntbr = 0;
            int cntdim = 0;
            if (raw == null)
                return (null, null, null);
            for (int i = 0; i < raw.Length; i++)
                sum += raw[i];
            avr = sum / raw.Length;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avr)
                    cntbr++;
                if (raw[i] < avr / 2)
                    cntdim++;
            }
            bright = new double[cntbr];
            dim = new double[cntdim];
            normal = new double[raw.Length];
            sum = 0;
            for (int i = 0, j = 0, k = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avr)
                    bright[j++] = raw[i];
                else if (raw[i] < avr / 2)
                    dim[k++] = raw[i];
                else
                    sum += raw[i];
            }
            norm = sum / (raw.Length - cntdim - cntbr);
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avr || raw[i] < avr / 2)
                    normal[i] = (raw[i] + norm) / 2;
                else
                    normal[i] = raw[i];
            }
            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
