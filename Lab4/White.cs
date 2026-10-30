namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i < vector.Length; i++)
                length += (double)vector[i] * vector[i];

            length = Math.Sqrt(length);

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
                if (P < array[i] && Q > array[i])
                    count++;

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int x = 0;

            for (int i = 1; i < array.Length; i++)
                if (array[x] < array[i])
                    x = i;

            if (x == array.Length - 1)
                return;

            int n = x + 1;

            for (int i = n + 1; i < array.Length; i++)
                if (array[n] > array[i])
                    n = i;

            (array[x], array[n]) = (array[n], array[x]);

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int x = 0;

            for (int i = 2; i < array.Length; i += 2)
                if (array[x] < array[i])
                    x = i;

            array[x] = x;

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;

            for (int i = 0; i < array.Length; i++)
                if (array[i] == P)
                {
                    index = i;
                    break;
                }

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int x = 0;

            for (int i = 1; i < array.Length; i++)
                if (array[x] < array[i])
                    x = i;

            for (int i = 0; i + 1 < x; i += 2)
                (array[i], array[i + 1]) = (array[i + 1], array[i]);

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int k = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    k++;

            answer = new int[k];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = array.Length - 1; j > i; j--)
                    if (array[j] > array[j - 1])
                        (array[j], array[j - 1]) = (array[j - 1], array[j]);

            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length / 2; i++)
            {
                int j = array.Length - 1 - i;

                (array[i], array[j]) = (array[j], array[i]);
            }

            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];

            int k = 0;
            int n = Math.Max(A.Length, B.Length);

            for (int i = 0; i < n; i++)
            {
                if (i < A.Length)
                {
                    C[k] = A[i];
                    k++;
                }

                if (i < B.Length)
                {
                    C[k] = B[i];
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
            else if (a != b && n >= 2)
            {
                array = new double[n];

                double h = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                    array[i] = a + i * h;
            }

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw.Length < 3)
                return null;

            restored = new double[raw.Length];

            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];

                int l = i - 1;
                int r = i + 1;

                if (l < 0)
                    l = raw.Length - 1;

                if (r == raw.Length)
                    r = 0;

                if (raw[i] == -1 && raw[l] != -1 && raw[r] != -1)
                    restored[i] = (raw[l] + raw[r]) / 2;
            }

            // end

            return restored;
        }
    }
}