namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -999999;
            double cnt = 0;
            double s = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cnt++;
                s += array[i];
                if (mx < array[i])
                {
                    mx = array[i];
                    index = i;

                }
            }
            double dl = s / cnt;
            for (int j = index + 1; j < array.Length; j++)
            {
                array[j] = dl;
            }
            return;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int cnt1 = (array.Length + 1) / 2;
            int cnt2 = array.Length / 2;
            even = new int[cnt1];
            odd = new int[cnt2];
            int eEn = 0;
            int oEn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[eEn++] = array[i];
                }
                else
                {
                    odd[oEn++] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length + 1];
            double s = 0;
            double cnt = 0;
            double dl = 0;
            double mn = 99999999;
            int inA = 0;
            int index = 0;
            int index2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                cnt++;
            }
            dl = s / cnt;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - dl) < mn)
                {
                    mn = Math.Abs(array[i] - dl);
                    index = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                answer[index2++] = array[i];
                if (i == index)
                {
                    answer[index2++] = P;
                }
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int p = 0;
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) p++;
                else m++;
            }
            int[] plus = new int[p];
            int[] mins = new int[m];
            int inp = 0;
            int inm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) plus[inp++] = array[i];
                else mins[inm++] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < p)
                {
                    array[i] = plus[i];
                }
                else
                {
                    array[i] = mins[i - p];
                }
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            // code here
            if (k > A.Length) return A;
            answer = new int[A.Length + B.Length];
            int st = 0;
            if (k > A.Length) k = A.Length;
            for (int i = 0; i < k; i++)
            {
                answer[st++] = A[i];
            }
            for (int j = 0; j < B.Length; j++)
            {
                answer[st++] = B[j];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[st++] = A[i];
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
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            else return (sum, dif);
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int mx = -99999999;
            int mn = 99999999;
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                mx = Math.Max(mx, array[i]);
                mn = Math.Min(mn, array[i]);
            }

            if (mx - mn == 0)
            {
                return null;
            }

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = -1 + 2 * ((array[i] - mn) / (double)(mx - mn));
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        int ch = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = ch;

                    }
                }
            }

            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int ch = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = ch;

                    }
                }
            }
            int cnA = 0, cnB = 0, cnC = 0;
            while (cnA < A.Length && cnB < B.Length)
            {
                if (A[cnA] >= B[cnB])
                {
                    C[cnC] = A[cnA];
                    cnA++;
                }
                else
                {
                    C[cnC] = B[cnB];
                    cnB++;
                }
                cnC++;
            }

            while (cnA < A.Length)
            {
                C[cnC] = A[cnA];
                cnA++;
                cnC++;
            }
            while (cnB < B.Length)
            {
                C[cnC] = B[cnB];
                cnB++;
                cnC++;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int index = 0;
            int mx = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (mx == array[i])
                {
                    index = i;
                    break;
                }
            }
            if (index == 0) return;
            int[] nwArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                nwArray[(i + index) % array.Length] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = nwArray[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N == 0) return;
            int minKolvo = Math.Min(N - 1, array.Length - N);
            for (int i = 0; i < minKolvo; i++)
            {
                array[N + i] = array[N-2- i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if ((a == b && n > 1) || a > b)
            {
                return (Xext, Yext);
            }
            X = new double[n];
            Y = new double[n];
            double xSchet = Math.Min(a, b);
            double shag = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                X[i] = xSchet;
                Y[i] = Math.Cos(xSchet) + xSchet * Math.Sin(xSchet);
                xSchet += shag;
            }
            int[] ext = new int[n];
            int cnt = 0;

            for (int i = 1; i < n - 1; i++)
            {
                bool isMaximum = Y[i] > Y[i - 1] && Y[i] > Y[i + 1];
                bool isMinimum = Y[i] < Y[i - 1] && Y[i] < Y[i + 1];

                if (isMaximum || isMinimum)
                {
                    ext[cnt] = i;
                    cnt++;
                }
            }
            Xext = new double[cnt];
            Yext = new double[cnt];

            for (int j = 0; j < cnt; j++)
            {
                int targetIndex = ext[j];
                Xext[j] = X[targetIndex];
                Yext[j] = Y[targetIndex];
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0, avg, favg;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            favg = sum / raw.Length;

            sum = 0;
            int bcnt = 0, ncnt = 0, dcnt = 0;

            int[] status = new int[raw.Length];

            for (int i = 0; i < raw.Length; i++)
            {
                double s = raw[i];
                if (s > 2 * favg)
                {
                    bcnt++;
                    status[i] = 1;
                }
                else if (s < favg / 2)
                {
                    dcnt++;
                    status[i] = 2;
                }
                else
                {
                    ncnt++;
                    sum += s;
                    status[i] = 0;
                }
            }
            avg = ncnt > 0 ? sum / ncnt : 0;
            bright = new double[bcnt];
            dim = new double[dcnt];
            normal = new double[raw.Length];

            int bidx = 0, didx = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                double s = raw[i];

                if (status[i] == 1)
                {
                    bright[bidx] = s;
                    bidx++;
                    s = (s + avg) / 2;
                }
                else if (status[i] == 2)
                {
                    dim[didx] = s;
                    didx++;
                    s = (s + avg) / 2;
                }

                normal[i] = s;
            }

            for (int gap = normal.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < normal.Length; i++)
                {
                    double key = normal[i];
                    int j;
                    for (j = i; j >= gap && normal[j - gap] < key; j -= gap)
                    {
                        normal[j] = normal[j - gap];
                    }
                    normal[j] = key;
                }
            }
            return (bright, normal, dim);
            // end
        }

    }
}
