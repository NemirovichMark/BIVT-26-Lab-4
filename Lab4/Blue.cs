using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            double max = double.MinValue;
            int indexMax = -1;

            for (int i = 0; i < array.Length; i++)
            { if (array[i] > max) { max = array[i]; indexMax = i; } }

            double min = double.MaxValue;
            int indexOtr = -1;

            for (int i = 0; i < array.Length; i++)
            { if (array[i] < min && array[i] < 0) { min = array[i]; indexOtr = i; break; } }

            double sum = 0;
            for (int i = indexMax + 1; i < array.Length; i++)
            { sum += array[i]; }

            if (max != double.MinValue && indexOtr != -1)
            {
                if (indexMax == array.Length - 1) { array[indexOtr] = 0; }
                else { array[indexOtr] = (int)sum; }
            }

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here

            int indexPos = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    indexPos = i;
                }
            }

            if (indexPos == -1)
            {
                answer = array;
            }
            else
            {
                int[] result = new int[array.Length + 1];

                for (int i = 0; i <= indexPos; i++)
                {
                    result[i] = array[i];
                }

                result[indexPos + 1] = P;

                for (int i = indexPos + 1; i < array.Length; i++)
                {
                    result[i + 1] = array[i];
                }

                answer = result;
            }

            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            double min = double.MaxValue;
            int indexMin = -1;

            for (int i = 0; i < array.Length; i++)
            { if (array[i] > 0 && array[i] < min) { min = array[i]; indexMin = i; } }

            if (min == double.MaxValue) { answer = array; }
            else
            {
                int[] result = new int[array.Length - 1];

                for (int i = 0; i < indexMin; i++)
                { result[i] = array[i]; }

                for (int i = indexMin + 1; i < array.Length; i++)
                { result[i - 1] = array[i]; }
                answer = result;
            }



            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            { sum += array[i]; count++; }

            double middleAns = sum / count;

            for (int i = 0; i < array.Length; i++)
            { array[i] = array[i] - middleAns; }


            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A.Length == B.Length)
            { 
                for (int i = 0; i < A.Length && i < B.Length; i++)
                { sum += A[i] * B[i]; } 
            }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here

            double sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            if (array.Length == 0)
            {
                indexes = new int[0];
            }
            else
            {
                double mid = sum / array.Length;
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < mid)
                    {
                        count++;
                    }
                }

                indexes = new int[count];

                int k = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < mid)
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
            if (array.Length > 0)
            {
                count = 1;

                int up = 1;
                int down = 1;

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
            answer = new int[array.Length * 2];
            int h = 2;
            for (int i = 0, k = 0; i < array.Length; i++)
            {
                answer[k] = array[i];
                answer[k + 1] = array[i];
                k+=h;
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            double max = double.MinValue;
            double min = double.MaxValue;
            for (int i = 0; i < array.Length; i++)
            { 
                if (array[i] < min) { min = array[i]; }
                if (array[i] > max) { max = array[i]; }
            }
            if (max == min) { normalized = null; }
            else
            {
                normalized = new double[array.Length];
                for ( int i = 0; i < normalized.Length; i++)
                {
                    normalized[i] = (array[i] - min) / (max - min);
                }

            }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;

            int i = 1, j = 2;
            int n = array.Length;
            while (i < n)
            {
                if (i == 0|| array[i] >= array[i - 1]) 
                {
                    i = j; j++;
                }
                else 
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    i--;
                }

            }

            int low = 0;
            int high = array.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                else if (array[mid] < P)
                {
                    low = mid + 1;
                }
                else
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
            if (b > 0)
            {
                int count = 0;

                for (int x = a; x <= c; x += b)
                {
                    count++;
                }

                array = new int[count];

                if (count > 0)
                {
                    array[0] = a;

                    for (int i = 1; i < count; i++)
                    {
                        array[i] = array[i - 1] + b;
                    }
                }
            }
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];

                for (int i = 0, k = 0; i < magazine.Length; i++)
                {
                    indexes[k] = i;
                    k++;
                }
            }
            else
            {
                int count = magazine[0] + magazine[1] + magazine[2];

                for (int i = 0; i < magazine.Length - 2; i++)
                {
                    int summa = 0;

                    summa = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (summa > count)
                    {
                        count = summa;
                    }
                }

                indexes = new int[3];

                for (int i = 0, k = 0; i < magazine.Length - 2; i++)
                {
                    if (magazine[i] + magazine[i + 1] + magazine[i + 2] == count)
                    {
                        indexes[k] = i;
                        indexes[k + 1] = i + 1;
                        indexes[k + 2] = i + 2;

                        break;
                    }
                }
            }
            // end

            return indexes;
        }
    }
}
