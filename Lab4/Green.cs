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
            int negativeID = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negativeID = i;
                    break;
                }
            }

            if (negativeID != -1)
            {
                for (int i = 0; i < negativeID; i++)
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
            int maxId = 0;
            int minId = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxId])
                {
                    maxId = i;
                }

                if (array[i] < array[minId])
                {
                    minId = i;
                }
            }

            int start = Math.Min(maxId, minId);
            int end = Math.Max(maxId, minId);
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
            int maxId = 0;
            int negativeId = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxId])
                {
                    maxId = i;
                }

                if (array[i] < 0 && negativeId == -1)
                {
                    negativeId = i;
                }
            }

            if (negativeId != -1)
            {
                int temp = array[maxId];
                array[maxId] = array[negativeId];
                array[negativeId] = temp;
            }
            // end
        }

        public int[] Task5(int[] array)
        {
            int[] answer = null;

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

            int number = 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += number;
                    number++;
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
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
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
            // end

            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = 0; j < array.Length - 2; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        int temp = array[j];
                        array[j] = array[j + 2];
                        array[j + 2] = temp;
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

            cleared = new int[count];
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
            // end

            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 0 || a == b)
            {
                return null;
            }

            if (n == 1)
            {
                return null;
            }

            A = new double[n];

            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
            }

            A[n - 1] = b;

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
                B = new double[0];
                return B;
            }

            double average = sum / count;
            int size = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    size++;
                }
            }

            B = new double[size];
            int j = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[j] = A[i];
                    j++;
                }
            }
            // end

            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] player = new int[dices.Length];
            int[] cheater = new int[dices.Length];

            int sixCount = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                player[i] = dices[i] - sixCount;

                if (player[i] < 1)
                {
                    player[i] = 1;
                }

                if (dices[i] == 6)
                {
                    sixCount++;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {
                cheater[i] = 6 - i;

                if (cheater[i] < 1)
                {
                    cheater[i] = 1;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {
                if (player[i] > cheater[i])
                {
                    wins++;
                }
            }
            // end

            return wins;
        }
    }
}
