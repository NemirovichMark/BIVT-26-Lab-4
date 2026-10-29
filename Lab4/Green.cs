namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int count = 0;
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    average += array[i];
                    count++;
                }
            }
            average /= count;
            if (average > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        {
                        array[i] = average;
                        }
                }
            }
            else { array = [];}
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            if (count != 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        sum += (array[i] * array[i]);
                    }
                    else { break; }
                }
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int maxElem = array[0];
            int minElem = array[0];
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minElem)
                {
                    minElem = array[i];
                    minIndex = i;
                }
                else if (array[i] > maxElem)
                {
                    maxElem = array[i];
                    maxIndex = i;
                }
            }
            int right = Math.Max(maxIndex, minIndex);
            int left = Math.Min(maxIndex, minIndex);
            
            int k = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    k++;
                }
            }
            int g = 0;
            if (k != 0);
            {
                negatives = new int[k];
                for (int i = left + 1; i < right; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[g] = array[i];
                        g++;
                    }
                }
            }

        
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = array[0];
            int maxIndex = 0;
            int firstNegative = 0;
            int firstNegativeIndex = 0;
            int a = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }

                if (array[i] < 0 && a == 0)
                {
                    firstNegative = array[i];
                    firstNegativeIndex = i;
                    a++;
                }
            }

            if (firstNegative != 0)
            {
                array[firstNegativeIndex] = max;
                array [maxIndex] = firstNegative;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here int max = array[0], count = 0;
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
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            int count = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxValue)
                {
                    array[i] += count;
                    count++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            int sum = 0;
            int sup = 0;
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
                    sup = array[i];
                    array[i] = sum;
                    sum += sup;
                }
                else { sum += array[i]; }
            }

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
           
            length++;
            int a = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    a++; 
                }
                else 
                { 
                    length = Math.Max (length,a);
                    a = 1; 
                }
            }

            // end

            return length;
        }
        public void Task9(int[] array) //В метод передается одномерный массив array. Упорядочить по возрастанию элементы массива
                                       // с четными индексами (остальные элементы оставить на своих местах).
        {

            // code here
            for (int i = 2; i < array.Length; i += 2)
            {
                int a = array[i];
                int k = i - 2;
                while (k >= 0 && array[k] > a)
                {
                    array[k + 2] = array[k];
                    k -= 2;
                }
                array[k + 2] = a;
            }

            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] a = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < count; j++)
                {
                    if (a [j] == array[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found) a [count++] = array[i];
            }
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = a [i];
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
                int s = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > average)
                    {
                        B[s++] = A[i];
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
            int sixPoint= 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int player = Math.Max(1, dices[i] - sixPoint);
                int sharper = Math.Max(1, 6 - i);
                if (player > sharper) 
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    sixPoint++;
                }
            }
            // end

            return wins;

        }
    }
}