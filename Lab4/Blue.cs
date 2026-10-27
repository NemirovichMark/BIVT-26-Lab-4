using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int n = array.Length;
            int maxIndex = 0;
            int negIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    negIndex = i;
                    break;
                }
            }

            if (negIndex == -1) return;

            int s = 0;

            for (int i = maxIndex + 1; i < n; i++)
            {
                s += array[i];
            }

            array[negIndex] = s;
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;
            int n = array.Length;
            int posIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    posIndex = i;
                }
            }

            if (posIndex == -1)
            {
                answer = new int[n];
                for (int i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n + 1];
                for (int i = 0; i <= posIndex; i++)
                {
                    answer[i] = array[i];
                }

                answer[posIndex + 1] = P;

                for (int i = posIndex + 1; i < n; i++)
                {
                    answer[i + 1] = array[i];
                }
            }
            
            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            int n = array.Length;
            int minIndex = -1;
            
            for (int i = 0; i < n; i++)
            {
                if ((array[i] > 0) && (minIndex == -1 || array[i] < array[minIndex]))
                {
                    minIndex = i;
                }
            }

            if (minIndex == -1)
            {
                answer = new int[n];
                for (int  i = 0; i < n; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[n - 1];
                for (int i = 0; i < minIndex; i++)
                {
                    answer[i] = array[i];
                }
                for (int i = minIndex + 1; i < n; i++)
                {
                    answer[i-1] = array[i];
                }
            }

            return answer;
        }
        public void Task4(double[] array)
        {
            double s = 0;
            double n = array.Length;

            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }

            double avg = s / n;

            for (int i = 0; i < n; i++)
            {
                array[i] -= avg;
            }
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            int lenA = A.Length;
            int lenB = B.Length;

            if (lenA != lenB) return 0;

            for (int i = 0; i < lenA; i++)
            {
                sum += A[i] * B[i];
            }
            
            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;
            double s = 0;
            double n = array.Length;

            for (int i = 0; i < n; i++)
            {
                s += array[i];
            }
            double avg = s / n;

            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < avg)
                {
                    c++;
                }
            }

            indexes = new int[c];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < avg)
                {
                    indexes[k] = i;
                    k++;
                }
            }

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;
            int n = array.Length;
            

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here

            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            // end

            return indexes;
        }
    }
}
