using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            if (array == null || array.Length == 0)
            {
                return;
            }

            int maxx = 0;
            int maxVal = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxx = i;
                }
            }

            int summ = 0;
            for (int i = maxx + 1; i < array.Length; i++)
            {
                summ += array[i];
            }

            int minus = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minus = i;
                    break;
                }
            }

            if (minus != -1)
            {
                array[minus] = summ;
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            


            if (array == null)
                return null;

            int last = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    last = i;
                    break;
                }
            }

            if (last == -1)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    copy[i] = array[i];
                return copy;
            }

            int[] answer = new int[array.Length + 1];

            
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= last)
                {
                    answer[i] = array[i];      
                }
                else
                {
                    answer[i + 1] = array[i];  
                }
            }

            answer[last + 1] = P; 

            
        

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            

            bool hz = false;
            int minn = -1;
            int min2 = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min2)
                {
                    min2 = array[i];
                    minn = i;
                    hz = true;
                }
            }

            if (!hz)
            {
                int[] res = new int[array.Length];
                for (int j = 0; j < array.Length; j++)
                {
                    res[j] = array[j];
                }
                return res;
            }

            int[] answer = new int[array.Length - 1];
            int vlevo = 0;

            for (int k = 0; k < array.Length; k++)
            {
                if (k == minn)
                {
                    vlevo = 1;
                }
                else
                {
                    answer[k - vlevo] = array[k];
                }
            }

            return answer;
        }
        public void Task4(double[] array)
        {

            double summ = 0;

            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            double del = summ / array.Length;

            for (int i = 0; i < array.Length; i++)
            {

                array[i] = array[i] - del;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            

            if (A == null || B == null)
            
                return 0;
            

            int summ = 0;

            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    summ += A[i] * B[i];
                }
            }

            return summ;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            if (array == null)
            
                return null;
            
            if (array.Length == 0)
            
                return new int[0];
            

            int cnt = 0;
            double summ = 0;

            for (int i = 0; i < array.Length; i++)
            
                summ += array[i];
            

            double del = summ / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < del)
                    cnt++;
            }

            int[] now = new int[cnt];

            for (int i = 0, l = 0; i < array.Length; i++)
            {
                if (array[i] < del)
                {
                    now[l] = i;
                    l++;
                }
            }

            return now;
        }
        public int Task7(int[] array)

        {
            int[] indexes = null;
            int cnt = 0;

            if (array == null ) 
                return 0;
            if (array.Length == 0)
                return 0;

            if (array.Length == 1) 
                return 1;

            int maxx = 1;

            int now = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    now++;
                }
                else
                {
                    now = 1;
                }
                if (now > maxx) maxx = now;
            }

            now = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1])
                {
                    now++;}


                else
                {
                    now = 1;
                }
                if (now > maxx) 
                    maxx = now;
            }

            cnt = maxx;

            // end

            return cnt;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            if (array == null)
            {
                return null;
            }

            int[] now = new int[2 * array.Length];

            for (int i = 0, l = 0; i < array.Length; i++, l += 2)
            {
                now[l] = array[i];
                now[l + 1] = array[i];
            }

            

            // end

            return now;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            if (array == null || array.Length == 0) 
                return null;

            int minn = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minn) minn = array[i];
            }

            int maxx = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxx) maxx = array[i];
            }

            if (minn == maxx)
            {
                return null;
            }

            double[] res = new double[array.Length];
            double razn = maxx - minn;

            for (int i = 0; i < array.Length; i++)
            {
                res[i] = (double)(array[i] - minn) / razn;
            }

            return res;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            index = -1;

            int n = array.Length;
            int l = 0; 
            int r = n - 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            while (l <= r)
            {
                int sred = l + (r - l) / 2;
                if (array[sred] == P)
                                    return sred;
                
                else if (array[sred] < P)
                
                    l = sred + 1;
                
                else
                
                    r = sred - 1;
                

            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            if (b < 0)
                return null;
            
            if (a < 0 && c < 0)
            {
                return new int[] { };
            }

            int dlina = (c - a) / b + 1;

            array = new int[dlina];
            int l = -1;
            int new2 = a;
            for ( ; new2 <= c; new2 += b)
            {
                array[++l] = new2;
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            if (magazine == null) 
                return null;

            

            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                                    indexes[i] = i;
                
            }
            else
            {
                int maxx = magazine[0] + magazine[1] + magazine[2];
                int yep = 0;

                
                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    int now = 0;

                    
                    for (int l = 0; l < 3; l++)
                    {
                        now = now + magazine[i + l];
                    }

                    if (now > maxx)
                    {
                        maxx = now;
                        yep = i;
                    }
                }

                indexes = new int[3];

                indexes[0] = yep;
                indexes[1] = yep + 1;
                indexes[2] = yep + 2;
            }

            return indexes;
        }
    }
}
