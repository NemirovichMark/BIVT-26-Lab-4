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
                for (int i = 0; i < negativeIndex; i++)
                {
                    sum += array[i] * array[i];
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

            for (int i = 1; i < array.Length; i++)
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

            int start = maxIndex;
            int end = minIndex;

            if (maxIndex > minIndex)
            {
                start = minIndex;
                end = maxIndex;
            }

            int count = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            negatives = new int[count];

            int j = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[j] = array[i];
                    j++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;

            for (int i = 1; i < array.Length; i++)
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
            int count = 0;

            for (int i = 1; i < array.Length; i++)
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

            int j = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[j] = i;
                    j++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
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

            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                    array[i] += count;
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

            int[] original = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                original[i] = array[i];
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (original[i] == max)
                {
                    array[i] = sum;
                }

                sum += original[i];
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int currentLength = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    currentLength++;

                    if (currentLength > length)
                    {
                        length = currentLength;
                    }
                }
                else
                {
                    currentLength = 1;
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int count = (array.Length + 1) / 2;

            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - 1 - i; j++)
                {
                    int first = j * 2;
                    int second = (j + 1) * 2;

                    if (array[first] > array[second])
                    {
                        int temp = array[first];
                        array[first] = array[second];
                        array[second] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool repeated = false;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        repeated = true;
                        break;
                    }
                }

                if (!repeated)
                {
                    count++;
                }
            }

            cleared = new int[count];

            int k = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool repeated = false;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        repeated = true;
                        break;
                    }
                }

                if (!repeated)
                {
                    cleared[k] = array[i];
                    k++;
                }
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

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            B = new double[0];

            if (count > 0)
            {
                double average = sum / count;
                int size = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > average)
                    {
                        size++;
                    }
                }

                B = new double[size];

                int j = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] > average)
                    {
                        B[j] = A[i];
                        j++;
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
            int playerSixes = 0;
            int opponentSixes = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int playerDice = dices[i] - playerSixes;

                if (playerDice < 1)
                {
                    playerDice = 1;
                }

                int opponentDice = 6 - opponentSixes;

                if (opponentDice < 1)
                {
                    opponentDice = 1;
                }

                if (playerDice > opponentDice)
                {
                    wins++;
                }

                if (dices[i] == 6)
                {
                    playerSixes++;
                }

                opponentSixes++;
            }
            // end

            return wins;

        }
    }
}
