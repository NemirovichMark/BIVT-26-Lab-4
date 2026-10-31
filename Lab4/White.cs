using System;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            
            // code here
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }
            length = System.Math.Sqrt(sum);
            // end
            
            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            
            // code here
            int min = System.Math.Min(P, Q);
            int max = System.Math.Max(P, Q);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                {
                    count++;
                }
            }
            // end
            
            return count;
        }

        public void Task3(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            if (maxIndex == array.Length - 1) return;

            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex]) minIndex = i;
            }

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;
            
            int maxEvenIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxEvenIndex])
                {
                    maxEvenIndex = i;
                }
            }
            array[maxEvenIndex] = maxEvenIndex;
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;
            
            // code here
            index = System.Array.IndexOf(array, P);
            // end
            
            return index;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length < 2) return;
            
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end
        }

        public int[] Task7(int[] array)
        {
            int[] answer = null;
            
            // code here
            if (array == null) return new int[0];
            
            int countPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) countPositive++;
            }

            answer = new int[countPositive];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }
            }
            // end
            
            return answer;
        }

        public void Task8(int[] array)
        {
            // code here
            if (array != null)
            {
                System.Array.Sort(array);
                System.Array.Reverse(array);
            }
            // end
        }

        public void Task9(int[] array)
        {
            // code here
            if (array != null)
            {
                System.Array.Reverse(array);
            }
            // end
        }

        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;
            
            // code here
            if (A == null) A = new int[0];
            if (B == null) B = new int[0];
            
            C = new int[A.Length + B.Length];
            int k = 0;
            int maxLen = System.Math.Max(A.Length, B.Length);

            for (int i = 0; i < maxLen; i++)
            {
                if (i < A.Length) C[k++] = A[i];
                if (i < B.Length) C[k++] = B[i];
            }
            // end
            
            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;
            
            // code here
            if (n <= 0) return null;
            if (n == 1)
            {
                if (a == b) return new double[] { a };
                return null;
            }
            if (a == b) return null;

            array = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * step;
            }
            // end
            
            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;
            
            // code here
            if (raw == null) return null;
            
            restored = (double[])raw.Clone();
            if (raw.Length < 3) return restored;

            bool allBroken = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allBroken = false;
                    break;
                }
            }
            if (allBroken) return restored;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    if (i > 0 && i < raw.Length - 1) 
                    {
                        if (raw[i - 1] != -1 && raw[i + 1] != -1)
                        {
                            restored[i] = (raw[i - 1] + raw[i + 1]) / 2.0;
                        }
                    }
                    else if (i == 0) 
                    {
                        if (raw[1] != -1 && raw[2] != -1)
                        {
                            restored[i] = (raw[1] + raw[2]) / 2.0;
                        }
                    }
                    else if (i == raw.Length - 1) 
                    {
                        if (raw[i - 1] != -1 && raw[i - 2] != -1)
                        {
                            restored[i] = (raw[i - 1] + raw[i - 2]) / 2.0;
                        }
                    }
                }
            }
            // end
            
            return restored;
        }
    }
}
