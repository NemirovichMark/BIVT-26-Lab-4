using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            // code here
            int summ = 0;
            int max_i = array[0];
            int id_i = 0;
            int id_o = -1;
            if (array.Length <= 1) return;
            for (int i = 1; i<array.Length; i++)
            {
                if (array[i] > max_i)
                {
                    max_i = array[i];
                    id_i = i;
                }
            }

            if (id_i == array.Length-1)
            {
                summ = 0;
            }

            for (int k = id_i+1; k < array.Length; k++)
            {
                summ += array[k];
            }

            for (int y = 0; y < array.Length; y++)
            {
                if (array[y] < 0)
                {
                    id_o = y;
                    break;
                }

               
            }

            if (id_o != -1)
            {
                array[id_o] = summ;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int id = -1;
            if (array.Length == 0)
            {
                return null; 
            }
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                  id = i;  
                  break;
                }
            }

            if (id == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];

                }
            }
            else
            {
                answer = new int[array.Length+1];
                for (int x = 0; x <= id; x++)
                {
                    answer[x] = array[x];
                }

                answer[id + 1] = P;
                for (int i = id + 1; i < array.Length; i++)
                {
                    answer[i+1] = array[i];
                }
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int min = int.MaxValue;
            int min_id = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] > 0)
                {
                    min = array[i];
                    min_id = i;
                }
            }

            if (min_id == -1)
            {
                answer = new int[array.Length];
                for (int x = 0; x < array.Length; x++)
                {
                    answer[x] = array[x];
                }
            }
            else
            {
                answer = new int[array.Length-1];
                for (int y = 0; y < min_id; y++)
                {
                    answer[y] = array[y];
                }

                for (int u = min_id + 1; u < array.Length; u++)
                {
                    answer[u-1] = array[u];
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double c = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                c += 1;
                s += array[i];
            }

            double sr_zn = s / c;
            for (int x = 0; x < array.Length; x++)
            {
                array[x] = array[x]-sr_zn;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length || A.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < A.Length; i++)
            {
                
                    sum += A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int s = 0;
            int c = 0;
            
            if (array.Length == 0)
            {
                return null;
            }
            
         

           
                for (int i = 0; i < array.Length; i++)
                {
                    s += array[i];
                }

                double srZn = (double) s / array.Length;
                for (int y = 0; y < array.Length; y++)
                {
                    if (array[y] < srZn)
                    {
                        c += 1;
                    }
                }

                if (c != 0)
                {
                    indexes  = new int[c];
                    int id = 0;
                    for (int x = 0; x < array.Length; x++)
                    {
                        if (array[x] < srZn)
                        {
                            indexes[id] = x;
                            id++;
                        }
                    }
                }
                else
                {
                    indexes = new int[0];
                }
                // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int maxLen = 1;
            int ci = 1; 
            int cd = 1; 

            for (int i = 1; i < array.Length; i++)
            {
                
                if (array[i] >= array[i - 1])
                {
                    ci++;
                }
                else
                {
                    if (ci > maxLen) maxLen = ci;
                    ci = 1; 
                }

                
                if (array[i] <= array[i - 1])
                {
                    cd++;
                }
                else
                {
                    if (cd > maxLen) maxLen = cd;
                    cd = 1;
                }
            }

            if (ci > maxLen) maxLen = ci;
            if (cd > maxLen) maxLen = cd;

            count = maxLen;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length*2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[2*i] = array[i];
                answer[2*i+1] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max)
            {
                return null;
            }
            normalized = new double[array.Length];
            for (int x = 0; x < array.Length; x++)
            {
                normalized[x] = (double)(array[x] - min)/(max - min);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool f = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int n = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = n;
                        f = true;
                    }
                }

                if (!f)
                {
                    break;
                }
            }

            int l = 0;
            int r = array.Length - 1;
            while (l<=r)
            {
                int m = l + (r - l) / 2;
                if (array[m] == P)
                {
                    index = m;
                    break;
                }
                else if (array[m] < P)
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b < 0) return null;
            if (a > c) return new int[0];
            int count = 0;
            for (int i = a; i <= c; i += b)
            {
                count++;
            }
            array = new int[count];
            int id = 0;
            for (int i = a; i <= c; i += b)
            {
                array[id] = i;
                id++;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            
            int n = magazine.Length;
            if (n < 3)
            {
                indexes = new int[n];
                for (int i = 0; i < n; i++)
                {
                    indexes[i] = i;
                }

                return indexes;
            }
            

            int m = int.MinValue;
            int best = 0;
            for (int j = 0; j <= n - 3; j++)
            {
                int c = magazine[j]+magazine[j+1]+magazine[j+2];
                if (c > m)
                {
                    m = c;
                    best = j;
                }
            }

            indexes = new int[] { best, best + 1, best + 2 };
            
            
            // end

            return indexes;
        }
    }
}