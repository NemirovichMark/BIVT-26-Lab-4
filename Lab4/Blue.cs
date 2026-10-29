using System.Runtime.InteropServices;

namespace Lab4
{
    public class Blue
    {
        public void Task1(int[] array)
        {
            int max = int.MinValue;
            int maxind = -1;
            
            int negind = -1;
            int sum = 0;

            for (int i = 0; i < array.Length; i++) {if (array[i] < 0) {negind = i; break; } }
            for (int i = 0; i < array.Length; i++) {if (array[i] > max) {max = array[i]; } }
            for (int i = 0; i < array.Length; i++) {if (array[i] == max) {maxind = i; break; } }
            
            if (negind == -1) {return; }
            
            if (maxind != (array.Length - 1))
            {
                for (int i = maxind + 1; i < array.Length; i++) {sum += array[i]; }
            }
            
            array[negind] = sum;
            // code here

            // end

        }
        public int[] Task2(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            int posind = -1;

            // code here
            for (int i = 0; i < array.Length; i++) {if (array[i] > 0) {posind = i; } } // last positive
            
            if (posind == -1) {return array;}

            int cnt = 0;
            for (int i = 0; i < posind + 1; i++) { answer[i] = array[i]; cnt++; }

            answer[posind + 1] = P;
            for (int i = cnt + 1; i < answer.Length; i++) { answer[i] = array[i - 1]; cnt++; }
            
            // end

            return answer;
        }
        public int[] Task3(int[] array)
        {
            int[] answer = new int[array.Length - 1];
            int minpos = int.MaxValue;
            int posind = -1;
            
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0 && array[i] < minpos) {minpos = array[i]; posind = i;}
            } 
            
            if (posind == -1) {return array;}

            int cnt = 0;
            for (int i = 0; i < posind; i++) { answer[i] = array[i]; cnt++; }
            for (int i = posind; i < answer.Length; i++) { answer[i] = array[cnt + 1]; cnt++; }
            // end

            return answer;
        }
        public void Task4(double[] array)
        {
            double rsum = 0;
            
            // code here
            for (int i = 0; i < array.Length; i++) { rsum += array[i]; }
            rsum /= array.Length;
            for (int i = 0; i < array.Length; i++) { array[i] -= rsum; }
            // end

        }
        public int Task5(int[] A, int[] B)
        {
            int sum = 0;

            if (A.Length != B.Length)
            {
                return 0;
            }
            
            // code here
            for (int i = 0; i < Math.Min(A.Length, B.Length); i++) { sum += (A[i] * B[i]); }
            // end

            return sum;
        }
        public int[] Task6(int[] array)
        {
            int[] indexes = null;
            double rsum = 0;

            // code here
            for (int i = 0; i < array.Length; i++) { rsum += array[i]; }
            rsum /= array.Length;

            int cnt = 0;
            for (int i = 0; i < array.Length; i++) {if (array[i] < rsum) {cnt++;}}

            indexes = new int[cnt];
            
            cnt = 0;
            for (int i = 0; i < array.Length; i++) {if (array[i] < rsum) {indexes[cnt] = i; cnt++;}}
            // end

            return indexes;
        }
        public int Task7(int[] array)
        {
            int maxc = array.Length > 0 ? 1:0;
            int up = 1;
            int down = 1;

            // code here
            for (int i = 1; i < array.Length; i++)
            {
                up = array[i] >= array[i - 1] ? up + 1 : 1;
                down = array[i] <= array[i - 1] ? down + 1 : 1;
                
                if (Math.Max(up, down) > maxc) {maxc = Math.Max(up, down); }
            }
            // end

            return maxc;
        }
        public int[] Task8(int[] array)
        {
            int[] answer = new int[array.Length * 2];

            // code here
            int cnt = 0;
            for (int i = 0; i < array.Length; i++) {answer[cnt] = array[i]; cnt++; answer[cnt] = array[i]; cnt++;}
            // end

            return answer;
        }
        public double[] Task9(int[] array)
        {
            double[] normalized = new double[array.Length];
            int max = int.MinValue;
            int min = int.MaxValue;

            // code here
            for (int i = 0; i < array.Length; i++) {if (array[i] > max) {max = array[i]; } }
            for (int i = 0; i < array.Length; i++) {if (array[i] < min) {min = array[i]; } }

            if (max == min) {return null; }
            
            for (int i = 0; i < array.Length; i++) {normalized[i] = (max - min) != 0 ? (array[i] - (double)min) / (max - min) : 0; }
            // end

            return normalized;
        }
        public int Task10(int[] array, int P)
        {
            int answer = -1;

            // code here
            if (array == null || array.Length == 0)
                return -1;
            
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
            
            int left = 0;
            int right = array.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == P)
                {
                    answer = mid;
                    break;
                }
                else if (array[mid] < P)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            // end

            return answer;
        }

        public int[] Task11(int a, int b, int c)
        {
            int[] array = null;

            // code here
            if (b > 0)
            {
                int cnt = a <= c ? (c - a) / b + 1 : 0;

                array = new int[cnt];
                for (int i = 0; i < cnt; i++)
                {
                    array[i] = a + i * b;
                }
            }
            // end

            return array;
        }


        public int[] Task12(int[] magazine)
        {
            int[] indexes = null;

            // code here
            if (magazine != null)
            {
                int n = magazine.Length;

                if (n < 3)
                {
                    indexes = new int[n];
                    for (int i = 0; i < n; i++)
                        indexes[i] = i;
                }
                else
                {
                    int bestStart = 0;
                    int sum = magazine[0] + magazine[1] + magazine[2];
                    int bestSum = sum;

                    for (int i = 1; i <= n - 3; i++)
                    {
                        sum = sum - magazine[i - 1] + magazine[i + 2];

                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestStart = i;
                        }
                    }

                    indexes = new int[] { bestStart, bestStart + 1, bestStart + 2 };
                }
            }
            // end

            return indexes;
        }

    }
}
