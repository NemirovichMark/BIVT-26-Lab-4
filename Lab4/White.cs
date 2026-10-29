namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
         double sum = 0;

for (int i = 0; i < vector.Length; i++)
{
    sum += (double)vector[i] * vector[i];
}

while (length * length <= sum)
{
    length += 0.00001;
}
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int low = P < Q ? P : Q;
            int high = P > Q ? P : Q;
            

            for (int i = 0; i < array.Length; i++)
{
        if (array[i] > low && array[i] < high)
    {
        count++;
    }
}

return count;
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array.Length < 2)
    {
    return;
    }

int maxIndex = 0;

    for (int i = 1; i < array.Length; i++)
    {
    if (array[i] > array[maxIndex])
    {
        maxIndex = i;
    }
}

if (maxIndex == array.Length - 1)
{
    return;
}

int minIndex = maxIndex + 1;

for (int i = maxIndex + 2; i < array.Length; i++)
{
    if (array[i] < array[minIndex])
    {
        minIndex = i;
    }
}

int temp = array[maxIndex];
array[maxIndex] = array[minIndex];
array[minIndex] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
    if (array.Length == 0)
{
    return;
}

int maxIndex = 0;

for (int i = 2; i < array.Length; i += 2)
{
    if (array[i] > array[maxIndex])
    {
        maxIndex = i;
    }
}

array[maxIndex] = maxIndex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
{
    if (array[i] == P)
    {
        return i;
    }
}

return -1;
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
    if (array.Length < 2)
{
    return;
}

int maxIndex = 0;

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > array[maxIndex])
    {
        maxIndex = i;
    }
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
        int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        count++;
    }
}

int[] result = new int[count];
int j = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] >= 0)
    {
        result[j] = array[i];
        j++;
    }
}

return result;
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
        int[] result = (int[])array.Clone();

for (int i = 0; i < result.Length - 1; i++)
{
    for (int j = i + 1; j < result.Length; j++)
    {
        if (result[i] < result[j])
        {
            int temp = result[i];
            result[i] = result[j];
            result[j] = temp;
        }
    }
}

return result;
            // end

        }
        public void Task9(int[] array)
        {

            // code here
             int[] result = new int[array.Length];

for (int i = 0; i < array.Length; i++)
{
    result[i] = array[array.Length - 1 - i];
}

return result;
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
 int[] C = new int[A.Length + B.Length];

int a = 0;
int b = 0;
int c = 0;

while (a < A.Length && b < B.Length)
{
    C[c] = A[a];
    c++;
    a++;

    C[c] = B[b];
    c++;
    b++;
}

while (a < A.Length)
{
    C[c] = A[a];
    c++;
    a++;
}

while (b < B.Length)
{
    C[c] = B[b];
    c++;
    b++;
}

return C;
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
        if (n <= 0 || (a == b && n != 1))
{
    return null;
}

if (n == 1)
{
    return new double[] { a };
}

double[] result = new double[n];
double step = (b - a) / (n - 1);

for (int i = 0; i < n; i++)
{
    result[i] = a + step * i;
}

result[0] = a;
result[n - 1] = b;

return result;
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
