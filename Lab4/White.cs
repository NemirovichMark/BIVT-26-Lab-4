namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here

            double sum = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                sum += (double)vector[i] * vector[i];
            }

            length = System.Math.Sqrt(sum);

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here

            int min = P;
            int max = Q;

            if (P > Q)
            {
                min = Q;
                max = P;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
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
                int maxIndex = 0;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }

                if (maxIndex < array.Length - 1)
                {
                    int minIndex = maxIndex + 1;

                    for (int i = maxIndex + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[minIndex])
                        {
                            minIndex = i;
                        }
                    }

                    int temp = array[maxIndex];
                    array[maxIndex] = array[minIndex];
                    array[minIndex] = temp;
                }
            }

            // end

        }
        public void Task4(int[] array)
        {

            // code here

            int maxIndex = 0;

            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            array[maxIndex] = maxIndex;

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

            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
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
                if (array[i] >= 0)
                {
                    count++;
                }
            }

            answer = new int[count];

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }
            }

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here

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

            C = new int[A.Length + B.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < A.Length && j < B.Length)
            {
                C[k] = A[i];
                k++;
                i++;

                C[k] = B[j];
                k++;
                j++;
            }

            while (i < A.Length)
            {
                C[k] = A[i];
                k++;
                i++;
            }

            while (j < B.Length)
            {
                C[k] = B[j];
                k++;
                j++;
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
                return null;
            }

            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[1];
                    array[0] = a;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                if (n == 1)
                {
                    return null;
                }

                array = new double[n];

                double step = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    array[i] = a + step * i;
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
                return null;
            }

            restored = new double[raw.Length];

            bool allDamaged = true;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allDamaged = false;
                    break;
                }
            }

            if (allDamaged)
            {
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }

                return restored;
            }

            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    int left = (i - 1 + raw.Length) % raw.Length;
                    int right = (i + 1) % raw.Length;

                    if (raw[left] != -1 && raw[right] != -1)
                    {
                        restored[i] = (raw[left] + raw[right]) / 2.0;
                    }
                }
            }

            // end

            return restored;
        }
    }
}
