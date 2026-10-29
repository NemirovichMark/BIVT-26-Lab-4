using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int negIndex = -1;
            int maxIndex = 0;
            int maxValue = int.MinValue;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && negIndex == -1)
                {
                    negIndex = i;
                }
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }
            if (maxIndex != array.Length-1)
            {
                for (int i = maxIndex + 1; i < array.Length; i++)
                {
                    sum = sum + array[i];
                }
            }
            if (negIndex != -1)
            {
                array[negIndex] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            // code here
            int posIndex = -1;
            for (int i = 0; i < array.Length;i++)
            {
              if (array[i] > 0)
              {
                    posIndex = i;
              }
            }
            if (posIndex != -1)
            {
                answer = new int[array.Length+1];
                for (int i = 0;i < answer.Length;i++)
                {
                    if (i < posIndex + 1)
                    {
                        answer[i] = array[i];
                    }
                    else if(i == posIndex+1)
                    {
                        answer[i] = P;
                    }
                    else
                    {
                        answer[i] = array[i-1];
                    }
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < answer.Length; i++)
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
            int minValue = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minValue)
                {
                    minIndex = i;
                    minValue = array[i];
                }
            }  
            if (minIndex != -1)
            {
                answer = new int[array.Length-1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < minIndex)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i] = array[i + 1];
                    }
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < answer.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            double avg;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - avg;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length != B.Length)
            {
                return 0;
            }
            for (int i = 0; i < A.Length && i < B.Length; i++)
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
            double sum = 0;
            double avg;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            avg = sum / array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    count++;
                }
            }
            int[] answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avg)
                {
                    answer[j] = i;
                    j++;
                }
            }
            return answer;
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array.Length == 0 || array == null)
            {
                return count;
            }
            int v = 1;
            int y = 1;
            count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i-1])
                {
                    v++;
                }
                else
                {
                    v = 1;
                }
                if (array[i] <= array[i - 1])
                {
                    y++;
                }
                else
                {
                    y = 1;
                }
                if (v > count)
                {
                    count = v;
                }
                if (y > count)
                {
                    count = y;
                }

            }
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[i * 2] = array[i];
                answer[i * 2 + 1] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double min = array[0];
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            if (max == min)
            {
                return null;
            }
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / (max - min);
            }
            // end
                
                return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1-i; j++)
                {
                    if (array[j] > array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            int left = 0;
            int right = array.Length - 1;
            index = -1;
            while (left <= right)
            {
                int middle = left + (right - left) / 2;
                if (array[middle] == P)
                {
                    index = middle;
                    break;
                }
                else if (array[middle] < P)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }
            }

            // end

            return index;
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
            for (int i = a; i <= c; i += b)
            {
                count++;
            }
            array = new int[count];
            for (int i = 0; i < count; i++)
            {
                array[i] = a + i * b;
            }

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            indexes = new int[magazine.Length < 3 ? magazine.Length : 3];
            if (magazine.Length < 3) { for (int i = 0; i < magazine.Length; i++) { indexes[i] = i; } }
            else
            {
                int maxSum = magazine[0] + magazine[1] + magazine[2]; int startIndex = 0;
                for (int i = 1; i <= magazine.Length - 3; i++)
                {
                    int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startIndex = i;
                    }
                }

                for (int i = 0; i < 3; i++)
                {
                    indexes[i] = startIndex + i;
                }
            }
            // end

            return indexes;
        }
    }
}