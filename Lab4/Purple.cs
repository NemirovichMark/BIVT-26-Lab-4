using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Net.Http.Headers;
using System.Security;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double znmax = -111111111111111111;
            int indmax = -1;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]>znmax)
                {
                    znmax = array[i];
                    indmax = i;
                }
            } //максимальный элемент

            double sum = 0;
            for (int i=0; i<array.Length; i++)
            {
                sum=sum+array[i];
            } //сумма массива
            double sr = sum / array.Length;

            for (int i=0; i < array.Length; i++)
            {
                if (i>indmax)
                {
                    array[i] = sr;
                }
            }
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            int j = 0;
            int k = 0;
            if (array.Length%2==0)
            {
                even = new int[array.Length / 2];
                odd = new int[array.Length / 2];
            }
            else
            {
                even = new int[(array.Length / 2)+1];
                odd = new int[array.Length / 2];
            }
            for (int i=0; i<array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[j]= array[i];
                    j = j + 1;
                }
                else
                {
                    odd[k] = array[i];
                    k = k + 1;
                }
            }
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;
            double razn = 1000000000000;
            int ind = 0;
            double sum = 0;

            for (int i=0; i<array.Length;i++)
            {
                sum = sum + array[i];
            }
            double sr = sum / array.Length; 


            for (int i=0; i<array.Length; i++)
            {
                if ((Math.Abs(array[i] - sr)) < razn)
                {
                    razn = Math.Abs(array[i] - sr);
                    ind = i+1;
                }
            }


            answer = new int[array.Length + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                if (i < ind)
                {
                    answer[i] = array[i];
                }
                else if (i == ind)
                {
                    answer[i] = P;
                }
                else
                {
                    answer[i] = array[i-1];
                }

            }
                return answer;
        }
        public void Task4(int[] array)
        {
            int p = 0;
            int n = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    p = p + 1;
                }
                else
                {
                    n = n + 1;
                }

            } //поиск сколько положительных и отриц эл в массиве

            int[] pol = new int[p];
            int[] otr = new int[n];

            int j = 0;
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    pol[j] = array[i];
                    j = j + 1;
                }
                else
                {
                    otr[k]= array[i];
                    k = k + 1;
                } //положительные в pol, отрицательные в otr 
            }

            for (int i=0; i<pol.Length; i++)
            {
                array[i]= pol[i];
            }

            int y = 0;
            for (int i=pol.Length; i<array.Length; i++)
            {
                array[i]= otr[y];
                y = y + 1;
            }

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            if (k > A.Length)
                return A;

            int[] nA = new int[k];
            int[] kA = new int[A.Length-k];
            answer = new int[A.Length + B.Length];


            for (int i=0; i<k; i++)
            {
                nA[i]= A[i];
            }

            int p = 0;
            for (int i = k; i < A.Length; i++)
            {
                kA[p] = A[i];
                p++;
            }

            int h = 0;
            int j = 0;
            for (int i=0; i<answer.Length; i++)
            {
                if (i < k)
                    answer[i] = nA[i];
                else if ((i >= k) && (i < k + B.Length))
                {
                    answer[i] = B[j];
                    j++;
                }
                else
                {
                    answer[i] = kA[h];
                    h++;
                        
                }
            }
            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;
            int p = 1;
            for (int i=0; i<array.Length-1; i++)
            {
                if (array[i] != array[i+1])
                {
                    p = 0;
                    break;
                }
            } //проверка что элемнты не равны

            double elmin = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]<elmin)
                {
                    elmin = array[i];
                }
            } //поиск минимального элемента

            double elmax = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > elmax)
                {
                    elmax = array[i];
                }
            } //поиск максимального элемента

            if (p == 0)
            {
                normalized = new double[array.Length];
                for (int i=0; i<array.Length; i++)
                {
                    normalized[i] = 2*((array[i] - elmin) / (elmax - elmin)) - 1;
                }
            }
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;
            C= new int[A.Length+B.Length];
            int n1 = A.Length;
            int n2 = B.Length;
            for (int i=0; i<n1-1; i++)
            {
                bool swap = false;
                for (int j=0; j<(n1-i-1); j++)
                {
                    if (A[j] < A[j+1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                        swap= true;
                    }
                }
                if (swap == false)
                    break;
            } //сортировка массива A по убыванию


            for(int i=0; i<n2-1; i++)
            {
                bool swap = false;
                for (int j=0; j<n2-i-1; j++)
                {
                    if (B[j] < B[j+1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                        swap = true;
                    }
                }
                if (swap == false)
                    break;
            } //сортировка B по убыванию

            int r = 0;
            int a = 0;

            for (int i=0; i<C.Length; i++)
            {
                if (a < A.Length && (r == B.Length || A[a] >= B[r]))
                {
                    C[i] = A[a];
                    a++;
                }
                else
                {
                    C[i] = B[r];
                    r = r + 1;
                }    
            }
            
            return C;
        }
        public void Task9(int[] array)
        {
            int maxind = 0;
            int maxxn = int.MinValue;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > maxxn)
                {
                    maxind = i;
                    maxxn= array[i];
                }

            } //поиск индекса первого макс эмента 


            int[] nn= new int[maxind]; // массив для хран эл до maxind


            int p = maxind-1;
            for (int i = array.Length-1; p>=0; i--)
            {
                nn[p]=array[i];
                p--;
            } //запись вылетевших знач в одельный массив 

            for (int i = array.Length - 1; i >= maxind; i--)
            {
                array[i] = array[i - maxind];
            } //сдвиг массивов на инд


            for (int i = 0; i < nn.Length; i++)
            {
                array[i] = nn[i];
            }
        }

       
        public void Task10(int[] array, int N)
        {
            N= N - 1;
            for (int i=1; N-i>=0 && N+i<array.Length; i++)
            {
                array[N + i] = array[N-i];
            }
             

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            if (a > b || (a == b && n > 1))
            {
                return (null, null);
            }

            X = new double[n];
            Y = new double[n];
            double h = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * h;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int k = 0;
            for (int i = 1; i < n-1; i++)
            {
                if (((Y[i - 1])< Y[i] && (Y[i + 1]) < Y[i]) || ((Y[i - 1]) > Y[i] && (Y[i + 1]) > Y[i]))
                {
                    k = k + 1;
                }
            }

            Xext = new double[k];
            Yext = new double[k];

            int j = 0;
            for (int i = 1; i < n-1; i++)
            {
                if (((Y[i - 1]) < Y[i] && (Y[i + 1]) < Y[i]) || ((Y[i - 1]) > Y[i] && (Y[i + 1]) > Y[i]))
                {
                    Xext[j] = X[i];
                    Yext[j] = Y[i];
                    j++;
                }
            }
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;
            double sum = 0;
            double[] raw2 = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                raw2[i]= raw[i];
            } //raw2 - копия raw


            for (int i = 0; i < raw.Length; i++)
            {
                sum = sum + raw[i];
            }
            double sr = sum / raw.Length; //среднее значение до изм


            int k1 = 0;
            int k2 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > (sr * 2))
                {
                    k1++;
                }
                else if (raw[i] < (sr / 2))
                {
                    k2++;
                }
            }  //ищу сколько эмелентов в каждом массиве 

            bright = new double[k1];
            dim= new double[k2];
            normal= new double[raw.Length];



            int k = 0; //счетчик аномалий
            int u = 0;
            int y = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i]>(sr*2))
                {
                    bright[u] = raw[i];
                    u++;
                    raw[i] = 0;
                    k = k + 1;
                }
                else if (raw[i] < (sr / 2))
                {
                    dim[y] = raw[i];
                    y++;
                    raw[i] = 0;
                    k = k + 1;
                }
            } //закинул яркие в bright, на месте аномалий 0

            double sum2 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum2 = sum2 + raw[i];
            }
            double sr2 = sum2 / (raw.Length-k); //среднее значение после изм



            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i]==0)
                {
                    raw[i] = (raw2[i] + sr2) / 2;
                }
            } //заменыв пустот

            int n = raw.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool swap = false;
                for (int j = 0; j < (n - i - 1); j++)
                {
                    if (raw[j] < raw[j + 1])
                    {
                        (raw[j], raw[j + 1]) = (raw[j + 1], raw[j]);
                        swap = true;
                    }
                }
                if (swap == false)
                    break;
            } //сортировка массива raw по убыванию
            normal = raw;



            return (bright, normal, dim);
        }
    }
 }
