using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        
        {

            // code here
            int a = -1,b=0,bmax=-10000;
            
            for (int i = 0; i < array.Length; i++)
            {
                
                
                if (array[i] < 0)
                {
                    a = i;
                    break;
                }
                
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > bmax)
                {
                    bmax = array[i];
                    b = i;

                }
            }

            int sum = 0;
            for (int i = b+1; i < array.Length; i++)
            {
                sum += array[i];
                
            }

            if (b == array.Length - 1)
            {
                sum = 0;
            }

            if (a>=0)
            {
                
                array[a] = sum;
            }

            

            // end

        }
        
        public int[] Task2(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int maxvalue = -10000, maxindex=0;
            
            int[] array2=new int[array.Length+1];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
                if (array[i] > 0)
                {
                    maxvalue = array[i];
                    maxindex = i;
                }
                
            }

            if (maxvalue > 0)
            {
                array2[maxindex + 1] = P;
            }
            else
            {
                return array;
            }

            for (int i = maxindex+1; i < array.Length; i++)
            {
                array2[i+1]=array[i];
            }
            
            
            return array2;
            
            // end

            
        }
        public int[] Task3(int[] array)
        {
            int[] answer = null;

            // code here
            if (array.Length == 0)
            {
                return new int[0];
            }
            
            int minvalue = int.MaxValue;
            int minindex=-1;
            
            int[] array2 = new int[array.Length-1];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minvalue)
                {
                    minvalue = array[i];
                    minindex = i;
                }
            }

            if (minindex != -1)
            {


                for (int i = 0; i < array.Length; i++)
                {
                    if (i == minindex)
                    {
                        break;
                    }

                    array2[i] = array[i];
                }

                for (int i = minindex + 1; i < array.Length; i++)
                {


                    array2[i - 1] = array[i];
                }
            }

            if (minindex==-1)
            {
                return array;
            }
            else
            {
                return array2;
            }
            
                
            // end

            
        }
        public void Task4(double[] array)
        {

            // code here
            double cred = 0;
            if (array.Length != 0)
            {
                

                for (int i = 0; i < array.Length; i++)
                {
                    cred += array[i];
                }
                cred /= array.Length;
            }



            for (int i = 0; i < array.Length; i++)
            {
                array[i] -= cred;
                
                
            }
            // end

        }

        public int Task5(int[] A, int[] B)
        {


            // code here
            int scar = 0;
            if (A.Length == B.Length)
            {
            

                for (int i = 0; i < A.Length; i++)
                {
                    scar += A[i] * B[i];
                }
            }
            

            return scar;
            // end

            
        }
        public int[] Task6(int[] array)
        {
            
            
            // code here
            double sred = 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sred += array[i];
            }
            sred/= array.Length;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                {
                    sum += 1;
                }
            }
            int[] indexes = new int[sum];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < sred)
                {
                    indexes[j] = i;
                    j++;
                }
            }
            return indexes;
            // end

            
        }
        public int Task7(int[] array)
        {
            // code here
            int count = 0, count2=1;
            
            
            for (int i = 0; i < array.Length-1; i++)
            {
                
                if (array[i] - array[i + 1]>=0)
                {
                    count2++;
                    if (count2 > count)
                    {
                        count = count2;
                    }

                }
                else
                {
                    count2 = 1;
                    
                }
            }

            count2 = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                
                if (array[i] - array[i + 1] <= 0)
                {
                    count2++;
                    if (count2 > count)
                    {
                        count = count2;
                    }

                }
                else
                {
                    
                    count2 = 1;
                }
            }
            if (array.Length == 1)
            {
                return 1;
            }
            

            return count;
            // end
        }
        public int[] Task8(int[] array)
        {
            // code here
            int[] answer = new int[array.Length*2];

            
            for (int i = 0; i < array.Length; i++)
            {
                answer[i*2]=array[i];
                answer[i*2+1]=array[i];
                
            }
            

            return answer;
            // end
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = new double[array.Length];

            // code here
            double minvalue = array.Min();
            double maxvalue = array.Max();
            if (minvalue != maxvalue)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (array[i] - minvalue)/(maxvalue - minvalue);
                
                }
                
            }
            else
            {
                return null;
            }
             // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int mid=0,left=0,right=array.Length-1;

            // code here
            Array.Sort(array);
            
            while(left<=right){
                mid = (left + right) / 2;
                if (P > array[mid])
                {
                    left = mid+1;
                }

                else if (P < array[mid])
                {
                    right = mid-1;
                }

                else 
                {
                    return mid;
                    
                }
                
            }

            return -1;
            // end


        }
        public int[] Task11(int a, int b, int c)
        {
            
            // code here
            if ( b <= 0)
            {
                return null;
            }

            if (a > c)
            {
                return new int[0];
            }
            
            int aa = a,count=1;
            
            while (aa+b <= c)
            {
                aa += b;
                count++;
            }

            
            int[] array = new int[count];
            array[0] = a;
            for (int i = 1; i < array.Length; i++)
            {
                array[i]=array[i-1]+b;
            }
            
            
            return array;
            // end
        }

        public int[] Task12(int[] magazine)
        {
            // code here

            if (magazine.Length <3)
            {
                int[] indexes = new int[magazine.Length];
                for (int i = 0; i < magazine.Length; i++)
                {
                    indexes[i] = i;
                }
                return indexes;
                
            }
            
            
            int[] indexes1 = new int[3];
            
            
            

            int maxsum = -1;
            
            for (int i = 0; i < magazine.Length-2; i++)
            {
                if ((magazine[i] + magazine[i + 1] + magazine[i + 2]) > maxsum)
                {
                    maxsum = magazine[i] + magazine[i + 1] + magazine[i + 2];
                    indexes1[0] = i;
                    indexes1[1] = i+1;
                    indexes1[2] = i+2;
                    
                }
            }
            
            

            return indexes1;
            // end
        }
    }
}