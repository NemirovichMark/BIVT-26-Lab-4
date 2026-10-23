using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int maxindex = 0;
            int sumaft = 0;
            int maxx = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    maxindex = i;
                }
            }
            for (int i = maxindex + 1; i < array.Length; ++i)
            {
                sumaft += array[i];
            }
            int minusch = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minusch = i;
                    break;
                }
            }
            if (minusch != -1)
            {
                array[minusch] = sumaft;
            }
            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int polojt = -1;
            int[] newA = new int[array.Length + 1];
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] > 0)
                    polojt = i;
            }
            for (int i = 0, j = 0; i < array.Length; i++, j++)
            {
                newA[j] = array[i];
                if (i == polojt)
                {
                    j++;
                    newA[j] = P;
                }
            }
            answer = newA;
            if (polojt == -1)
                answer = array;
                // end

                return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            int minpoloj = -1;
            int vrem = 999999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < vrem)
                {
                    minpoloj = i;
                    vrem = array[i];
                }
            }
            if (minpoloj == -1)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    copy[i] = array[i];
                }
                answer = copy;
            }
            else
            {
                int[] newA = new int[array.Length - 1];
                for (int i = 0, j = 0; i < array.Length; i++)
                {
                    if (i == minpoloj)
                        continue;
                    newA[j] = array[i];
                    j++;
                }
                answer = newA;
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

                array[i] = array[i] - average;
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
                    sum += A[i]*B[i];
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
            double sred = sum/array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                    count++;
            }
            int[] now = new int[count];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                {
                    now[j] = i;
                    j++;
                }
            }
            // end
            indexes = now;
            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int maxx = 1; 
            int vozrast = 1;
            int ubiv = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    vozrast++;
                    ubiv = 1;
                }
                else if (array[i] > array[i + 1])
                {
                    ubiv++;
                    vozrast = 1; // Возрастающая последовательность прервалась
                }
                else
                {
                    ubiv++;
                    vozrast++;
                }
                if (vozrast > maxx) maxx = vozrast;
                if (ubiv > maxx) maxx = ubiv;
            }
            count = maxx;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int[] nov = new int[2*array.Length];
            for (int i = 0, j = 0; i < array.Length; i++, j+=2)
            {
                nov[j] = array[i];
                nov[j + 1] = array[i];
                
            }
            answer = nov;
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
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            if (min == max)
                return null;
            double[] vrm = new double[array.Length];
            double zn = max - min;

            for (int i = 0; i < array.Length; i++)
            {
                vrm[i] = (array[i] - min) / zn;
            }
            normalized = vrm;
            // end
            return normalized;
        }
            
            
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            int low = 0;
            int vremi = -1;
            int high = array.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (array[mid] == P)
                {
                    vremi = mid;
                    break;
                }
                else if (array[mid] < P)
                    low = mid + 1;
                else
                    high = mid - 1;    
            }
            index = vremi;
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
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
            int[] array = new int[count];
            int vrem = a;

            for (int i = 0; i < count; i++)
            {
                array[i] = vrem;
                vrem += b;
            }

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
