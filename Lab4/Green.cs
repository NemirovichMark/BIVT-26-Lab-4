namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            int count = 0;
            for(int i=0; i<array.Length; i++)
            {
                if(array[i] > 0)
                {  sum += array[i];
                    count++;
                }
            }
            double midle = sum / count;
            for(int i=0;i<array.Length;i++)
            {
                if(array[i] > 0)
                { array[i] = midle;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int n = array.Length;
            int negindex = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    negindex = i;
                    break;
                }

            }
            if (negindex == -1)
            {
                return 0;
            }
            for (int i = 0; i < negindex; i++)
            {
                sum += array[i] * array[i];
            }

            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int n = array.Length;
            int min = int.MaxValue;
            int minIndex = -1;
            int max = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;

                }

                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;

                }
            }
            int left = Math.Min(minIndex, maxIndex);
            int right = Math.Max(minIndex, maxIndex);
            if (left > right)
            {
                return new int[0];
            }
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
            
            int max = array[0];
            int maxindex = 0;
            for(int i=1;i<array.Length;i++)
            {
                if (array[i]>max)
                { max = array[i];
                    maxindex= i;
                }
            }
            int minindex = -1;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]<0)
                {  minindex = i;
                    break;
                }
            }
            if(minindex!=-1)
            { int temp = array[maxindex];
                array[maxindex] = array[minindex];
                array[minindex] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            for (int i = 1; i<array.Length;i++)
            { 
                if(array[i]>max)
                { max = array[i]; }
            }
            int count = 0;
            for(int i=0;i<array.Length;i++)
            { if (array[i]==max)
                {  count++; }
            }
            int[]result=new int[count];
            int j = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (array[i]==max)
                { result[j] = i;
                    j++;
                }
            }
            // end

                return result;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for(int i =1;i<array.Length; i++)
            {
                if (array[i]>max)
                { max = array[i]; }
            }
            int numbers = 1;
            for(int i=0;i<array.Length;i++)
            { if(array[i]==max)
                {
                    array[i] += numbers;
                    numbers++;
                }
                    
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int n = array.Length;
            int max = int.MinValue;
            int maxIndex = -1;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                int a = array[i];
                if (array[i] == max)
                {
                    array[i] = sum;
                }
                sum += a;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int n = array.Length;
            int maxcount = 1;
            int count = 1;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;
                }

                else
                {
                    if (maxcount < count)
                    {
                        maxcount = count;
                    }
                    count = 1;
                }
            }
            if (maxcount < count)
            {
                maxcount = count;

            }
            length = maxcount;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = array.Length;

            for (int i = 0; i < n; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - 2; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                        swapped = true;
                    }
                }
                if (swapped == false) break;

            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int count = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                bool swapped = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        swapped = true;
                        break;
                    }
                }
                if (swapped == false)
                {
                    count++;
                }
            }
            cleared = new int[count];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                bool swapped = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        swapped = true;
                        break;
                    }
                }
                if (swapped == false)
                {
                    cleared[idx] = array[i];
                    idx++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b)
            {
                return null;
            }
            A = new double[n];

            double s = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * s; ;
            }

            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
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
            int count2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    count2++;
                }
            }
            if (count2 == 0)
            {
                return new double[0];
            }
            B = new double[count2];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[idx] = A[i];
                    idx++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            if (dices == null || dices.Length == 0)
            {
                return 0;
            }
            int n = dices.Length;
            int Count = 0;
            for (int i = 0; i < n; i++)
            {
                int player = dices[i] - Count;
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
                    Count++;
                }
            }
            // end

            return wins;

        }
    }
}