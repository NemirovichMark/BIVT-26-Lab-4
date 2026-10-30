namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            double srch = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    k += 1;
                }
            }
            srch = s / k;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = srch;
                }

            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int cv = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    sum = cv;
                    break;
                }
                cv += array[i] * array[i];
            }
            //end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            // code here
            int max = array[0];
            int min = array[0];
            int imax = 0;
            int imin = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }
            }

            int from = Math.Min(imax, imin);   // левая граница диапазона
            int to = Math.Max(imax, imin);     // правая граница диапазона

            int count = 0;
            for (int i = from + 1; i < to; i++)
            {
                if (array[i] < 0) count++;
            }

            negatives = new int[count];        // при count = 0 получится пустой массив
            int k = 0;
            for (int i = from + 1; i < to; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k] = array[i];
                    k++;
                }
            }
            // end
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = 0;
            int firsr= -1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;

                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if ((double)array[i] < 0)
                {
                    firsr= i;
                    break;
                }
            }
            if (firsr != -1)
            {
                int temp = array[max];
                array[max] = array[firsr];
                array[firsr] = temp;

            }

            
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue;
            int maxi = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    maxi= i;
                    
                }

            }
            for (int i = 0; i < array.Length; i++)
            {
                if (max == array[i])
                {
                    count++;
                }
            }
            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
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
                    max = array[i];
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
                    max = array[i];
            }
            int sumBefore = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i];
                if (current == max)
                    array[i] = sumBefore;
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
                        length = current;
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
            int[] unique = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < count; j++)
                {
                    if (unique[j] == array[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    unique[count] = array[i];
                    count++;
                }
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
                cleared[i] = unique[i];
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
                double average = 0;
                if (countPositive > 0)
                    average = sumPositive / countPositive;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > average)
                        count++;
                }
                B = new double[count];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > average)
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
                int player = Math.Max(1, dices[i] - sixes);
                int cheater = Math.Max(1, 6 - i);
                if (player > cheater)
                    wins++;
                if (dices[i] == 6)
                    sixes++;
            }

            // end

            return wins;

        }
    }
}