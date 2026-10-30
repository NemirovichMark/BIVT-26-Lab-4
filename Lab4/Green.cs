using System.ComponentModel.DataAnnotations;
using System.Security;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int pol = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    pol++;
                }
                if (array[i] < 0)
                {
                    sum += 0;
                    pol += 0;
                }
            }
            if (pol  > 0)
            {
                double arf = sum / pol;
                for (int i = 0;i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i]= arf;
                    }
                }
            }

           
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int neg = 0;
            for(int i  = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg++;
                } 
            }

            if (neg > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        break;
                    }
                    sum += array[i] * array[i];
                }
            }
            else
            {
                return sum;
            }
               
          

            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxN = -1;
            int minN = -1;
            int start = -1;
            int end = -1;
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxN = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minN = i;
                }
            }
            if (minN > maxN)
            {
                start = maxN;
                end = minN;
            }
            else
            {
                start = minN;
                end = maxN;
            }
            int nega = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    nega++;
                }

            }
            int pidydy = 0;
            negatives= new int[nega];
            for(int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[pidydy] = array[i];
                    pidydy++;
                }
               

            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            bool check = false;
            int smena= 0;
            int nega = 0;
            int max = int.MinValue;
            int maxN = 0;
            int negaN = 0;
            if (array == null || array.Length == 0)
            {
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    check = true;
                }
            }

            if (check == false)
            {
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                   max = array[i];
                    maxN = i;
                }
            }
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    nega = array[i];
                    negaN = i;
                    break;
                }
            }
            smena = max;
            array[maxN] = nega;
            array[negaN] = smena;
            

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue;
            int maxN = 0;
            int index = 0;
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i =0;i<array.Length;i++)
            {
                if (array[i] == max)
                {
                    maxN++;
                }
            }
            answer = new int[maxN];
            for(int i = 0;i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }


            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue; 
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] > max) 
                { 
                    max = array[i]; 
                } 
            } 
 
            int index = 1; 
            for (int i = 0; i < array.Length; i++) 
            { 
                if (array[i] == max) 
                { 
                    array[i] = max + index; 
                    index++; 
                } 
            } 

            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int shag = array[i];
                if (array[i] == max)
                {
                    array[i] = sum;
                }
                sum += shag;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int[] n = new int[array.Length];
            int shag = 1;
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    shag++;
                }
                else
                {
                    n[count] = shag;
                    count++;
                    shag = 1;
                }
            }

            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] > length)
                {
                    length = n[i];
                }
            }

            if (length == 0)
            {
                length = 1;
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    count++;
                }
            }

            int[] now = new int[count];
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    now[count] = array[i];
                    count++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < now.Length - 1; j++)
                {
                    if (now[j] > now[j + 1])
                    {
                        (now[j], now[j + 1]) = (now[j + 1], now[j]);
                    }
                }
            }

            count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    array[i] = now[count];
                    count++;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int n = array.Length;
            int count = 0;  
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            cleared = new int[n - count];
            int[] now = new int[count];
            count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        now[count] = j;
                        count++;
                        break;
                    }
                }
            }

            count = 0;
            for (int i = 0; i < n; i++)
            {
                bool skip = false;
                for (int j = 0; j < now.Length; j++)
                {
                    if (i == now[j])
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip != true)
                {
                    cleared[count] = array[i];
                    count++;
                }
            }


            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            A = new double[n];

            if ((n > 1) && (a != b))
            {
                for (int i = 0; i < n; i++)
                {
                    A[i] = ((b - a) / (n - 1) * i) + a;
                }
            }
            else
            {
                return B;
            }

            int count = 0;
            double sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            double mouse = sum / count;
            count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > mouse))
                {
                    count++;
                }
            }

            B = new double[count];
            count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > mouse))
                {
                    B[count] = A[i];
                    count++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;
            int[] index = new int[n];

            for (int i = 0; i < n; i++)
            {
                index[i] = 6;
            }

            int count = 0;
            int count2 = 0;

            for (int i = 0; i < n; i++)
            {
                int shag = index[i] - count;

                if (index[i] == 6)
                {
                    count++;
                }
                index[i] = shag;
                if (index[i] < 1)
                {
                    index[i] = 1;
                }

                int shag2 = dices[i] - count2;

                if (dices[i] == 6)
                {
                    count2++;
                }
                dices[i] = shag2;
                if (dices[i] < 1)
                {
                    dices[i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (dices[i] > index[i])
                {
                    wins++;
                }
            }
            // end

            return wins;

        }
    }
}
