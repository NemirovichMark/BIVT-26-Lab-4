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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Math.Min(P, Q) && array[i] < Math.Max(P, Q))
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
            if (array.Length == 0)
            {
                return;
            }

            int maxIndex = 0;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1)
            {
                return;
            }
            int minIndex = maxIndex+1;

            
           

            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            if (array[minIndex] == array[maxIndex])
            {
                return;
            }
            int temp = array[minIndex];
            array[minIndex] = array[maxIndex];
            array[maxIndex] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length == 0)
                return;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i+=2)
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
            int index = -1;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] ==P)
                    {
                    index=i;
                    break;
                    }
            }

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array.Length == 0)
                return;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
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
            for (int i = 0; i < array.Length-1; i++)
            {
                int maxIndex = i;
                for (int k=i+1;k<array.Length;k++)
                {
                 if (array[k] > array[maxIndex])
                     {
                        maxIndex = k;
                     }
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
            C=new int[A.Length+B.Length];
            int k = 0;
            for (int i = 0; i < Math.Max(A.Length, B.Length);i++)
            {
                if (i<A.Length)
                {
                    C[k] = A[i];
                    k++;
                }
                if (i<B.Length)
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
                return new double[] { a };
            }

            if (n < 2 || a == b)
            {
                return null;
            }
            array = new double[n];
            double step=(b-a)/(n-1);
            for (int i = 0; i < n; i++)
            {
                array[i] = a + step * i;
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
            }


            // end

            return restored;
        }
    }
}