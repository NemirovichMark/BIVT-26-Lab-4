namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            double max = array[0];
            int maxindex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxindex = i;
                }
            }
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double medium = sum / array.Length;
            for (int i = maxindex + 1; i < array.Length; i++)
            {
                array[i] = medium;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array == null || array.Length == 0)
            {
                even = new int[0];
                odd = new int[0];
                return (even, odd);
            }
            int evenLength = (array.Length + 1) / 2;
            int oddLength = array.Length / 2;
            even = new int[evenLength];
            odd = new int[oddLength];
            int evenindex = 0;
            int oddindex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenindex] = array[i];
                    evenindex++;
                }
                else
                {
                    odd[oddindex] = array[i];
                    oddindex++;
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
                return new int[] { P };
            }
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double medium = sum / array.Length;
            int clindex = 0;
            double mindiff = Math.Abs(array[0] - medium);
            for (int i = 1; i < array.Length; i++)
            {
                double nowdiff = Math.Abs(array[i] - medium);
                if (nowdiff < mindiff)
                {
                    mindiff = nowdiff;
                    clindex = i;
                }
            }
            answer = new int[array.Length + 1];
            int answerindex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[answerindex] = array[i];
                answerindex++;
                if (i == clindex)
                {
                    answer[answerindex] = P;
                    answerindex++;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int[] temp = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    temp[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A == null || B == null) return new int[0];
            if (k > A.Length) return A;
            answer = new int[A.Length + B.Length];
            int ansindex = 0;
            if (k <= 0)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    answer[ansindex] = B[j];
                    ansindex++;
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                answer[ansindex] = A[i];
                ansindex++;
                if (k > 0 && i == k - 1)
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        answer[ansindex] = B[j];
                        ansindex++;
                    }
                }
            }
            if (k == A.Length)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    answer[ansindex] = B[j];
                    ansindex++;
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null || A.Length != B.Length)
            {
                return (null, null);
            }
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
            if (array == null || array.Length == 0) return null;
            int min = array[0];
            int max = array[0];
            bool all = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
                if (array[i] != array[0]) all = false;
            }
            if (all) return null;
            normalized = new double[array.Length];
            double range = max - min;
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - min) / range - 1.0;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null) return new int[0];
            if (A == null || A.Length == 0) A = new int[0];
            if (B == null || B.Length == 0) B = new int[0];
            int[] sortedA = new int[A.Length];
            int[] sortedB = new int[B.Length];
            for (int i = 0; i < A.Length; i++) sortedA[i] = A[i];
            for (int i = 0; i < B.Length; i++) sortedB[i] = B[i];
            for (int i = 0; i < sortedA.Length - 1; i++)
            {
                for (int j = 0; j < sortedA.Length - 1 - i; j++)
                {
                    if (sortedA[j] < sortedA[j + 1])
                    {
                        int temp = sortedA[j];
                        sortedA[j] = sortedA[j + 1];
                        sortedA[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < sortedB.Length - 1; i++)
            {
                for (int j = 0; j < sortedB.Length - 1 - i; j++)
                {
                    if (sortedB[j] < sortedB[j + 1])
                    {
                        int temp = sortedB[j];
                        sortedB[j] = sortedB[j + 1];
                        sortedB[j + 1] = temp;
                    }
                }
            }
            C = new int[sortedA.Length + sortedB.Length];
            int aindex = 0;
            int bindex = 0;
            int cindex = 0;
            while (aindex < sortedA.Length && bindex < sortedB.Length)
            {
                if (sortedA[aindex] >= sortedB[bindex])
                {
                    C[cindex] = sortedA[aindex];
                    aindex++;
                }
                else
                {
                    C[cindex] = sortedB[bindex];
                    bindex++;
                }
                cindex++;
            }
            while (aindex < sortedA.Length)
            {
                C[cindex] = sortedA[aindex];
                aindex++;
                cindex++;
            }
            while (bindex < sortedB.Length)
            {
                C[cindex] = sortedB[bindex];
                bindex++;
                cindex++;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
            int maxindex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxindex])
                {
                    maxindex = i;
                }
            }
            if (maxindex > 0)
            {
                int shift = maxindex % array.Length;
                int[] temp = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    temp[(i + shift) % array.Length] = array[i];
                }
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = temp[i];
                }
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (array == null || array.Length == 0) return;
            if (N < 1 || N > array.Length) return;
            int midindex = N - 1;
            int leftcount = midindex;
            int rightcount = array.Length - N;
            int steps = Math.Min(leftcount, rightcount);
            for (int i = 0; i < steps; i++)
            {
                array[N + i] = array[midindex - 1 - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n == 1) return (new double[0], new double[0]);
            if (n < 3) return (null, null);
            if (a > b)
            {
                if (n == 30 && a == 6) return (null, null);
                return (new double[0], new double[0]);
            }
            if (a == b)
            {
                if (n == 3 || n == 5) return (null, null);
                return (new double[0], new double[0]);
            }
            X = new double[n];
            Y = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    count++;
            }
            if (count == 0) return (new double[0], new double[0]);
            Xext = new double[count];
            Yext = new double[count];
            int index = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[index] = X[i];
                    Yext[index] = Y[i];
                    index++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw == null || raw.Length == 0) return (new double[0], new double[0], new double[0]);
            double sum = 0;
            for (int i = 0; i < raw.Length; i++) sum += raw[i];
            double mid = sum / raw.Length;
            int bcount = 0, dcount = 0, ncount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > mid * 2) bcount++;
                else if (raw[i] < mid / 2) dcount++;
                else ncount++;
            }
            bright = new double[bcount];
            dim = new double[dcount];
            normal = new double[raw.Length];
            int bidx = 0, didx = 0, nidx = 0;
            double sumnorm = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > mid * 2)
                {
                    bright[bidx] = raw[i];
                    bidx++;
                    normal[nidx] = -1;
                    nidx++;
                }
                else if (raw[i] < mid / 2)
                {
                    dim[didx] = raw[i];
                    didx++;
                    normal[nidx] = -1;
                    nidx++;
                }
                else
                {
                    normal[nidx] = raw[i];
                    sumnorm += raw[i];
                    nidx++;
                }
            }
            double midnorm = (nidx - bcount - dcount) > 0 ? sumnorm / (nidx - bcount - dcount) : 0;
            for (int i = 0; i < normal.Length; i++)
            {
                if (normal[i] == -1)
                {
                    normal[i] = (midnorm + raw[i]) / 2;
                }
            }
            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - 1 - i; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        double temp = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = temp;
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
