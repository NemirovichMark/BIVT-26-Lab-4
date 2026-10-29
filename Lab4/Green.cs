using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Net.Http.Headers;
using System.Numerics;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sr_arifm = 0;
            int kol = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sr_arifm += array[i];
                    kol += 1;
                    
                }
            }
            sr_arifm = sr_arifm / kol;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr_arifm;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int negIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negIndex = i;
                    break;
                }
            }
            if (negIndex == 0)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < negIndex; i++)
                {
                    sum += array[i] * array[i];
                }
            }
            
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = int.MinValue;
            int maxIndex = 0;
            int min = int.MaxValue;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            
            int left = Math.Min(maxIndex, minIndex);
            int right = Math.Max(maxIndex, minIndex);

            int count = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            negatives = new int[count];
            int nach = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives[nach] = array[i];
                    nach++;
                }
            }

            // end

            return negatives;
        }
      
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            int max = int.MinValue;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int negIndex = -1;

            for (int i  = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negIndex = i;
                    break;
                }
            }
            if (negIndex != -1)
            {
                int temp = array[negIndex];
                array[negIndex] = array[maxIndex];
                array[maxIndex] = temp;
            }
            // end
           
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int count_max = 0;
            int max = int.MinValue;
            int maxIndex = -1;
            int nach = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    count_max = 1;
                }
                else if (array[i] == max)
                {
                    count_max++;
                }
            }
            if (count_max != 0)
            {
                answer = new int[count_max];
                nach = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        answer[nach] = i;
                        nach++;
                    }
                }
            }
            
             // end

            return answer ?? [];
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

            int count_max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count_max ++;
                    array[i] = array[i] + count_max;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here

            
            int maxIndex = 0;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            
            int[] original = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                original[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (original[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += original[j];
                    }
                    array[i] = sum;
                }
                
            }
            
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int current = 1;
            length = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current++;
                }
                else
                {
                    current = 1;
                }
                if (current > length)
                {
                    length = current;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 2; j+=2)
                {
                    if (array[j] > array[j + 2])
                    {
                        int temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
                    }
                }
                
            }
        }
            // end

        
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int length = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int left = 0; left < i; left++)
                {
                    if (array[i] == array[left])
                    {
                        length--;
                        break;
                    }
                }
            }

            cleared = new int[length];
            int nach = 0;
            

            for (int i = 0; i < array.Length; i++)
            {
                int flag = 0;
                for (int left = 0; left < i; left++)
                {
                    if (array[i] == array[left])
                    {
                        flag = 1;
                    }
                }
                if (flag == 0)
                {
                    cleared[nach] = array[i];
                    nach++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if ((n <= 1) || (a == b))
            {
                return B;
            }
            
            
            A = new double[n];
            double step = ((b - a) / (n - 1));
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            

            double srarifm = 0;
            int ksrarifm = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    srarifm += A[i];
                    ksrarifm++;
                }
            }
            if (ksrarifm == 0)
            {
                return [];
            }
            srarifm = srarifm / ksrarifm;


            int length_B = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] >  srarifm))
                {
                    length_B++;
                }
            }

            B = new double[length_B];
            int B_nach = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > srarifm))
                {
                    B[B_nach] = A[i];
                    B_nach++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int sixes = 0; 

            for (int i = 0; i < dices.Length; i++)
            {
                int player = Math.Max(1, dices[i] - sixes);
                int cheater = Math.Max(1, 6 - i); 

                if (player > cheater)
                    wins++;

                if (dices[i] == 6) 
                    sixes++;
            }
            // end

            return wins;
        }
    }
}
