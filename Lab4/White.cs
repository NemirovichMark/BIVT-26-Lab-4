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
                length += (double)vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
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
            if (array.Length > 1)
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
            if (array.Length > 0)
            {
                int maxIndex = 0;
                for (int i = 2; i < array.Length; i += 2)
                {
                    if (array[i] > array[maxIndex])
                    {
                        maxIndex = i;
                    }
                }
                array[maxIndex] = maxIndex;
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
            if (array.Length > 1)
            {
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
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[k] = array[i];
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] < value)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = value;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array.Length - 1 - i;
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
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
            while (i < A.Length || j < B.Length)
            {
                if (i < A.Length)
                {
                    C[k] = A[i];
                    i++;
                    k++;
                }
                if (j < B.Length)
                {
                    C[k] = B[j];
                    j++;
                    k++;
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                array = new double[1];
                array[0] = a;
            }
            else if (a != b && n > 1)
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
                array[n - 1] = b;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length >= 3)
            {
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                    int left = (i + raw.Length - 1) % raw.Length;
                    int right = (i + 1) % raw.Length;
                    if (raw[i] == -1 && raw[left] != -1 && raw[right] != -1)
                    {
                        restored[i] = (raw[left] + raw[right]) / 2;
                    }
                }
            }
            // end

            return restored;
        }
    }
}