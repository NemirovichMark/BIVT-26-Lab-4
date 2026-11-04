using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (array.Length == 0 || array==null)
            {
                return;
            }

            int MI = 0;

            for(int i = 1;i<array.Length;i++)
            {
                if (array[i] > array[MI])
                {
                    MI = i;
                    
                }
            }

            int sum = 0;
           
            for (int i = MI+1; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (MI == array.Length - 1)
            {
                sum = 0;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <0)
                {
                    
                    array[i]=sum;
                    break;
                }
            }
            


            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            if (array == null)
            {
                return null;
            }

            // code here
            int ind = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ind = i;
                }
            }
            if (ind == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];

                return answer;
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i <= ind; i++)
            {
                answer[i] = array[i];
            }
            answer[ind + 1] = P;
            for (int i = ind + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here

            int minind = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && (minind == -1 || array[i] < array[minind]))
                {
                    minind = i;
                }
            }

            if (minind == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];

                return answer;
            }

            answer = new int[array.Length - 1];

            for (int i = 0; i < minind; i++)
            {
                answer[i] = array[i];
            }

            for (int i = minind+1; i < array.Length; i++)
            {
                answer[i - 1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double znach = 0;

            for(int i=0; i<array.Length; i++)
            {
                znach+= array[i];
            }

            znach = znach / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i]-znach;
            }

            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if(A==null || B == null || A.Length != B.Length)
            {
                return 0;
            }
            

            for(int i = 0; i < A.Length; i++)
            {
                sum+= A[i] * B[i];
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int count = 0;
            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double sred = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                    count++;
            }

            indexes = new int[count];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            // end
            

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                return 0;
            }

            if (array.Length == 1)
            {
                return 1;
            }

            int up = 1;
            int down = 1;
            int max = 1;

            for (int i = 1; i < array.Length; i++)
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
                {
                    down = 1;
                }


                if (up > max)
                {
                    max = up;
                }
                else if(down > max)
                {
                    max = down;
                }
            }

            count= max;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null)
            {
                return null;
            }

            answer = new int[array.Length * 2];
            
            for (int i = 0; i < array.Length; i++)
            {
                answer[2*i]= array[i];
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

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) 
                    min = array[i];
                if (array[i] > max) 
                    max = array[i];
            }

            if (min == max)
                return null;

            normalized = new double[array.Length];
            double zn = max - min;

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / zn;
            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0) 
                return -1;

            
            for (int i = 1; i < array.Length; i++)
            {
                int current = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > current)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = current;
            }

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                index = left + (right - left) / 2;

                if (array[index] == P)
                    return index;

                if (array[index] < P)
                    left = index + 1;
                else
                    right = index - 1;
            }

            return -1;
        
            // end

            
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0)
            {
                return null;
            }
            if (a > c)
            {
                return new int[0];
            }
            int count = 0;
            int temp = a;

            while (temp <= c)
            {
                count++;
                temp += b;
            }
            array = new int[count];
            int vrem = a;

            for (int i = 0; i < count; i++)
            {
                array[i] = vrem;
                vrem += b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                int maxs = magazine[0] + magazine[1] + magazine[2];
                int bestk = 0;

                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    int currentSum = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (currentSum > maxs)
                    {
                        maxs = currentSum;
                        bestk = i;
                    }
                }

                indexes = new int[3];
                indexes[0] = bestk;
                indexes[1] = bestk + 1;
                indexes[2] = bestk + 2;
            }
            // end

            return indexes;
        }
    }
}