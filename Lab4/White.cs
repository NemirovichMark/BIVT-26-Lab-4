namespace Lab4.White
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }
            length = Math.Sqrt(sum);
            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    count++;
                }
            }
            return count;
        }

        public void Task3(int[] array)
        {
            if (array.Length == 0) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            if (maxIndex < array.Length - 1)
            {
                int minAfterIndex = maxIndex + 1;
                for (int i = maxIndex + 2; i < array.Length; i++)
                {
                    if (array[i] < array[minAfterIndex])
                        minAfterIndex = i;
                }

                int temp = array[maxIndex];
                array[maxIndex] = array[minAfterIndex];
                array[minAfterIndex] = temp;
            }
        }

        public void Task4(int[] array)
        {
            if (array.Length == 0) return;

            int maxVal = array[0];
            int maxIndex = 0;

            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIndex = i;
                }
            }

            array[maxIndex] = maxIndex;
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            if (index == 0 && array[0] != P)
            {
                index = -1;
            }
            return index;
        }

        public void Task6(int[] array)
        {
            if (array.Length <= 1) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }

        public int[] Task7(int[] array)
        {
            List<int> tempList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    tempList.Add(array[i]);
                }
            }
            return tempList.ToArray();
        }

        public void Task8(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void Task9(int[] array)
        {
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
        }

        public int[] Task10(int[] A, int[] B)
        {
            if (A.Length == 0 && B.Length == 0) return new int[0];
            if (A.Length == 0) return B;
            if (B.Length == 0) return A;

            int[] C = new int[A.Length + B.Length];
            int i = 0, j = 0, k = 0;

            while (i < A.Length && j < B.Length)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }

            while (i < A.Length) C[k++] = A[i++];
            while (j < B.Length) C[k++] = B[j++];

            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
            if (n <= 0) return null;

            if (a == b && n == 1) return new double[] { a };
            if (a == b) return null;

            double[] array = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * step;
            }
            return array;
        }

        public double[] Task12(double[] raw)
        {
            if (raw.Length < 3) return (double[])raw.Clone();

            bool allDamaged = true;
            foreach (double val in raw)
            {
                if (val != -1)
                {
                    allDamaged = false;
                    break;
                }
            }
            if (allDamaged) return (double[])raw.Clone();

            double[] restored = (double[])raw.Clone();

            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 0; i < restored.Length; i++)
                {
                    if (restored[i] == -1)
                    {
                        bool leftOk = (i > 0 && restored[i - 1] != -1);
                        bool rightOk = (i < restored.Length - 1 && restored[i + 1] != -1);

                        if (leftOk && rightOk)
                        {
                            restored[i] = (restored[i - 1] + restored[i + 1]) / 2.0;
                            changed = true;
                        }
                    }
                }
            }
            return restored;
        }
    }
}
