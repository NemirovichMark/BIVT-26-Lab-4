namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int maid = 0;
            double max = array[0];
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max  = array[i];
                    maid = i;
                }
            }
            double sr = sum/array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (i > maid)
                {
                    array[i] = sr;
                }
            }
            
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                k++;
            }
            if (k % 2 == 0)
            {
                even = new int[k / 2];
                odd = new int[k / 2];
            }
            else
            {
                even = new int[k - k / 2];
                odd = new int[k / 2];
            }
            int ed = 0;
            int od = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ed] = array[i];
                    ed++;
                }
                else
                {
                    odd[od] = array[i];
                    od++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double s = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }
            double sr = s / n;
            int id = -1;
            double r = double.MaxValue;
            for (int i = 0; i < n; i++)
            {
                double nr = Math.Abs(sr - array[i]);
                if (nr < r)
                {
                    r = nr;
                    id = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i <= id; i++)
            {
                answer[i] = array[i];
            }
            answer[id + 1] = P;
            for (int i = id + 2; i < answer.Length; i++) { answer[i] = array[i - 1]; }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int k = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++) { if (array[i] >= 0) { k++; } }

            int[] pl = new int[k];
            int[] ot = new int[n - k];
            int kp = 0;
            int ko = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    pl[kp] = array[i];
                    kp++;
                }
                else
                {
                    ot[ko] = array[i];
                    ko++;
                }
            }
            for (int i = 0; i < k; i++)
            {
                array[i] = pl[i];
            }
            int nk = 0;
            for (int i = k; i < n; i++)
            {
                array[i] = ot[nk];
                nk++;
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            // code here
            answer = new int[A.Length + B.Length];
            if (k == A.Length)
            {     
                for (int i = 0, ca = 0, cb = 0; i < answer.Length; i++)
                {
                    if (ca<A.Length) { answer[i] = A[ca]; ca++; }
                    else { answer[i] = B[cb]; cb++; }
                }
            }
            else
            {
                if (k < 0 || k > A.Length) return A;
                int d = 0;
                for (int i = 0; i < k; i++) { answer[i] = A[i]; d++; }
                for (int i = 0, c = k; i< B.Length; i++,c++) { answer[c] = B[i];}
                for (int i = d+B.Length, c = d; i < answer.Length; i++, c++) { answer[i] = A[c];}
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
                int n = A.Length;
                sum = new int[n];
                dif = new int[n];
                for (int i = 0; i < n; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int mi = array[0];
            int ma = array[0];
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < mi) { mi = array[i]; }
                if (array[i] > ma) {ma = array[i];}
            }
            if (mi != ma)
            {
                normalized = new double[n];
                double r = ma - mi;
                for (int i = 0; i < n; i++)
                {
                    normalized[i] = 2.0 * (array[i] - mi) / r - 1.0;
                }
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int n = C.Length;
            int k = 0;
            for (int i = 0; i < A.Length; i++,k++) { C[i] = A[i]; }
            for (int i = k, j = 0; i< n; i++, j++) { C[i] = B[j]; }
            int a = 1, b = 2;
            while (a < n)
            {
                if (a == 0 || C[a] < C[a - 1])
                {
                    a = b;
                    b++;
                }
                else
                {
                    (C[a], C[a - 1]) = (C[a - 1], C[a]);
                    a--;
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int id = 0;
            int ma = array[0];
            for (int i = 0; i < n; i++)
            {
                if (ma < array[i]) { ma = array[i]; id = i; }
            }
            int[] ne = new int[n];
            for (int i = 0; i < n; i++) {  ne[(i + id) % n] = array[i]; }
            for (int i = 0; i < n; i++) { array[i] = ne[i]; }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N > 0 && N <= array.Length)
            {
                int[] l = new int[N - 1];
                for (int i = 0; i < N - 1; i++) { l[i] = array[i]; }
                
                int[] rev = new int[l.Length];
                for (int i = l.Length-1, a = 0; i >= 0; i--, a++) { rev[a] = l[i]; }

                if (array.Length - l.Length > l.Length)
                {
                    for (int i = N, a = 0; a < rev.Length; i++, a++) { array[i] = rev[a]; }
                    
                }
                else
                {
                    for (int i = N, a = 0; i<array.Length; i++, a++) { array[i] = rev[a]; }
                }
            }
            
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n==1) 
            {
                Xext = new double[0];
                Yext = new double[0];
            }
            if (n > 1 && a<b)
            {
                X = new double[n];
                Y = new double[n];
                double h = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    double x = a + i * h;
                    X[i] = x;
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                }
                int k = 0;
                for (int i = 1; i < Y.Length - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1])) { k++; }
                }
                Xext = new double[k];
                Yext = new double[k];
                if (k > 0)
                {
                    
                    for (int i = 1, j = 0; i < Y.Length - 1; i++)
                    {
                        if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                        {
                            Xext[j] = X[i];
                            Yext[j] = Y[i];
                            j++;
                        }
                    }
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int n = raw.Length;
            normal = new double[n];
            int nn = n;
            double sum = 0;
            for (int i = 0; i<n; i++) { sum += raw[i]; }
            double nsum = sum;
            double sr = sum / n;
            int kbr =0;
            int kdm = 0;
            for (int i = 0; i < n; i++)
            {
                if (raw[i]>sr*2) { kbr++; }
                if (raw[i]<sr/2) { kdm++; }
            }
            bright = new double[kbr];
            
            dim = new double[kdm];
            
            for (int i = 0, kb =0, kd  = 0; i < n; i++)
            {
                if (raw[i] > sr * 2) 
                { bright[kb] = raw[i]; 
                    kb++; nsum -= raw[i]; nn--; }

                if (raw[i] < sr / 2) 
                { dim[kd] = raw[i]; 
                    kd++; nsum -= raw[i]; nn--; }
            }
            double nsr = nsum / nn;

            for (int i = 0, kb = 0, kd = 0; i < n; i++)
            {
                if (raw[i] > sr * 2) { raw[i] = (bright[kb]+nsr)/2.0; kb++; }
                if (raw[i] < sr / 2) { raw[i] = (dim[kd] + nsr)/ 2.0; kd++; }
            }

            for (int i = 0; i<n; i++) { normal[i] = raw[i]; }

            int a = 1, b = 2;
            while (a < n)
            {
                if (a == 0 || normal[a] < normal[a - 1])
                {
                    a = b;
                    b++;
                }
                else
                {
                    (normal[a], normal[a - 1]) = (normal[a - 1], normal[a]);
                    a--;
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
