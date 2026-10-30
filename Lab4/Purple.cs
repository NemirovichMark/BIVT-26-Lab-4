using System;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            double max = array[0];
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
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
            if (array != null)
            {
                int evenCount = (array.Length + 1) / 2;
                int oddCount = array.Length / 2;

                even = new int[evenCount];
                odd = new int[oddCount];

                int eIdx = 0, oIdx = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even[eIdx++] = array[i];
                    }
                    else
                    {
                        odd[oIdx++] = array[i];
                    }
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
                answer = array;
            }
            else
            {
                double sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                double avg = sum / array.Length;

                int bestIndex = 0;
                double minDiff = Math.Abs(array[0] - avg);

                for (int i = 1; i < array.Length; i++)
                {
                    double diff = Math.Abs(array[i] - avg);
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        bestIndex = i;
                    }
                }

                answer = new int[array.Length + 1];
                for (int i = 0, j = 0; i < array.Length; i++, j++)
                {
                    answer[j] = array[i];
                    if (i == bestIndex)
                    {
                        j++;
                        answer[j] = P;
                    }
                }
            }
            // end

            return answer;
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int countNegative = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) countNegative++;
            }

            int[] negatives = new int[countNegative];
            int[] positives = new int[array.Length - countNegative];

            int nIdx = 0, pIdx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negatives[nIdx++] = array[i];
                }
                else
                {
                    positives[pIdx++] = array[i];
                }
            }

            for (int i = 0; i < positives.Length; i++)
            {
                array[i] = positives[i];
            }
            for (int i = 0; i < negatives.Length; i++)
            {
                array[positives.Length + i] = negatives[i];
            }
            // end
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A == null) answer = B;
            else if (B == null) answer = A;
            else
            {
                answer = new int[A.Length + B.Length];
                int insertIdx = k < A.Length ? k + 1 : A.Length;

                int idx = 0;
                for (int i = 0; i < insertIdx; i++)
                {
                    answer[idx++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[idx++] = B[i];
                }
                for (int i = insertIdx; i < A.Length; i++)
                {
                    answer[idx++] = A[i];
                }
            }
            // end

            return answer;
        }

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A != null && B != null && A.Length == B.Length)
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
            if (array != null && array.Length > 0)
            {
                int min = array[0];
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min) min = array[i];
                    if (array[i] > max) max = array[i];
                }

                if (min != max)
                {
                    normalized = new double[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        normalized[i] = 2.0 * (array[i] - min) / (max - min) - 1.0;
                    }
                }
            }
            // end
            
            return normalized;
        }

        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null) C = B;
            else if (B == null) C = A;
            else
            {
                int[] aCopy = (int[])A.Clone();
                int[] bCopy = (int[])B.Clone();

                Array.Sort(aCopy, (x, y) => y.CompareTo(x));
                Array.Sort(bCopy, (x, y) => y.CompareTo(x));

                C = new int[aCopy.Length + bCopy.Length];
                int i = 0, j = 0, k = 0;

                while (i < aCopy.Length && j < bCopy.Length)
                {
                    if (aCopy[i] >= bCopy[j])
                    {
                        C[k++] = aCopy[i++];
                    }
                    else
                    {
                        C[k++] = bCopy[j++];
                    }
                }

                while (i < aCopy.Length) C[k++] = aCopy[i++];
                while (j < bCopy.Length) C[k++] = bCopy[j++];
            }
            // end

            return C;
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            int shift = maxIndex % array.Length;
            if (shift == 0) return;

            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[(i + shift) % array.Length] = array[i];
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
            if (array == null || array.Length == 0) return;

            int nIndex = N < array.Length ? N : array.Length - 1;
            int leftCount = nIndex; 
            int rightCount = array.Length - 1 - nIndex;
            int count = Math.Min(leftCount, rightCount);

            for (int i = 1; i <= count; i++)
            {
                int leftVal = array[nIndex - i];
                array[nIndex + i] = leftVal;
            }
            // end
        }

        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n > 1)
            {
                X = new double[n];
                Y = new double[n];
                double h = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    X[i] = a + i * h;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                }

                int extCount = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    {
                        extCount++;
                    }
                }

                Xext = new double[extCount];
                Yext = new double[extCount];
                int idx = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    {
                        Xext[idx] = X[i];
                        Yext[idx] = Y[i];
                        idx++;
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
            if (raw != null && raw.Length > 0)
            {
                double sum = 0;
                for (int i = 0; i < raw.Length; i++)
                {
                    sum += raw[i];
                }
                double mean = sum / raw.Length;

                double upperLimit = 2.0 * mean;
                double lowerLimit = mean / 2.0;

                int brightCount = 0;
                int dimCount = 0;
                int normalCount = 0;

                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] > upperLimit) brightCount++;
                    else if (raw[i] < lowerLimit) dimCount++;
                    else normalCount++;
                }

                bright = new double[brightCount];
                dim = new double[dimCount];
                double[] normalTemp = new double[normalCount];

                int bIdx = 0, dIdx = 0, nIdx = 0;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] > upperLimit)
                    {
                        bright[bIdx++] = raw[i];
                    }
                    else if (raw[i] < lowerLimit)
                    {
                        dim[dIdx++] = raw[i];
                    }
                    else
                    {
                        normalTemp[nIdx++] = raw[i];
                    }
                }

                double normalSum = 0;
                for (int i = 0; i < normalTemp.Length; i++)
                {
                    normalSum += normalTemp[i];
                }
                double normalAvg = normalTemp.Length > 0 ? normalSum / normalTemp.Length : 0;

                normal = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] > upperLimit)
                    {
                        normal[i] = (normalAvg + raw[i]) / 2.0;
                    }
                    else if (raw[i] < lowerLimit)
                    {
                        normal[i] = (normalAvg + raw[i]) / 2.0;
                    }
                    else
                    {
                        normal[i] = raw[i];
                    }
                }

                Array.Sort(normal, (x, y) => y.CompareTo(x));
            }
            // end

            return (bright, normal, dim);
        }
    }
}
