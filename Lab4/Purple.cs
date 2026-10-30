using System;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            double avg = sum / array.Length;

            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] = avg;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array == null) return (null, null);

            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                else
                {
                    odd[i / 2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return null;

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = sum / array.Length;

            int closestIndex = 0;
            double minDiff = Math.Abs(array[0] - avg);

            for (int i = 1; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - avg);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closestIndex = i;
                }
            }

            answer = new int[array.Length + 1];
            for (int i = 0; i <= closestIndex; i++)
            {
                answer[i] = array[i];
            }
            answer[closestIndex + 1] = P;
            for (int i = closestIndex + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;

            int[] temp = new int[array.Length];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    temp[index++] = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    temp[index++] = array[i];
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
            if (A == null || B == null) return null;
        
            if (k < 0) k = 0;
            if (k > A.Length) k = A.Length;
        
            answer = new int[A.Length + B.Length];
            int index = 0;
        
            for (int i = 0; i < k; i++)
            {
                answer[index++] = A[i];
            }
        
            for (int i = 0; i < B.Length; i++)
            {
                answer[index++] = B[i];
            }
        
            for (int i = k; i < A.Length; i++)
            {
                answer[index++] = A[i];
            }
            // end
        
            return answer;
        }
        
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null || A.Length != B.Length) return (null, null);

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

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max) return null;

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
            if (A == null || B == null) return null;

            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1 - i; j++)
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
                for (int j = 0; j < B.Length - 1 - i; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        int temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }

            C = new int[A.Length + B.Length];
            int idxA = 0, idxB = 0, idxC = 0;

            while (idxA < A.Length && idxB < B.Length)
            {
                if (A[idxA] >= B[idxB])
                {
                    C[idxC++] = A[idxA++];
                }
                else
                {
                    C[idxC++] = B[idxB++];
                }
            }

            while (idxA < A.Length)
            {
                C[idxC++] = A[idxA++];
            }

            while (idxB < B.Length)
            {
                C[idxC++] = B[idxB++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == 0) return;

            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[(i + maxIndex) % array.Length] = array[i];
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
            if (array == null || N < 1 || N > array.Length) return;

            int centerIndex = N - 1;
            int leftCount = centerIndex;
            int rightCount = array.Length - 1 - centerIndex;
            int count = Math.Min(leftCount, rightCount);

            for (int i = 1; i <= count; i++)
            {
                array[centerIndex + i] = array[centerIndex - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;
        
            // code here
            if (n <= 0) return (null, null);
            if (n == 1) return (null, null);
            if (a > b) return (null, null);
        
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
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    extCount++;
                }
            }
        
            Xext = new double[extCount];
            Yext = new double[extCount];
            int idx = 0;
        
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[idx] = X[i];
                    Yext[idx] = Y[i];
                    idx++;
                }
            }
            // end
        
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw == null || raw.Length == 0) return (null, null, null);

            double sumAll = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sumAll += raw[i];
            }
            double avgAll = sumAll / raw.Length;

            int brightCount = 0;
            int dimCount = 0;
            double sumNormal = 0;
            int normalCount = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2.0 * avgAll)
                {
                    brightCount++;
                }
                else if (raw[i] < 0.5 * avgAll)
                {
                    dimCount++;
                }
                else
                {
                    sumNormal += raw[i];
                    normalCount++;
                }
            }

            bright = new double[brightCount];
            dim = new double[dimCount];
            normal = new double[raw.Length];

            double avgNormal = normalCount > 0 ? sumNormal / normalCount : 0;
            int bIdx = 0, dIdx = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2.0 * avgAll)
                {
                    bright[bIdx++] = raw[i];
                    normal[i] = (avgNormal + raw[i]) / 2.0;
                }
                else if (raw[i] < 0.5 * avgAll)
                {
                    dim[dIdx++] = raw[i];
                    normal[i] = (avgNormal + raw[i]) / 2.0;
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
