using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
       

        public void Task1(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx]) maxIdx = i;

            int negIdx = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { negIdx = i; break; }

            if (negIdx == -1) return;

            int sum = 0;
            for (int i = maxIdx + 1; i < array.Length; i++)
                sum += array[i];

            array[negIdx] = sum;
            // end
        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;

            int lastPos = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) lastPos = i;

            if (lastPos == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++) answer[i] = array[i];
                return answer;
            }

            answer = new int[array.Length + 1];
            for (int i = 0; i <= lastPos; i++) answer[i] = array[i];
            answer[lastPos + 1] = P;
            for (int i = lastPos + 1; i < array.Length; i++) answer[i + 1] = array[i];
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;

            int minPosIdx = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0 && (minPosIdx == -1 || array[i] < array[minPosIdx]))
                    minPosIdx = i;

            if (minPosIdx == -1)
            {
                answer = new int[array.Length];
                for (int i = 0; i < array.Length; i++) answer[i] = array[i];
                return answer;
            }

            answer = new int[array.Length - 1];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
                if (i != minPosIdx) answer[k++] = array[i];
            // end

            return answer;
        }
        public void Task4(double[] array)
        {
            // code here
            if (array == null || array.Length == 0) return;

            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = sum / array.Length;

            for (int i = 0; i < array.Length; i++) array[i] -= avg;
            // end
        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
            if (A == null || B == null) return 0;
            if (A.Length != B.Length) return 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i] * B[i];
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            if (array == null || array.Length == 0) { indexes = new int[0]; return indexes; }
            double avg = 0;
            for (int i = 0; i < array.Length; i++) avg += array[i];
            avg /= array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < avg) count++;
            indexes = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < avg) indexes[k++] = i;
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0) return 0;

            int best = 1;

            int cur = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1]) cur++; else cur = 1;
                if (cur > best) best = cur;
            }

            cur = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] <= array[i - 1]) cur++; else cur = 1;
                if (cur > best) best = cur;
            }

            count = best;
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null) return null;
            answer = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                answer[2 * i] = array[i];
                answer[2 * i + 1] = array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null || array.Length == 0) return null;
            int min = array[0], max = array[0];
            bool allEqual = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
                if (array[i] != array[0]) allEqual = false;
            }
            if (allEqual || min == max) return null;
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                normalized[i] = (double)(array[i] - min) / (max - min);
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            if (array == null || array.Length == 0) return -1;
            int[] sorted = new int[array.Length];
            for (int i = 0; i < array.Length; i++) sorted[i] = array[i];
           
            for (int i = 1; i < sorted.Length; i++)
            {
                int key = sorted[i];
                int j = i - 1;
                while (j >= 0 && sorted[j] > key) { sorted[j + 1] = sorted[j]; j--; }
                sorted[j + 1] = key;
            }
            int lo = 0, hi = sorted.Length - 1;
            index = -1;
            while (lo <= hi)
            {
                int mid = (lo + hi) / 2;
                if (sorted[mid] == P) { index = mid; break; }
                if (sorted[mid] < P) lo = mid + 1; else hi = mid - 1;
            }
            // end

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;
            if (a > c) return new int[0];
            int count = 0;
            for (int v = a; v <= c; v += b) count++;
            array = new int[count];
            int k = 0;
            for (int v = a; v <= c; v += b) array[k++] = v;
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine == null) return null;
            if (magazine.Length == 0) return new int[0];
            if (magazine.Length <= 3)
            {
                indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++) indexes[i] = i;
                return indexes;
            }
            int bestSum = int.MinValue;
            int bestStart = 0;
            for (int i = 0; i <= magazine.Length - 3; i++)
            {
                int s = magazine[i] + magazine[i + 1] + magazine[i + 2];
                if (s > bestSum) { bestSum = s; bestStart = i; }
            }
            indexes = new int[3] { bestStart, bestStart + 1, bestStart + 2 };
            // end

            return indexes;
        }
    }
}
