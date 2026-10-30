namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            int count = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }

            double average = sum / count;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = average;
                }
            }


        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    min = i;
                    break;
                }
            }

            for (int i = 0; i < min; i++)
            {
                sum += array[i] * array[i];
            }

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int indMin = 0;
            int indMax = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indMin = i;
                }

                if (array[i] > max)
                {
                    max = array[i];
                    indMax = i;
                }
            }

            if (indMax > indMin)
            {
                for (int i = indMin + 1; i < indMax; i++)
                {
                    if (array[i] < 0) count++;
                }
            }
            else
            {
                for (int i = indMax + 1; i < indMin; i++)
                {
                    if (array[i] < 0) count++;
                }
            }

            int[] negativetes = new int[count];
            int j = 0;
            int start = Math.Min(indMin, indMax) + 1;
            int end = Math.Max(indMin, indMax);

            for (int i = start; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negativetes[j] = array[i];
                    j++;
                }
            }
            negatives = negativetes;

            return negatives;
        }
        public void Task4(int[] array)
        {
            int max = Int32.MinValue;
            int min = 0;
            int minInd = -1;
            int maxInd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxInd = i;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
            if (array[i] < 0)
                {
                    minInd = i;
                    min = array[i];
                    break;
                }
            }

            if (minInd == -1)
                return;

            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i == minInd) array[i] = max;

                    if (i == maxInd) array[i] = min;
                }
            }

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int max = Int32.MinValue;
            int minInd = 0;
            int maxInd = 0;
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                    
                }
            }

            int[] ae = new int[count];
            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    ae[j] = i;
                    j++;
                }
            }

            answer = ae;

            return answer;
        }
        public void Task6(int[] array)
        {

            int max = Int32.MinValue;
            int maxInd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int count = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += count;
                    count++;
                }
            }
        }
        public void Task7(int[] array)
        {

            int max = Int32.MinValue;
            int maxInd = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxInd = i;
                }
            }

            int[] original = (int[])array.Clone();

            for (int i = 0; i < array.Length; i++)
            {
                if (original[i] == max)
                {
                    int sum = 0;

                    for (int j = 0; j < i; j++) sum += original[j];

                    array[i] = sum;
                }
            }
        }
        public int Task8(int[] array)
        {
            int length = 1;
            int max = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                }
                else
                {
                    length = 1;
                }

                if (length > max)
                {
                    max = length;
                }
            }

            length = max;

            return length;
        }
        public void Task9(int[] array)
        {
            for (int i = 0; i < array.Length - 2;)
            {
                if (array[i] > array[i + 2])
                {
                    int term = array[i];
                    array[i] = array[i + 2];
                    array[i + 2] = term;

                    if (i >= 2)
                    {
                        i -= 2;
                    }
                }

                else
                {
                    i += 2;
                }
            }
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            cleared = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    count++;
                }
            }

            cleared = new int[count];
            int c = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                {
                    cleared[c] = array[i];
                    c++;
                }
            }
            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            

            double[] A = null;
            double[] B = null;
            
            if (n < 2 || a == b)
                return null;

            double h = (b - a) / (n - 1);

            A = new double[n];

            for (int i = 0; i < n; i++)
            {
                A[i] = a + h * i;
            }

            double sum = 0;
            int positive = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    positive++;
                }
            }

            B = new double[0];

            if (positive == 0)
                return B;

            double avg = sum / positive;
            int size = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                    size++;
            }

            B = new double[size];

            int k = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                {
                    B[k] = A[i];
                    k++;
                }
            }

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;
            int sixes = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int player = dices[i] - sixes;

                if (player < 1)
                {
                    player = 1;
                }

                int cheater = 6 - i;

                if (cheater < 1)
                {
                    cheater = 1;
                }

                if (player > cheater)
                {
                    wins++;
                }

                if (dices[i] == 6)
                {
                    sixes++;
                }
            }


            return wins;

        }
    }
}