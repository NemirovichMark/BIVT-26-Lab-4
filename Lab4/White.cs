using System;

namespace Lab4
{
    public class White
    {
        // Task 1: Find the geometric length of the vector (square root of sum of squares)
        public double Task1(int[] vector)
        {
            double length = 0;
            if (vector == null || vector.Length == 0) return 0;

            double sumOfSquares = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sumOfSquares += (double)vector[i] * vector[i];
            }

            length = Math.Sqrt(sumOfSquares);
            return length;
        }

        // Task 2: Count how many elements sit strictly between boundaries P and Q
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            if (array == null) return 0;

            int minBound = Math.Min(P, Q);
            int maxBound = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minBound && array[i] < maxBound)
                {
                    count++;
                }
            }

            return count;
        }

        // Task 3: Find the minimum element after the maximum element and swap them
        public void Task3(int[] array)
        {
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1) return;

            int minIndex = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }

            int temp = array[maxIndex];
            array[maxIndex] = array[minIndex];
            array[minIndex] = temp;
        }

        // Task 4: Double all elements that come after the maximum element
        public void Task4(int[] array)
        {
            if (array == null || array.Length < 2) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] *= 2;
            }
        }

        // Task 5: Find the index of the first element that is strictly less than parameter P
        public int Task5(int[] array, int P)
        {
            int index = -1; 
            if (array == null) return index;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < P)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        // Task 6: Swap adjacent elements before the maximum element
        public void Task6(int[] array)
        {
            if (array == null || array.Length < 2) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i + 1 < maxIndex; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
        }

        // Task 7: Filter out negative values into a new array
        public int[] Task7(int[] array)
        {
            if (array == null) return null;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) count++;
            }

            int[] answer = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[j] = array[i];
                    j++;
                }
            }
            return answer;
        }

        // Task 8: Sort descending in-place directly on the array (void method)
        public void Task8(int[] array)
        {
            if (array == null) return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        // Task 9: Reverse elements in-place directly on the array (void method)
        public void Task9(int[] array)
        {
            if (array == null) return;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        // Task 10: Alternate merge elements from arrays A and B
        public int[] Task10(int[] A, int[] B)
        {
            if (A == null) A = new int;
            if (B == null) B = new int;

            int[] C = new int[A.Length + B.Length];
            int a = 0, b = 0, c = 0;

            while (a < A.Length && b < B.Length)
            {
                C[c++] = A[a++];
                C[c++] = B[b++];
            }

            while (a < A.Length) C[c++] = A[a++];
            while (b < B.Length) C[c++] = B[b++];

            return C;
        }

        // Task 11: Create an array of n equally spaced values between a and b
        public double[] Task11(double a, double b, int n)
        {
            if (n <= 1) return null;

            double[] result = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                result[i] = a + step * i;
            }

            result = a;
            result[n - 1] = b;

            return result;
        }

        // Task 12: Restore damaged elements marked with -1.0 using nearest valid neighbors
        public double[] Task12(double[] raw)
        {
            if (raw == null) return null;
            
            double[] restored = (double[])raw.Clone();
            if (raw.Length < 3) return restored;

            bool allDamaged = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1.0)
                {
                    allDamaged = false;
                    break;
                }
            }
            if (allDamaged) return restored;

            for (int i = 1; i < raw.Length - 1; i++)
            {
                if (raw[i] == -1.0)
                {
                    int leftIndex = i - 1;
                    while (leftIndex >= 0 && raw[leftIndex] == -1.0)
                    {
                        leftIndex--;
                    }

                    int rightIndex = i + 1;
                    while (rightIndex < raw.Length && raw[rightIndex] == -1.0)
                    {
                        rightIndex++;
                    }

                    if (leftIndex >= 0 && rightIndex < raw.Length)
                    {
                        restored[i] = (raw[leftIndex] + raw[rightIndex]) / 2.0;
                    }
                }
            }

            return restored;
        }
    }
}
