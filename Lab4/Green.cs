namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here

            int count = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            
            double srzn = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = srzn;
                    
                }
            }

          
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            bool flag = false;
            // code here
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    flag = true;
                    break;
                }
               
                sum+= array[i]*array[i];
            }

            sum = flag ? sum : 0;
            
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max=0, min =0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min]) min = i;
                if (array[i] > array[max]) max = i;
            }
            
            int count=0;

            int from = Math.Min(max,min)+1;
            int to = Math.Max(min,max);
            for (int i = from; i < to; i++)
            {
                if(array[i]<0) count++;
                
            }
            negatives = new int[count];
            int k = 0;
            for (int i = from; i < to; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k++] = array[i];
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int indmax = 0;
            int otrp = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[indmax]) indmax = i;
                if (otrp == -1 && array[i]<0)
                {
                    otrp = i;
                }
            }

            if (otrp != -1)
            {
                int a = array[indmax];
                int b = array[otrp];
                array[indmax] = b;
                array[otrp] = a;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int max = array[0];
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max =array[i];
                
            }
            int count=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }
            answer = new int[count];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) answer[c++] = i;
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int c = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += c;
                    c++;
                }
                
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>max)max = array[i];
            }

            int sum = 0;
            int t = 0;
            for (int i = 0; i < array.Length; i++)
            {
                t = array[i];
                if (array[i] == max)
                {
                    array[i] = sum;
                    
                }
                sum += t;
                
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int[] len = new int[array.Length];
            int k = 0;
            int c = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    c++;
                }
                else
                {
                    len[k++] = c;
                    c = 1;
                }
            }
            int max = 1;

            for (int i = 0; i < len.Length; i++)
            {
                if (len[i] > max)
                {
                    max = len[i];
                }
            }
            length = max;
            
            // int max = 1;
            // int c = 1;
            // for (int i = 0; i < array.Length-1; i++)
            // {
            //     if (array[i] > array[i + 1])
            //     {
            //         c++;
            //     }
            //     else
            //     {
            //         if (c > max) max = c;
            //         c = 1;
            //     }
            //
            // }
            // if (c>max) max = c;
            // length = max;



            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 2; i < array.Length; i += 2)
            {
                int current = array[i];
                int j = i - 2;
                while (j >= 0 && array[j] > current)
                {
                    array[j + 2] = array[j];
                    j -= 2;
                }
                array[j + 2] = current;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool flag = false;
                for (int j = 0; j < i ;j++)
                {
                    if (array[i] == array[j])
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    c++;
                }
            }
            cleared = new int[c];

            int indexCountInd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool flag2 = false;
                for (int j = 0; j < indexCountInd; j++)
                {
                    if (array[i] == cleared[j])
                    {
                        flag2 = true;
                        break;
                    }

        
                }
                if (!flag2)
                {
                    cleared[indexCountInd] = array[i];
                    indexCountInd++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n >= 2 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);
                double s = 0;
                double countp = 0;
                for (int i = 0;i < n;i++)
                {
                    A[i] = a + i * step;
                    if (A[i] > 0)
                    {
                        s += A[i];
                        countp++;
                    }
                }
                double sr = s / countp;
                int count = 0;
                for (int i = 0;i < n;i++)
                {
                    if (A[i] > 0 && A[i] > sr)
                    {
                        count++;
                    }
                }
                B = new double[count];
                int r = 0;
                for (int i = 0;i < n;i++)
                {
                    if (A[i] > 0 && A[i] > sr)
                    {
                        B[r++] = A[i];
                    }
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int six = 0;
            for (int i = 0;i < dices.Length;i++)
            {
                int player = Math.Max(1,dices[i] - six);
                int cheater = Math.Max(1,6 - i);
                if (player > cheater)
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    six++;
                }
            }
            // end

            return wins;

        }
    }
}
