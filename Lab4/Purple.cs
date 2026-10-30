using System.Data;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text.Json.Serialization.Metadata;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double max = array[0];
            int max_i = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                    max_i = i;
                }
            }
            double sr = sum / array.Length;
            for (int i = max_i + 1; i < array.Length; i++)
            {
                array[i] = sr;
            }
            // end


        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int len_ev = (array.Length + 1) / 2;
            int len_od = (array.Length) / 2;

            even = new int[len_ev];
            odd = new int[len_od];

            int i_ev = 0;
            int i_od = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i_ev] = array[i];
                    i_ev++;
                }
                else
                {
                    odd[i_od] = array[i];
                    i_od++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return answer;
            }

            double s = 0;

            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }

            double sr = s / array.Length;

            double r = Math.Abs(array[0] - sr);
            int i_r = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < r)
                {
                    r = Math.Abs(array[i] - sr);
                    i_r = i;
                }
            }

            answer = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                answer[i] = array[i];
            }

            for (int i = array.Length; i > i_r + 1; i--)
            {
                answer[i] = answer[i - 1];
            }

            answer[i_r + 1] = P;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            //code here
            if (array == null || array.Length == 0)
            {
                return;
            }

            int n = array.Length;
            int len_p = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0) len_p++;
            }
            int len_ne = n - len_p;

            int[] p = new int[len_p];
            int[] ne = new int[len_ne];
            int i_p = 0, i_ne = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    p[i_p] = array[i];
                    i_p++;
                }
                else
                {
                    ne[i_ne] = array[i];
                    i_ne++;
                }
            }

            for (int i = 0; i < len_p; i++)
            {
                array[i] = p[i];
            }
            for (int i = 0; i < len_ne; i++)
            {
                array[i + len_p] = ne[i];
            }

            //if (array == null || array.Length == 0)
            //{
            //    return;
            //}

            //int n = array.Length;
            //int ind = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    if (array[i] >= 0)
            //    {
            //        if (i != ind)
            //        {
            //            int temp = array[ind];
            //            array[ind] = array[i];
            //            array[i] = temp;
            //        }
            //        ind++;
            //    }
            //}
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A == null || B == null || k < 0)
            {
                return answer;
            }

            int n1 = A.Length;
            int n2 = B.Length;

            if (k > n1)
            {
                answer = new int[n1];

                for (int i = 0; i < n1; i++)
                {
                    answer[i] = A[i];
                }

                return answer;
            }

            answer = new int[n1 + n2];

            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }

            for (int i = 0; i < n2; i++)
            {
                answer[k + i] = B[i];
            }

            for (int i = k; i < n1; i++)
            {
                answer[i + n2] = A[i];
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null)
            {
                return (null, null);
            }

            if (A.Length != B.Length) { return (null, null); }

            int n = A.Length;
            sum = new int[n];
            dif = new int[n];
            for (int i = 0; i < n; i++)
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
            if (array == null || array.Length == 0)
            {
                return (null);
            }

            int n = array.Length;
            int mi = array[0], ma = array[0];
            for (int i = 1; i < n; i++)
            {
                if (array[i] > ma)
                {
                    ma = array[i];
                }
                if (array[i] < mi)
                {
                    mi = array[i];
                }
            }

            if (ma == mi)
            {
                return null;
            }

            normalized = new double[n];

            double di = (double)(ma - mi);
            double k = 2.0 / di;
            for (int i = 0; i < n; i++)
            {
                normalized[i] = (array[i] - mi) * k - 1;
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null || B == null) return null;

            int n1 = A.Length, n2 = B.Length;

            for (int i = 0; i < n1 - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < n1 - 1 - i; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        int t = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = t;
                        f = true;
                    }
                }
                if (!f) break;
          
            }
            for (int i = 0; i < n2 - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < n2 - 1 - i; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int t = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = t;
                        f = true;
                    }
                }
                if (!f)
                {
                    break;
                }
            }

            C = new int[n1 + n2];
            for (int i = 0; i < n1; i++)
            {
                C[i] = A[i];
            }
            for (int i = 0; i < n2; i++)
            {
                C[i + n1] = B[i];
            }

            for (int i = 0; i < n1 + n2 - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < n1 + n2 - 1 - i; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        int t = C[j];
                        C[j] = C[j + 1];
                        C[j + 1] = t;
                        f = true;
                    }
                }
                if (!f)
                {
                    break;
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }

            int max = array[0];
            int i_max = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    i_max = i;
                }
            }

            int[] temp = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                temp[(i + i_max) % array.Length] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (array == null || N < 1 || N > array.Length)
            {
                return;
            }

            int k = N - 2;
            int j = N;

            while (k >= 0 && j < array.Length)
            {
                array[j] = array[k];
                k--;
                j++;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n == 1)
            {
                return (new double[0], new double[0]);
            }

            if (n <= 0 || a >= b)
            {
                return (null, null);
            }

            X = new double[n];
            Y = new double[n];

            double h = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * h;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int c = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    c++;
                }
            }

            Xext = new double[c];
            Yext = new double[c];

            int j = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[j] = X[i];
                    Yext[j] = Y[i];
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
            if (raw == null)
            {
                return (null, null, null);
            }

            if (raw.Length == 0)
            {
                return (new double[0], new double[0], new double[0]);
            }

            double sum = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }

            double avg = sum / raw.Length;

            int c_bright = 0;
            int c_dim = 0;
            int c_normal = 0;

            double sum_normal = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg)
                {
                    c_bright++;
                }
                else if (raw[i] < avg / 2)
                {
                    c_dim++;
                }
                else
                {
                    c_normal++;
                    sum_normal += raw[i];
                }
            }

            bright = new double[c_bright];
            dim = new double[c_dim];
            normal = new double[raw.Length];

            double avg_normal = 0;

            if (c_normal > 0)
            {
                avg_normal = sum_normal / c_normal;
            }

            int j = 0;
            int k = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avg)
                {
                    bright[j] = raw[i];
                    j++;

                    normal[i] = (raw[i] + avg_normal) / 2;
                }
                else if (raw[i] < avg / 2)
                {
                    dim[k] = raw[i];
                    k++;

                    normal[i] = (raw[i] + avg_normal) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j2 = 0; j2 < normal.Length - 1 - i; j2++)
                {
                    if (normal[j2] < normal[j2 + 1])
                    {
                        double temp = normal[j2];
                        normal[j2] = normal[j2 + 1];
                        normal[j2 + 1] = temp;
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
