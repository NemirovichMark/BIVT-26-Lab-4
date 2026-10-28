using System.Numerics;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0, mx = Double.MinValue;
            int mxidx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > mx) {
                    mx = array[i];
                    mxidx = i+1;
                }
            }
            sum/=array.Length;
            if (mxidx < array.Length)
            {
                for (; mxidx < array.Length; mxidx++)
                {
                    array[mxidx] = sum;
                }
            }
            
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[array.Length / 2 + array.Length % 2];
            odd = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i/2]=array[i];
                }
                else
                {
                    odd[(i-1)/2]=array[i];
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
            double avg = 0, mgn=double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                avg+= array[i];
            }
            avg /= array.Length;
            int idx = 0;
            for (int i = 0; i < array.Length; i++) {
                double chk = 0;
                chk = Math.Abs(avg - array[i]);
                if (chk < mgn)
                {
                    mgn = chk;
                    idx = i;
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                if (i <= idx)
                {
                    answer[i] = array[i];
                }else if (i > (idx+1))
                {
                    answer[i] = array[i-1];
                }
                else
                {
                    answer[i] = P;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {
            // code here
            int[] pl = new int[array.Length];
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int j = array[i];
                if (j >= 0)
                {
                    pl[idx] = j;
                    Console.WriteLine("{0}, {1}, {2}", j, pl[idx], idx);
                    idx++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                int j = array[i];
                if (j < 0)
                {
                    pl[idx] = j;
                    Console.WriteLine("{0}, {1}, {2}", j, pl[idx], idx);
                    idx++;
                }
            }
                array = pl;
            for (int i = 0; i < pl.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k <= A.Length)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i <= k)
                    {
                        answer[i] = A[i];
                    }
                    else if (i <= k + B.Length)
                    {
                        answer[i] = B[i - k - 1];
                    }
                    else
                    {
                        answer[i] = A[i - B.Length];
                    }
                }
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

                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            //Different normalization
            double mx = 0;
            int lel = array[0], flag = 0;
            for(int i=0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > mx)
                {
                    mx=Math.Abs(array[i]);
                }
                if (array[i] != lel)
                {
                    flag = 1;
                }
            }
            if ((flag==1)&&(mx>1)){
                normalized= new double[array.Length];
                for(int i=0; i < array.Length; i++)
                {
                    normalized[i]=array[i]/mx;
                }
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
