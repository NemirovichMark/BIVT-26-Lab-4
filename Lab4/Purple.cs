namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -999999;
            double cnt = 0;
            double s = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                cnt ++;
                s += array[i];
                if (mx < array[i])
                {
                    mx = array[i];
                    index = i;

                }
            }
            double dl = s / cnt;
            for (int j = index + 1;  j < array.Length; j++)
            {
                array[j] = dl;
            }
            return;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int cnt1 = (array.Length + 1) / 2;
            int cnt2 = array.Length / 2;
            even = new int[cnt1];
            odd = new int[cnt2];
            int eEn = 0;
            int oEn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[eEn++] = array[i];
                }
                else
                {
                    odd[oEn++] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length+1];
            double s = 0;
            double cnt = 0;
            double dl = 0;
            double mn = 99999999;
            int inA = 0;
            int index = 0;
            int index2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                cnt++;
            }
            dl = s / cnt;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - dl) < mn)
                {
                    mn = Math.Abs(array[i] - dl);
                    index = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                answer[index2++] = array[i];
                if (i == index)
                {
                    answer[index2++] = P;
                }
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int p = 0;
            int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) p++;
                else m++;
            }
            int[] plus = new int[p];
            int[] mins = new int[m];
            int inp = 0;
            int inm = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) plus[inp++] = array[i];
                else mins[inm++] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i < p)
                {
                    array[i] = plus[i];
                }
                else
                {
                    array[i] = mins[i - p];
                }
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            // code here
            if (k > A.Length) return A;
            answer = new int[A.Length + B.Length];
            int st = 0;
            if (k > A.Length) k = A.Length;
            for (int i = 0; i < k; i++)
            {
                answer[st++] = A[i];
            }
            for (int j = 0; j < B.Length; j++)
            {
                answer[st++] = B[j];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[st++] = A[i];
            }
            // end
            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            } else return (sum, dif);
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int mx = -99999999;
            int mn = 99999999;
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                mx = Math.Max(mx, array[i]);
                mn = Math.Min(mn, array[i]);
            }

            if (mx - mn == 0)
            {
                return null;
            }

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = -1 + 2 * ((array[i] - mn) / (double)(mx - mn));
            }
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
