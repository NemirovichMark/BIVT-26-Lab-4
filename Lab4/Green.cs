using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double count = 0;
            for (int i  = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    count++;    
                }
            }
            double average = sum / count;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                  {
                    array[i] = average;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
                        int firstNegative = -1;   

            for (int i = 0; i < array.Length && firstNegative == -1; i++)
            {
                if (array[i] < 0)
                {
                    firstNegative = i;
                }
            }

            if (firstNegative != -1)
            {
                for (int i = 0; i < firstNegative; i++)
                {
                    sum += array[i] * array[i];
                }
            }
            // end
            
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

                       // code here
            negatives = new int[0];

            if (array.Length == 0)
            {
                return negatives;
            }

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) { maxIndex = i; }
                if (array[i] < array[minIndex]) { minIndex = i; }
            }

            int left = Math.Min(maxIndex, minIndex);
            int right = Math.Max(maxIndex, minIndex);

            int count = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                }
            }

            negatives = new int[count];

            int k = 0;
            for (int i = left + 1; i < right; i++)
            {
                if (array[i] < 0)
                {
                    negatives[k] = array[i];
                    k++;
                }
            }
            // end

            return negatives;
        }
                      
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            int fn = -1;
            
            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }
            for (int i = 0; i < array.Length && fn ==-1; i++)
            {
                if (array[i] < 0)
                {
                    fn = i;
                }
            } 
            if (fn != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[fn];
                array[fn] = temp;

            }

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            int count = 0;
                        for ( int i =1; i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
            } 
            for ( int i =0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                }
            }
            answer = new int[count];
            int k = 0;
            for ( int i = 0; i < array.Length; i++)
            {
               if (array[i] == max)
                {
                    answer[k] = i;
                    k++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = array[0];
            for ( int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int number = 0;
            for ( int i = 0;i < array.Length;i++)
            {
                if (array[i] == max)
                {
                    number++;
                    array[i] += number;
                }
            }
                        // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
                {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int sum = 0;
            for ( int i = 0; i < array.Length; i++)
            {
                int original = array[i];
                if (original == max)
                {
                    array[i]= sum;
                    
                }
                sum += original;
            } 
            

            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
             int pd = 1;
            length = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    pd++;
                    
                }
                else
                {
                    pd = 1;
                }
                if (pd > length)
                {
                    length = pd;
                }
            } 
            
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here

            for (int i = 0; i < array.Length; i+= 2)
            {
                int minIndex = i;
                for (int j = i + 2; j < array.Length; j+= 2)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;

            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            
                        int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool seen = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        seen = true;
                    }
                }

                if (!seen)
                {
                    count++;
                }
            }

            cleared = new int[count];

            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool seen = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        seen = true;
                    }
                }

                if (!seen)
                {
                   cleared[k] = array[i];
                    k++;
                }
            }
                       // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n > 1 && a != b)
            {
                A = new double[n];
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * (b - a) / (n - 1);
                }

                double sum = 0;
                int positiveCount = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0)
                    {
                        sum += A[i];
                        positiveCount++;
                    }
                }

                B = new double[0];

                if (positiveCount > 0)
                {
                    double average = sum / positiveCount;

                    int countB = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > average)
                        {
                            countB++;
                        }
                    }

                    B = new double[countB];
                    int k = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (A[i] > 0 && A[i] > average)
                        {
                            B[k] = A[i];
                            k++;
                        }
                    }
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int sixes = 0;    

            for (int i = 0; i < dices.Length; i++)
            {
                int player = dices[i] - sixes;
                if (player < 1)
                {
                    player = 1;
                }

                int cheater = 6 - i;
                if (cheater < 1)
                {
                    cheater = 1;
                }

                if (player > cheater)
                {
                    wins++;
                }

                if (dices[i] == 6)
                {
                    sixes++;
                }
            }

            // end

            return wins;

        }
    }
}
