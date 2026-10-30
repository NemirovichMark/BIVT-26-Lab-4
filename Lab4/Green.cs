namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            List<double> pos = new List<double>();
            foreach (var item in array)
            {
                if (item > 0) pos.Add(item);
            }
            if (pos.Count > 0)
            {
                double avg = pos.Sum() / pos.Count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = avg;
                    }
                }
            }
            // end
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            // code here
            int firstNegIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstNegIdx = i;
                    break;
                }
            }
            int limit = firstNegIdx == -1 ? array.Length : firstNegIdx;
            for (int i = 0; i < limit; i++)
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
            int maxVal = array[0];
            int imax = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > maxVal) { maxVal = array[i]; imax = i; }

            int minVal = array[0];
            int imin = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] < minVal) { minVal = array[i]; imin = i; }

            int left = Math.Min(imax, imin) + 1;
            int right = Math.Max(imax, imin) - 1;

            List<int> resList = new List<int>();
            if (left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    if (array[i] < 0) resList.Add(array[i]);
                }
            }
            negatives = resList.ToArray();
            // end
            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            int iMax = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[iMax]) iMax = i;

            int iNeg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    iNeg = i;
                    break;
                }
            }
            if (iNeg != -1)
            {
                int temp = array[iMax];
                array[iMax] = array[iNeg];
                array[iNeg] = temp;
            }
            // end
        }

        public int[] Task5(int[] array)
        {
            int[] answer = null;
            // code here
            int max = array[0];
            foreach (var x in array) if (x > max) max = x;

            List<int> idxList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) idxList.Add(i);
            }
            answer = idxList.ToArray();
            // end
            return answer;
        }

        public void Task6(int[] array)
        {
            // code here
            int maxVal = array[0];
            foreach (var v in array) if (v > maxVal) maxVal = v;

            int countMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    countMax++;
                    array[i] += countMax;
                }
            }
            // end
        }

        public void Task7(int[] array)
        {
            // code here
            int maxVal = array[0];
            foreach (var x in array) if (x > maxVal) maxVal = x;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    int sumBefore = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sumBefore += array[j];
                    }
                    array[i] = sumBefore;
                }
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            int maxLen = 1;
            int current = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    current++;
                    if (current > maxLen) maxLen = current;
                }
                else
                {
                    current = 1;
                }
            }
            length = maxLen;
            // end
            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;
            int evenCount = (array.Length + 1) / 2;
            int[] temp = new int[evenCount];
            int k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                temp[k++] = array[i];
            }
            
            for (int i = 1; i < evenCount; i++)
            {
                int key = temp[i];
                int j = i - 1;
                while (j >= 0 && temp[j] > key)
                {
                    temp[j + 1] = temp[j];
                    j--;
                }
                temp[j + 1] = key;
            }

            k = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = temp[k++];
            }
            // end
        }

        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // code here
            if (array == null || array.Length == 0) return new int[0];
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
                if (!isDup)
                {
                    array[count++] = array[i];
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
            if (n < 1 || (n != 1 && a == b) || (n == 1 && a != b)) 
            {
                return null;
            }

            if (n == 1 && a == b)
            {
                A = new double[1];
                A[0] = a;
            }
            else if (n > 1 && a != b)
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
                        sum += A[i];
                        count++;
                    }
                }

                if (count > 0)
                {
                    double avg = sum / count;
                    int countB = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > avg) countB++;
                    }

                    B = new double[countB];
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > avg)
                        {
                            B[k++] = A[i];
                        }
                    }
                }
                else
                {
                    B = new double[0];
                }
            }
            // end
            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;
            // code here
            if (dices == null || dices.Length == 0) return 0;
            
            int curse = 0; 
            for (int i = 0; i < dices.Length; i++)
            {
                int myDice = dices[i] - curse;
                int dealerDice = 6 - curse; 
                
                if (myDice < 1) myDice = 1;
                if (dealerDice < 1) dealerDice = 1;
                
                if (myDice > dealerDice) wins++;
                
                if (dices[i] == 6) 
                {
                    curse++;
                }
            }
            // end
            return wins;
        }
    }
}
