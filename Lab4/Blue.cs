using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Xml.Serialization;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here\
            int sum = 0;
            int max = array[0];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i > ind)
                    sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    array[i] = sum;
                    break;
                }
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int o = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    o = i;
            }

            if (o == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            else
            {
                answer = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    if (i <= o)
                        answer[i] = array[i];
                    else
                        answer[i + 1] = array[i];
                }
                answer[o + 1] = P;
            }
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int k = -1;
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min && array[i] > 0)
                {
                    min = array[i];
                    k = i;
                }
                    
            }
            if (k != -1)
            {
                answer = new int[array.Length - 1];
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (i < k)
                     {
                        answer[i] = array[i];
                    }
                    if (i >= k)
                    {
                        answer[i] = array[i+1];
                    }
                }
            }
            else
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                    answer[i] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            int L = array.Length;
            double sum = 0, sr = 0;
            for (int i = 0; i < L; i++)
            {
                sum += array[i];
            }
            sr = sum / L;
            for (int i = 0; i < L; i++)
            {
                array[i]= array[i] - sr;
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
                    sum += A[i] * B[i];
            }

            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int L = array.Length;
            double sum = 0, sr = 0;
            int k = 0;
            for (int i = 0; i < L; i++)
            {
                sum += array[i];
            }
            sr = sum / L;
            for (int i = 0; i < L; i++)
            {
                if (array[i] <  sr)
                {
                    k += 1;
                }
            }
            indexes = new int[k];
            int j = 0;
            for (int i = 0; i < L; i++)
            {
                if (array[i] < sr)
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
            int k = 1;
            int j = 1;
            count = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1]) k += 1;
                else k = 1;

                if (array[i] >= array[i - 1]) j += 1;
                else j = 1;

                if (k > count) count = k;
                if (j > count) count = j;
            }
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
                answer[i*2] = array[i];
                answer[i*2+1] = array[i];
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

            if (min != max)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                    normalized[i] = ((double)array[i] - min) / ((double)max - min);
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            int n = array.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            int target = P, low = 0, high = array.Length - 1;
            index = -1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == target)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < target)
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                int o = a, k = 0;
                while (o <= c)
                {
                    o += b;
                    k++;
                }
                array = new int[k];
                for (int i = 0; i < k; i++)
                {
                    array[i] = a;
                    a += b;
                }
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
                int z = magazine[0] + magazine[1] + magazine[2];
                indexes = new int[] { 0, 1, 2 };    
                for (int i = 1; i < magazine.Length - 2; i++)
                {
                    int zd = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    if (zd > z)
                    {
                        z = zd;
                        for (int j = 0; j < 3; j++)
                        {
                            indexes[j] = i + j;
                        }
                    }
                }
            }
            // end

            return indexes;
        }
    }
}
