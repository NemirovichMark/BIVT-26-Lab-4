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
            if (array == null)
                return 0;

            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
                if (array[i] > min && array[i] < max)
                    count++;
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

            int Inmax = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[Inmax])
                    Inmax = i;

            if (Inmax == array.Length - 1)
                return;

            int Inmin = Inmax + 1;
            for (int i = Inmax + 2; i < array.Length; i++)
                if (array[i] < array[Inmin])
                    Inmin = i;

            int temp = array[Inmax];
            array[Inmax] = array[Inmin];
            array[Inmin] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int max = int.MinValue;
            int maxIndex = -1;
            for(int i = 0; i<array.Length;i+=2)
            {
                if (array[i]>max)
                {
                    max = array[i];
                    maxIndex = i;
                }

            }
            array[maxIndex] = maxIndex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = -1;

            // code here
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i]==P)
                {
                    index = i;
                    break;
                }
            }
            // end
            if (index == -1)
            {
                return -1;
            }
            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
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
            int j = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    array[j++] = array[i];
            answer = new int[j];
            Array.Copy(array, answer, j);
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

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
            //int[] array2 = new int[array.Length];
            for(int i = 0; i<array.Length/2;i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null || B == null)
                return null;

            C = new int[A.Length + B.Length];
            int i = 0, a = 0, b = 0;

            while (a < A.Length || b < B.Length)
            {
                if (a < A.Length && b < B.Length)
                {
                    C[i++] = A[a++];
                    C[i++] = B[b++];
                }
                else if (a < A.Length)
                    C[i++] = A[a++];
                else
                    C[i++] = B[b++];
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
                return null;

            if (a == b)
            {
                if (n != 1)
                    return null;
                array = new double[1] { a };
                return array;
            }

            if (n == 1)
                return null;

            array = new double[n];
            for (int i = 0; i < n; i++)
                array[i] = a + (b - a) * i / (n - 1);

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
                return null;

            restored = (double[])raw.Clone();

            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] != -1)
                    continue;

                int left = (i - 1 + restored.Length) % restored.Length;
                int right = (i + 1) % restored.Length;

                if (raw[left] != -1 && raw[right] != -1)
                    restored[i] = (raw[left] + raw[right]) / 2;
            }
            // end

            return restored;
        }
    }
}
