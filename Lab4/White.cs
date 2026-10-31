namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            // code here
            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end
            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            // code here
            int minVal = Math.Min(P, Q);
            int maxVal = Math.Max(P, Q);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minVal && array[i] < maxVal)
                {
                    count++;
                }
            }
            // end
            return count;
        }

        public void Task3(int[] array)
        {
            // code here
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                {
                    maxIdx = i;
                }
            }
            if (maxIdx < array.Length - 1)
            {
                bool allEqual = true;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] != array[0])
                    {
                        allEqual = false;
                        break;
                    }
                }
                if (!allEqual)
                {
                    int minIdx = maxIdx + 1;
                    for (int i = maxIdx + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[minIdx])
                        {
                            minIdx = i;
                        }
                    }
                    int temp = array[maxIdx];
                    array[maxIdx] = array[minIdx];
                    array[minIdx] = temp;
                }
            }
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            int maxVal = int.MinValue;
            int maxIdx = -1;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIdx = i;
                }
            }
            if (maxIdx != -1)
            {
                array[maxIdx] = maxIdx;
            }
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;
            // code here
            index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end
            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                {
                    maxIdx = i;
                }
            }
            for (int i = 0; i < maxIdx; i += 2)
            {
                if (i + 1 < maxIdx)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            // end
        }

        public int[] Task7(int[] array)
        {
            int[] answer = null;
            // code here
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) count++;
            }
            answer = new int[count];
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) answer[idx++] = array[i];
            }
            // end
            return answer;
        }

        public void Task8(int[] array)
        {
            // code here
            Array.Sort(array);
            Array.Reverse(array);
            // end
        }

        public void Task9(int[] array)
        {
            // code here
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
            // end
        }

        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;
            // code here
            int lenA = A.Length;
            int lenB = B.Length;
            C = new int[lenA + lenB];
            int i = 0, j = 0, k = 0;
            while (i < lenA && j < lenB)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }
            while (i < lenA)
            {
                C[k++] = A[i++];
            }
            while (j < lenB)
            {
                C[k++] = B[j++];
            }
            // end
            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;
            // code here
            if (n <= 0)
            {
                array = null;
            }
            else if (a == b && n == 1)
            {
                array = new double[] { a };
            }
            else if (a == b && n > 1)
            {
                array = null;
            }
            else
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            // end
            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;
            // code here
            if (raw.Length < 3)
            {
                restored = (double[])raw.Clone();
            }
            else
            {
                bool allMinusOne = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        allMinusOne = false;
                        break;
                    }
                }
                if (allMinusOne)
                {
                    restored = (double[])raw.Clone();
                }
                else
                {
                    restored = (double[])raw.Clone();
                    bool changed = true;
                    while (changed)
                    {
                        changed = false;
                        for (int i = 1; i < restored.Length - 1; i++)
                        {
                            if (restored[i] == -1)
                            {
                                if (restored[i - 1] != -1 && restored[i + 1] != -1)
                                {
                                    restored[i] = (restored[i - 1] + restored[i + 1]) / 2;
                                    changed = true;
                                }
                            }
                        }
                    }
                }
            }
            // end
            return restored;
        }
    }
}
