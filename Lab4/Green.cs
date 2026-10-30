namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            double su = 0;
            int c = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    su += array[i];
                    c++;
                }
            }

            if (c == 0 ) return;

            double avg = su / c;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
        }
        public int Task2(int[] array)
        {
            int sum = 0;

            int firstNegIdx = -1;

            for ( int i = 0; i < array.Length ; i++)
            {
                if (array[i] < 0)

                {
                    firstNegIdx = i;
                    break;
                }
            }

            if (firstNegIdx == -1) return 0;

            for (int i = 0; i < firstNegIdx ; i++)

            {
                sum += array[i] * array[i];
            }

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            int minVal = int.MaxValue;

            int maxVal = int.MinValue;

            int minPos = 0;
            int maxPos = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] < minVal)
                {
                    minVal = array[i];

                    minPos = i;

                }
                if ( array[i] > maxVal )
                {

                    maxVal = array[i];
                    maxPos = i;
                }
            }

            int start = minPos;
            int end = maxPos;
            if ( start > end )
            {
                int temp = start;
                start = end;
                end = temp;
            }

            int count = 0;
            for ( int i = start + 1; i < end; i++)
            {
                if (array[i] < 0) count++;
            }

            negatives = new int[count];
            int idx = 0;
            for (int i = start + 1; i < end; i++)
            {
                if ( array[i] <  0 )
                {
                    negatives[idx] = array[i];
                    idx++;
                }
            }

            return negatives;
        }
        public void Task4(int[] array)
        {

            int neg = -1;
            int maxPos = 0;

            int maxVal = int.MinValue;

            for ( int i = 0; i < array.Length; i++ )
            {
                if  (array[i] < 0)
                {
                    neg = i;

                    break;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if ( array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxPos = i;
                }
            }

            if ( neg != -1)
            {

                int t = array[neg ];
                array[neg] = array[maxPos];

                array[ maxPos] = t;
            }

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]  > max) max = array[i];
            }

            int cnt = 0;


            for ( int i = 0; i < array.Length;  i++)


            {

                if (array[i] ==  max) cnt++;
            }

             answer = new int[cnt];
            int j = 0;

            for (int i = 0; i < array.Length; i++)

            {
                if ( array[i] == max)
                {
                    answer[j] = i;
                    j++;
                }
            }


            return answer;
        }
        public void Task6(int[] array)
        {

            int mx =  int.MinValue;

            for (int i = 0; i < array.Length ; i++)
            {
                if ( array[i] > mx ) mx = array[i];
            }

            int n = 0;
            for ( int i = 0; i < array.Length; i++)

            {
                if ( array[i] == mx )
                     
                {
                    n++;

                    array[i] = array[i] + n;
                }
            }

        }
        public void Task7(int[] array)
        {

            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++ )

            {
                if (array[i] > max) max = array[i];
            }

            int s = 0;
            for ( int i = 0; i < array.Length; i++ )
            {

                int cur = array[i];

                if ( cur == max)
                {

                    array[i] = s;
                }
                s += cur;
            }

        }
        public int Task8(int[] array)
        {
            int length = 0;


            if (array.Length == 0) return 0;

            int cur = 1;
            int mx = 1;

            for (int i = 0; i < array.Length - 1; i++ )
            {
                if (array[i] > array[i + 1])
                {
                    cur++;
                }
                else
                {
                    if (cur > mx) mx = cur;
                    cur = 1;
                }
            }

            if (cur > mx) mx = cur;

            length = mx;

            return length;



        }
        public void Task9(int[] array)
        {

            for (int i = 0; i < array.Length - 2; i += 2)
            {


                for (int j = 0; j < array.Length - 2 - i; j += 2)
                {

                    if (array[j] > array[j + 2])
                    {
                        int t = array[j];

                        array[j] = array[ j + 2 ];
                        array[j + 2] = t;
                    }
                }
            }

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;
            int c = 0;

            for ( int i = 0; i < array.Length; i++)
            {
                bool f = false;


                for (int j = 0; j < i; j++)
                {

                    if (array[i] == array[j] )
                    {
                        f = true;

                        break;
                    }
                }
                if (!f) c++;
            }

            cleared = new int[ c];


            int idx = 0;

            for (int i = 0; i < array.Length; i++)
            {

                bool f = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        f = true;

                        break;
                    }
                }
                if (!f)
                {
                    cleared[idx] = array[i];

                    idx++;



                }
            }


            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            if (n <= 1 || a == b) return null;



            A = new double[n];
            double step = (b - a ) / ( n - 1 );

            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;

            }

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



            if (count == 0) return new double[0];
            double avg =  sum / count;

            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg) k++;

            }

            B = new double[k];
            int j = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)

                {
                    B[j] = A[i];

                    j++;
                }

            }

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            if (dices == null || dices.Length == 0) return 0;


            int p = 0;

            for ( int i = 0; i < dices.Length; i++ )
            {
                int x = dices[i] - p;
                if (x < 1) x = 1;

                int y = 6 - i;
                if (y < 1) y = 1;

                if (x > y)
                {
                    wins++;

                }

                if (dices[i] == 6)
                {
                    p++;

                }
            }

            return wins;


        }
    }
}
