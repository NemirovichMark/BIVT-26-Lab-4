using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxIndex = 0;
            int negativeIndex = -1;
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }
            for(int i = maxIndex +1;i < array.Length; i++)
            {
                sum += array[i];
            }
            if (negativeIndex != -1)
            {
                array[negativeIndex] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int LastIndex = -1;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    LastIndex = i;
                }
            }
            if (LastIndex != -1)
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i <= LastIndex; i++)
                {
                    answer[i] = array[i];
                }
                answer[LastIndex + 1] = P;
                for (int i = LastIndex + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
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
            int minIndex = -1;
            for ( int i = 0; i < array.Length; i ++)
            {
                if (array[i] >0)
                {
                    if(minIndex == -1 || array[i] < array[minIndex])
                    {
                        minIndex = i;
                    }
                }

            }
            if (minIndex == -1)
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length - 1];
                for(int i = 0; i < minIndex; i++)
                {
                    answer[i] = array[i];
                }
                for(int i = minIndex+1; i < array.Length; i ++)
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
            for(int i = 0; i<array.Length; i ++)
            {
                sum += array[i];
            }
            if ( array.Length != 0)
            {
                double srednee = sum / array.Length;
                for (int i = 0; i < array.Length; i ++)
                {
                    array[i] = array[i] - srednee;
                }
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }
            }
            else
            {
                sum = 0;
            }
                // end

                return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            if ( array.Length != 0)
            {
                double srednee = sum /array.Length;
                int cnt = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    if (array[i] < srednee)
                    {
                        cnt++;
                    }
                }
                indexes = new int[cnt];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < srednee)
                    {
                        indexes[k] = i;
                        k++;
                    }
                }

            }
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int up = 1;
            int down = 1;
            if (array.Length > 0)
            {
                count = 1;
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
                    { down = 1; }
                    if (up > count)
                    {
                        count = up;
                    }
                    if (down > count)
                    {
                        count = down;
                    }
                }
            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
                answer = new int [array.Length*2];
                for(int i = 0; i < array.Length; i++)
                {
                    answer[i+i] = array[i];
                    answer[i+i+1] = array[i];
                }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if(array.Length != 0)
            {
                int min = array[0];
                int max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                if (max != min)
                {
                    normalized = new double[array.Length];
                    for (int i = 0; i < array.Length; i++)
                    {
                        normalized[i] = ((double)array[i] - min) / ((double)max - min);
                    }
                }
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int left = 0;
            int right = array.Length - 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            index = -1;
            while(left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            int n = 0;
            if (b > 0)
            {
                if (a <= c)
                {
                    n = (c - a) / b + 1;
                }
                array = new int[n];
                for(int i = 0; i < n; i ++)
                {
                    array[i] = a + i * b;
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if(magazine.Length < 3)
            {
                indexes = new int[magazine.Length];

                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            else
            {
                int maxSum = magazine[0] + magazine[1] + magazine[2];
                int bestRoom = 0;
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (sum > maxSum)
                    {
                        maxSum = sum; bestRoom = i;
                    }
                    
                }
                indexes = new int[3];
                for(int i = 0; i < 3; i++)
                {
                    indexes[i] = bestRoom + i;
                }
            }
            // end

            return indexes;
        }
    }
}
