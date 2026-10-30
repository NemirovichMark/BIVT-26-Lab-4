namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int maxindex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxindex]) maxindex = i;

            if (maxindex == array.Length - 1) return;

            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = sum / array.Length;

            for (int i = maxindex + 1; i < array.Length; i++)
                array[i] = avg;
            // end
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array == null) return (even, odd);

            int evenCount = (array.Length + 1) / 2;
            int oddCount = array.Length / 2;
            even = new int[evenCount];
            odd = new int[oddCount];

            int ie = 0, io = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) even[ie++] = array[i];
                else odd[io++] = array[i];
            }
            // end

            return (even, odd);
        }

        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null) return answer;

            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = (double)sum / array.Length;

            int bestIdx = 0;
            double bestDiff = Math.Abs(array[0] - avg);
            for (int i = 1; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - avg);
                if (diff < bestDiff)
                {
                    bestDiff = diff;
                    bestIdx = i;
                }
            }

            answer = new int[array.Length + 1];
            int pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[pos++] = array[i];
                if (i == bestIdx) answer[pos++] = P;
            }
            // end

            return answer;
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int negCount = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) negCount++;

            if (negCount == 0 || negCount == array.Length) return;

            int[] result = new int[array.Length];
            int pos = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0) result[pos++] = array[i];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) result[pos++] = array[i];

            for (int i = 0; i < array.Length; i++) array[i] = result[i];
            // end
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A == null || B == null) return answer;
            if (k < 0 || k > A.Length) return answer;

            answer = new int[A.Length + B.Length];
            int pos = 0;
            for (int i = 0; i < k; i++) answer[pos++] = A[i];
            for (int i = 0; i < B.Length; i++) answer[pos++] = B[i];
            for (int i = k; i < A.Length; i++) answer[pos++] = A[i];
            // end

            return answer;
        }

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null || A.Length != B.Length) return (sum, dif);

            sum = new int[A.Length];
            dif = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
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
            if (array == null || array.Length == 0) return normalized;

            int min = array[0], max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            if (min == max) return null;

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                normalized[i] = 2.0 * (array[i] - min) / (max - min) - 1.0;
            // end

            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null || B == null) return C;

            int[] a = new int[A.Length];
            int[] b = new int[B.Length];
            for (int i = 0; i < A.Length; i++) a[i] = A[i];
            for (int i = 0; i < B.Length; i++) b[i] = B[i];

            for (int i = 0; i < a.Length - 1; i++)
                for (int j = 0; j < a.Length - 1 - i; j++)
                    if (a[j] < a[j + 1]) { int t = a[j]; a[j] = a[j + 1]; a[j + 1] = t; }
            for (int i = 0; i < b.Length - 1; i++)
                for (int j = 0; j < b.Length - 1 - i; j++)
                    if (b[j] < b[j + 1]) { int t = b[j]; b[j] = b[j + 1]; b[j + 1] = t; }

            C = new int[a.Length + b.Length];
            int ia = 0, ib = 0, ic = 0;
            while (ia < a.Length && ib < b.Length)
            {
                if (a[ia] >= b[ib]) C[ic++] = a[ia++];
                else C[ic++] = b[ib++];
            }
            while (ia < a.Length) C[ic++] = a[ia++];
            while (ib < b.Length) C[ic++] = b[ib++];
            // end

            return C;
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length <= 1) return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx]) maxIdx = i;

            int shift = maxIdx % array.Length;
            if (shift == 0) return;

            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                temp[(i + shift) % array.Length] = array[i];
            for (int i = 0; i < array.Length; i++) array[i] = temp[i];
            // end
        }

        public void Task10(int[] array, int N)
        {
            // code here
            if (array == null || array.Length == 0) return;
            if (N < 1 || N > array.Length) return;

            int idx = N - 1;
            int leftCount = idx;
            int rightCount = array.Length - idx - 1;
            int count = Math.Min(leftCount, rightCount);

            for (int i = 1; i <= count; i++)
                array[idx + i] = array[idx - i];
            // end
        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n <= 0) return (Xext, Yext);

            if (n == 1)
            {
                if (a != b) return (Xext, Yext);
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }

            X = new double[n];
            Y = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int extCount = 0;
            for (int i = 1; i < n - 1; i++)
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    extCount++;

            Xext = new double[extCount];
            Yext = new double[extCount];
            int pos = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[pos] = X[i];
                    Yext[pos] = Y[i];
                    pos++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw == null || raw.Length == 0) return (bright, normal, dim);

            double sumAll = 0;
            for (int i = 0; i < raw.Length; i++) sumAll += raw[i];
            double avgAll = sumAll / raw.Length;

            bool[] isBright = new bool[raw.Length];
            bool[] isDim = new bool[raw.Length];
            int brightCount = 0, dimCount = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * avgAll) { isBright[i] = true; brightCount++; }
                else if (raw[i] < 0.5 * avgAll) { isDim[i] = true; dimCount++; }
            }

            double sumNormal = 0;
            int normalCount = 0;
            for (int i = 0; i < raw.Length; i++)
                if (!isBright[i] && !isDim[i]) { sumNormal += raw[i]; normalCount++; }
            double avgNormal = normalCount > 0 ? sumNormal / normalCount : 0;

            bright = new double[brightCount];
            dim = new double[dimCount];
            normal = new double[raw.Length];

            int ib = 0, id = 0, inrm = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (isBright[i])
                {
                    bright[ib++] = raw[i];
                    normal[inrm++] = (avgNormal + raw[i]) / 2;
                }
                else if (isDim[i])
                {
                    dim[id++] = raw[i];
                    normal[inrm++] = (avgNormal + raw[i]) / 2;
                }
                else
                {
                    normal[inrm++] = raw[i];
                }
            }

            for (int i = 0; i < normal.Length - 1; i++)
                for (int j = 0; j < normal.Length - 1 - i; j++)
                    if (normal[j] < normal[j + 1])
                    {
                        double t = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = t;
                    }
            // end

            return (bright, normal, dim);
        }
    }
}
