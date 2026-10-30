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
                double avg = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = avg;
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

            int imax = 0, imin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                {
                    imax = i;
                }
                if (array[i] < array[imin])
                {
                    imin = i;
                }
            }
            int start, end;
            if (imax < imin)
            {
                start = imax;
                end = imin;
            }
            else
            {
                start = imin;
                end = imax;
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
            int k = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k] = array[i];
                    k++;
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here

            int imax = 0;
            int ineg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[imax])
                {
                    imax = i;
                }
                if (ineg == -1 && array[i] < 0)
                {
                    ineg = i;
                }
            }
            if (ineg != -1)
            {
                int temp = array[imax];
                array[imax] = array[ineg];
                array[ineg] = temp;
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
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int number = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    number++;
                    array[i] += number;
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
            int current = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    current++;
                }
                else
                {
                    current = 1;
                }

                if (current > length)
                {
                    length = current;
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
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
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
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
                {
                    count++;
                }
            }

            cleared = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool duplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        duplicate = true;
                        break;
                    }
                }
                if (!duplicate)
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

            if (n <= 0)
            {
                return null;
            }

            if (n == 1)
            {
                if (a != b)
                {
                    return null;
                }
            }
            else
            {
                if (a == b)
                {
                    return null;
                }
            }

            A = new double[n];
            if (n == 1)
            {
                A[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * step;
                }
            }

            double sum = 0;
            int countPositive = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    countPositive++;
                }
            }

            if (countPositive == 0)
            {
                B = new double[0];
            }
            else
            {
                double avg = sum / countPositive;

                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > avg)
                    {
                        count++;
                    }
                }

                B = new double[count];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > avg)
                    {
                        B[k] = A[i];
                        k++;
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

            // end

            return wins;

        }
    }
}