using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            if (array==null || array.Length == 0)
            {
                return;
            }
            int maxindex = 0;
            for (int i=1;  i<array.Length; i++)
            {
                if (array[i]>array[maxindex])
                {
                    maxindex = i;
                }
            }
            int sum = 0;
            for (int i = maxindex+1;  i<array.Length; i++)
            {
                sum=sum+array[i];
            }
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
           

            // code here
            int[] answer = null;

            if (array == null)
            {
                return null;
            }

            int pospol = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    pospol = i;
                }
            }

            int novdl = array.Length;

            if (pospol != -1)
            {
                novdl++;
            }

            answer = new int[novdl];

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                answer[j] = array[i];
                j++;

                if (i == pospol)
                {
                    answer[j] = P;
                    j++;
                }
            }

            return answer;
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            

            // code here
            int[] answer = null;
            if (array == null)
            {
                return null;
            }
            int minindex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (minindex==-1 || array[i] < array[minindex])
                    {
                        minindex = i;
                    }
                } 
            }
            int newLength = array.Length;

            if (minindex != -1)
            {
                newLength--;
            }

            int[] result = new int[newLength];
            int j = 0;
            for (int i =0; i < array.Length; i++)
            {
                if (i != minindex)
                {
                    result[j] = array[i];
                    j++;

                }
            }
            answer = result;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sr = 0;
            if (array == null)
            {
                return;
            }
            if (array.Length == 0)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                sr = sr + array[i] / array.Length;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] - sr;
            }
            // end

        }
        public int Task5(int[] A, int[] B)
        {


            // code here
            int sum = 0;
            int peremnogenoe = 0;
            if (A == null || B == null)
            {
                return 0;
            }
            if (A.Length != B.Length)
            {
                return 0;
            }
            for (int i = 0; i < A.Length; i++)
            {
                peremnogenoe = A[i] * B[i];
                sum = sum + peremnogenoe;
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if (array == null)
            {
                return null;
            }

            if (array.Length == 0)
            {
                return new int[0];
            }
            double sr = 0;
            double sum = 0;
            int k = 0;
            for (int i =0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            sr = sum / array.Length;
            for (int i =0; i<array.Length; i++)
            {
                if (array[i] < sr)
                {
                    k++;
                }
            }
            int[] result = new int[k];
            int j = 0;
            for (int i=0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    result[j] = i;
                    j++;
                }
            }
            indexes = result;
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

            int a = 1;
            int b = 1;
            count = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    a++;
                }
                else
                {
                    a = 1;
                }

                if (array[i] <= array[i - 1])
                {
                    b++;
                }
                else
                {
                    b = 1;
                }

                if (a > count)
                {
                    count = a;
                }

                if (b > count)
                {
                    count = b;
                }
            }

            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int index = 0;
            if (array == null)
            {
                return null;
            }
            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[index] = array[i];
                index++;
                answer[index] = array[i];
                index++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here

            if (array == null || array.Length == 0)
            {
                return null;
            }

            int min = array[0];
            int max = array[0];

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

            if (min == max)
            {
                return null;
            }

            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = ((double)array[i] - min) / ((double)max - min);
            }

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here

            index = -1;

            if (array == null)
            {
                return index;
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int x = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = x;
                    }
                }
            }

         
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

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
            int k = 0;
            int x = a;
            if (b <= 0)
            {
                return null;
            }
            while (x <= c)
            {
                k++;
                x = x + b;
            }
            array = new int[k];
            x = a;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = x;
                x = x + b;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here

            if (magazine == null)
            {
                return null;
            }

            if (magazine.Length < 3)
            {
                indexes = new int[magazine.Length];

                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }

                return indexes;
            }

            int max = magazine[0] + magazine[1] + magazine[2];
            int index = 0;

            for (int i = 1; i + 2 < magazine.Length; i++)
            {
                int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];

                if (sum > max)
                {
                    max = sum;
                    index = i;
                }
            }

            indexes = new int[3];

            indexes[0] = index;
            indexes[1] = index + 1;
            indexes[2] = index + 2;

            // end

            return indexes;
        }
    }
}