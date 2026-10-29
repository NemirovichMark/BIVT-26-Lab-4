using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int sum = 0;
            int min = -1;
            int max = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0 && min == -1)
                {
                    min = i;
                }
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i > max)
                    sum += array[i];
            }
            if (min != -1) array[min] = sum;




        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            int ip = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    ip = i;
                }
            }

            if (ip == -1)
            {
                answer = new int[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    answer[i] = array[i];
                }
            }
            else
            {
                answer = new int[array.Length + 1];

                for (int i = 0; i <= ip; i++)
                {
                    answer[i] = array[i];
                }

                answer[ip + 1] = P;

                for (int i = ip + 1; i < array.Length; i++)
                {
                    answer[i + 1] = array[i];
                }
            }

            return answer;
        }


        public int[] Task3(int[] array)
        {
            int[] answer = null;
            int ip = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && (ip == -1 || array[i] < array[ip]))
                {
                    ip = i;
                }
            }

            int size = array.Length;

            if (ip != -1)
            {
                size--;
            }

            answer = new int[size];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i != ip)
                {
                    answer[j] = array[i];
                    j++;
                }
            }

            return answer;


        }
        public void Task4(double[] array)
        {
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i]-sr;
            }

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            if (A.Length != B.Length) return 0;
            else
            {
                for (int i = 0; i < A.Length; i++)
                {
                    sum += A[i] * B[i];
                }

                return sum;
            }

        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            double sum = 0;
            int mensr = 0; 
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double sr = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr) mensr++;
            }
            indexes = new int[mensr];
            int j = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sr)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 1;
            int up = 1;
            int down = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    up++;
                    down = 1;
                }
                else if (array[i] < array[i - 1])
                {
                    down++;
                    up = 1;
                }
                else
                {
                    up++;
                    down++;
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
            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                (answer[j], answer[j+1]) = (array[i], array[i]);
                j += 2;
            }
            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }


            if (min==max) return normalized;
            else
            {
                normalized = new double[array.Length];

                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (double) (array[i] - array[min]) / (array[max] - array[min]);
                }

                return normalized;
            }
            
        }
        public int Task10(int[] array, int P)
        {
            

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int q = array[j];
                        (array[j], array[j + 1]) = (array[j + 1], q);
                    }
                }
            }
            for (int left = 0, right = array.Length - 1; left <= right;)
            {
                int mid = (left + right) / 2;

                if (array[mid] == P)
                {
                    return mid;
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

            return -1;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            if (b <= 0) return array;

            int count = 0;

            for (long i = a; i <= c; i += b)
            {
                count++;
            }

            array = new int[count];
            int j = 0;

            for (long i = a; i <= c; i += b)
            {
                array[j] = (int)i;
                j++;
            }

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;


            int count = 3;
            int ip = 0;

            if (magazine.Length < 3)
            {
                count = magazine.Length;
            }
            else
            {
                int max = magazine[0] + magazine[1] + magazine[2];

                for (int i = 1; i < magazine.Length - 2; i++)
                {
                    int sum = magazine[i] + magazine[i + 1] + magazine[i + 2];

                    if (sum > max)
                    {
                        max = sum;
                        ip = i;
                    }
                }
            }

            indexes = new int[count];

            for (int i = 0; i < count; i++)
            {
                indexes[i] = ip + i;
            }

            return indexes;
        }
    }
}
