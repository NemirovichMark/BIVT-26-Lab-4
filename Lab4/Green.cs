namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double n = 0;
            for(int i=0; i<array.Length;i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    n++;
                }
            }
            double sr = sum / n;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr;
                }
            }
                // end

            }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<0)
                {
                    n++;
                }
            }
            if (n > 0)
            {
                for (int i = 0; i < array.Length && array[i] >= 0; i++)
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
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            int n = 0;

            for (int i = 0; i < array.Length; i++)
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
            if (minIndex < maxIndex)
            {
                for (int i = minIndex+1; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        n += 1;
                    }
                }
            }
            else
            {
                for (int i = maxIndex+1; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        n += 1;
                    }
                }
            }
            negatives = new int[n];
            int neg = 0;
            if (minIndex < maxIndex)
            {
                for (int i = minIndex+1; i < maxIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[neg] = array[i];
                        neg++;
                    }
                }
            }
            else
            {
                for (int i = maxIndex+1; i < minIndex; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[neg] = array[i];
                        neg++;
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
            int min = int.MaxValue;
            int maxIndex = -1;
            int minIndex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;

                }
                if (array[i] < 0)
                {
                    if (minIndex == -1)
                    {
                        min = array[i];
                        minIndex = i;
                    }
                }
            }
            if (minIndex != -1)
            { 
            array[maxIndex] = min;
            array[minIndex] = max;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = int.MinValue;
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
               if (array[i]>max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {
                    n += 1;
                }
            }
            answer= new int[n];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]==max)
                {
                    answer[ind] = i;
                    ind++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            int n = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i=0;i<array.Length;i++)
            {
                if (array[i]==max)
                {
                    array[i] += n;
                    n++;

                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i=0;i<array.Length;i++)
            { 
                if (array[i] != max)
                {
                    sum += array[i];
                }
                else
                {
                    sum += array[i];
                    array[i] = sum-max;
                }
            }
                // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int mx = 1;
            for (int i=0;i<array.Length-1;i++)
            {
                if (array[i] > array[i+1])
                {
                    mx++;
                }
                else
                {
                    if (length < mx)
                        length = mx;
                    mx = 1;
                }
            }
            if (length == 0)
                length = 1;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int i = 2;
            while (i<array.Length)
            {
                if (array[i - 2] <= array[i])
                    i+=2;
                else
                {
                    (array[i], array[i - 2]) = (array[i - 2], array[i]);
                    i-=2;
                    if (i==0)
                        i = 2;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int[] cl1 = new int[array.Length];
            int n = 0;
            for (int i=0;i<array.Length;i++)
            {
                bool f = true;
                for (int j=0;j<i;j++)
                {
                    if (array[i] == array[j])
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    cl1[n]=array[i];
                    n++;
                }
                
            }
            cleared= new int[n];
            for (int i=0;i<cleared.Length;i++)
            {
                cleared[i] = cl1[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a == b || n < 2)
            {
                return null;
            }
            double raz = 0;
            if (n!=1)
                raz = (b - a)/(n-1);
            else
                raz = (b - a) / (n);

            A = new double[n];
            B=new double[0];
            A[0] = a;
            double sred = 0;

            int nn = 0;
            if(A[0] > 0)
            {
                sred += A[0];
                nn++;
            }

            for (int i=1;i<n;i++)
            {
                A[i] = A[i-1]+raz;
                if (A[i] > 0)
                {
                    sred += A[i];
                    nn++;
                }
            }
            
            if (nn > 0)
                sred /= nn;
            
            if (nn > 0)
            {
                int higtsred = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > sred)
                        higtsred++;
                }
                B = new double[higtsred];
                int bi = 0;
                for (int i = 0; i < n; i++)
                    if (A[i] > sred)
                    {
                        B[bi] = A[i];
                        bi++;
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
            int[] shuler = new int[n];
            int shulerdice = 0;

            for (int i = 0; i < n; i++)
            {
                int a = 6 - shulerdice;
                if (a < 1) a = 1;

                shuler[i] = a;
                shulerdice++;
            }
            int mydice = 0;
            for (int i = 0; i < n; i++)
            {
                int b = dices[i]; 
                dices[i] -= mydice;
                if (dices[i] < 1) dices[i] = 1;
                if (b == 6)
                {
                    mydice++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (dices[i] > shuler[i])
                {
                    wins++;
                }
            }

        
            // end

            return wins;

        }
    }
}
