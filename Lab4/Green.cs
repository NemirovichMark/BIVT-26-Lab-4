
namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
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
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            int negativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeIndex = i;
                    break;
                }
            }

            if (negativeIndex == -1)
            {
                return 0;
            }

            for (int i = 0; i < negativeIndex; i++)
            {
                sum += array[i] * array[i];
            }

            return sum;
        }

        public int[] Task3(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[0];
            }

            int max = array[0];
            int min = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            int start = minIndex;
            int end = maxIndex;

            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            int count = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            int[] negatives = new int[count];
            int index = 0;

            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }

            return negatives;
        }

        public void Task4(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            int maxIndex = 0;
            int negativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }

                if (array[i] < 0 && negativeIndex == -1)
                {
                    negativeIndex = i;
                }
            }

            if (negativeIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[negativeIndex];
                array[negativeIndex] = temp;
            }
        }

        public int[] Task5(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[0];
            }

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
                }
            }

            int[] answer = new int[count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }

            return answer;
        }

        public void Task6(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
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
                    array[i] += number;
                    number++;
                }
            }
        }

        public void Task7(int[] array)
        {
            if (array.Length == 0)
            {
                return;
            }

            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];

                if (current == max)
                {
                    array[i] = sum;
                }

                sum += current;
            }
        }

        public int Task8(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int length = 1;
            int currentLength = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    currentLength++;
                }
                else
                {
                    currentLength = 1;
                }

                if (currentLength > length)
                {
                    length = currentLength;
                }
            }

            return length;
        }

        public void Task9(int[] array)
        {
            for (int i = 0; i < array.Length; i += 2)
            {
                int minIndex = i;

                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

        public int[] Task10(int[] array)
        {
            int count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    count++;
                }
            }

            int[] cleared = new int[count];
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;

                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }

            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            if (n <= 1 || a == b)
            {
                return null;
            }

            double[] A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
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

            if (count == 0)
            {
                return new double[0];
            }

            double average = sum / count;
            int size = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > average)
                {
                    size++;
                }
            }

            double[] B = new double[size];
            int index = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > average)
                {
                    B[index] = A[i];
                    index++;
                }
            }

            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;
            int curses = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int player = dices[i] - curses;

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
                    curses++;
                }
            }

            return wins;
        }
    }
}
