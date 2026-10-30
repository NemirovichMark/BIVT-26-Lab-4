namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double s = 0;
            foreach (double x in vector)
                s += x * x;
            return Math.Sqrt(s);

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int lt=Math.Min(P, Q);
            int rt=Math.Max(P,Q);
            foreach (int x in array)
            {
                if (x > lt && x < rt)
                    count++;
            }

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array.Length == 0)
                return;
            int maxIndex = 0;
            for (int i = 1; i< array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }
            int minIndex = maxIndex+1;
            if (minIndex >= array.Length)
                return;
            for (int i = maxIndex+2; i < array.Length; i++)
            {
                if (array[i]<array[minIndex])
                    minIndex = i;
            }
            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;


            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length == 0)
                return;
            int maxIndex = 0;

            for(int i = 2;i< array.Length; i+=2)
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
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] == P)
                    return i;
            }
            return -1;

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int c = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[c])
                {
                    c = i;
                }
            }
            for (int i = 0; i+1 < array.Length; i+=2)
            {
                if (i + 1 < c)
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
            return array.Where(x => x >= 0).ToArray();
                        
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            Array.Sort(array);
            Array.Reverse(array);

            // end

        }
        public void Task9(int[] array)
        {

            // code here
            Array.Reverse(array);

            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A.Length == 0 && B.Length == 0)
            {
                C = new int[0];
            }
            else if (A.Length == 0)
            {
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                    C[i] = B[i];
            }
            else if (B.Length == 0)
            {
                C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                    C[i] = A[i];
            }
            else
            {
                C = new int[A.Length + B.Length];
                int idxA = 0, idxB = 0;

                for (int i = 0; i < C.Length; i++)
                {

                    if (idxA < A.Length && (i % 2 == 0 || idxB >= B.Length))
                    {
                        C[i] = A[idxA];
                        idxA++;
                    }
                    else
                    {
                        C[i] = B[idxB];
                        idxB++;
                    }
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
                array = new double[] { a };
            else if (a != b && n > 1)
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                    array[i] = a + i * step;
            }
            else
                array = null;


            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            
            if (raw.Length < 3)
            {
                restored = null;
            }
            else
            {
                bool allminusone = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        allminusone = false;
                        break;
                    }
                }
                
                restored = new double[raw.Length];
                int n = raw.Length;
                
                if (allminusone)
                {
                    for (int i = 0; i < n; i++)
                    {
                        restored[i] = raw[i];
                    }
                }
                
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (raw[i] == -1)
                        {
                            int leftIx;
                            if (i == 0)
                            {
                                leftIx = n - 1;
                            }
                            else
                            {
                                leftIx = i - 1;
                            }
                            int rightIx;
                            if (i == n - 1)
                            {
                                rightIx = 0;
                            }
                            else
                            {
                                rightIx = i + 1;
                            }
                            if (raw[leftIx] != -1 && raw[rightIx] != -1)
                            {
                                restored[i] = (raw[leftIx] + raw[rightIx]) / 2.0;
                            }
                            else
                            {
                                restored[i] = -1;
                            }
                        }
                        else
                        {
                            restored[i] = raw[i];
                        }
                    }

                }
            }


            // end

            return restored;
        }
    }
}

