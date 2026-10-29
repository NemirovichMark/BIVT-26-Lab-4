namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int iMax = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > array[iMax]) iMax = i;
            }
            double average = sum / array.Length;
            for (int i = iMax + 1; i < array.Length; i++)
            {
                array[i] = average;
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here

            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) even[i / 2] = array[i];
                else odd[i / 2] = array[i];
            }

            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            int closest = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - average) < Math.Abs(array[closest] - average)) closest = i;
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i <= closest; i++)
            {
                answer[i] = array[i];
            }
            answer[closest + 1] = P;
            for (int i = closest + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] temp = new int[array.Length];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    temp[k] = array[i];
                    k++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp[k] = array[i];
                    k++;
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
            if (k < 0 || k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
            }
            else
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[k + i] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[B.Length + i] = A[i];
                }
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
                for (int i = 0; i < A.Length; i++)
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
            int min = array[0], max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            if (max != min)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2.0 * (array[i] - min) / (max - min) - 1;
                }
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            int[] sortedA = new int[A.Length];
            int[] sortedB = new int[B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sortedA[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                sortedB[i] = B[i];
            }
            for (int i = 1; i < sortedA.Length; i++)
            {
                int current = sortedA[i];
                int j = i - 1;
                while (j >= 0 && sortedA[j] < current)
                {
                    sortedA[j + 1] = sortedA[j];
                    j--;
                }
                sortedA[j + 1] = current;
            }
            for (int i = 1; i < sortedB.Length; i++)
            {
                int current = sortedB[i];
                int j = i - 1;
                while (j >= 0 && sortedB[j] < current)
                {
                    sortedB[j + 1] = sortedB[j];
                    j--;
                }
                sortedB[j + 1] = current;
            }
            C = new int[sortedA.Length + sortedB.Length];
            int iA = 0, iB = 0;
            for (int k = 0; k < C.Length; k++)
            {
                if (iB >= sortedB.Length || (iA < sortedA.Length && sortedA[iA] >= sortedB[iB]))
                {
                    C[k] = sortedA[iA];
                    iA++;
                }
                else
                {
                    C[k] = sortedB[iB];
                    iB++;
                }
            }

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int iMax = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[iMax]) iMax = i;
            }
            if (iMax > 0)
            {
                int[] temp = new int[n];
                for (int i = 0; i < n; i++)
                {
                    temp[(i + iMax) % n] = array[i];
                }
                for (int i = 0; i < n; i++)
                {
                    array[i] = temp[i];
                }
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N >= 1 && N <= array.Length)
            {
                int center = N - 1;
                int count = center;
                if (array.Length - 1 - center < count) count = array.Length - 1 - center;
                for (int j = 1; j <= count; j++)
                {
                    array[center + j] = array[center - j];
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            bool valid = n >= 1 && a <= b;
            if (a == b && n != 1) valid = false;
            if (a < b && n < 2) valid = false;
            if (valid)
            {
                X = new double[n];
                Y = new double[n];
                double step = 0;
                if (n > 1) step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    X[i] = a + step * i;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                }
                int count = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    bool isMax = Y[i - 1] < Y[i] && Y[i + 1] < Y[i];
                    bool isMin = Y[i - 1] > Y[i] && Y[i + 1] > Y[i];
                    if (isMax || isMin) count++;
                }
                Xext = new double[count];
                Yext = new double[count];
                int k = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    bool isMax = Y[i - 1] < Y[i] && Y[i + 1] < Y[i];
                    bool isMin = Y[i - 1] > Y[i] && Y[i + 1] > Y[i];
                    if (isMax || isMin)
                    {
                        Xext[k] = X[i];
                        Yext[k] = Y[i];
                        k++;
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
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += raw[i];
            }
            double average = sum / n;
            int countBright = 0, countDim = 0;
            double sumRest = 0;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * average) countBright++;
                else if (raw[i] < average / 2) countDim++;
                else sumRest += raw[i];
            }
            double averageRest = 0;
            if (n - countBright - countDim > 0) averageRest = sumRest / (n - countBright - countDim);
            bright = new double[countBright];
            dim = new double[countDim];
            normal = new double[n];
            int kBright = 0, kDim = 0;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * average)
                {
                    bright[kBright] = raw[i];
                    kBright++;
                    normal[i] = (averageRest + raw[i]) / 2;
                }
                else if (raw[i] < average / 2)
                {
                    dim[kDim] = raw[i];
                    kDim++;
                    normal[i] = (averageRest + raw[i]) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }
            for (int i = 1; i < n; i++)
            {
                double current = normal[i];
                int j = i - 1;
                while (j >= 0 && normal[j] < current)
                {
                    normal[j + 1] = normal[j];
                    j--;
                }
                normal[j + 1] = current;
            }
                // end

                return (bright, normal, dim);
        }
    }
 }
