namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            foreach (int x in vector) 
            {
                length += x * x;
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            foreach (int element in array)
            {
                if (min < element && element < max)
                {
                    count += 1;
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
            int maxIndex = 0;
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] > array[maxIndex])
                {
                    maxIndex = j;
                }
            }
            if (maxIndex == array.Length - 1) return;
            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            if (array[maxIndex] == array[minIndex])
            {
                return ;
            }
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
            for (int i = 0; i < array.Length; i += 2)
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
            if (array == null) return -1;
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
            if (array == null || array.Length <= 1) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex == 0) return;
            for (int i = 0; i + 1 < maxIndex; i = i + 2)
            {
                int term = array[i];
                array[i] = array[i + 1];
                array[i + 1] = term;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null; // chek existing array
            int count = 0;
            foreach (int x in array)
            {
                if (x >= 0)
                {
                    count++;
                }
            }
            answer = new int[count]; // закидываем в answer какая у нас будет длина массива
            int index = 0;
            foreach (int x in array)
            {
                if (x >= 0)
                {
                    answer[index] = x;
                    index = index + 1;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
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
            if (array == null || array.Length <= 1) return;
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
            if (A == null && B == null) return new int[0];
            if (A == null)
            {
                int[] copyB = new int[B.Length];
                for (int i = 0; i < B.Length; i++) copyB[i] = B[i];
                return copyB;
            }
            if (B == null)
            {
                int[] copyA = new int[A.Length];
                for (int i = 0; i < A.Length; i++) copyA[i] = A[i];
                return copyA;
            }
            C = new int[A.Length + B.Length];
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;
            while (indexA < A.Length || indexB < B.Length)
            {
                if (indexA < A.Length)
                {
                    C[indexC] = A[indexA];
                    indexA++;
                    indexC++;
                }
                if (indexB < B.Length)
                {
                    C[indexC] = B[indexB];
                    indexB++;
                    indexC++;
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
            else if (n <= 0 || a == b || n == 1)
            {
                array = null;
            }
            else
            {
                array = new double[n];
                array[0] = a;
                array[n - 1] = b;
                if (n > 2)
                {
                    double step = (b - a) / (n - 1);
                    for (int i = 1; i < n - 1; i++)
                    {
                        array[i] = a + i * step;
                    }
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
            {
                restored = null;
            }
            else
            {
                restored = new double[raw.Length];
                int minusOneCount = 0;
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                    if (raw[i] == -1.0)
                    {
                        minusOneCount++;
                    }
                }
                if (minusOneCount != raw.Length)
                {
                    for (int i = 0; i < raw.Length; i++)
                    {
                        if (raw[i] == -1.0)
                        {
                            int leftIndex = (i == 0) ? raw.Length - 1 : i - 1;
                            int rightIndex = (i == raw.Length - 1) ? 0 : i + 1;
                            double leftValue = raw[leftIndex];
                            double rightValue = raw[rightIndex];
                            if (leftValue != -1.0 && rightValue != -1.0)
                            {
                                restored[i] = (leftValue + rightValue) / 2.0;
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