namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double mx = array[0];
            int mxi = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (mx < array[i])
                {
                    mx = array[i];
                    mxi = i;
                }
            }
            s /= array.Length;
            for (int i = mxi + 1;  i < array.Length; i++)
            {
                array[i] = s;
            }
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            int e = 0, o = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) { e++; }
                else { o++; }
            }
            even = new int[e];
            odd = new int[o];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 0)
                {
                    e--;
                    even[e] = array[i];
                }
                else
                {
                    o--;
                    odd[o] = array[i];                    
                }
            }
            

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            double s = 0;
            for (int i = 0; i < array.Length; i++) { s+= array[i]; }
            s /= array.Length;
            int xd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[xd] - s) > Math.Abs(array[i] - s)) { xd = i; }
            }
            for (int i = 0; i <= xd; i++) { answer[i] = array[i]; }
            answer[xd + 1] = P;
            for (int i = xd + 2; i < answer.Length; i++) 
            { 
                answer[i] = array[i - 1]; 
            } 
            return answer;
        }
        public void Task4(int[] array)
        {
            int p = 0, m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    p++;
                }
                else
                {
                    m++;
                }
            }
            int[] plus = new int[p], minus = new int[m];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] >= 0)
                {
                    p--;
                    plus[p] = array[i];
                }
                else
                {
                    m--;
                    minus[m] = array[i];
                }
            }
            int c = 0;
            for (int i = 0; i < plus.Length; i++)
            {
                array[c] = plus[i];
                c++;
            }
            for (int i = 0; i < minus.Length; i++)
            {
                array[c] = minus[i];
                c++;
            }

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            k--;
            int[] answer = new int[A.Length + B.Length];
            for (int i = 0; i <= k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[i + k + 1] = B[i];
            }
            if (k == A.Length - 1)
            {
                return answer;
            }
            for (int i = k + 1; i < A.Length; i++)
            {
                answer[i + B.Length] = A[i];
            }

            return answer;
        }

        //public int[] Task5(int[] A, int[] B, int k)
        //{
        //    if (A == null || A.Length == 0) return B ?? new int[0];
        //    if (B == null || B.Length == 0) return A;

        //    int[] answer = new int[A.Length + B.Length];

        //    // СПЕЦИАЛЬНЫЙ СЛУЧАЙ: Если k <= 0, вставляем B в самое начало
        //    if (k <= 0)
        //    {
        //        // Сначала копируем весь массив B
        //        for (int i = 0; i < B.Length; i++)
        //        {
        //            answer[i] = B[i];
        //        }
        //        // Затем встык копируем весь массив A
        //        for (int i = 0; i < A.Length; i++)
        //        {
        //            answer[i + B.Length] = A[i];
        //        }
        //        return answer;
        //    }

        //    // СТАНДАРТНЫЙ СЛУЧАЙ: k > 0 (если k слишком большой, ограничиваем концом массива А)
        //    if (k > A.Length) k = A.Length;
        //    k--; // Переводим в индекс C#

        //    // 1. Копируем первую часть массива A (до k включительно)
        //    for (int i = 0; i <= k; i++)
        //    {
        //        answer[i] = A[i];
        //    }

        //    // 2. Вставляем массив B сразу после k-го элемента
        //    for (int i = 0; i < B.Length; i++)
        //    {
        //        answer[i + k + 1] = B[i];
        //    }

        //    // 3. Копируем оставшуюся часть массива A
        //    for (int i = k + 1; i < A.Length; i++)
        //    {
        //        answer[i + B.Length] = A[i];
        //    }

        //    return answer;
        //}

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
 }
