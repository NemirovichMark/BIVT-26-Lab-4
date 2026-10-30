using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int min = -1; 
            int max = int.MinValue;
            int inx = 0;
            int sum = 0;

            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    min = i;
                    break;
                }
            }

            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    inx = i;
                }
            }

          
            for (int i = inx + 1; i < array.Length; i++)
            {
                sum += array[i];
            }

         
            if (min != -1)
            {
                array[min] = sum;
            }


        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int LPS = -1;

            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    LPS = i;
                }
            }

            if (LPS == -1)
            {
                
                return array;
            }

            
            answer = new int[array.Length + 1];

            
            for (int i = 0; i <= LPS; i++)
            {
                answer[i] = array[i];
            }

            answer[LPS + 1] = P;

            
            for (int i = LPS + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }

           
            

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = new int[array.Length-1];

            // code here
            int min = int.MaxValue,mm=-1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        mm = i;
                    }


                }// end
            }

            if (min == int.MaxValue)
            {

                return array;
            }
            else {
                for (int i = 0, j = 0; i < array.Length ; i++)
                {
                    if (i != mm)
                    {
                        answer[j++] = array[i];
                    }
                }

            }
            return answer;
        }
        public void Task4(double[] array)
        {
            double sum = 0,z=0;
            for (int i = 0; i < array.Length; i++) {
                sum += array[i];
            }
            z = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                array[i]-= z;
            }
            

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;
            if (A.Length != B.Length) {
                return sum;
            }
            
            
            for (int i = 0; i < Math.Min(A.Length,B.Length); i++) {

                sum += A[i] * B[i];
            
            }
            
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = sum / array.Length;
            int count = 0;
            for (int i = 0; i < array.Length; i++) if (array[i] < avg) count++;
            int[] indexes = new int[count];

            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (array[i] < avg) indexes[j++] = i;
            }
       
            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;
            int max = 1;
            int inc = 1;
            int dec = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] >= array[i])
                {
                    inc++;
                }
                else
                {
                    inc = 1;
                }

                if (array[i + 1] <= array[i])
                {
                    dec++;
                }
                else
                {
                    dec = 1;
                }

                int currentMax = inc > dec ? inc : dec;
                if (currentMax > max)
                {
                    max = currentMax;
                }
            }

            count = max;
            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = new int[array.Length * 2];
            int j = 0;
            for (int i = 0; i < array.Length ; i++) {

                answer[j]=array[i];
                answer[j+1]=array[i];
                j += 2;
            }
            // code here

            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = new double[array.Length]; ;

            int min = array[0];
            int max = array[0];

            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            if (min == max)
            {
                return null;
            }

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = -1;
            for (int i = 0; i < array.Length-1; i++) {

                for (int j = 0; j < array.Length - 1 - i; j++) {
                    if (array[j] > array[j+1]) { 
                    int temp=array[j];
                        array[j] = array[j+1];
                        array[j+1]= temp;
                    
                    
                    }
                
                
                }
            
            }
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                index = left + (right - left) / 2;

                if (array[index] == P)
                {
                    return index; 
                }
                else if (array[index] < P)
                {
                    left = index + 1;
                }
                else
                {
                    right = index - 1;
                }
            }

            return -1;
        }
        public int[] Task11(int a, int b, int c)
        {
            if (b <= 0)
            {
                return null;
            }

            int count = 0;
            long temp = a;

            while (temp <= c)
            {
                count++;
                temp += b;
            }

            int[] array = new int[count];
            long current = a;

            for (int i = 0; i < count; i++)
            {
                array[i] = (int)current;
                current += b;
            }


            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = new int[3];
            if (magazine == null)
            {
                return null;
            }

            if (magazine.Length <= 3)
            {
                int[] shortIndexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    shortIndexes[i] = i;
                }
                return shortIndexes;
            }

            int bestStartIndex = 0;
            long maxsum = 0;
            for (int i = 0; i < 3; i++)
            {
                maxsum += magazine[i];
            }

            long currentSum = maxsum;

            for (int i = 1; i <= magazine.Length - 3; i++)
            {
                currentSum = currentSum - magazine[i - 1] + magazine[i + 2];

                if (currentSum > maxsum)
                {
                    maxsum = currentSum;
                    bestStartIndex = i;
                }
            }

            indexes = new int[3] { bestStartIndex, bestStartIndex + 1, bestStartIndex + 2 };
            return indexes;
        }
    }
}
