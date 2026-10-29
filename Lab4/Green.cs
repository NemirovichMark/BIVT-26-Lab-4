namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sr = 0;
            int countPositive = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sr += array[i];
                    countPositive++;
                }
            }
            if (countPositive > 0)
            {
                double average = sr / countPositive;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        array[i] = average;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int s = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] < 0)
                {
                    sum = s;
                    break;
                }
                s += array[i]*array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = 0, min = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max]) max = i;
                if (array[i] < array[min]) min = i;
            }
            int from = Math.Min(max, min);
            int to = Math.Max(max, min);
            int count = 0;
            for (int i = from + 1; i < to; i++)
            {
                if (array[i] < 0) count++;
            }
            negatives = new int[count];
            int k = 0;
            for (int i = from + 1; i < to; i++)
            {
                if (array[i] < 0) negatives[k++] = array[i];
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0, negative= -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (negative == -1 && array[i] < 0) negative = i;
            }
            if (negative != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[negative];
                array[negative] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0], count = 0;
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
            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) 
                {
                    answer[k] = i;
                    k++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for(int i=1;i<array.Length;i++)
            {
                if (array[i]>max)
                { 
                    max = array[i];
                }
            }
            int num = 1;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i] == max) 
                {
                    array[i] += num;
                    num++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int sumBefore = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                if (current == max) array[i] = sumBefore;
                sumBefore += current;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int current = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    current++;
                    if (current > length)
                    {
                        length = current;
                    }
                }
                else
                {
                    current = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 2; i < array.Length; i += 2)
            {
                int key = array[i];
                int j = i - 2;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 2] = array[j];
                    j -= 2;
                }
                array[j + 2] = key;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] individual = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < count; j++)
                {
                    if (individual[j] == array[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) individual[count++] = array[i];
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = individual[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n >= 2 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);
                double sumPositive = 0;
                int countPositive = 0;
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * step;
                    if (A[i] > 0)
                    {
                        sumPositive += A[i];
                        countPositive++;
                    }
                }
                double average = sumPositive / countPositive;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > average)
                    {
                        count++;
                    }
                }
                B = new double[count];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > average)
                    {
                        B[k++] = A[i];
                    }
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int six= 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int player = Math.Max(1, dices[i] - six);
                int cheater = Math.Max(1, 6 - i);
                if (player > cheater) 
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    six++;
                }
            }
            // end

            return wins;

        }
    }
}