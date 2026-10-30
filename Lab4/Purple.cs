namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            //code here
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];

            double average = sum / array.Length;

            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] = average;
            }
            //end
        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            //code here
            if (array == null) return (null, null);

            int n = array.Length;
            even = new int[(n + 1) / 2];
            odd = new int[n / 2];

            int evenIndex = 0;
            int oddIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) even[evenIndex++] = array[i];
                else odd[oddIndex++] = array[i];
            }
            //end

            return (even, odd);
        }

        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            //code here
            if (array == null || array.Length == 0) return null;

            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];

            double average = sum / array.Length;
            int bestIndex = 0;
            double bestDifference = System.Math.Abs(array[0] - average);

            for (int i = 1; i < array.Length; i++)
            {
                double difference = System.Math.Abs(array[i] - average);
                if (difference < bestDifference)
                {
                    bestDifference = difference;
                    bestIndex = i;
                }
            }

            answer = new int[array.Length + 1];

            for (int i = 0; i <= bestIndex; i++)
            {
                answer[i] = array[i];
            }

            answer[bestIndex + 1] = P;

            for (int i = bestIndex + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            //end

            return answer;
        }

        public void Task4(int[] array)
        {
            //code here
            if (array == null || array.Length <= 1) return;

            int n = array.Length;
            int[] temp = new int[n];
            int index = 0;

            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0) temp[index++] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0) temp[index++] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = temp[i];
            }
            //end
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            //code here
            if (A == null || B == null) return null;
            if (k < 1 || k > A.Length) return null;

            answer = new int[A.Length + B.Length];
            int position = 0;

            for (int i = 0; i < k; i++)
            {
                answer[position++] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                answer[position++] = B[i];
            }

            for (int i = k; i < A.Length; i++)
            {
                answer[position++] = A[i];
            }
            //end

            return answer;
        }

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            //code here
            if (A == null || B == null || A.Length != B.Length) return (null, null);

            sum = new int[A.Length];
            dif = new int[A.Length];

            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            //end

            return (sum, dif);
        }

        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            //code here
            if (array == null || array.Length == 0) return null;

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (max == min) return null;

            normalized = new double[array.Length];
            double range = max - min;

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - min) / range - 1.0;
            }
            //end
            
            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            //code here
            if (A == null || B == null) return null;

            int[] a = new int[A.Length];
            int[] b = new int[B.Length];

            for (int i = 0; i < A.Length; i++) a[i] = A[i];
            for (int i = 0; i < B.Length; i++) b[i] = B[i];

            for (int i = 1; i < a.Length; i++)
            {
                int key = a[i];
                int j = i - 1;

                while (j >= 0 && a[j] < key)
                {
                    a[j + 1] = a[j];
                    j--;
                }

                a[j + 1] = key;
            }

            for (int i = 1; i < b.Length; i++)
            {
                int key = b[i];
                int j = i - 1;

                while (j >= 0 && b[j] < key)
                {
                    b[j + 1] = b[j];
                    j--;
                }

                b[j + 1] = key;
            }

            C = new int[a.Length + b.Length];

            int ia = 0;
            int ib = 0;
            int ic = 0;

            while (ia < a.Length && ib < b.Length)
            {
                if (a[ia] >= b[ib]) C[ic++] = a[ia++];
                else C[ic++] = b[ib++];
            }

            while (ia < a.Length) C[ic++] = a[ia++];
            while (ib < b.Length) C[ic++] = b[ib++];
            //end

            return C;
        }

        public void Task9(int[] array)
        {
            //code here
            if (array == null || array.Length <= 1) return;

            int n = array.Length;
            int maxIndex = 0;

            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            int shift = maxIndex % n;
            if (shift == 0) return;

            int[] temp = new int[n];

            for (int i = 0; i < n; i++)
            {
                temp[(i + shift) % n] = array[i];
            }

            for (int i = 0; i < n; i++)
            {
                array[i] = temp[i];
            }
            //end
        }

        public void Task10(int[] array, int N)
        {
            //code here
            if (array == null || array.Length == 0) return;
            if (N < 1 || N > array.Length) return;

            int pivot = N - 1;
            int leftCount = pivot;
            int rightCount = array.Length - N;
            int count = leftCount < rightCount ? leftCount : rightCount;

            for (int i = 0; i < count; i++)
            {
                array[N + i] = array[pivot - 1 - i];
            }
            //end
        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            //code here
            if (n <= 0) return (null, null);

            X = new double[n];
            Y = new double[n];

            if (n == 1)
            {
                X[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    X[i] = a + i * step;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Y[i] = System.Math.Cos(X[i]) + X[i] * System.Math.Sin(X[i]);
            }

            int count = 0;

            for (int i = 1; i < n - 1; i++)
            {
                bool isMax = Y[i] > Y[i - 1] && Y[i] > Y[i + 1];
                bool isMin = Y[i] < Y[i - 1] && Y[i] < Y[i + 1];

                if (isMax || isMin) count++;
            }

            Xext = new double[count];
            Yext = new double[count];

            int index = 0;

            for (int i = 1; i < n - 1; i++)
            {
                bool isMax = Y[i] > Y[i - 1] && Y[i] > Y[i + 1];
                bool isMin = Y[i] < Y[i - 1] && Y[i] < Y[i + 1];

                if (isMax || isMin)
                {
                    Xext[index] = X[i];
                    Yext[index] = Y[i];
                    index++;
                }
            }
            //end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            //code here
            if (raw == null || raw.Length == 0) return (null, null, null);

            int n = raw.Length;
            double sumAll = 0;

            for (int i = 0; i < n; i++) sumAll += raw[i];

            double averageAll = sumAll / n;
            double brightThreshold = 2.0 * averageAll;
            double dimThreshold = 0.5 * averageAll;

            int brightCount = 0;
            int dimCount = 0;
            int remainCount = 0;

            for (int i = 0; i < n; i++)
            {
                if (raw[i] > brightThreshold) brightCount++;
                else if (raw[i] < dimThreshold) dimCount++;
                else remainCount++;
            }

            bright = new double[brightCount];
            dim = new double[dimCount];

            double sumRemain = 0;
            int brightIndex = 0;
            int dimIndex = 0;

            for (int i = 0; i < n; i++)
            {
                if (raw[i] > brightThreshold) bright[brightIndex++] = raw[i];
                else if (raw[i] < dimThreshold) dim[dimIndex++] = raw[i];
                else sumRemain += raw[i];
            }

            double averageRemain = remainCount > 0 ? sumRemain / remainCount : averageAll;

            normal = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (raw[i] > brightThreshold || raw[i] < dimThreshold)
                {
                    normal[i] = (averageRemain + raw[i]) / 2.0;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }

            for (int i = 1; i < normal.Length; i++)
            {
                double key = normal[i];
                int j = i - 1;

                while (j >= 0 && normal[j] < key)
                {
                    normal[j + 1] = normal[j];
                    j--;
                }

                normal[j + 1] = key;
            }
            //end

            return (bright, normal, dim);
        }
    }
}
