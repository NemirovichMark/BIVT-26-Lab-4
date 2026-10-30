namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sr = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sr += array[i];
                    count++;
                }
            }
            sr /= count;
            if (sr > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = sr;
                    }
                }
            }
            else { array = []; }
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
            int max_elem = array[0];
            int min_elem = array[0];
            int min_index = 0;
            int max_index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min_elem)
                {
                    min_elem = array[i];
                    min_index = i;
                }
                else if (array[i] > max_elem)
                {
                    max_elem = array[i];
                    max_index = i;
                }
            }
            int left = Math.Min(max_index, min_index);
            int right = Math.Max(max_index, min_index);
            int n = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            int a = 0;
            if (n != 0)
            {
                negatives = new int[n];
                for (int i = left + 1; i < right; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[a] = array[i];
                        a++;
                    }
                }
            }
            else { negatives = [];}
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = array[0];
            int max_index = 0;
            int first_otr = 0;
            int first_otr_index = 0;
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }
                if (array[i] < 0 && c == 0)
                {
                    first_otr = array[i];
                    first_otr_index = i;
                    c++;
                }
            }
            if (first_otr != 0)
            {
                array[max_index] = first_otr;
                array[first_otr_index] = max;
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            int count = 0;
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
            int a = 0;
            answer = new int[count];
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] == max)
                {
                    answer[a] = i;
                    a++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            int num = 0;

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
                    num++;
                    array[i] += num;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            int sum = 0;
            int help = 0;
            for ( int i = 0; i < array.Length; i++)
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
                    help = array[i];
                    array[i] = sum;
                    sum += help;
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
            int len = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    len++; 
                }
                else 
                { 
                    length = Math.Max(length,len);
                    len = 1; 
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                c++;
            }
            int[] array2 = new int[c];
            int a = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array2[a] = array[i];
                a++;
            }
            int k = 1, j = 2;
            while (k < c)
            {
                if (k == 0 || array2[k] > array2[k - 1])
                {
                    k = j;
                    j++;
                }
                else
                {
                    (array2[k], array2[k - 1]) = (array2[k - 1], array2[k]);
                    k--;
                }
            }
            int k2 = 0;
            for (int k1 = 0; k1 < array.Length; k1 += 2)
            {
                array[k1] = array2[k2];
                k2++;
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int n = array.Length, c = 0;
            int[] helper = new int[n];
            for (int i = 0; i < n; i++)
            {
                bool povtor = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        povtor = true;
                        break;
                    }
                }
                if (!povtor)
                {
                    helper[c] = array[i];
                    c++;
                }
            }
            cleared = new int[c];
            for (int i = 0; i < c; i++)
            {
                cleared[i] = helper[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n > 1 && a != b)
            {
                A = new double[n];
                double p = (b - a) / (n - 1);
                double sum = 0;
                int cp = 0;
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * p;
                    if (A[i] > 0)
                    {
                        sum += A[i];
                        cp++;
                    }
                }
                double sr_arifm = 0;
                if (cp > 0)
                    sr_arifm = sum / cp;
                int lenB = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > sr_arifm)
                        lenB++;
                }
                B = new double[lenB];
                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0 && A[i] > sr_arifm)
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

                int shuler = 6 - i;
                if (shuler < 1)
                {
                    shuler = 1;
                }

                if (player > shuler)
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
