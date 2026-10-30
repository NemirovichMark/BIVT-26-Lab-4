namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            
            if (array == null || array.Length == 0) return;
            double sum = 0;
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;
                }
            }
            if (count == 0) return;
            double avg = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    array[i] = avg;
            }
            

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            if (array == null || array.Length == 0) return 0;

            int firstNeg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNeg = i;
                    break;
                }
            }

            if (firstNeg == -1) return 0; 

            for (int i = 0; i < firstNeg; i++)
                sum += array[i] * array[i];
            

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            int maxIndex = 0, minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (array[i] < array[minIndex]) minIndex = i;
            }

            int left = Math.Min(maxIndex, minIndex);
            int right = Math.Max(maxIndex, minIndex);

            int start = left + 1;
            int end = right - 1;

            if (start > end) return new int[0];

            int count = 0;
            for (int i = start; i <= end; i++)
                if (array[i] < 0) count++;

            if (count == 0) return new int[0];

            negatives = new int[count];
            int k = 0;
            for (int i = start; i <= end; i++)
                if (array[i] < 0) negatives[k++] = array[i];
            

            return negatives;
        }
        public void Task4(int[] array)
        {

            
            if (array == null || array.Length == 0) return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex]) maxIndex = i;

            int firstNeg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNeg = i;
                    break;
                }
            }

            if (firstNeg == -1) return;      
            if (firstNeg == maxIndex) return; 

            int temp = array[maxIndex];
            array[maxIndex] = array[firstNeg];
            array[firstNeg] = temp;

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            int count = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) count++;

            answer = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max)
                    answer[k++] = i;
            

            return answer;
        }
        public void Task6(int[] array)
        {

            
            if (array == null || array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            int order = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += order;
                    order++;
                }
            }
            

        }
        public void Task7(int[] array)
        {

            
            if (array == null || array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                if (array[i] > max) max = array[i];

            int sumBefore = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int original = array[i];
                if (original == max)
                    array[i] = sumBefore;
                sumBefore += original;
            }
            

        }
        public int Task8(int[] array)
        {
            int length = 0;

            
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;

            int maxLen = 1;
            int curLen = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    curLen++;
                    if (curLen > maxLen) maxLen = curLen;
                }
                else
                {
                    curLen = 1;
                }
            }
            length = maxLen;
            

            return length;
        }
        public void Task9(int[] array)
        {

            
            if (array == null || array.Length <= 1) return;

            int evenCount = (array.Length + 1) / 2;
            int[] evens = new int[evenCount];
            for (int i = 0; i < evenCount; i++)
                evens[i] = array[i * 2];

            
            for (int i = 0; i < evenCount - 1; i++)
            {
                for (int j = 0; j < evenCount - 1 - i; j++)
                {
                    if (evens[j] > evens[j + 1])
                    {
                        int temp = evens[j];
                        evens[j] = evens[j + 1];
                        evens[j + 1] = temp;
                    }
                }
            }

            for (int i = 0; i < evenCount; i++)
                array[i * 2] = evens[i];
            

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            
            if (array == null) return null;
            if (array.Length == 0) return new int[0];

            int[] temp = new int[array.Length];
            int newSize = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool exists = false;
                for (int j = 0; j < newSize; j++)
                {
                    if (temp[j] == array[i])
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    temp[newSize] = array[i];
                    newSize++;
                }
            }

            cleared = new int[newSize];
            for (int i = 0; i < newSize; i++)
                cleared[i] = temp[i];
            

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            
            if (n < 2) return null;        
            if (a == b) return null;        

            A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
                A[i] = a + i * step;

            double sumPos = 0;
            int countPos = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sumPos += A[i];
                    countPos++;
                }
            }

            if (countPos == 0)
            {
                B = new double[0];
            }
            else
            {
                double avgPos = sumPos / countPos;
                int countB = 0;
                for (int i = 0; i < n; i++)
                    if (A[i] > 0 && A[i] > avgPos) countB++;

                B = new double[countB];
                int k = 0;
                for (int i = 0; i < n; i++)
                    if (A[i] > 0 && A[i] > avgPos)
                        B[k++] = A[i];
            }
            

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            
            if (dices == null || dices.Length == 0) return 0;

            int reduction = 0;
            for (int i = 0; i < dices.Length; i++)
            {
               
                int playerVal = dices[i] - reduction;
                if (playerVal < 1) playerVal = 1;

               
                int shulerVal = 6 - i;
                if (shulerVal < 1) shulerVal = 1;

                if (playerVal > shulerVal) wins++;

                
                if (dices[i] == 6) reduction++;
            }
            

            return wins;

        }
    }
}