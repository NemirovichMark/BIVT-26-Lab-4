using System.Numerics;
using System.Threading.Tasks.Dataflow;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                    idx++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                int j = array[i];
                if (j < 0)
                {
                    pl[idx] = j;
                    idx++;
                }
            }
            for (int i = 0; i < pl.Length; i++)
            {
                array[i] = pl[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < k)
                    {
                        answer[i] = A[i];
                    }
                    else if (i < k + B.Length)
                    {
                        answer[i] = B[i - k];
                    }
                    else
                    {
                        answer[i] = A[i - B.Length];
                    }
                }
            }
            else
            {
                answer = A;
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
            double mx = double.MinValue, mn=double.MaxValue, dif;
            int lel = array[0], flag = 0;
            for(int i=0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
                if (array[i] < mn)
                {
                    mn = array[i];
                }
                if (array[i] != lel)
                {
                    flag = 1;
                }
            }
            dif = 2 / (double)(mx - mn);
            if (flag==1){
                normalized= new double[array.Length];
                for(int i=0; i < array.Length; i++)
                {
                    normalized[i]=((array[i]-mn)*dif)-1;
                }
            }
                // end

                return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for(int i=0; i < C.Length; i++)
            {
                if (i < A.Length)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i-A.Length];
                }
            }
            for (int gap =C.Length/ 2; gap > 0; gap/=2) {
                for(int i=gap; i<C.Length; i++)
                {
                    int key = C[i], j;
                    for(j=i; j>=gap && C[j-gap]<key; j -= gap)
                    {
                        C[j] = C[j - gap];
                    }
                    C[j] = key;

                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = array[0], idx = 0;
            int[] b = new int[array.Length];
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] > mx)
                {
                    mx = array[i];
                    idx = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i + idx < array.Length)
                {
                    b[i + idx] = array[i];

                }
                else
                {
                    b[i+idx-array.Length]=array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = b[i];
            }
                // end

            }
        public void Task10(int[] array, int N)
        {
            // code here
            N--;
            int ln=Math.Min(array.Length, N*2+1);
            for(int i=(N+1); i<ln; i++)
            {
                array[i] = array[N - (i - N)];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if ((b > a)||(b==a && n==1))
            {
                X = new double[n];
                Y = new double[n];
                double step = 0;
                if (n > 1)
                {
                    step = (b-a) / (n-1);
                }
                for(int i=0; i<n; i++)
                {
                    double x = a + (step * i);
                    X[i] = x;
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                }
                int extcnt = 0;
                for(int i=1; i<n-1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                    {
                        extcnt++;
                    }
                }
                Xext = new double[extcnt];
                Yext = new double[extcnt];
                int extidx = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                    {
                        Xext[extidx] = X[i];
                        Yext[extidx] = Y[i];
                        extidx++;
                    }
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0, avg, favg;
            for(int i=0; i<raw.Length; i++)
            {
                sum += raw[i];
            }
            favg = sum / raw.Length;
            sum = 0;
            int bcnt = 0, ncnt = 0, dcnt = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                double s = raw[i];
                if (s > 2 * favg)
                {
                    bcnt++;
                    raw[i] = -s;
                }
                else if (s < favg / 2)
                {
                    dcnt++;
                    raw[i] = -s;
                }
                else
                {
                    ncnt++;
                    sum += s;
                }
            }
            avg = sum / ncnt;
            bright=new double[bcnt];
            dim = new double[dcnt];
            normal = new double[raw.Length];
            int didx = 0, bidx = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                double s = raw[i];
                if (s<=0)
                {
                    s = Math.Abs(s);
                    if (s > 2 * favg)
                    {
                        bright[bidx] = s;
                        bidx++;
                    }
                    else if (s < favg / 2)
                    {
                        dim[didx] = s;
                        didx++;
                    }
                    s = (s + avg) / 2;
                }
                normal[i] = s;
            }
            for (int gap = normal.Length / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < normal.Length; i++)
                {
                    double key = normal[i];
                    int j;
                    for (j = i; j >= gap && normal[j - gap] < key; j -= gap)
                    {
                        normal[j] = normal[j - gap];
                    }
                    normal[j] = key;

                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
