using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double average = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = average;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int neg_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg_index = i;
                    break;
                }
            }

            for (int i = 0; i < neg_index; i++)
            {
                sum += array[i] * array[i];
            }
            
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            //code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }

            int max_index = 0;
            int min_index = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max_index])
                {
                    max_index = i;
                }
                if (array[i] < array[min_index])
                {
                    min_index = i;
                }
            }

            int start = Math.Min(max_index, min_index);
            int end = Math.Max(max_index, min_index);
            
            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            negatives = new int[count];

            int index = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here

            if (array == null || array.Length == 0) return;

            int max_index = 0;
            int neg1_index = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_index])
                {
                    max_index = i;
                }
                if (array[i] < 0 && neg1_index == -1)
                {
                    neg1_index = i;
                }
            }

            if (neg1_index >= 0)
            {
                int max = array[max_index];
                array[max_index] = array[neg1_index];
                array[neg1_index] = max;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return new int[0];

            int max_num = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_num)
                {
                    max_num = array[i];
                }
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_num)
                {
                    count++;
                }
            }

            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_num)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int max_num = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_num)
                {
                    max_num = array[i];
                }
            }

            int period_max_num = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_num)
                {
                    array[i] = array[i] + period_max_num;
                    period_max_num++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int max_num = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_num)
                {
                    max_num = array[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int original = array[i];
                if (original == max_num && i != 0)
                {
                    array[i] = sum;
                }
                sum += original;
            }

            if (array[0] == max_num)
            {
                array[0] = 0;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array == null || array.Length == 0) return 0;

            int current_length = 1;
            int max_length = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current_length++;
                }
                else
                {
                    current_length = 1;
                }
                if (current_length > max_length)
                {
                    max_length = current_length;
                }
            }

            length = max_length;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            int count = (array.Length + 1) / 2;
            int[] evenElements = new int[count];

            for (int i = 0, j = 0; i < array.Length; i += 2)
            {
                evenElements[j++] = array[i];
            }

            for (int i = 0; i < count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < count; j++)
                {
                    if (evenElements[j] < evenElements[minIndex])
                        minIndex = j;
                }

                if (minIndex != i)
                {
                    int temp = evenElements[i];
                    evenElements[i] = evenElements[minIndex];
                    evenElements[minIndex] = temp;
                }
            }

            for (int i = 0, j = 0; i < array.Length; i += 2)
            {
                array[i] = evenElements[j++];
            }

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length <= 1) return array;

            int uniqueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j]) isUnique = false;
                }

                if (isUnique) uniqueCount++;
            }

            cleared = new int[uniqueCount];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j]) isUnique = false;
                }

                if (isUnique)
                {
                    cleared[index++] = array[i];
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


            double average = 0; 
            int count = 0; 
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    average += A[i];
                    count++;
                }
            }
            if (count == 0)
            {
                return [];
            }
            average = average / count;


            int length_B = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > average))
                {
                    length_B++;
                }
            }

            B = new double[length_B];
            int B_nach = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > average))
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
