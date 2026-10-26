using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.Arm;
using System.Runtime.Intrinsics.X86;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {

            // code here
            int index=-1;
            for (int i  = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    index = i;
                    break;  
                }
            }
            int max = array[0];
            int max_index=0;
            for (int i = 1; i < array.Length; i++)
            
            {
                if (array[i]>max)
                {
                    max_index = i;
                    max = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(max_index<i)
                {
                    sum += array[i];
                }
            }
            if (index != -1)
            {
                array[index] = sum;
            }
            
            // end
            

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int[] NewArray = new int[n + 1];
            int lastposIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    lastposIndex = i;
                }
            }
            if (lastposIndex == -1)
            {
                int[] copy = new int[n];
                for (int i =0;  i < n; i++)
                {
                    copy[i] = array[i];
                }
                answer = copy;
                return answer;
            }
            for (int j = 0; j <= lastposIndex; j++)
            {
                NewArray[j] = array[j];
            }
            NewArray[lastposIndex + 1] = P;
            for (int k = lastposIndex +1 ; k<n; k++)
            {
                NewArray[k + 1] = array[k];
            }
            answer = NewArray;
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            
            int n = array.Length;
            int min = int.MaxValue;
            int[] newArray = new int[n - 1];
            int index = -1;
            for (int i = 0; i < n; i++)
            { 
                if (array[i]>0)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        index = i;
                    }
                }
            }
            if (index == -1)
            {
                int[] copy = new int[n];
                for (int i =0;  i < n; i++)
                {
                    copy[i] = array[i];
                }
                answer = copy;
                return answer;
            }
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index + 1; i<n; i++)
            {
                newArray[i-1] = array[i];
            }
            answer = newArray;
            // end

            return answer;
        }
        public void Task4(double[] array)
        {

            // code here
            double n = array.Length;
            double[] newArray = new double[array.Length];
            double avg = 0;
            double sum = 0;
            for (int i = 0; i < n; i++) 
            {
                sum += array[i];    
            }
            avg = sum / n;
            for (int i = 0; i<n; i++)
            {
                array[i] = array[i] - avg;
            }
            
            
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            // code here
        

            if (A.Length != B.Length)
            {
                return 0;
            }    
            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i] * B[i];
            }
            
            
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;

            // code here
            int n = array.Length;
            double avg = 0, sum = 0;


            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                
            }
            avg = sum / n;
            int count = 0;
            for (int i = 0; i < n; i ++)
            {
                if (array[i] < avg)
                {
                    count++;
                }
                
            }
            indexes = new int[count];
            int j = 0;
            for (int i = 0; i<n; i++)
            {
                if (array[i]<avg)
                {
                    indexes[j] = i;
                    j++;
                }
            }

            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int count = 0;

            // code here
            int n = array.Length;
            if (n == 0) return n;
            count = 1;
            int up = 1;
            int down = 1;
            for (int i = 1; i < n; i++)
            {
                if (array[i] >= array[i - 1])
                    up++;
                else
                    up = 1;
                if (array[i] <= array[i - 1])
                    down++;
                else
                    down = 1;
                if (up > count) count = up;
                if (down > count) count = down;

            }
            count = count;     
            // end

            return count;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            answer = new int[n * 2];
            for (int i = 0; i<n; i++)
            {
                answer[i * 2] = array[i];
                answer[i * 2 + 1]= array[i];
            }
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = null;

            // code here
            int n = array.Length;
            normalized= new double[n];
            int min = int.MaxValue; int max = int.MinValue;
            if (n == 0) return null;
            for (int i = 0; i<n;i++ )
            {
                if (array[i]> max) max = array[i];
                if (array[i]< min) min = array[i];
            }
            if (max == min) return null;
            for (int i = 0; i<n; i++)
            {
                normalized[i] = (double)(array[i] - min) / (max - min);
            }    

            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            int n = array.Length;
            int left = 0; int right = n - 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (array[mid] == P)
                {
                    return mid;
                }
                else if (array[mid] < P)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }

            }
                // end

                return index;
        }
        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b <= 0) return null;
            int count = 0;
            int current = a;
            while (current <= c)
            {   
                count++;
                current += b;
            }   
            if (count==0)
                return new int[0];

            int[] NewArray = new int[count];
            current = a;
            for (int i = 0; i<NewArray.Length; i++)
            {
                NewArray[i] = current;
                current += b;
            }

            array = NewArray;
            // end

            return array;
        }

        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            int n = magazine.Length;
            if (n == 0) return new int[0];
            if (n == 1) return new int[] { 0 };
            if (n == 2) return new int[] { 0, 1 };
            int currentSum = magazine[0] + magazine[1] + magazine[2];
            int MaxSum = currentSum;
            int Index = 0;
            for (int i = 1; i <= n - 3; i++)
            {
                currentSum = currentSum - magazine[i - 1] + magazine[i + 2];
                if (currentSum > MaxSum)
                {
                    MaxSum = currentSum;
                    Index = i;
                }
            }
            indexes = new int[3] { Index, Index + 1, Index + 2 };
            // end

            return indexes;
        }
    }
}