namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            int n = vector.Length;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                double a = vector[i];
                s += a * a;

            }
            length = Math.Sqrt(s);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<max && array[i]>min)
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
            bool elementsequal = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[0])
                {
                    elementsequal = false;
                    break;
                }
            }
            int maxIndex = 0;
            for (int i=1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex == array.Length - 1)
                return;
            int minIndex = maxIndex + 1;
            for (int i = maxIndex+1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
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
            bool elementsequal = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != array[0])
                {
                    elementsequal = false;
                    break;
                }
            }
            int maxIndex = 0;
            for(int i=2;i< array.Length; i+=2)
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i; break;
                }
                else
                    index = -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            if (maxIndex>0)
            {
                for (int i =0; i+1<maxIndex;i+=2)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i+1] = temp;
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
            answer= new int[count];
            int j = 0;
            
             for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
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
            int i = 1, j = 2, n = array.Length;
            while (i < n)
            {
                if (i==0 || array[i - 1] >= array[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    i--;
                }
            }

            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            for (int i=0; i<n/2;i++)
            {
                (array[i], array[n - 1 - i]) = (array[n - 1 - i], array[i]);
            }

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
            //1
            if (raw.Length <3)
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
                //2
                restored = new double[raw.Length];
                int n = raw.Length;
                //3
                if (allminusone)
                {
                    for (int i = 0; i < n; i++)
                    {
                        restored[i] = raw[i];
                    }
                }
                //4
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
