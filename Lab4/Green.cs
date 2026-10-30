namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            double s = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double sr = s / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = sr;
                    }
                }
            }
            // end
        }
        public int Task2(int[] array)
        {
            int sum = 0;
            // code here
            int otr = -1;
             for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sum += array[i] * array[i];
                }
                else
                {
                    otr = i;
                    break;
                }
            }
            if (otr == -1)
            {
                return 0;
            }
            return sum;
            // end
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            int max = int.MinValue;
            int maxi = -1;
            int min = int.MaxValue;
            int mini = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    mini = i;
                }
            }
            int count = 0;
            if (maxi != -1 && mini != -1)
            {
                int left = Math.Min(maxi, mini);
                int right = Math.Max(maxi, mini);
                for (int i = left + 1;i < right; i++)
                {
                    if (array[i] < 0)
                    {
                        count++;
                    }
                }
            }
            negatives = new int[count];
            int ind = 0;
            if (maxi != -1 && mini != -1)
            {
                int left = Math.Min(maxi, mini);
                int right = Math.Max(maxi, mini);
                for (int i = left + 1; i < right; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[ind] = array[i];
                        ind++;
                    }
                }
            }
            // end
            return negatives;
        }
        public void Task4(int[] array)
        {
            // code here
            int max = int.MinValue;
            int maxi = 0;
            int pervotr = 0;
            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    pervotr = array[i];
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                var p = array[maxi];
                array[maxi] = array[index];
                array[index] = p;
            }
            // end
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            // code here
             int max = int.MinValue;
            int count = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }
            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end
            return answer;
        }
        public void Task6(int[] array)
        {
            // code here
             int max = int.MinValue;
            int maxi = 0;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxi = i;
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
            // end
        }
        public void Task7(int[] array)
        {
            // code here
            int s = 0;
            int max = int.MinValue;
            int d = 0;
            for (int i = 0;i < array.Length;i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                d = array[i];
                if (array[i] == max)
                {
                    array[i] = s;
                }

                s += d;
            }
            // end
        }
        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            int max = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    length++;
                }
                else
                {
                    if (length + 1 > max)
                    {
                        max = length + 1;
                    }
                    length = 0;
                }

                if (length + 1 > max)
                {
                    max = length + 1;
                }
            }
            length = max;
            // end
            return length;
        }
        public void Task9(int[] array)
        {
            // code here
            for (int i = 0;i < array.Length / 2;i++)
            {
                for (int j = 0; j < array.Length - i - 2; j+=2)
                {
                    if (array[j] > array[j + 2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
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
                bool dupl = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        dupl = true;
                        break;
                    }
                }
                if (!dupl)
                {
                    count++;
                }
            }
            cleared = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool dupl = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        dupl = true;
                        break;
                    }
                }
                if (!dupl)
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
            if (n >= 2 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);
                double s = 0;
                double countp = 0;
                for (int i = 0;i < n;i++)
                {
                    A[i] = a + i * step;
                    if (A[i] > 0)
                    {
                        s += A[i];
                        countp++;
                    }
                }
                double sr = s / countp;
                int count = 0;
                for (int i = 0;i < n;i++)
                {
                    if (A[i] > 0 && A[i] > sr)
                    {
                        count++;
                    }
                }
                B = new double[count];
                int r = 0;
                for (int i = 0;i < n;i++)
                {
                    if (A[i] > 0 && A[i] > sr)
                    {
                        B[r++] = A[i];
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
            int six = 0;
            for (int i = 0;i < dices.Length;i++)
            {
                int player = Math.Max(1,dices[i] - six);
                int cheater = Math.Max(1,6 - i);
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
