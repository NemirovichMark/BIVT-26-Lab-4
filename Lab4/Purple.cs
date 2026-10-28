namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int count = 0;
            double summ = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                summ += array[i];
                ++count;
            }
            double sr = summ / count;
            double maxx = -9999999999;
            int max_ind = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > maxx) {
                    maxx = array[i];
                    max_ind = i;
                }
            }
            for (int i = 0; i < array.Length; ++i) {
                if (i > max_ind)
                    array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];
            int ind_even = 0, ind_odd = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (i % 2 == 0)
                {
                    even[ind_even] = array[i];
                    ++ind_even;
                }
                else
                {
                    odd[ind_odd] = array[i];
                    ++ind_odd;
                }

            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length + 1];
            double count = 0;
            int summ = 0;
            for (int i = 0; i < array.Length; ++i) {
                answer[i] = array[i];
                count += 1;
                summ += array[i];
            }
            double sr = summ / count;
            double minn = 999999999;
            int ind_correctel = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (Math.Abs(array[i] - sr) < minn)
                {
                    minn = Math.Abs(array[i] - sr);
                    ind_correctel = i;
                }
            }
            for (int i = answer.Length - 1; i > ind_correctel; --i)
                answer[i] = answer[i - 1];
            answer[ind_correctel + 1] = P; 
            // end

                return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] negative = new int[array.Length];
            int[] pozitive = new int[array.Length];
            int ind_pozitive = 0, ind_negative = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] < 0)
                {
                    negative[ind_negative] = array[i];
                    ++ind_negative;
                }
                else
                {
                    pozitive[ind_pozitive] = array[i];
                    ++ind_pozitive;
                }
            }
            for (int i = 0; i < ind_pozitive; ++i) {
                array[i] = pozitive[i];
            }
            for (int i = 0; i < ind_negative; ++i)
            {
                array[ind_pozitive + i] = negative[i];
            }
            // end
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; ++i)
            {
                answer[i] = A[i];
            }
            int shift = B.Length;
            for (int i = answer.Length - 1; i > k - 1 + shift; --i)
            {
                answer[i] = answer[i - shift];
            }
            int temp = k;
            for (int i = 0; i < B.Length; i++)
            {
                answer[temp + i] = B[i];
            }

            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null || A.Length != B.Length)
            {
                return (null, null);
            }
            sum = new int[A.Length];
            dif = new int[A.Length];
            for (int i = 0; i < A.Length; ++i)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            normalized = new double[array.Length];
            double maxx = int.MinValue;
            double minn = int.MaxValue;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > maxx)
                    maxx = array[i];
                if (array[i] < minn)
                    minn = array[i];    
            }
            if (maxx == minn)
                return null;
            for (int i = 0; i < array.Length; ++i) {
                normalized[i] = 2 * (array[i] - minn) / (maxx - minn) - 1;
            }
            // end

            return normalized;  
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; ++i) {
                for (int j = 0; j < A.Length - i - 1; ++j) {
                    if (A[j] < A[j + 1]) {
                        int temp = A[j];
                        A[j] = A[j + 1];
                        A[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < B.Length; ++i)
            {
                for (int j = 0; j < B.Length - i - 1; ++j)
                {
                    if (B[j] < B[j + 1])
                    {
                        int temp = B[j];
                        B[j] = B[j + 1];
                        B[j + 1] = temp;
                    }
                }
            }
            int ind_A = 0, ind_B = 0, ind_C = 0;
            while (ind_A < A.Length && ind_B < B.Length) {
                if (A[ind_A] > B[ind_B])
                {
                    C[ind_C] = A[ind_A];
                    ++ind_A;
                }
                else
                {
                    C[ind_C] = B[ind_B];
                    ++ind_B;
                }
                ++ind_C;
            }

            while (ind_A < A.Length)
            {
                C[ind_C] = A[ind_A];
                ++ind_A;
                ++ind_C;
            }

            while (ind_B < B.Length)
            {
                C[ind_C] = B[ind_B];
                ++ind_B;
                ++ind_C;
            }
            // end



            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int ind_max = 0;
            int maxx = int.MinValue;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > maxx) {
                    maxx = array[i];
                    ind_max = i;
                }
            }
            int[] ost = new int[array.Length - ind_max];
            int ind_ost = 0;
            for (int i = ind_max; i < array.Length; ++i) {
                ost[ind_ost] = array[i];
                ++ind_ost;
            }
            for (int i = array.Length - 1; i >= ind_max; --i)
            {
                array[i] = array[i - ind_max];
            }
            for (int i = 0; i < ost.Length; ++i) {
                array[i] = ost[i];
            }

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
