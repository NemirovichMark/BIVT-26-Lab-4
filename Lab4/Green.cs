amespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {vvv             f

            // code here
            long sum = 0; int cnt = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) { sum += array[i]; cnt++; }
            if (cnt > 0)
            {
                int avg = (int)(sum / cnt);
                for (int i = 0; i < array.Length; i++)
                    if (array[i] > 0) array[i] = avg;
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int answer = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                answer += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int maxIdx = 0, minIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
                if (array[i] < array[minIdx]) minIdx = i;
            }
            int from = Math.Min(maxIdx, minIdx) + 1;
            int to = Math.Max(maxIdx, minIdx);
            int cnt = 0;
            for (int i = from; i < to; i++) if (array[i] < 0) cnt++;
            int[] answer = new int[cnt];
            int k = 0;
            for (int i = from; i < to; i++) if (array[i] < 0) answer[k++] = array[i];
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx]) maxIdx = i;
            int negIdx = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { negIdx = i; break; }
            if (negIdx != -1)
            {
                int t = array[maxIdx]; array[maxIdx] = array[negIdx]; array[negIdx] = t;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int mx = array[0];
            for (int i = 1; i < array.Length; i++) if (array[i] > mx) mx = array[i];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] == mx) cnt++;
            int[] answer = new int[cnt];
            int k = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] == mx) answer[k++] = i;
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int mx = array[0];
            for (int i = 1; i < array.Length; i++) if (array[i] > mx) mx = array[i];
            int ord = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == mx) { ord++; array[i] += ord; }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int mx = array[0];
            for (int i = 1; i < array.Length; i++) if (array[i] > mx) mx = array[i];
            int[] idx = new int[array.Length];
            int c = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] == mx) idx[c++] = i;
            int running = 0, p = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (p < c && idx[p] == i) { array[i] = running; p++; }
                else running += array[i];
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int answer = 1;
            int cur = 1;
            for (int i = 0; i + 1 < array.Length; i++)
            {
                if (array[i] > array[i + 1]) { cur++; if (cur > answer) answer = cur; }
                else cur = 1;
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int m = (array.Length + 1) / 2;
            int[] even = new int[m];
            for (int i = 0; i < m; i++) even[i] = array[2 * i];
            for (int i = 1; i < m; i++)
            {
                int key = even[i], j = i - 1;
                while (j >= 0 && even[j] > key) { even[j + 1] = even[j]; j--; }
                even[j + 1] = key;
            }
            for (int i = 0; i < m; i++) array[2 * i] = even[i];
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool dup = false;
                for (int j = 0; j < cnt; j++)
                    if (array[j] == array[i]) { dup = true; break; }
                if (!dup) array[cnt++] = array[i];
            }
            int[] answer = new int[cnt];
            for (int i = 0; i < cnt; i++) answer[i] = array[i];
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            double[] A = null;
            double[] B = new double[0];
            if (n == 1 && a == b) A = new double[] { a };
            else if (n > 0 && a != b)
            {
                A = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++) A[i] = a + step * i;
                double sum = 0; int cnt = 0;
                for (int i = 0; i < n; i++) if (A[i] > 0) { sum += A[i]; cnt++; }
                if (cnt > 0)
                {
                    double avg = sum / cnt;
                    B = new double[cnt];
                    int k = 0;
                    for (int i = 0; i < n; i++)
                        if (A[i] > 0 && A[i] > avg) B[k++] = A[i];
                    Array.Resize(ref B, k);
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int answer = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int my = dices[i];
                int dealer = 6;
                for (int j = 0; j < i; j++)
                {
                    if (dices[j] == 6) my = my - 1;
                    dealer = dealer - 1; 
                }
                if (my < 1) my = 1;
                if (dealer < 1) dealer = 1;
                if (my > dealer) answer = answer + 1;
            }
            // end

            return wins;

        }
    }
}
