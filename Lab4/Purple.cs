namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
             if (array == null || array.Length == 0)
            {
                return;
            }
            double m = array[0];
            double mIndex = 0;
            double s = 0;
            double mid = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (array[i] > m)
                {
                    m = array[i];
                    mIndex = i;
                }
            }
            mid = s / array.Length;
            for (double j = (mIndex + 1); j < array.Length; j++)
            {
                array[(int)j] = mid;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array == null)
            {
                return (new int[0], new int[0]);
            }
            
            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];
            int evenI = 0;
            int oddI = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[evenI] = array[i];
                    evenI++;
                }
                else
                {
                    odd[oddI] = array[i];
                    oddI++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                return new int[0];
            }
            
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            
            double mid = (double)sum / array.Length;
            int cI = 0;
            double cD = Math.Abs(array[0] - mid);
            
            for (int j = 1; j < array.Length; j++)
            {
                if (Math.Abs(array[j] - mid) < cD)
                {
                    cD = Math.Abs(array[j] - mid);
                    cI = j;
                }
            }
            
            answer = new int[array.Length + 1];
            
            for (int k = 0; k < array.Length; k++)
            {
                if (k <= cI)
                {
                    answer[k] = array[k];
                }
                else
                {
                    if (k == cI + 1)
                    {
                        answer[k] = P;
                        answer[k + 1] = array[k];
                    }
                    else
                    {
                        answer[k + 1] = array[k];
                    }
                }
            }
            
            if (cI == array.Length - 1)
            {
                answer[array.Length] = P;
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null)
            {
                return;
            }
            
            int[] answer = new int[array.Length];
            int aI = 0;
            
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] >= 0)
                {
                    answer[aI] = array[j];
                    aI++;
                }
            }
            
            for (int k = 0; k < array.Length; k++)
            {
                if (array[k] < 0)
                {
                    answer[aI] = array[k];
                    aI++;
                }
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = answer[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A == null || B == null)
            {
                return null;
            }
            
            if (k < 0 || k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                return answer;
            }
            
            answer = new int[A.Length + B.Length];
            int curI = 0;
            
            for (int i = 0; i < k; i++)
            {
                answer[curI] = A[i];
                curI++;
            }
            
            for (int i = 0; i < B.Length; i++)
            {
                answer[curI] = B[i];
                curI++;
            }
            
            for (int i = k; i < A.Length; i++)
            {
                answer[curI] = A[i];
                curI++;
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null || A.Length != B.Length)
            {
                return (null, null);
            }
            
            int l = A.Length;
            sum = new int[l];
            dif = new int[l];
            
            for (int i = 0; i < l; i++)
            {
                sum[i] = A[i] + B[i];
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
                return new double[0];
            }
            bool flag = true;
            int first = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (first != array[i])
                {
                    flag = false;
                    break;
                }
            }
            
            if (flag)
            {
                return null;
            }
            
            normalized = new double[array.Length];
            int min = array[0];
            int max = array[0];
            
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            
            int range = max - min;
            
            for (int k = 0; k < array.Length; k++)
            {
                double a1 = (double)(array[k] - min) / range * 2 - 1;
                normalized[k] = a1;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null || B == null)
            {
                return new int[0];
            }
            
            if (A.Length == 0 && B.Length == 0)
            {
                return new int[0];
            }
            
            int[] sortedA = new int[A.Length];
            
            for (int i = 0; i < A.Length; i++) sortedA[i] = A[i];
            
            int[] sortedB = new int[B.Length];
            
            for (int i = 0; i < B.Length; i++) sortedB[i] = B[i];
            
            for (int i = 1; i < sortedA.Length; i++)
            {
                int key = sortedA[i];
                int j = i - 1;
            
                while (j >= 0 && sortedA[j] < key)
                {
                    sortedA[j + 1] = sortedA[j];
                    j--;
                }
            
                sortedA[j + 1] = key;
            }
            
            for (int i = 1; i < sortedB.Length; i++)
            {
                int key = sortedB[i];
                int j = i - 1;
            
                while (j >= 0 && sortedB[j] < key)
                {
                    sortedB[j + 1] = sortedB[j];
                    j--;
                }
            
                sortedB[j + 1] = key;
            }
            
            C = new int[sortedA.Length + sortedB.Length];
            int iA = 0;
            int iB = 0;
            int iC = 0;
            
            while (iA < sortedA.Length && iB < sortedB.Length)
            {
                if (sortedA[iA] >= sortedB[iB])
                {
                    C[iC] = sortedA[iA];
                    iA++;
                }
                else
                {
                    C[iC] = sortedB[iB];
                    iB++;
                }
                iC++;
            }
            
            while (iA < sortedA.Length)
            {
                C[iC] = sortedA[iA];
                iA++;
                iC++;
            }
            
            while (iB < sortedB.Length)
            {
                C[iC] = sortedB[iB];
                iB++;
                iC++;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
            {
                return;
            }
            
            int max = array[0];
            int maxI = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxI = i;
                }
            }
            
            if (maxI == 0)
            {
                return;
            }
            int[] temp = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                int newI = (i + maxI) % array.Length;
                temp[newI] = array[i];
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (array == null || array.Length == 0 || N < 1 || N > array.Length)
            {
                return;
            }
            
            int nI = N - 1;
            int elLeft = N - 1;
            
            for (int i = 1; i <= elLeft; i++)
            {
                if (nI + i >= array.Length)
                {
                    break;
                }
            
                array[nI + i] = array[nI - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n < 1 || a > b || (a == b && n != 1))
            {
                return (null, null);
            }
        
            double step = 0;
            if (n > 1)
            {
                step = (b - a) / (n - 1);
            }
        
            X = new double[n];
            Y = new double[n];
        
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
        
            double[] tempX = new double[n];
            double[] tempY = new double[n];
            int extC = 0;
        
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    tempX[extC] = X[i];
                    tempY[extC] = Y[i];
                    extC++;
                }
            }
        
            if (extC > 0)
            {
                Xext = new double[extC];
                Yext = new double[extC];
                for (int i = 0; i < extC; i++)
                {
                    Xext[i] = tempX[i];
                    Yext[i] = tempY[i];
                }
            }
            else
            {
                Xext = new double[0];
                Yext = new double[0];
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw == null || raw.Length == 0)
            {
                return (new double[0], new double[0], new double[0]);
            }
            
            int brCount = 0, diCount = 0, nCount = 0, rCount = 0;
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double mid = sum / raw.Length;
            double hL = mid * 2;
            double lL = mid / 2;
            
            double[] tempBr = new double[raw.Length];
            double[] tempN = new double[raw.Length];
            double[] tempDi = new double[raw.Length];
            int[] normalIndices = new int[raw.Length];
            double[] removedVals = new double[raw.Length];
            
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > hL)
                {
                    tempBr[brCount++] = raw[i];
                }
                else if (raw[i] < lL)
                {
                        tempDi[diCount++] = raw[i];
                }
                else
                {
                    tempN[nCount++] = raw[i];
                    normalIndices[rCount] = i;
                    rCount++;
                }
            }
            
            double sum1 = 0;
            for (int i = 0; i < nCount; i++)
            {
                sum1 += tempN[i];
            }
            double mid1 = (nCount > 0) ? (sum1 / nCount) : 0;
            double[] finalN = new double[raw.Length];
            int fNIndex = 0;
            int nPtr = 0;
            
            for (int i = 0; i < raw.Length; i++)
            {
                if (nPtr < rCount && normalIndices[nPtr] == i)
                {
                    finalN[fNIndex++] = raw[i];
                    nPtr++;
                }
                else
                {
                    finalN[fNIndex++] = (mid1 + raw[i]) / 2.0;
                }
            }
            
            normal = new double[fNIndex];
            for (int i = 0; i < fNIndex; i++)
            {
                normal[i] = finalN[i];
            }
            
            for (int i = 1; i < normal.Length; i++)
            {
                double key = normal[i];
                int j = i - 1;
                while (j >= 0 && normal[j] < key)
                {
                    normal[j + 1] = normal[j];
                    j--;
                }
                normal[j + 1] = key;
            }
            
            bright = new double[brCount];
            for (int i = 0; i < brCount; i++)
            {
                bright[i] = tempBr[i];
            }
            
            dim = new double[diCount];
            for (int i = 0; i < diCount; i++)
            {
                dim[i] = tempDi[i];
            }
            // end

            return (bright, normal, dim);
        }
    }
 }
