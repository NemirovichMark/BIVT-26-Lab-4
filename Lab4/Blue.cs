using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int max = -999999999;
            int indexforsum = 0;
            int mussum = 0;
            bool lastmax = false;
            bool firstminus = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (max >=  array[i])
                {
                    mussum +=  array[i];
                }
                if (max < array[i] && i != array.Length - 1)
                {
                    max = array[i];
                    mussum = 0;
                }
                if (max < array[i] && i == array.Length - 1)
                {
                    lastmax = true;
                }
                if (array[i] < 0 && firstminus == false)
                {
                    indexforsum = i;
                    firstminus = true;
                }
            }
            if (firstminus == true && lastmax == false)
            {
                array[indexforsum] = mussum;
            }
        }
        public int[] Task2(int[] array, int P)
        {
            bool positive = false;
            int lastmaxindex = 0;
            int[] answer = null;
            for (int i = 0; i < array.Length ; i++)
            {
                if (array[i] > 0)
                {
                    lastmaxindex = i;
                    positive = true;
                }
            }

            if (positive == true)
            {
                if (lastmaxindex != array.Length - 1)
                {
                    bool afterlst = false;
                    answer = new int[array.Length + 1];
                    for (int asd = 0; asd < answer.Length ; asd++)
                    {
                        if (afterlst)
                        {
                            answer[asd] = array[asd - 1];
                        }
                        else
                        {
                            answer[asd] = array[asd];
                        }
                        
                        if (lastmaxindex + 1 == asd)
                        {
                            afterlst = true;
                            answer[asd] = P;
                        }

                    }
                }
                else
                {
                    answer = new int[array.Length+1];
                    for (int i = 0; i < (answer.Length - 1); i++)
                    {
                        answer[i] = array[i];
                    }

                    answer[^1] = P;
                }
            }
            else
            {
                answer = array;
            }

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;
            bool nexstp = false;
            bool positive = false;
            int  minpoz = 1;
            int countdel = 0;
            for (int i = 0; i < array.Length ; i++)
            {
                
                if (array[i] > 0 && !nexstp)
                {
                    positive = true;
                    minpoz = i;
                    nexstp = true;
                }
                if (array[i] > 0 && nexstp  && array[i] < array[minpoz])
                {
                    minpoz = i;
                }
            }
            if (positive == true)
            {
                int ccount = 0;
                answer = new int[array.Length-1];
                for (int i = 0; i < (array.Length); i++)
                {
                    
                    if (i != minpoz)
                    {
                        answer[ccount] = array[i];
                        ccount++;
                    }
            
                }
            }
            else
            {
                answer = array;
            }

            return answer;
        }
        public void Task4(double[] array)
        {
            double avgsum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                avgsum += array[i];
            }
            avgsum /= array.Length;
            for (int i = 0 ; i < array.Length; i++)
            {
                array[i] -= avgsum;
            }
            
            

        }
        public int Task5(int[] A, int[] B)
        {
            int len = 0;
            int sum = 0;
            int lenA = A.Length;
            int lenB = B.Length;
           
            if (lenA == lenB)
            {
                len = lenA;
            }
            for (int i = 0; i < len; i++)
            {
                sum += A[i] * B[i];
            }

            return sum;
        }

        public int[] Task6(int[] array)
        {
            int ccount = 0;
            double avgsum = 0;
            int[] indexes = null;
            for (int i = 0; i < array.Length; i++)
            {
                avgsum += array[i];
                
            }
            avgsum /= array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avgsum)
                {
                    ccount++;
                }
            }

            indexes = new int[ccount];
            int cntindx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < avgsum)
                {
                    indexes[cntindx] = i;
                    cntindx++;
                }
            }


        return indexes;
        }
        public int Task7(int[] array)
        {

                int count = 1;
                int maxxing = 1;
                int minning = 1;
                for (int i = 0; i < array.Length-1; i++)
                {
                    if (array[i] >= array[i + 1])
                    {
                        minning++;
                        
                    }
                    else
                    {
                        minning = 1;
                    }

                    if (array[i] <= array[i + 1])
                    {
                        maxxing++;
                    }
                    else
                    {
                        maxxing = 1;
                    }
                    int maxlen = Math.Max(maxxing,minning);
                    count = Math.Max(count, maxlen);
                    
                }

                return count ;
            }
        public int[] Task8(int[] array)
        {
            int[] answer = null;
            int ccount = 0;
            answer = new int[array.Length * 2];
            for (int i = 0; i < answer.Length; i += 2)
            {
                answer[i] = array[ccount];
                answer[i + 1] = array[ccount];
                ccount++;
            }

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double xmax = -99999999;
            double xmin = 999999999;
            double[] normalized = null;
            for (int i = 0; i < array.Length; i++)
            {
                
                xmax = Math.Max(xmax, array[i]);
                xmin = Math.Min(xmin, array[i]);
            }
            
            bool notsame = false;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    notsame = true;
                }
            }
         if (notsame)
         {
             normalized = new double[array.Length];
                for (int i = 0; i < normalized.Length; i++)
                {
                    normalized[i] = (array[i] - xmin) / (xmax - xmin);
                }

                return normalized;
                
                    
         }
         else
         {
             return normalized;
         }
            
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;
            int n =  array.Length;
            while (index < n)
            {
                if (index == 0 || array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    int temp = array[index];
                    array[index] = array[index - 1];
                    array[index - 1] = temp;
                    index--;
                }
            }

            int right = array.Length - 1;
            int left = 0;
            
            index = -1;
            while (left <= right)
            {
                int mid = (right + left) / 2;
                if (array[mid] == P)
                {
                    index = mid;
                    break;
                }
                if (array[mid] < P)
                {
                    left = mid + 1;
                }

                if (array[mid] > P)
                {
                    right = mid - 1;
                }

                

            }

            return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            bool stop = false;
            int[] array = null;
            int asd = a;
            int ccount = 0;
            if (b < 0)
            {
                stop = true;
            }

            if (a > c && !stop)
            {
                array = new int[0];
                stop = true;
            }

            if (!stop)
            {
                array = new int[((Math.Abs(c - a)) / b) + 1];
                while (asd <= c)
                {
                    array[ccount] = asd;
                    ccount++;
                    asd += b;
                }
            }


            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;
            switch (magazine.Length)
            {
                case 3:
                    indexes = new int[3];
                    indexes[0] = 0;
                    indexes[1] = 1;
                    indexes[2] = 2;
                    return indexes;
                case 2:
                    indexes = new int[2];
                    indexes[0] = 0;
                    indexes[1] = 1;
                    return indexes;
                case 1:
                    indexes = new int[1];
                    indexes[0] = 0;
                    return indexes;
                default:
                    indexes = new int[3];
                    indexes[0] = 0;
                    indexes[1] = 1;
                    indexes[2] = 2;
                    break;
            }

            int maxsum = 0;
            for (int i = 1; i < magazine.Length - 1; i++)
            {
                int maxrooms = magazine[i-1] + magazine[i] + magazine[i+1];
                if (maxrooms > maxsum)
                {
                    maxsum = maxrooms;
                    indexes[0] = i-1;
                    indexes[1] = i;
                    indexes[2] = i+1;
                }
            }

            return indexes;
        }
    }
}
