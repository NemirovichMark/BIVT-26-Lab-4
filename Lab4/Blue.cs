using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int mxindex = 0;
            int nindex = -1;
            int sum = 0;
            int mx = int.MinValue;
            int arl=array.Length;
            bool flag = true;
            for (int i =0;i<arl;i++)
            {
                if (array[i]>mx)
                {
                    mx=array[i];
                    mxindex = i;
                }
                if (array[i]<0 && flag)
                {
                    nindex = i;
                    flag = false;
                }
            }
            for(int i = mxindex+1 ;i<arl;i++)
            {
                    sum+= array[i];
            }
            if(nindex!=-1)
            {
                    array[nindex] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int idxlst = -1;
            int arl=array.Length;
            for(int i=0;i<arl;i++)
            {
                if (array[i] > 0) idxlst = i;
            }
            if(idxlst!=-1)
            {
                answer = new int[arl + 1];
                for (int i = 0; i <= idxlst; i++)
                {
                    answer[i] = array[i];
                }
                answer[idxlst + 1] = P;
                for (int i = idxlst + 1; i < arl; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            else
            {
                answer = new int[arl];
                for(int i = 0;i<arl;i++)
                {
                    answer[i] = array[i];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int mindex = -1;
            int arl = array.Length;

            for (int i = 0; i < arl; i++)
            {
                if (array[i] > 0)
                {
                    if (mindex == -1 || array[i] < array[mindex])
                    {
                        mindex = i;
                    }
                }

            }
            if (mindex == -1)
            {
                answer = new int[arl];

                for (int i = 0; i < arl; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[arl - 1];
                for (int i = 0; i < mindex; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = mindex + 1; i < arl; i++)
                {
                    answer[i - 1] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            int arl= array.Length;
            for (int i = 0; i < arl; i++)
            {
                sum += array[i];
            }
            if (arl != 0)
            {
                double avg = sum / arl;
                for (int i = 0; i < arl; i++)
                {
                    array[i] = array[i] - avg;
                }
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            int arl= A.Length;
            int brl= B.Length;
            if(arl==brl)
            {
                for (int i = 0; i < arl; i++) sum += A[i] * B[i];
            }
            else sum=0;
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double arl = array.Length;
            double avg;
            double sum = 0;
            int cnt= 0,cnt1=0;
            for(int i=0;i<arl;i++) sum += array[i];
            if (arl != 0)
            {
                avg = sum / arl;
                cnt= 0;
                for(int i=0;i<arl;i++)
                {
                    if (array[i] < avg) cnt++;
                }
                indexes = new int[cnt];
                for(int i=0;i<arl; i++)
                {
                    if(array[i] < avg)
                    {
                        indexes[cnt1] = i;cnt1++;
                    }
                }

            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int cnt0 = 0;

            // code here
            int up = 1;
            int down = 1;
            int arl= array.Length;
            if (arl > 0)
            {
                cnt0 = 1;
                for (int i = 1; i < arl; i++)
                {
                    if (array[i] >= array[i - 1])
                    {
                        up++;
                    }
                    else
                    {
                        up = 1;
                    }
                    if (array[i] <= array[i - 1])
                    {
                        down++;
                    }
                    else
                    { down = 1; }
                    if (up > cnt0)
                    {
                        cnt0 = up;
                    }
                    if (down > cnt0)
                    {
                        cnt0 = down;
                    }
                }
            }
            // end

            return cnt0;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int arl=array.Length; //да сколько можно одну и ту же строчку писать 
            answer = new int[arl*2];
            for(int i = 0;i<arl;i++)
            {
                answer[i * 2] = array[i]; 
                answer[i*2+1]=array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int arl = array.Length;
            int mn=int.MaxValue,mx=int.MinValue;
            for(int i=0;i<arl;i++)
            {
                if (array[i] < mn) mn = array[i];
                if (array[i] > mx) mx = array[i];
            }
            if(mx!=mn)
            {
                normalized = new double[arl];
                for(int i =0;i<arl; i++)
                {
                    normalized[i] = ((double)array[i] - mn) / ((double)mx - mn);
                }
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int arl=array.Length;
            int left = 0;
            int right = arl - 1;
            int temp;
            int mid;
            for (int i = 0; i < arl - 1; i++)
            {
                for (int j = 0; j < arl - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            index = -1;
            while (left <= right)
            {
                mid = (left + right) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P) left = mid + 1;
                else right = mid - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int n = 0;//array.Length не используется, удивительно
            if (b > 0)
            {
                if (a <= c)  n = (c - a) / b + 1;
                array = new int[n];
                for (int i = 0; i < n; i++) array[i] = a + i * b;

            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int mrl=magazine.Length;
            int maxSum;
            int best = 0;
            if (mrl < 3)
            {
                indexes = new int[mrl];

                for (int i = 0; i < mrl; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                maxSum = magazine[0] + magazine[1] + magazine[2];
                best = 0;
                for (int i = 0; i < mrl - 2; i++)
                {
                    int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum; best = i;
                    }

                }
                indexes = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    indexes[i] = best + i;
                }
            }
            // end

            return indexes;
        }
    }
}
