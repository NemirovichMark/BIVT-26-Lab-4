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
                    sum += array[i];
                    count++;
                }
            }
            if (count > 0)
            {
                double average = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = average;
                    }
                }
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            if (array == null || array.Length == 0) return 0;
            bool hasNegative = false;
            int tempSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    hasNegative = true;
                    break;
                }
                tempSum += array[i] * array[i];
            }
            if (!hasNegative)
            {
                sum = 0;
            }
            else
            {
                sum = tempSum;
            }

            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array == null || array.Length == 0) return new int[0];
            int maxIdx = 0;
            int minIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
                if (array[i] < array[minIdx]) minIdx = i;
            }
            if (maxIdx == minIdx) return new int[0];
            int start = maxIdx < minIdx ? maxIdx + 1 : minIdx + 1;
            int end = maxIdx < minIdx ? minIdx - 1 : maxIdx - 1;
            if (start > end) return new int[0];
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }
            negatives = new int[count];
            int idx = 0;
            for (int i = start; i <= end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[idx] = array[i];
                    idx++;
                }
            }


				// end

				return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxIdx = 0;
            int firstNegIdx = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                {
                    maxIdx = i;
                }
                if (firstNegIdx == -1 && array[i] < 0)
                {
                    firstNegIdx = i;
                }
            }
            if (firstNegIdx != -1)
            {
                int temp = array[maxIdx];
                array[maxIdx] = array[firstNegIdx];
                array[firstNegIdx] = temp;
            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0) return answer;
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    count++;
                }
            }
            answer = new int[count];
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    answer[idx] = i;
                    idx++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            int ordinalNumber = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] += ordinalNumber;
                    ordinalNumber++;
                }
            }


			// end

		}
        public void Task7(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;
            int maxVal = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                }
            }
            int[] sums = new int[array.Length];
            int currentSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sums[i] = currentSum;
                currentSum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] = sums[i];
                }
            }

			// end

		}
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array == null || array.Length == 0) return 0;
            if (array.Length == 1) return 1;
            int maxLen = 1;
            int currentLen = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    currentLen++;
                }
                else
                {
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                    }
                    currentLen = 1;
                }
            }
            if (currentLen > maxLen)
            {
                maxLen = currentLen;
            }
            length = maxLen;


				// end

				return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1) return;
            int count = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                count++;
            }
            int[] evenElements = new int[count];
            int idx = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                evenElements[idx] = array[i];
                idx++;
            }
            for (int i = 0; i < evenElements.Length - 1; i++)
            {
                for (int j = 0; j < evenElements.Length - i - 1; j++)
                {
                    if (evenElements[j] > evenElements[j + 1])
                    {
                        int temp = evenElements[j];
                        evenElements[j] = evenElements[j + 1];
                        evenElements[j + 1] = temp;
                    }
                }
            }
            idx = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = evenElements[idx];
                idx++;
            }
				// end

			}
		public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array == null || array.Length == 0) return cleared;
            int uniqueCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate)
                {
                    uniqueCount++;
                }
            }
            cleared = new int[uniqueCount];
            int resIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isDublicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isDublicate = true;
                        break;
                    }
                }
                if (!isDublicate)
                {
                    cleared[resIndex] = array[i];
                    resIndex++;
                }
            }


				// end

				return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;


            // code here

            if (n <= 0 || a > b) return null;
            A = new double[n];
            if (n == 1)
            {
                A[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * step;
                }
                A[n - 1] = b;
            }
            double sum = 0;
            int countPos = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    countPos++;
                }
            }
            if (countPos == 0) return new double[0];
            double avg = sum / countPos;
            int countB = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    countB++;
                }
            }
            if (countB == 0) return null;
            B = new double[countB];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
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
            if (dices == null || dices.Length == 0) return wins;
            int penalty = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int val = dices[i] - penalty;
                if (val < 1) val = 1;
                if (dices[i] == 6 || val > 6)
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    penalty++;
                }
            }

				// end

				return wins;

        }
    }
}
