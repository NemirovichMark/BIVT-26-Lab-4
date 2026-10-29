namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i < vector.Length; ++i) {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int min_val = Math.Min(P, Q);
            int max_val = Math.Max(P, Q);
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > min_val && array[i] < max_val)
                    ++count;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int maxx = int.MinValue, ind_max = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] >= maxx) {
                    maxx = array[i];
                    ind_max = i;
                }
            }
            if (ind_max != array.Length - 1) {
                int minn = int.MaxValue, ind_min = ind_max + 1;
                int start_value = array[ind_max + 1];
                for (int i = ind_max + 1; i < array.Length; ++i) {
                    if (array[i] < minn) {
                        minn = array[i];
                        ind_min = i;
                    }
                }
                bool is_same = true;
                for (int i = ind_max + 1; i < array.Length - 1; ++i) {
                    if (array[i] != array[i + 1]) {
                        is_same = false;
                        break;
                    }
                }
                if (!is_same)
                {
                    int temp = array[ind_max];
                    array[ind_max] = array[ind_min];
                    array[ind_min] = temp;
                }

            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maxx = int.MinValue, max_ind = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (i % 2 == 0) {
                    if (array[i] > maxx) {
                        maxx = array[i];
                        max_ind = i;
                    }
                }
            }
            array[max_ind] = max_ind;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int maxx = int.MinValue, ind_max = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] > maxx) {
                    maxx = array[i];
                    ind_max = i;
                }
            }
            if (ind_max != 0)
            {
                for (int i = 0; i < ind_max - 1; i += 2)
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int count_pozitive = 0;
            for (int i = 0; i < array.Length; ++i) {
                if (array[i] >= 0)
                    ++count_pozitive;
            }
            answer = new int[count_pozitive];
            int ind_answer = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= 0) {
                    answer[ind_answer] = array[i];
                    ++ind_answer;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; ++i)
            {
                for (int j = 0; j < array.Length - i - 1; ++j)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < (array.Length / 2); ++i)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int ind_A = 0, ind_B = 0, ind_C = 0;
            while (A.Length > ind_A || B.Length > ind_B)
            {
                if (ind_C < A.Length)
                {
                    C[ind_C] = A[ind_A];
                    ++ind_A;
                }
                else
                {
                    C[ind_C] = B[ind_B];
                    ++ind_B;
                }
                ++ind_C;
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                return new double[] { a };
            }
            if (a == b || n < 2)
            {
                return null;
            }
            array = new double[n];
            double step = Math.Abs(b - a) / (n - 1);
            if (a > b)
            {
                double meaning = a;
                for (int i = 0; i < array.Length; ++i)
                {
                    array[i] = meaning;
                    meaning -= step;
                }
            }
            if (a < b)
            {
                double meaning = a;
                for (int i = 0; i < array.Length; ++i)
                {
                    array[i] = meaning;
                    meaning += step;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here

            // end

            return restored;
        }
    }
}
