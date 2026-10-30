using System;

namespace Lab4
{
    public class White
    {
        // Task 1: Find the product of elements between the first and second negative numbers
        public void Task1(int[] array)
        {
            if (array == null || array.Length < 3) return;

            int firstNegative = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegative = i;
                    break;
                }
            }

            int secondNegative = -1;
            for (int i = firstNegative + 1; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    secondNegative = i;
                    break;
                }
            }

            if (firstNegative == -1 || secondNegative == -1 || secondNegative - firstNegative <= 1) return;

            int product = 1;
            for (int i = firstNegative + 1; i < secondNegative; i++)
            {
                product *= array[i];
            }
        }

        // Task 2: Swap the maximum element with the first element of the array
        public void Task2(int[] array)
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

            int temp = array[0];
            array[0] = array[maxIndex];
            array[maxIndex] = temp;
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

            int[] result = new int[count];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    result[j] = array[i];
                    j++;
                }
            }
            return result;
        }

        // Task 8: Sort descending via a copy
        public int[] Task8(int[] array)
        {
            if (array == null) return null;

            int[] result = (int[])array.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] < result[j])
                    {
                        int temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }
            return result;
        }

        // Task 9: Reverse copy elements into a new array
        public int[] Task9(int[] array)
        {
            if (array == null) return null;

            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = array[array.Length - 1 - i];
            }
            return result;
        }

        // Task 10: Alternate merge elements from arrays A and B
        public int[] Task10(int[] A, int[] B)
        {
            if (A == null) A = new int[0];
            if (B == null) B = new int[0];

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
            double[] array = null;

            if (n <= 1) return null;

            double[] result = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                result[i] = a + step * i;
            }

            result[0] = a;
            result[n - 1] = b;

            array = result;
            return array;
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
