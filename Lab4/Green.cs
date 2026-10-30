namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
            }

            double sum = 0;
            for (int i = maxIdx + 1; i < array.Length; i++)
            {
                sum = sum + array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = sum;
                    break;
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

            int start = 0, end = 0;
            if (maxIdx < minIdx) { start = maxIdx + 1; end = minIdx; }
            else { start = minIdx + 1; end = maxIdx; }

            int count = 0;
            for (int i = start; i < end; i++)
            {
                if (array[i] < 0) count = count + 1;
            }

            negatives = new int[count];
            int k = 0;
            for (int i = start; i < end; i++)
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

            int runningSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = runningSum;
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
            if (array.Length > 1)
            {
                length = 1;
                int cur = 1;

                for (int i = 0; i + 1 < array.Length; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        cur = cur + 1;
                        if (cur > length) length = cur;
                    }
                    else
                    {
                        cur = 1;
                    }
                }
            }
            else
            {
                length = 1;
            }
            // end

            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            int evenCount = (array.Length + 1) / 2;
            int[] temp = new int[evenCount];
            int k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                temp[k] = array[i];
                k = k + 1;
            }

            for (int i = 1; i < evenCount; i++)
            {
                int key = temp[i];
                int j = i - 1;
                while (j >= 0 && temp[j] > key)
                {
                    temp[j + 1] = temp[j];
                    j = j - 1;
                }
                temp[j + 1] = key;
            }

            k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = temp[k];
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
                    {
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
                        if (A[i] > 0 && A[i] > avg)
                        {
                            countB = countB + 1;
                        }
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
                else
                {
                    B = new double[0];
                }
            }
            else
            {
                B = new double[0];
            }
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
                
                for (int j = 0; j < i; j++)
                {
                    if (dices[j] == 6)
                    {
                        myDice = myDice - 1;
                    }
                }
                
                if (myDice < 1)
                {
                    myDice = 1;
                }

                if (myDice > 6)
                {
                    wins = wins + 1;
                }
            }
            // end

            return wins;
        }
    }
}
