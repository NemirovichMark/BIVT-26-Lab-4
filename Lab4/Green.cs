namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            if (array == null || array.Length == 0) return;
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
                    {
                        array[i] = avg;
                    }
                }
            }
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            if (array == null || array.Length == 0) return 0;
            int firstNegIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegIdx = i;
                    break;
                }
            }
            if (firstNegIdx > 0)
            {
                for (int i = 0; i < firstNegIdx; i++)
                {
                    sum += array[i] * array[i];
                }
            }
            return sum;
        }

        public int[] Task3(int[] array)
        {
            if (array == null || array.Length == 0) return null;
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
                if (array[i] < 0) count++;
            }
            int[] negatives = new int[count];
            int k = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k++] = array[i];
                }
            }
            return negatives;
        }

        public void Task4(int[] array)
        {
            if (array == null || array.Length == 0) return;
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
                {
                    firstNegIdx = i;
                }
            }
            if (firstNegIdx != -1)
            {
                int temp = array[maxIdx];
                array[maxIdx] = array[firstNegIdx];
                array[firstNegIdx] = temp;
            }
        }

        public int[] Task5(int[] array)
        {
            if (array == null || array.Length == 0) return null;
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal) count++;
            }
            int[] answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal) answer[k++] = i;
            }
            return answer;
        }

        public void Task6(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
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
        }

        public void Task7(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
            }
            int runningSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int original = array[i];
                if (original == maxVal)
                {
                    array[i] = runningSum;
                }
                runningSum += original;
            }
        }

        public int Task8(int[] array)
        {
            if (array == null || array.Length == 0) return 1;
            int length = 1;
            int currentLen = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    currentLen++;
                }
                else
                {
                    currentLen = 1;
                }
                if (currentLen > length)
                {
                    length = currentLen;
                }
            }
            return length;
        }

        public void Task9(int[] array)
        {
            if (array == null || array.Length <= 2) return;
            int evenCount = 0;
            for (int i = 0; i < array.Length; i += 2) evenCount++;
            int[] evens = new int[evenCount];
            int k = 0;
            for (int i = 0; i < array.Length; i += 2) evens[k++] = array[i];
            for (int i = 1; i < evens.Length; i++)
            {
                int key = evens[i];
                int j = i - 1;
                while (j >= 0 && evens[j] > key)
                {
                    evens[j + 1] = evens[j];
                    j--;
                }
                evens[j + 1] = key;
            }
            int idx = 0;
            for (int i = 0; i < array.Length; i += 2) array[i] = evens[idx++];
        }

        public int[] Task10(int[] array)
        {
            if (array == null || array.Length == 0) return null;
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
                        {
                            isDuplicate[j] = true;
                        }
                    }
                }
            }
            int[] cleared = new int[uniqueCount];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!isDuplicate[i])
                {
                    cleared[k++] = array[i];
                }
            }
            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] B = null;
            if (n < 1) return B;
            double[] A = new double[n];
            for (int i = 0; i < n; i++)
            {
                if (n == 1) A[i] = a;
                else A[i] = a + i * (b - a) / (n - 1);
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
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > avgPos) count++;
                }
                B = new double[count];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > avgPos)
                    {
                        B[k++] = A[i];
                    }
                }
            }
            else
            {
                B = new double[0];
            }
            return B;
        }

        public int Task12(int[] dices)
        {
            if (dices == null || dices.Length == 0) return 0;
            int wins = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] == 6) wins++;
            }
            return wins;
        }
    }
}
