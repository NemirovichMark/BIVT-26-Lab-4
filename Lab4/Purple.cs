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
