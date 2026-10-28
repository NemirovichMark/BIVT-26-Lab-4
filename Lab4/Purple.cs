namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double mx = array[0];
            int mxi = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (mx < array[i])
                {
                    mx = array[i];
                    mxi = i;
                }
            }
            s /= array.Length;
            for (int i = mxi + 1;  i < array.Length; i++)
            {
                array[i] = s;
            }
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            int e = 0, o = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) { e++; }
                else { o++; }
            }
            even = new int[e];
            odd = new int[o];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    e--;
                    even[e] = array[i];
                }
                else
                {
                    o--;
                    odd[o] = array[i];                    
                }
            }
            

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            double s = 0;
            for (int i = 0; i < array.Length; i++) { s+= array[i]; }
            s /= array.Length;
            int xd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[xd] - s) > Math.Abs(array[i] - s)) { xd = i; }
            }
            for (int i = 0; i <= xd; i++) { answer[i] = array[i]; }
            answer[xd + 1] = P;
            for (int i = xd + 2; i < answer.Length; i++) 
            { 
                answer[i] = array[i - 1]; 
            } 
            return answer;
        }
        public void Task4(int[] array)
        {
            int p = 0, m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    p++;
                }
                else
                {
                    m++;
                }
            }
            int[] plus = new int[p], minus = new int[m];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] >= 0)
                {
                    p--;
                    plus[p] = array[i];
                }
                else
                {
                    m--;
                    minus[m] = array[i];
                }
            }
            int c = 0;
            for (int i = 0; i < plus.Length; i++)
            {
                array[c] = plus[i];
                c++;
            }
            for (int i = 0; i < minus.Length; i++)
            {
                array[c] = minus[i];
                c++;
            }

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            k--;
            if (k > A.Length) return A;
            int[] answer = new int[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[i + k + 1] = B[i];
            }
            if (k == A.Length - 1)
            {
                return answer;
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                answer[i + B.Length] = A[i];
            }

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = new int[A.Length], dif = new int[A.Length];
            if (A == null || B == null || A.Length != B.Length)
            {
                return (null, null);
            }
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = new double[array.Length];
            double mx = array[0], mn = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                mx = Math.Max(mx, array[i]);
                mn = Math.Min(mn, array[i]);
            }
            if (mn == mx) return null;
            
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = -1 + (2 * (array[i] - mn) / (mx - mn));
            }
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = [..A, ..B];
            int n = C.Length;
            int i = 1;
            while (i < n)
            {
                if (i == 0 || C[i] <= C[i - 1])
                {
                    i++;
                }
                else 
                {
                    (C[i], C[i - 1]) = (C[i - 1], C[i]);
                    i--;
                }
            }
            return C;
        }
        public void Task9(int[] array)
        {
            int mxi = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[mxi])
                {
                    mxi = i;
                }
            }
            int c;
            for (; mxi > 0; mxi--)
            {
                c = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = c;
            }
        }
        public void Task10(int[] array, int N)
        {
            if (N <= 0 || N >= array.Length) N = 1;
            N--;
            int[] rofl = new int[N];
            for (int i = N - 1, j = 0; i >= 0; i--, j++)
            {
                rofl[j] = array[i];
            }
            for (int i = N + 1, j = 0; i < array.Length && j < rofl.Length; i++, j++)
            {
                array[i] = rofl[j]; 
            }
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            if (a > b) return (null, null);
            if (n < 3) return (new double[0], new double[0]); // это такой рофл
            if (a == b) return (null, null);
            double h = (b - a) / (n - 1);
            double[] X = new double[n], Y = new double[n];
            double[] Xtemp = new double[n], Ytemp = new double[n];
            double[] Xext = null, Yext = null;

            for (int i = 0; i < n; i++)
            {
                double xd = a + i * h;
                X[i] = xd;
                Y[i] = Math.Cos(xd) + xd * Math.Sin(xd);
            }
            int c = 0;
            for (int i = 1; i < X.Length - 1; i++)
            {                
                if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1] || Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
                {
                    Ytemp[c] = Y[i];
                    Xtemp[c] = X[i];
                    c++;
                }
            }
            Xext = new double[c];
            Yext = new double[c];
            for (int i = 0; i < c; i++) Xext[i] = Xtemp[i];
            for (int i = 0; i < c; i++) Yext[i] = Ytemp[i];

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = new double[raw.Length], dim = null;
            int b = 0, d = 0;
            
            double s = 0;
            for (int i = 0; i < raw.Length; i++) // среднее от сырого
            {
                s += raw[i];
            }
            s /= raw.Length;
            
            double[] xd = new double[raw.Length]; // единый переходной массив со светлыми и тусклыми
            
            for (int i = 0; i < raw.Length; i++) // светлые
            {
                if (raw[i] > 2 * s)
                {
                    xd[b] = raw[i];
                    b++;
                }
            }
            
            for (int i = 0; i < raw.Length; i++) // тусклые
            { 
                if (raw[i] < s / 2)
                {
                    xd[b + d] = raw[i];
                    d++;
                }
                if (raw[i] <= 2 * s && raw[i] >= s / 2) normal[i] = raw[i];
            }
            
            int[] bi = new int[b]; // индексы светлых и тусклых и их поиск
            int[] di = new int[d];
            for (int i = 0, bb = 0, dd = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * s)
                {
                    bi[bb] = i;
                    bb++;
                }
                if (raw[i] < s / 2)
                {
                    di[dd] = i;
                    dd++;
                }
            }
            
            bright = new double[b];
            dim = new double[d];
            for (int i = 0; i < b + d; i++)
            {
                if (i < b)
                {
                    bright[i] = xd[i];
                }
                else
                {
                    dim[i - b] = xd[i];
                }
            }
            
            double sr = 0;
            for (int i = 0; i < normal.Length; i++) sr += normal[i]; // среднее отчищенного массива
            sr /= normal.Length - b - d;
            
            for (int i = 0; i < b; i++)
            {
                normal[bi[i]] = (sr + bright[i]) / 2; // замена нуликов из нормала на полусуммы
            }
            for (int i = 0; i < d; i++)
            {
                normal[di[i]] = (sr + dim[i]) / 2;
            }
            
            int n = normal.Length;
            int j = 1;
            while (j < n)
            {
                if (j == 0 || normal[j] <= normal[j - 1])
                {
                    j++;
                }
                else
                {
                    (normal[j], normal[j - 1]) = (normal[j - 1], normal[j]); // гномик сортит
                    j--;
                }
            }
            
            return (bright, normal, dim);
        }
    }
 }
