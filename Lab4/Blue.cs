using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int maxind = 0;
            int smax = 0;
            int negind = -1;
            if (array == null || array.Length == 0)
            {
                return;
            }
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > array[maxind])
                {
                    maxind = i;
                }
            }
            if (maxind != array.Length - 1)
            {
                for (int i = maxind + 1; i < array.Length; i++)
                {
                    smax += array[i];
                }
            }
             
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negind = i;
                    break;
                }
            }

            if (negind != -1)
            {
                array[negind] = smax;
            }

            return;
        }
        public int[] Task2(int[] array, int P)
        {
            int lastpol = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    lastpol = i;
                }
            }
            if (lastpol == -1)
            {
                int[] narray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    narray[i] = array[i];
                }
                return narray;
            }

            int[] newarray = new int[array.Length + 1];

            for (int i =0; i <= lastpol; i++)
            {
                newarray[i] = array[i];
            }

            newarray[lastpol + 1] = P;

            for (int i = lastpol + 1; i < array.Length; i++)
            {
                newarray[i + 1] = array[i];
            }

            return newarray;
        }
        public int[] Task3(int[] array)
        {
            int armin = int.MaxValue;
            int arminind = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < armin)
                {
                    armin = array[i];
                    arminind = i;
                }
            }


            if (arminind == -1)
            {
                int[] narray = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    narray[i] = array[i];
                }
                return narray;
            }

            int[] newarray = new int[array.Length - 1];
            int nind = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (i == arminind)
                {
                    continue;
                }
                newarray[nind] = array[i];
                nind++;
            }


            return newarray;
        }
        public double[] Task4(double[] array)
        {

            double sum = 0;
            for (int i = 0;i < array.Length;i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }

            return array;
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            if (A.Length != B.Length)
            {
                return 0;
            }

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }

            return sum;
        }
        public int[] Task6(int[] array)
        {
            double sum = 0;
            int skoka = 0;

            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double sr = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    skoka++;
                }
            }

            if (skoka == 0)
            {
                return new int[0];
            }

            int[] narray = new int[skoka];
            int nind = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    narray[nind] = i;
                    nind++;
                }
            }
            return narray;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }
}
