using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double maxelement = double.MinValue;
            bool flag = false;
            double elsumma = 0;
            foreach(double el in array)
            {
                elsumma += el;
                if (el > maxelement)
                {
                    maxelement = el;
                }
            }
            double srednee = elsumma / array.Length;
            for(int i = 0; i < array.Length; i++)
            {
                if (flag)
                {
                    array[i] = srednee;
                }
                else
                {
                    if (array[i]==maxelement)flag = true;
                }
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            // code here
            
            int evenCount = 0;
            int oddCount = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) evenCount++;
                else oddCount++;
            }
            int[] even = new int[evenCount];
            int[] odd = new int[oddCount];
            int lastEvenID = 0;
            int lastOddID = 0;

            for(int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[lastEvenID] = array[i];
                    lastEvenID++;
                }
                else
                {
                    odd[lastOddID] = array[i];
                    lastOddID++;
                }
            }
            
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length+1];
            double mostAvrg = double.MaxValue;
            double elsumm = 0;
            foreach(int el in array)
            {
                elsumm += el;
            }
            double avrg = elsumm / array.Length;
            int mostAvrgID = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(avrg - array[i]) < mostAvrg)
                {
                    mostAvrg = Math.Abs(avrg - array[i]);
                    mostAvrgID = i;
                } 
            }
            bool flag = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (i != mostAvrgID)
                {
                    if (!flag)
                    {
                        answer[i] = array[i];
                    }
                    else
                    {
                        answer[i+1]=array[i];
                    }
                }
                else
                {
                    answer[i] = array[i];
                    flag = true;
                    answer[i+1] = P;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int negativesCount = 0;
            int positivesCount = 0;
            foreach (int en in array)
            {
                if(en < 0)
                {
                    negativesCount++;
                }
                else
                {
                    positivesCount++;
                }
            }
            int[] negas = new int[negativesCount];
            int[] poses = new int[positivesCount];

            int lastneg = 0;
            int lastpos = 0;
            foreach(int en in array)
            {
                if(en<0) 
                {
                    negas[lastneg] = en;
                    lastneg++;
                }
                else
                {
                    poses[lastpos] = en;
                    lastpos++;
                }
            }
            int lastID = 0;
            for(int i = 0; i < poses.Length; i++)
            {
                array[i] = poses[i];
                lastID++;
            }
            for (int i = 0; i < negas.Length; i++)
            {
                array[lastID+i] = negas[i];
            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = new int[A.Length+B.Length];

            // code here
            if(k>A.Length)return A;

            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[k + i] = B[i];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[i + B.Length] = A[i];
            }

            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = new int[A.Length], dif = new int[A.Length];
            if(A.Length != B.Length)return(null,null);
            // code here
            for(int i = 0; i < A.Length; i++)
            {
                sum[i]=A[i]+B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return normalized;
            }

            int min = array[0];
            int max = array[0];
            bool allEqual = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
                if (array[i] != array[0]) allEqual = false;
            }
            if (allEqual)
            {
                return null;
            }
            normalized = new double[array.Length];


            for (int i = 0; i < array.Length; i++)
            {

                normalized[i] = 2.0 * (array[i] - min) / (max - min) - 1.0;
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = [.. A, .. B];

            // code here
            int i = 1;
            while (i < C.Length)
            {
                if (i == 0 || C[i] <= C[i - 1])
                {
                    i++;
                }
                else
                {
                    (C[i], C[i - 1]) = (C[i - 1], C[i]);
                    i--;
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {
            if (array == null || array.Length <= 1) return;
            int maxID = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxID])
                {
                    maxID = i;
                }
            }
            int[] temp = new int[maxID];
            for (int i = 0; i < maxID; i++)
            {
                temp[i] = array[array.Length - maxID + i];
            }
            for (int i = array.Length - maxID - 1; i >= 0; i--)
            {
                array[i + maxID] = array[i];
            }
            for (int i = 0; i < maxID; i++)
            {
                array[i] = temp[i];
            }
        }
        public void Task10(int[] array, int N)
        {

            // code here
            int nID = N - 1;
            int leftCount = nID;
            int rightCount = array.Length - N;

            int sideToReplace;
            if (leftCount < rightCount)
            {
                sideToReplace = leftCount;
            }
            else
            {
                sideToReplace = rightCount;
            }
            for (int i = 1; i <= sideToReplace; i++)
            {
                array[nID + i] = array[nID - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;
            // code here
            if (a > b) return (null, null);
            if (n < 3)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }
            if (a == b) return (null, null);

            X = new double[n];
            Y = new double[n];

            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * (b - a) / (n - 1);
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int extCount = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    extCount++;
                }
            }

            Xext = new double[extCount];
            Yext = new double[extCount];

            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[k] = X[i];
                    Yext[k] = Y[i];
                    k++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double average = sum / raw.Length;

            int brightCount = 0;
            int dimCount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * average)
                    brightCount++;
                else if (raw[i] < average / 2)
                    dimCount++;
            }

            bright = new double[brightCount];
            dim = new double[dimCount];

            double[] tempNormal = new double[raw.Length];
            bool[] isRemoved = new bool[raw.Length];

            int brID = 0;
            int dimID = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * average)
                {
                    bright[brID] = raw[i];
                    brID++;
                    isRemoved[i] = true;
                }
                else if (raw[i] < average / 2)
                {
                    dim[dimID] = raw[i];
                    dimID++;
                    isRemoved[i] = true;
                }
                else
                {
                    tempNormal[i] = raw[i];
                }
            }

            double normalSum = 0;
            int normalCount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (!isRemoved[i])
                {
                    normalSum += raw[i];
                    normalCount++;
                }
            }

            double newAverage = 0;
            if (normalCount > 0)
                newAverage = normalSum / normalCount;

            for (int i = 0; i < raw.Length; i++)
            {
                if (isRemoved[i])
                {
                    tempNormal[i] = (newAverage + raw[i]) / 2.0;
                }
            }
            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                normal[i] = tempNormal[i];
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - 1 - i; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j+1], normal[j]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
