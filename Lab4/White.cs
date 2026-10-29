namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            double S = 0.0;
            for (int i = 0; i < vector.Length; i++)
            {
                S+=vector[i] * vector[i];
            }
            length=Math.Sqrt(S);

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int min = Math.Min(P, Q);
                int max = Math.Max(P, Q);
                if (array[i]>min &array[i]<max)
                {
                    count++;
                }
            }

            return count;
        }
        public void Task3(int[] array)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int minIndex = -1;
            int maxIndex = -1;
            int i = 0;
            for (;i<array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            for (int l = 0; l < array.Length; l++)
            {
                if (array[l] < min & (l +1 > maxIndex))
                {
                    min = array[l];
                    minIndex = l;
                }
                
            }

            array[minIndex] = max;
            array[maxIndex] = min;
        }
        public void Task4(int[] array)
        {
            double max=double.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max & i%2==0)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            array[maxIndex] = maxIndex;

        }
        public int Task5(int[] array, int P)
        {
            int index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        public void Task6(int[] array)
        {

            int max=Int32.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
        
                }
            }
            for (int i = 0; i < maxIndex-1; i+=2)
            {
                int elem =array[i];
                array[i] = array[i+1];
                array[i+1]=elem;
            }

        }
        public int[] Task7(int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }
            int[] answer =new int[count];
            int l = 0;
            for (int i = 0; i < array.Length; i++)
            {
    
                if (array[i] >= 0)
                {
                    answer[l] = array[i];
                    l++;
                }
    
            }
            return answer;
        }
        public void Task8(int[] array)
        {
            
           // int[]answer=new int[array.Length];
           int cnt = 0;
           do
           {
               cnt = 0;
               for (int i = 0; i < array.Length - 1; i++)
               {
                   if (array[i] < array[i + 1])
                   {
                       int max = array[i + 1];
                       array[i + 1] = array[i];
                       array[i] = max;
                       cnt = 1;
                   }
               }
               
           } while (cnt == 1);
        }
        public void Task9(int[] array)
        {
            
            int[] aswer =new int [array.Length];
            int l = 0;
            for (int i = array.Length-1; i >= 0; i--, l++)
            {
                aswer[l] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = aswer[i];
            }
            
        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C=new int[A.Length+B.Length];
            int max=Math.Max(A.Length,B.Length);
            int l = 0;
            for (int i = 0; i < max; i++)
            {
                if (i < A.Length)
                {
                    C[l++] = A[i];
                }

                if (i < B.Length)
                {
                    C[l++] = B[i];
                }
            }

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array3 = { a };
            if (a == b)
            {
                if (n == 1)
                {
                    return array3;
                }
                return null;
            }


            if (n < 2)
            {
                return null;
            }


            double[] result = new double[n];


            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                result[i] = a + i * step;
            }

            result[n - 1] = b;

            return result;
        }

        public double[] Task12(double[] raw)
        {
            if (raw == null || raw.Length < 3)
            {
                return null;
            }

            int n = raw.Length;
            bool allbroken = true;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] != -1)
                {
                    allbroken = false;
                    break;
                }
            }

            if (allbroken)
            {
                return raw;
            }
            
            double[] restored = new double[n];

            for (int i = 0; i < n; i++)
            {
                if (raw[i] != -1)
                {
                    restored[i] = raw[i];
                    continue;
                }


                int l = (i - 1 + n) % n;
                int r = (i + 1) % n;
                
                if (raw[l] != -1 && raw[r] != -1)
                {
                    restored[i] = (raw[l] + raw[r]) / 2.0;
                }
                else
                {
                    restored[i] = -1;
                }
            }

            return restored;
        }
    }
}
