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
                    sum = sum + array[i]; 
                    count = count + 1; 
                }
            }
            if (count > 0)
            {
                double avg = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0) array[i] = avg;
                }
            }
            // end
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                sum = sum + array[i] * array[i];
            }
            // end
            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            int maxIdx = 0;
            int minIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
                if (array[i] < array[minIdx]) minIdx = i;
            }
            
            int from, to;
            if (maxIdx < minIdx) 
            { 
                from = maxIdx + 1; 
                to = minIdx; 
            }
            else 
            { 
                from = minIdx + 1; 
                to = maxIdx; 
            }

            int count = 0;
            for (int i = from; i < to; i++)
            {
                if (array[i] < 0) count = count + 1;
            }

            negatives = new int[count];
            int k = 0;
            for (int i = from; i < to; i++)
            {
                if (array[i] < 0) 
                { 
                    negatives[k] = array[i]; 
                    k = k + 1; 
                }
            }
            // end
            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
            }
            
            int negIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) 
                { 
                    negIdx = i; 
                    break; 
                }
            }
            
            if (negIdx != -1)
            {
                int temp = array[maxIdx];
                array[maxIdx] = array[negIdx];
                array[negIdx] = temp;
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
                if (array[i] > max) max = array[i];
            }
            
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count = count + 1;
            }
            
            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) 
                { 
                    answer[k] = i; 
                    k = k + 1; 
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
                if (array[i] > max) max = array[i];
            }
            
            int order = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    order = order + 1;
                    array[i] = array[i] + order;
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
                if (array[i] > max) max = array[i];
            }
            
            int[] idx = new int[array.Length];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) 
                { 
                    idx[cnt] = i; 
                    cnt = cnt + 1; 
                }
            }
            
            int sumBefore = 0;
            int p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (p < cnt && idx[p] == i)
                {
                    array[i] = sumBefore;
                    p = p + 1;
                }
                else
                {
                    sumBefore = sumBefore + array[i];
                }
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            length = 1;
            int current = 1;
            for (int i = 0; i + 1 < array.Length; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current = current + 1;
                    if (current > length) length = current;
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
            int count = (array.Length + 1) / 2;
            int[] even = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                even[k] = array[i];
                k = k + 1;
            }
            
            for (int i = 1; i < count; i++)
            {
                int key = even[i];
                int j = i - 1;
                while (j >= 0 && even[j] > key)
                {
                    even[j + 1] = even[j];
                    j = j - 1;
                }
                even[j + 1] = key;
            }
            
            k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = even[k];
                k = k + 1;
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
                bool isDup = false;
                for (int j = 0; j < count; j++)
                {
                    if (array[j] == array[i]) 
                        isDup = true; 
                        break; 
                    }
                }
                if (isDup == false)
                {
                    array[count] = array[i];
                    count = count + 1;
                }
            }
            
            cleared = new int[count];
            for (int i = 0; i < count; i++)
            {
                cleared[i] = array[i];
            }
            // end
            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            // code here
            if (n == 1 && a == b)
            {
                A = new double[1];
                A[0] = a;
            }
            else if (n > 0 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + step * i;
                }
            }

            if (A != null)
            {
                double sum = 0;
                int count = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0)
                    {
                        sum = sum + A[i];
                        count = count + 1;
                    }
                }
                
                if (count > 0)
                {
                    double avg = sum / count;
                    int countB = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > avg) countB = countB + 1;
                    }
                    
                    B = new double[countB];
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > avg)
                        {
                            B[k] = A[i];
                            k = k + 1;
                        }
                    }
                }
            }
            if (B == null) B = new double[0];
            // end
            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;
            // code here
            for (int i = 0; i < dices.Length; i++)
            {
                int myDice = dices[i];
                int dealerDice = 6;
                for (int j = 0; j < i; j++)
                {
                    if (dices[j] == 6)
                    {
                        myDice = myDice - 1;
                        dealerDice = dealerDice - 1;
                    }
                }
                
                if (myDice < 1) myDice = 1;
                if (dealerDice < 1) dealerDice = 1;
                
                if (myDice > dealerDice) wins = wins + 1;
            }
            // end
            return wins;
        }
    }
}
