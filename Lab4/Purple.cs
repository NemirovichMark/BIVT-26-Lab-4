namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
             if (array == null || array.Length == 0)
            {
                return;
            }
            double m = array[0];
            double mIndex = 0;
            double s = 0;
            double mid = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (array[i] > m)
                {
                    m = array[i];
                    mIndex = i;
                }
            }
            mid = s / array.Length;
            for (double j = (mIndex + 1); j < array.Length; j++)
            {
                array[(int)j] = mid;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array == null)
            {
                return (even, odd);
            }
            int[] even1 = new int[(array.Length + 1) / 2];
            int[] odd1 = new int[(array.Length / 2)];
            int evenI = 0;
            int oddI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even1[evenI] = array[i];
                    evenI++;
                }
                else
                {
                    odd1[oddI] = array[i];
                    oddI++;
                }
            }
            for (int i = 0; i < even1.Length; i++)
            {
                even[i] = even1[i];
            }
            for (int i = 0; i < odd1.Length; i++)
            {
                odd[i] = odd1[i];
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return answer;
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double mid = (double)sum / array.Length;
            int cI = 0;
            double cD = Math.Abs(array[0] - mid);
            for (int j = 0; j < array.Length; j++)
            {
                if (Math.Abs(array[j] - mid) < cD)
                {
                    cD = Math.Abs(array[j] - mid);
                    cI = j;
                }
            }
            answer = new int[array.Length+1];
            for (int k = 0; k < array.Length; k++)
            {
                if (k <= cI)
                {
                    answer[k] = array[k];
                }
                else if (k == cI + 1)
                {
                    answer[k] = P;
                }
                else
                {
                    answer[k+1] = array[k]; 
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null)
            {
                return;
            }
            int[] answer = new int[array.Length];
            int aI = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] >= 0)
                {
                    answer[aI] = array[j];
                    aI++;
                }
            }
            aI = 0;
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < 0)
                {
                    answer[aI] = array[k];
                    aI++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = answer[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
 }
