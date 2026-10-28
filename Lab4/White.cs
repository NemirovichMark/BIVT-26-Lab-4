using static System.Runtime.InteropServices.JavaScript.JSType;

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
            if (A == null) A = new int[0];
            if (B == null) B = new int[0]; 

             C = new int[A.Length + B.Length];

            Array.Copy(A, 0, C, 0, A.Length);
            Array.Copy(B, 0, C, A.Length, B.Length);

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a > b)
            {
                double temp = a;
                a = b;
                b = temp;
            }

            if (a == b)
            {
                return new double[] { a };
            }

            array = new double[n];
            

            for (int i = 0; i < n; i++)
            {
                array[i] = a+(b-a);
            }

            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            int dc = 0;
            int nc = 0;
            double s = 0;
            for (int i=0; i<raw.Length; i++)
            {
                if (raw[i]==-1)
                {
                    dc++;
                }
                else
                {
                    s += raw[i];
                    nc++;
                }
            }
            if (dc<3)
            {
                return null;
            }
            double a = s / nc;
            double[] r = (double[])raw.Clone();
            for (int i =1; i<r.Length; i++)
            {
                if (r[i]==-1)
                {
                    r[i] = a;
                }
            }

            // end

            return restored;
        }
    }
}
