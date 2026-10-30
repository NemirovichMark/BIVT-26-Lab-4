
namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;
            // code here
            if (vector == null || vector.Length == 0) return 0;
            double sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i] * vector[i];
            }
            length = Math.Sqrt(sum);
            // end
            return length;
        }

        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;
            // code here
            if (array == null || array.Length == 0) return 0;
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
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
            if (array == null || array.Length < 2) return;
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
            if (maxIndex != minIndex && array[maxIndex] != array[minIndex])
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[minIndex];
                array[minIndex] = temp;
            }
            // end
        }

        public void Task4(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
            }
            array[maxIndex] = maxIndex;
            // end
        }

        public int Task5(int[] array, int P)
        {
            int index = 0;
            // code here
            index = -1;
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == P)
                    {
                        index = i;
                        break; 
                    }
                }
            }
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
            if (array == null || array.Length == 0)
            {
                answer = new int[0];
            }
            else
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) count++;
                }
                if (count == 0)
                {
                    answer = new int[0];
                }
                else
                {
                    answer = new int[count];
                    int j = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] >= 0)
                        {
                            answer[j] = array[i];
                            j++;
                        }
                    }
                }
            }
            // end
            return answer;
        }

        public void Task8(int[] array)
        {
            // code here
            if (array == null || array.Length < 2) return;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length < 2) return;
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
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
            int maxLength = Math.Max(A.Length, B.Length);
            int k = 0;
            for (int i = 0; i < maxLength; i++)
            {
                if (i < A.Length)
                {
                    C[k] = A[i];
                    k++;
                }
                if (i < B.Length)
                {
                    C[k] = B[i];
                    k++;
                }
            }
            // end
            return C;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;
            // code here
            if (n <= 0) return null;
            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[] { a };
                }
                else
                {
                    return null;
                }
            }
            else
            {
                array = new double[n];
                if (n == 1)
                {
                    array[0] = a;
                }
                else
                {
                    double step = (b - a) / (n - 1);
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = a + i * step;
                    }
                }
            }
            // end
            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;
            // code here
            if (raw == null || raw.Length < 3)
            {
                if (raw == null) return null;
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++) restored[i] = raw[i];
                return restored;
            }
            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }
            bool allMinusOne = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    allMinusOne = false;
                    break;
                }
            }
            if (allMinusOne) return restored;
            for (int i = 1; i < raw.Length - 1; i++)
            {
                if (raw[i] == -1 && raw[i - 1] != -1 && raw[i + 1] != -1)
                {
                    restored[i] = (raw[i - 1] + raw[i + 1]) / 2.0;
                }
            }
            // end
            return restored;
        }
    }
}
