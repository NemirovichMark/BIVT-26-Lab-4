using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s = s + array[i];
            }
            double sr = s / array.Length;

            double max = array[0];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array.Length % 2 == 0)
            {
                int[] z = new int[array.Length / 2];
                int[] p = new int[array.Length / 2];
                even = z;
                odd = p;
            }
            else
            {
                int[] z = new int[(array.Length / 2) + 1];
                int[] p = new int[array.Length / 2];
                even = z;
                odd = p;
            }
            int k = 0;
            for (int i = 0; (i + 2) <= array.Length + 1; i += 2)
            {
                even[k] = array[i];
                k += 1;
            }
            int m = 0;
            for (int i = 1; (i + 2) <= array.Length + 1; i += 2)
            {
                            odd[m] = array[i];
                m += 1;
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int[] z = new int[array.Length + 1];
            double med = 0;
            for (int i = 0; i < array.Length; i++)
            {
                med += array[i];
            }
            med /= array.Length;
            double clos = 100000000000;
            int u = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - med) < clos)
                {
                    clos = Math.Abs(array[i] - med);
                    u = i + 1;
                }
            }
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i < u)
                {
                    z[i] = array[i];
                }
                else if (i == u)
                {

                    z[i] = P;
                }

                else if (i > u)
                {
                    z[i] = array[i - 1];
                }
            }
            answer = z;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] z = new int[array.Length];
            int u = 0;
            for (int i = 0; i + 1 <= array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    z[u] = array[i];
                    u += 1;
                }
            }
            for (int i = 0; i + 1 <= array.Length; i++)
            {
                if (array[i] < 0)
                {
                    z[u] = array[i];
                    u += 1;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = z[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < 0 || k > A.Length)
            {
                answer = A;
            }
            else
            {
                int[] z = new int[A.Length + B.Length];
                int c = 0;
                for (int i = 0; i < k; i++)
                {
                    z[c] = A[i];
                    c = c + 1;
                }
                for (int j = 0; j < B.Length; j++)
                {
                    z[c] = B[j];
                    c = c + 1;
                }
                for (int m = k; m < A.Length; m++)
                {
                    z[c] = A[m];
                    c = c + 1;
                }
                answer = z;
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                int[] z = new int[A.Length];
                int[] z1 = new int[B.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    z[i] = A[i] + B[i];
                    z1[i] = A[i] - B[i];
                }
                sum = z;
                dif = z1;
            }
            else
            {
                sum = null;
                dif = null;
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            double ma = -1000000;
            double mn = 10000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > ma)
                {
                    ma = array[i];
                }
                if (array[i] < mn)
                {
                    mn = array[i];
                }
            }
            if (mn == ma)
            {
                normalized = null;
            }
            else
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2 * (array[i] - mn) / (ma - mn) - 1;
                }
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - i - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }
            int[] z = new int [A.Length + B.Length];
            for (int i = 0; i < A.Length;i++)
            {
                z[i] = A[i];
            }
            for (int i = A.Length; i < z.Length; i++)
            {
                z[i] = B[i- A.Length];
            }
            for (int i = 0; i < z.Length;i++)
            {
                for (int j = 0;j < z.Length-i -1; j++)
                {
                    if (z[j] < z[j + 1])
                    {
                        int f = z[j];
                        z[j] = z[j + 1];
                        z[j + 1] = f;    
                    }
                }
            }
            C = z;
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = -10000;
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                  {
                        mx = array[i];
                        ind = i;

                  }
            }
            int[] z = new int[array.Length + ind];
            for (int i = ind; i < z.Length;i++)
            {
                z[i] = array[i - ind]; 
            }
            for (int i = array.Length; i< z.Length;i++)
            {
                z[i - array.Length] = z[i];
            }
            for (int i = 0; i < array.Length;i++)
            {
                array[i] = z[i];
            }
                // end

         }
        public void Task10(int[] array, int N)
        {

            // code here
            int ind = 0;
            int ind2 = 0;
            int z = N - 2;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i == N - 1)
                {
                    ind = i;
                }
                if (i > N - 1)
                {
                    ind2++;
                }
            }
            if (ind > ind2)
            {
                for (int i = N; i < (N + ind2); i++)
                {
                    array[i] = array[z];
                    z--;
                }
            }
            else
            {
                {
                    for (int i = N; i < ind + N; i++)
                    {
                        array[i] = array[z];
                        z--;
                    }
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n <= 0 || a > b || (a == b && n > 1))
            {
                return (Xext, Yext);
            }
            X = new double[n];
            Y = new double[n];
            double step = 0;
            if (n > 1)
            {
                step = (b - a) / (n - 1);
            }

            for (int i = 0; i < n; i++)
            {
                double x = a + step * i;
                X[i] = x;
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
            }
            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                {
                    k++;
                }
                else if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    k++;
                }
            }
            Xext = new double[k];
            Yext = new double[k];
            int z = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                {
                    Xext[z] = X[i];
                    Yext[z] = Y[i];
                    z++;
                }
                else if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    Xext[z] = X[i];
                    Yext[z] = Y[i];
                    z++;
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
                return (bright, normal, dim);
            }

            if (raw.Length == 0)
            {
                bright = new double[0];
                normal = new double[0];
                dim = new double[0];
                return (bright, normal, dim);
            }

            double s = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                s += raw[i];
            }
            double sr = s / raw.Length;

            int k1 = 0;
            int k2 = 0;
            int k3 = 0;
            double s2 = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > sr * 2)
                {
                    k1++;
                }
                else if (raw[i] < sr / 2)
                {
                    k2++;
                }
                else
                {
                    s2 += raw[i];
                    k3++;
                }
            }

            bright = new double[k1];
            dim = new double[k2];
            normal = new double[raw.Length];

            double sr2 = 0;
            if (k3 > 0)
            {
                sr2 = s2 / k3;
            }

            int z1 = 0;
            int z2 = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > sr * 2)
                {
                    bright[z1] = raw[i];
                    z1++;
                    normal[i] = (sr2 + raw[i]) / 2;
                }
                else if (raw[i] < sr / 2)
                {
                    dim[z2] = raw[i];
                    z2++;
                    normal[i] = (sr2 + raw[i]) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - 1 - i; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        double t = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = t;
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
