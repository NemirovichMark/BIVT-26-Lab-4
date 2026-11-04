namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i < vector.Length; i++)
    length += vector[i] * vector[i];
length = Math.Sqrt(length);

            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
    if (P < array[i] && Q > array[i])
        count++;

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int x = 0;
for(int i =1; i < array.Length; i++)
    if (array[x] < array[i])  
        x = i;
if (x == array.Length - 1)
    return;
int n = x + 1;
for (int i = n + 1; i < array.Length; i++)
    if (array[n] > array[i])
        n = i;
(array[n], array[x]) = (array[x], array[n]);

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
    return;

int maxIndex = 0;

for (int i = 2; i < array.Length; i += 2)
{
    if (array[i] > array[maxIndex])
        maxIndex = i;
}

array[maxIndex] = maxIndex;

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
if (array != null)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == P)
        {
            index = i;
            break;
        }
    }
}

            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
    return;

int maxIndex = 0;
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[maxIndex])
        maxIndex = i;
}

for (int i = 0; i + 1 < maxIndex; i += 2)
{
    int temp = array[i];
    array[i] = array[i + 1];
    array[i + 1] = temp;
}

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null)
    return null;

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
        count++;
}

answer = new int[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        answer[j] = array[i];
        j++;
    }
}

            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
    return;

for (int i = 0; i < array.Length - 1; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[j] > array[i])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}

            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length <= 1)
    return;

for (int i = 0; i < array.Length / 2; i++)
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
            if (A == null) A = new int[0];
if (B == null) B = new int[0];

if (A.Length == 0 || B.Length == 0)
    return (int[])(A.Length == 0 ? B : A).Clone();

C = new int[A.Length + B.Length];
int i = 0, j = 0;

for (int k = 0; k < C.Length; k++)
{
    if (j >= B.Length || (i < A.Length && k % 2 == 0))
        C[k] = A[i++];
    else
        C[k] = B[j++];
}

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
              if (n <= 0)
    {
        array = null;
    }
    else if (n == 1)
    {
        if (a == b)
            array = new double[] { a };
        else
            array = null;
    }
    else if (a == b)
    {
        array = null;
    }
    else
    {
        array = new double[n];
        double step = (b - a) / (n - 1);

        for (int i = 0; i < n; i++)
        {
            array[i] = a + i * step;
        }
    }

            // code here
             if (raw == null || raw.Length < 3)
    {
        restored = null;
    }
    else
    {
        bool allDamaged = true;
        for (int i = 0; i < raw.Length; i++)
        {
            if (raw[i] != -1)
            {
                allDamaged = false;
                break;
            }
        }

        if (allDamaged)
        {
            restored = (double[])raw.Clone();
        }
        else
        {
            restored = (double[])raw.Clone();

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    int leftIndex = (i == 0) ? raw.Length - 1 : i - 1;
                    int rightIndex = (i == raw.Length - 1) ? 0 : i + 1;

                    double left = raw[leftIndex];
                    double right = raw[rightIndex];

                    if (left != -1 && right != -1)
                    {
                        restored[i] = (left + right) / 2.0;
                    }
                }
            }
        }
    }

            // end

            return restored;
        }
    }
}
