namespace Lab4
{
    public class Green
    {
        
        public void Task1(double[] array)
        {
            // code here
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            if (count > 0)
            {
                double avg = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        array[i] = avg;
                }
            }
            // end
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    break;
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            if (array == null || array.Length == 0)
                return negatives;

            int maxVal = array[0], minVal = array[0];
            int maxIdx = 0, minIdx = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) { maxVal = array[i]; maxIdx = i; }
                if (array[i] < minVal) { minVal = array[i]; minIdx = i; }
            }

            int start = Math.Min(maxIdx, minIdx);
            int end = Math.Max(maxIdx, minIdx);

            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                    count++;
            }

            if (count > 0)
            {
                negatives = new int[count];
                int k = 0;
                for (int i = start + 1; i < end; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[k] = array[i];
                        k++;
                    }
                }
            }
            else
            {
                negatives = new int[0];
            }
            // end

            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
                return;

            int maxVal = array[0];
            int maxIdx = 0;
            int firstNegIdx = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIdx = i;
                }
                if (firstNegIdx == -1 && array[i] < 0)
                    firstNegIdx = i;
            }

            if (firstNegIdx != -1)
            {
                int temp = array[maxIdx];
                array[maxIdx] = array[firstNegIdx];
                array[firstNegIdx] = temp;
            }
            // end
        }

        public int[] Task5(int[] array)
        {
            int[] answer = null;
            // code here
            if (array == null || array.Length == 0)
                return answer;

            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                    count++;
            }

            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    answer[k] = i;
                    k++;
                }
            }
            // end

            return answer;
        }
        
        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
                return;

            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }

            int order = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] += order;
                    order++;
                }
            }
            // end
        }

        public void Task7(int[] array)
        {
            // code here
            if (array == null || array.Length == 0)
                return;

            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }

            int runningSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] = runningSum;
                    runningSum = runningSum + array[i];
                }
                else
                {
                    runningSum = runningSum + array[i];
                }
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            if (array == null || array.Length == 0)
                return 0;

            int currentLen = 1;
            length = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                    currentLen++;
                else
                    currentLen = 1;

                if (currentLen > length)
                    length = currentLen;
            }
            // end

            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length <= 2)
                return;

            for (int i = 2; i < array.Length; i += 2)
            {
                int key = array[i];
                int j = i - 2;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 2] = array[j];
                    j -= 2;
                }
                array[j + 2] = key;
            }
            // end
        }

        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // code here
            if (array == null || array.Length == 0)
                return cleared;

            bool[] isDuplicate = new bool[array.Length];
            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (!isDuplicate[i])
                {
                    uniqueCount++;
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[i] == array[j])
                            isDuplicate[j] = true;
                    }
                }
            }

            cleared = new int[uniqueCount];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!isDuplicate[i])
                {
                    cleared[k] = array[i];
                    k++;
                }
            }
            // end

            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            // code here
            if (n < 1 || (n != 1 && a == b) || (n == 1 && a != b))
                return B;

            A = new double[n];
            if (n == 1)
            {
                A[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                    A[i] = a + i * step;
            }

            double posSum = 0;
            int posCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    posSum += A[i];
                    posCount++;
                }
            }

            if (posCount > 0)
            {
                double avgPos = posSum / posCount;
                B = new double[posCount];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > avgPos)
                    {
                        B[k] = A[i];
                        k++;
                    }
                }

                if (k < posCount)
                {
                    double[] tempB = new double[k];
                    Array.Copy(B, tempB, k);
                    B = tempB;
                }
            }
            else
            {
                B = new double[0];
            }
            // end

            return B;
        }

        public int Task12(int[] dicss)
        {
            int wins = 0;
            // code here
            if (dicss == null || dicss.Length == 0)
                return wins;

            int n = dicss.Length;
            int[] result = new int[n];

            for (int i = 0; i < n; i++)
                result[i] = dicss[i];

            for (int i = 0; i < n; i++)
            {
                if (dicss[i] == 6)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (result[j] > 1)
                            result[j]--;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (result[i] > 6)
                    wins++;
            }
            // end

            return wins;
        }
    }
}
