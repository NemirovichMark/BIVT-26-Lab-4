using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Xml.Serialization;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int max_array = array[0];
            int max_i = 0;
            int neg_i = -1;
            int sum = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max_array)
                {
                    max_array = array[i];
                    max_i = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg_i = i;
                    break;
                }
            }
            if (neg_i != -1)
            {
                for (int i = max_i + 1; i < array.Length; i++)
                {
                    sum += array[i];
                }
                array[neg_i] = sum;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int pos_i = -1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] > 0)
                {
                    pos_i = i;
                    break;
                }
            }
            if (pos_i == -1)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    copy[i] = array[i];
                }
                return copy;
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= pos_i)
                {
                    answer[i] = array[i];
                }
                else
                {
                    answer[i + 1] = array[i];
                }
            }
            answer[pos_i + 1] = P;
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int min_array = int.MaxValue;
            int min_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < min_array)
                {
                    min_array = array[i];
                    min_i = i;
                }
            }
            if (min_i != -1)
            { 
                answer = new int[array.Length - 1];
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i < min_i)
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
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    copy[i] = array[i];
                }
                return copy;
            }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= average;
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

            // code her
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = sum / array.Length;
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < average)
                {
                    cnt++;
                }
            }
            indexes = new int[cnt];
            int cnt_ind = 0;
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < average)
                {
                    indexes[cnt_ind] = j;
                    cnt_ind++;
                }
            }
            // end

                return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            count = 1;
            int inclen = 1;
            int declen = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    inclen++;
                    declen = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    declen++;
                    inclen = 1;
                }
                else
                {
                    inclen++;
                    declen++;
                }
                int currentmax = Math.Max(inclen, declen);
                if (currentmax > count)
                {
                    count = currentmax;
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
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                answer[2 * i] = array[cnt];
                answer[2 * i + 1] = array[cnt];
                cnt++;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            bool equal = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    equal = false;
                    break;
                }
            }
            if (equal) return null;
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }
            normalized = new double[array.Length];
            double delitel = (max - min);
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - min) / delitel;
            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
            index = -1;
            int low = 0;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    low = mid + 1;
                }
                else if (array[mid] > P)
                {
                    high = mid - 1;
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
                return null;
            if (a > c)
                return new int[0];
            int num = ((c - a) / b) + 1;
            array = new int[num];
            array[0] = a;            
            for (int i = 1; i < num; i++)
            {
                array[i] = array[i - 1] + b;
                if (array[i] > c)
                    break;
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int bestsum = 0;
            int beststart = 0;
            if (magazine.Length >= 3)
            { 
                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    if (magazine[i] + magazine[i + 1] + magazine[i + 2] > bestsum)
                    {
                        bestsum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                        beststart = i;
                    }
                }
                indexes = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    indexes[i] = beststart;
                    beststart++;
                }
            }
            if (magazine.Length < 3)
            {
                for (int i = 0; i < magazine.Length; i++)
                {
                    bestsum += magazine[i];
                }
                indexes = new int[magazine.Length];
                for (int i = 0; i < indexes.Length; i++)
                {
                    indexes[i] = i;
                }
            }
            // end

            return indexes;
        }
    }
}
