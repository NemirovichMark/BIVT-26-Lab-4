namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i] * array[i];
            }
            double length = Math.Sqrt(sum);
            Console.WriteLine(length);
            // end
        }

        public int Task2(int[] array, int P, int Q)
        {
            int sum = 0;
            // code here
            int min = Math.Min(P, Q);
            int max = Math.Max(P, Q);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > min && array[i] < max)
                    sum++;
            }
            // end
            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            if (array == null || array.Length < 2)
                return array;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }

            if (maxIdx == array.Length - 1)
                return array;

            int minIdx = maxIdx + 1;
            for (int i = maxIdx + 2; i < array.Length; i++)
            {
                if (array[i] < array[minIdx])
                    minIdx = i;
            }

            bool allEqual = true;
            for (int i = maxIdx + 1; i < array.Length; i++)
            {
                if (array[i] != array[maxIdx])
                {
                    allEqual = false;
                    break;
                }
            }
            if (allEqual)
                return array;

            int temp = array[maxIdx];
            array[maxIdx] = array[minIdx];
            array[minIdx] = temp;

            negatives = array;
            // end
            return negatives;
        }

        public void Task4(int[] array)
        {
            // code here
            int maxVal = int.MinValue;
            int maxIndex = -1;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIndex = i;
                }
            }
            if (maxIndex != -1)
            {
                array[maxIndex] = maxIndex;
            }
            // end
        }

        public int[] Task5(int[] array, int P)
        {
            int[] answer = null;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    answer = new int[] { i };
                    return answer;
                }
            }
            answer = new int[] { -1 };
            // end
            return answer;
        }

        public void Task6(int[] array)
        {
            // code here
            if (array == null || array.Length < 2)
                return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }

            int limit = maxIdx;
            if (limit % 2 != 0)
                limit--;

            for (int i = 0; i < limit; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end
        }

        public void Task7(int[] array)
        {
            // code here
            List<int> result = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    result.Add(array[i]);
            }
            for (int i = 0; i < result.Count; i++)
            {
                array[i] = result[i];
            }
            for (int i = result.Count; i < array.Length; i++)
            {
                array[i] = 0;
            }
            // end
        }

        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            Array.Sort(array);
            Array.Reverse(array);
            length = array.Length;
            // end
            return length;
        }

        public void Task9(int[] array)
        {
            // code here
            Array.Reverse(array);
            // end
        }

        public int[] Task10(int[] array, int[] B)
        {
            int[] cleared = null;
            // code here
            if (array.Length == 0 && B.Length == 0)
            {
                cleared = new int[0];
                return cleared;
            }
            if (array.Length == 0)
            {
                cleared = (int[])B.Clone();
                return cleared;
            }
            if (B.Length == 0)
            {
                cleared = (int[])array.Clone();
                return cleared;
            }

            cleared = new int[array.Length + B.Length];
            int i = 0, j = 0, k = 0;
            while (i < array.Length && j < B.Length)
            {
                cleared[k++] = array[i++];
                cleared[k++] = B[j++];
            }
            while (i < array.Length)
                cleared[k++] = array[i++];
            while (j < B.Length)
                cleared[k++] = B[j++];
            // end
            return cleared;
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            // code here
            if (a == b)
            {
                if (n == 1)
                {
                    B = new double[] { a };
                    return B;
                }
                else
                {
                    return null;
                }
            }

            if (n <= 0)
                return null;

            B = new double[n];
            double step;

            if (a > b)
            {
                step = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    B[i] = a - i * step;
                }
            }
            else
            {
                step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    B[i] = a + i * step;
                }
            }
            // end
            return B;
        }

        public int Task12(int[] dice)
        {
            int wins = 0;
            // code here
            if (dice.Length < 3)
                return 0;

            bool allMinusOne = true;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] != -1)
                {
                    allMinusOne = false;
                    break;
                }
            }
            if (allMinusOne)
            {
                wins = dice.Length;
                return wins;
            }

            bool changed = true;
            while (changed)
            {
                changed = false;
                for (int i = 0; i < dice.Length; i++)
                {
                    if (dice[i] == -1)
                    {
                        bool hasLeft = (i > 0 && dice[i - 1] != -1);
                        bool hasRight = (i < dice.Length - 1 && dice[i + 1] != -1);

                        if (hasLeft && hasRight)
                        {
                            dice[i] = (dice[i - 1] + dice[i + 1]) / 2;
                            changed = true;
                            wins++;
                        }
                    }
                }
            }
            // end
            return wins;
        }
    }
}
