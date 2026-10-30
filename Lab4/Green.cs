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
                    sum = sum + array[i];
                    count = count + 1;
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
            int firstNegative = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegative = i;
                    break;
                }
            }
            if (firstNegative != -1)
            {
                for (int i = 0; i < firstNegative; i++)
                {
                    sum = sum + array[i] * array[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
                if (array[i] < array[minIndex])
                {
                    minIndex = i;
                }
            }
            int left = maxIndex;
            int right = minIndex;
            if (minIndex < maxIndex)
            {
                left = minIndex;
                right = maxIndex;
            }
            int count = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    count = count + 1;
                }
            }
            negatives = new int[count];
            int k = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k] = array[i];
                    k = k + 1;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            int negativeIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }
            if (negativeIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[negativeIndex];
                array[negativeIndex] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count = count + 1;
                }
            }
            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[k] = i;
                    k = k + 1;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int number = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = array[i] + number;
                    number = number + 1;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (copy[i] == max)
                {
                    int sumBefore = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sumBefore = sumBefore + copy[j];
                    }
                    array[i] = sumBefore;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int current = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current = current + 1;
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
            int m = (array.Length + 1) / 2;
            int[] evenValues = new int[m];
            for (int k = 0; k < m; k++)
            {
                evenValues[k] = array[2 * k];
            }
            for (int i = 1; i < m; i++)
            {
                int currentValue = evenValues[i];
                int j = i - 1;
                while (j >= 0 && evenValues[j] > currentValue)
                {
                    evenValues[j + 1] = evenValues[j];
                    j = j - 1;
                }
                evenValues[j + 1] = currentValue;
            }
            for (int k = 0; k < m; k++)
            {
                array[2 * k] = evenValues[k];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] temp = new int[array.Length];
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool already = false;
                for (int j = 0; j < count; j++)
                {
                    if (temp[j] == array[i])
                    {
                        already = true;
                        break;
                    }
                }
                if (already == false)
                {
                    temp[count] = array[i];
                    count = count + 1;
                }
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = temp[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n < 2 || a == b)
            {
                return null;
            }
            A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum = sum + A[i];
                    count = count + 1;
                }
            }
            if (count == 0)
            {
                B = new double[0];
                return B;
            }
            double average = sum / count;
            int bigger = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    bigger = bigger + 1;
                }
            }
            B = new double[bigger];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[k] = A[i];
                    k = k + 1;
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
                int mine = dices[i] - sixes;
                if (mine < 1)
                {
                    mine = 1;
                }
                int his = 6 - i;
                if (his < 1)
                {
                    his = 1;
                }
                if (mine > his)
                {
                    wins = wins + 1;
                }
                if (dices[i] == 6)
                {
                    sixes = sixes + 1;
                }
            }
            // end

            return wins;

        }
    }
}