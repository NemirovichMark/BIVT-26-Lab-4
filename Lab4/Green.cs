namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            double s = 0;
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) { s += array[i]; cnt++; }
            if (cnt > 0)
            {
                double avg = s / cnt;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0) array[i] = avg;
            }
            // end
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            // code here
            int negIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { negIdx = i; break; }
            }
            sum = 0;
            for (int i = 0; i < negIdx; i++)   
                sum += array[i] * array[i];
            // end
            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            int maxVal = array[0], minVal = array[0], maxIdx = 0, minIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) { maxVal = array[i]; maxIdx = i; }
                if (array[i] < minVal) { minVal = array[i]; minIdx = i; }
            }
            int lo = Math.Min(maxIdx, minIdx);
            int hi = Math.Max(maxIdx, minIdx);
            int cnt = 0;
            for (int i = lo + 1; i < hi; i++)
                if (array[i] < 0) cnt++;
            negatives = new int[cnt];
            int k = 0;
            for (int i = lo + 1; i < hi; i++)
                if (array[i] < 0) { negatives[k] = array[i]; k++; }
            // end
            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            int maxVal = array[0], maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxVal) { maxVal = array[i]; maxIdx = i; }
            int firstNeg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { firstNeg = i; break; }
            }
            if (firstNeg != -1)
            {
                int t = array[maxIdx];
                array[maxIdx] = array[firstNeg];
                array[firstNeg] = t;
            }
            // end
        }

        public int[] Task5(int[] array)
        {
            int[] answer = null;
            // code here
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxVal) maxVal = array[i];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == maxVal) cnt++;
            answer = new int[cnt];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == maxVal) { answer[k] = i; k++; }
            // end
            return answer;
        
        public void Task6(int[] array)
        {
            // code here
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxVal) maxVal = array[i];
            int order = 1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == maxVal) { array[i] += order; order++; }
            // end
        }

        public void Task7(int[] array)
        {
            // code here
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxVal) maxVal = array[i];
            int runningSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] = runningSum;                
                    runningSum = runningSum + array[i];    
                }
                else
                {
                    runningSum = runningSum + array[i];
                }
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            int cur = 1;
            length = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) cur++;
                else cur = 1;
                if (cur > length) length = cur;
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
            bool[] dup = new bool[array.Length];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (!dup[i])
                {
                    cnt++;
                    for (int j = i + 1; j < array.Length; j++)
                        if (array[i] == array[j]) dup[j] = true;
                }
            }
            cleared = new int[cnt];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
                if (!dup[i]) { cleared[k] = array[i]; k++; }
            // end
            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            // code here
            if (n < 1 || (n != 1 && a == b) || (n == 1 && a != b))
                return B;  

            A = new double[n];
            if (n == 1)
            {
                A[0] = a;                                   
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++) A[i] = a + i * step;
            }

            double posSum = 0;
            int posCnt = 0;
            for (int i = 0; i < n; i++)
                if (A[i] > 0) { posSum += A[i]; posCnt++; }

            if (posCnt > 0)
            {
                double avg = posSum / posCnt;
                int cnt = 0;
                for (int i = 0; i < n; i++)
                    if (A[i] > 0 && A[i] > avg) cnt++;
                B = new double[cnt];
                int k = 0;
                for (int i = 0; i < n; i++)
                    if (A[i] > 0 && A[i] > avg) { B[k] = A[i]; k++; }
            }
            else
            {
                B = new double[0];
            }
            // end
            return B;
        }

        public int Task12(int[] dicss)
        {
            int wins = 0;
            // code here
            int n = dicss.Length;
            int[] result = new int[n];
            for (int i = 0; i < n; i++) result[i] = dicss[i];

            for (int i = 0; i < n; i++)
            {
                if (dicss[i] == 6)
                    for (int j = i + 1; j < n; j++)
                        if (result[j] > 1) result[j]--;
            }

            wins = 0;
            for (int i = 0; i < n; i++)
                if (result[i] > 6) wins++;   
            // end
            return wins;
        }
    }
}
