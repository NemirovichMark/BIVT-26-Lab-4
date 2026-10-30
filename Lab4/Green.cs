namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            double s = 0; int cnt = 0;
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
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                sum += array[i] * array[i];
            }
            // end
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            if (array.Length > 0)
            {
                int imax = 0, imin = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[imax]) imax = i;
                    if (array[i] < array[imin]) imin = i;
                }
                int l = imax < imin ? imax : imin;
                int r = imax < imin ? imin : imax;
                int[] tmp = new int[array.Length]; int c = 0;
                for (int i = l + 1; i < r; i++)
                    if (array[i] < 0) { tmp[c] = array[i]; c++; }
                negatives = new int[c];
                for (int i = 0; i < c; i++) negatives[i] = tmp[i];
            }
            // end
            return negatives;
        }
        public void Task4(int[] array)
        {
            // code here
            if (array.Length > 0)
            {
                int imax = 0;
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > array[imax]) imax = i;
                int ineg = -1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0) { ineg = i; break; }
                }
                if (ineg >= 0)
                {
                    int t = array[imax]; array[imax] = array[ineg]; array[ineg] = t;
                }
            }
            // end
        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            // code here
            if (array.Length > 0)
            {
                int mx = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > mx) mx = array[i];
                int[] tmp = new int[array.Length]; int c = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == mx) { tmp[c] = i; c++; }
                answer = new int[c];
                for (int i = 0; i < c; i++) answer[i] = tmp[i];
            }
            // end
            return answer;
        }
        public void Task6(int[] array)
        {
            // code here
            if (array.Length > 0)
            {
                int mx = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > mx) mx = array[i];
                int order = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == mx) { order++; array[i] += order; }
            }
            // end
        }
        public void Task7(int[] array)
        {
            // code here
            if (array.Length > 0)
            {
                int mx = array[0];
                for (int i = 1; i < array.Length; i++)
                    if (array[i] > mx) mx = array[i];
                int[] prefix = new int[array.Length];
                int s = 0;
                for (int i = 0; i < array.Length; i++) { prefix[i] = s; s += array[i]; }
                for (int i = 0; i < array.Length; i++)
                    if (array[i] == mx) array[i] = prefix[i];
            }
            // end
        }
        public int Task8(int[] array)
        {
            int length = 0;
            // code here
            if (array.Length > 0)
            {
                length = 1; int cur = 1;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < array[i - 1]) { cur++; if (cur > length) length = cur; }
                    else cur = 1;
                }
            }
            // end
            return length;
        }
        public void Task9(int[] array)
        {
            // code here
            int m = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 == 0) m++;
            int[] e = new int[m]; int k = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 == 0) { e[k] = array[i]; k++; }
            for (int i = 1; i < m; i++)
            {
                int key = e[i]; int j = i - 1;
                while (j >= 0 && e[j] > key) { e[j + 1] = e[j]; j--; }
                e[j + 1] = key;
            }
            k = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 == 0) { array[i] = e[k]; k++; }
            // end
        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            // code here
            int[] tmp = new int[array.Length]; int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool seen = false;
                for (int j = 0; j < c; j++) if (tmp[j] == array[i]) { seen = true; break; }
                if (!seen) { tmp[c] = array[i]; c++; }
            }
            cleared = new int[c];
            for (int i = 0; i < c; i++) cleared[i] = tmp[i];
            // end
            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;
            // code here
            A = new double[n];
            for (int i = 0; i < n; i++)
                A[i] = (n > 1) ? (a + (b - a) * i / (n - 1)) : a;
            double s = 0; int cnt = 0;
            for (int i = 0; i < n; i++) if (A[i] > 0) { s += A[i]; cnt++; }
            double avg = cnt > 0 ? s / cnt : 0;
            int[] idx = new int[n]; int c = 0;
            for (int i = 0; i < n; i++) if (A[i] > 0 && A[i] > avg) { idx[c] = i; c++; }
            B = new double[c];
            for (int i = 0; i < c; i++) B[i] = A[idx[i]];
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
                if (dicss[i] == 6)
                    for (int j = i + 1; j < n; j++)
                        if (result[j] > 1) result[j] -= 1;
            for (int i = 0; i < n; i++) if (result[i] > 6) wins++;
            // end
            return wins;
        }
    }
}
