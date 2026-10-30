namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null) return 0;
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += (double)vector[i] * vector[i];
            }
            length = Math.Sqrt(sum);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null) return 0;
            int min = P < Q ? P : Q;
            int max = P < Q ? Q : P;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max) count++;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }
            if (maxIndex == array.Length - 1) return;
            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
            }
            if (array[minIndex] == array[maxIndex]) return;
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }
            array[maxIndex] = maxIndex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            if (array == null) return index;
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
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
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
            if (array == null) return null;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) count++;
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
            if (array == null) return;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[maxIndex]) maxIndex = j;
                }
                int temp = array[i];
                array[i] = array[maxIndex];
                array[maxIndex] = temp;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null) return;
            for (int i = 0; i < array.Length / 2; i++)
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
            int lenA = A == null ? 0 : A.Length;
            int lenB = B == null ? 0 : B.Length;
            C = new int[lenA + lenB];
            int ia = 0, ib = 0, k = 0;
            while (ia < lenA || ib < lenB)
            {
                if (ia < lenA)
                {
                    C[k] = A[ia];
                    k++;
                    ia++;
                }
                if (ib < lenB)
                {
                    C[k] = B[ib];
                    k++;
                    ib++;
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
                array = new double[] { a };
            }
            else if (a != b && n >= 2)
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
            if (raw == null || raw.Length < 3) return null;
            int n = raw.Length;
            restored = new double[n];
            for (int i = 0; i < n; i++)
            {
                restored[i] = raw[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (raw[i] == -1)
                {
                    int prev = (i - 1 + n) % n;
                    int next = (i + 1) % n;
                    if (raw[prev] != -1 && raw[next] != -1)
                    {
                        restored[i] = (raw[prev] + raw[next]) / 2;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
