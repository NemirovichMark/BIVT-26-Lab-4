namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int pol = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    pol++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sum / pol;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int otr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    otr++;
                    break;
                }
            }


            if (otr > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        break;
                    }
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

            int minN = -1;
            int maxN = -1;
            int max = -999999;
            int min = 10000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    maxN = i;
                    max = array[i];
                }
                if (array[i] < min)
                {
                    minN = i;
                    min = array[i];
                }
            }
            int left = Math.Min(maxN, minN);
            int right = Math.Max(maxN, minN);

            int count = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            negatives = new int[count];
            int index = 0;

            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxN = -1;
            int negN = -1;
            int max = int.MinValue;
            int neg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg = array[i];
                    negN = i;
                    break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxN = i;
                }
            }

            if (neg < 0)
            {
                array[negN] = max;
                array[maxN] = neg;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue;
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
                    count++;
                }
            }

            answer = new int[count];
            int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[count2] = i;
                    count2++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
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
                    array[i] = max + count;
                    count++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int temp = array[i];
                if (array[i] == max)
                {
                    array[i] = sum;
                }
                sum += temp;
            }
            // end
        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int[] kols = new int[array.Length];
            int temp = 1;
            int count = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i+1])
                {
                    temp++;
                }
                else
                {
                    kols[count] = temp;
                    count++;
                    temp = 1;
                }
            }

            for (int i = 0; i < kols.Length; i++)
            {
                if (kols[i] > length)
                {
                    length = kols[i];
                }
            }

            if (length == 0)
            {
                length = 1;
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    count++;
                }
            }

            int[] even = new int[count];
            count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    even[count] = array[i];
                    count++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < even.Length - 1; j++)
                {
                    if (even[j] > even[j + 1])
                    {
                        (even[j], even[j + 1]) = (even[j + 1], even[j]);
                    }
                }
            }

            count = 0;
            for (int i = 0; i < n; i++)
            {
                if ((i % 2) == 0)
                {
                    array[i] = even[count];
                    count++;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // 10 3 6 8 0 -1    n = 6
            //  0 1 2 3 4 5
            // code here
            int n = array.Length;
            int count = 0; // количество повторных элементов
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            cleared = new int[n - count];
            int[] repsN = new int[count];
            count = 0;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        repsN[count] = j;
                        count++;
                        break;
                    }
                }
            }

            count = 0;
            for (int i = 0; i < n; i++)
            {
                bool skip = false;
                for (int j = 0; j < repsN.Length; j++)
                {
                    if (i == repsN[j])
                    {
                        skip = true;
                        break;
                    }
                }

                if (skip != true)
                {
                    cleared[count] = array[i];
                    count++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            A = new double[n];

            if ((n > 1) && (a != b))
            {
                for (int i = 0; i < n; i++)
                {
                    A[i] = ((b - a) / (n - 1) * i) + a;
                }
            }
            else
            {
                return B;
            }

            int count = 0;
            double sum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            double mid = sum / count;
            count = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > mid))
                {
                    count++;
                }
            }

            B = new double[count];
            count = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > mid))
                {
                    B[count] = A[i];
                    count++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;
            int[] Jdices = new int[n];

            for (int i = 0; i < n; i++)
            {
                Jdices[i] = 6;
            }

            int count = 0;
            int count2 = 0;

            for (int i = 0; i < n; i++)
            {
                int temp = Jdices[i] - count;

                if (Jdices[i] == 6)
                {
                    count++;
                }
                Jdices[i] = temp;
                if (Jdices[i] < 1)
                {
                    Jdices[i] = 1;
                }

                int temp2 = dices[i] - count2;

                if (dices[i] == 6)
                {
                    count2++;
                }
                dices[i] = temp2;
                if (dices[i] < 1)
                {
                    dices[i] = 1;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (dices[i] > Jdices[i])
                {
                    wins++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(Jdices[i] + " ");
                Console.Write(dices[i] + " ");
                Console.WriteLine();
            }
            // end

            return wins;

        }
    }
}
