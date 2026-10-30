namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }
            int count = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    count++;
                    sum += array[i];
                }
            }
            if (count == 0)
            {
                return;
            }
            double srznach = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = srznach;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            bool fl = false;
            if (array == null || array.Length == 0)
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    fl = true;
                    break;
                }
                sum += array[i] * array[i];
            }
            if (!fl)
            {
                sum = 0;
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length < 2)
            {
                negatives = new int[0];
            }
            int indmax = 0, indmin = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[indmax])
                {
                    indmax = i;
                }
                if (array[i] < array[indmin])
                {
                    indmin = i;
                }
            }
            int left = Math.Min(indmin, indmax);
            int right = Math.Max(indmin, indmax);
            int countn = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    countn++;
                }
            }
            negatives = new int[countn];
            int j = 0;
            for (int i = left + 1; i < right; i++)
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
            int indmax = 0;
            int indneg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[indmax])
                {
                    indmax = i;
                }
                if (indneg == -1 && array[i] < 0)
                {
                    indneg = i;
                }
            }
            if (indneg != -1)
            {
                int n = array[indmax];
                int n1 = array[indneg];
                array[indmax] = n1;
                array[indneg] = n;
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int sum = 0;
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                j = array[i];
                if (array[i] == max)
                {
                    array[i] = sum;
                }
                sum += j;
            }
                // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int[] len = new int[array.Length];
            int k = 0;
            int c = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    c++;
                }
                else
                {
                    len[k++] = c;
                    c = 1;
                }
            }
            int max = 1;

            for (int i = 0; i < len.Length; i++)
            {
                if (len[i] > max)
                {
                    max = len[i];
                }
            }
            length = max;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 2; i < array.Length; i+=2)
            {
                int c = array[i];
                int j = i - 2;
                while (j >= 0 && array[j] > c)
                {
                    array[j + 2] = array[j];
                    j -= 2;
                }
                array[j + 2] = c;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // code here
            cleared = new int[array.Length];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool fl = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        fl = false;
                        break;
                    }
                }
                if (fl)
                {
                    count++;
                }
            }
            cleared = new int[count];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool fl = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        fl = false;
                        break;
                    }
                }
                if (fl)
                {
                    cleared[c] = array[i];
                    c++;
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
            double h = (b - a) / (n - 1);
            A = new double[n];
            for (int i = 0; i < n; i++)
            {
                A[i] = a + h * i;
            }
            double sum = 0;
            int pos = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    pos++;
                }
            }
            B = new double[0];
            if (pos == 0)
                return B;
            double avg = sum / pos;
            int size = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                    size++;
            }
            B = new double[size];
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > avg)
                {
                    B[k] = A[i];
                    k++;
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
            for (int i = 0; i < dices.Length; i++)
            {
                int player = dices[i] - six;
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
                    six++;
                }
            }

            // end

            return wins;

        }
    }
}
