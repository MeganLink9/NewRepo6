using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Zavdan_12_6()
        {

            /*
             * Дан двумерный массив. Вывести на экран:
                а) все элементы второго столбца массива;
                б) все элементы m-й строки массива.
             */

            int N, M;
            Console.WriteLine("Введите количество строк массива ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива ");
            M = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N, M];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i, j] = r.Next(100);
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Все элементы второго столбца массива: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 1; j < 2; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Введите m - строку все элементы которой вы хотите вывести ");
            int s;
            s = Convert.ToInt32(Console.ReadLine());
            for (int i = s - 1; i < s; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.ReadKey();
        }

        static void Zavdan_12_30()
        {
            /*
             * 12.30.*Дан двумерный массив размером 9*9
                Построить последовательность
                чисел, получающуюся при чтении этого массива по спирали (см. задачу 12.29).
             */

            const int n = 9;
            const int m = 9;
            int[,] matrix = new int[n, m];

            int row = 0;
            int col = 0;
            int dx = 1;
            int dy = 0;
            int dirChanges = 0;
            int visits = m;

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[row, col] = i + 1;
                if (--visits == 0)
                {
                    visits = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }

                col += dx;
                row += dy;
            }


        }

        static void Zavdan_12_54()
        {
            /*
             * В двумерном массиве хранится информация о количестве студентов в той
                или иной группе каждого курса института с первого по пятый (в первом
                столбце — информация о группах первого курса, во втором — второго и т. д.).
                На каждом курсе имеется 8 групп. Определить среднее число студентов
                в одной группе на третьем курсе.
             */

            int sum = 0;
            int[,] arr = new int[5, 8];
            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                    arr[i, j] = rnd.Next(1, 10);
            Console.WriteLine("The original matrix:");
            Console.WriteLine(arr);
            Console.Write("Enter course number: ");
            int k = int.Parse(Console.ReadLine());
            for (int j = 0; j < arr.GetLength(1); j++)
                sum += arr[k - 1, j];
            Console.WriteLine("Number of students: {0}", sum);
            Console.ReadKey();

        }

        static void Zavdan_12_78()
        {
            /*
            *Дан двумерный массив. Найти:
                а) число пар одинаковых соседних элементов в каждой строке;
                б) число пар одинаковых соседних элементов в каждом столбце.
            */


            int[,] nums3 = new int[3, 3] { { 0, 1, 1 }, { 2, 2, 2 }, { 3, 4, 4 } };

            int pair = 0;
            int pair_2 = 0; 
            int row_number = 3;
            int colum_number = 3;

            //A
            for (int row = 0; row < row_number; row++)
            {
                for (int colum = 0; colum < colum_number - 1; colum++)
                {
                    if (nums3[row, colum] == nums3[row, colum + 1])
                        pair++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"а) число пар одинаковых соседних элементов в каждой строке {pair}");

            //Б

            for (int colum = 0; colum < colum_number - 1; colum++)
            {
                for (int row = 0; row < row_number; row++)
                {
                    if (nums3[row, colum] == nums3[row, colum + 1])
                        pair_2++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"б) число пар одинаковых соседних элементов в каждом столбце {pair_2}");

        }

        static void Zavdan_12_102()
        {
            /*
             * Дан двумерный массив из двух строк и двадцати столбцов. Найти макси-
                мальную сумму элементов в двух соседних столбцах.
             */

            int[,] arr = new int[2, 20];

            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    arr[i, j] = random.Next(100);
                    Console.Write("{0,4}", arr[i, j] );
                }
                Console.WriteLine();
            }

            int maxsum = 0;
            for (int k = 0; k < 19; k++)
            {
                int sum = arr[k, 1] + arr[k, 2];
                if (maxsum < sum) maxsum = sum;
            }
            Console.WriteLine($"Максимальная сума елементов соседних столбцов {maxsum}");
        }

        static void Zavdan_12_126()
        {
            /*
             * Составить программу, определяющую, верно ли, что сумма элементов
                столбца массива с известным номером кратна заданному числу.
             */


            Random rnd = new Random();
            Console.WriteLine("Введите количество строк, столбцов, номер столбца и делитель числа");
            int n = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine());
            int summ = 0, columnnum = int.Parse(Console.ReadLine()), divider = int.Parse(Console.ReadLine());
            if (columnnum >= m)
            {
                Console.WriteLine("Номер суммируемого столбца больше чем количество столбцов ({0}) в массиве. Введите номер заново", m);
                columnnum = int.Parse(Console.ReadLine());
            }
            int[,] arr = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rnd.Next(-1000, 1000);
                    Console.Write(arr[i, j] + " ");
                    if (j == columnnum - 1)
                    {
                        summ = summ + arr[i, columnnum - 1];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сумма элементов выбраного столбца: {0}", summ);
            if (summ % divider == 0)
            {
                Console.WriteLine("Сумма элементов выбранного столбца кратна {0}", divider);
            }
            else
            {
                Console.WriteLine("Сумма элементов выбранного столбца не кратна {0}", divider);
            }
            Console.ReadKey();
        }

        static void Zavdan_12_150()
        {
            /*
             * Дан двумерный массив целых чисел. Для каждого его столбца выяснить:
                а) имеются ли в нем элементы, большие некоторого числа d;
                б) имеются ли в нем нечетные элементы;
             */

            int N, M, d;
            Console.WriteLine("Введите количество строк массива ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива ");
            M = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[N, M];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i, j] = r.Next(100);
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(a[i, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Введите число d ");
            d = Convert.ToInt32(Console.ReadLine());

            int tit = 0;
            int row_number = N;
            int colum_number = M;

            //а) имеются ли в нем элементы, большие некоторого числа d;

            for (int row = 0; row < row_number; row++)
            {
                for (int colum = 0; colum < colum_number ; colum++)
                {
                    if (a[row, colum] >= d)
                        tit++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"а) имеются ли в нем элементы, большие некоторого числа {d}: {tit}");

            //  б) имеются ли в нем нечетные элементы;
            int odd = 0;

            for (int row = 0; row < row_number; row++)
            {
                for (int colum = 0; colum < colum_number; colum++)
                {
                    if (a[row, colum] % 2 != 0)
                        odd++;
                }
                Console.WriteLine();
            }
            Console.WriteLine($"б) имеются ли в нем нечетные элементы: {odd}");


        }


        static void Zavdan_12_198()
        {
            /*
             * К элементам k1-й столбца двумерного массива прибавить элементы k2-й
                столбца.
             */

            Console.Write("Введите количество строк m:\t");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов n:\t");
            int n = int.Parse(Console.ReadLine());
            int i, j;
            Random rand = new Random();
            int[,] mass = new int[m, n];
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(0, 20);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.Write("Введите номер столбца k1:\t");
            int k1 = int.Parse(Console.ReadLine()) - 1;
            Console.Write("Введите номер столбца k2:\t");
            int k2 = int.Parse(Console.ReadLine()) - 1;
            for (i = 0; i < m; i++)
            {
                mass[i, k1] += mass[i, k2];
            }
            Console.WriteLine("Новый массив:");
            for (i = 0; i < m; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }


        }

        static void Zavdan_12_222()
        {
            /*
             * Дан двумерный массив из четного числа строк. Поменять местами его стро-
                ки следующим способом: первую строку поменять с последней, вторую —
                с предпоследней и т. д.
             */


            int N, M, d;
            Console.WriteLine("Количество строк массива = 4");
            N = 4;
            Console.WriteLine("Введите количество столбцов массива ");
            M = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, M];
            Random r = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    array[i, j] = r.Next(100);
            Console.WriteLine();
            Console.WriteLine("Массив:");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < M; j++)
                    Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Новий масив: ");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                var tmp = array[3, i];
                array[3, i] = array[0, i];
                array[0, i] = tmp;

            }
            Console.WriteLine("Новий масив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }

        static void Zavdan_12_270()
        {

            /*
             * Напечатать строку, образованную символами, расположенными в четырех
                углах массива (в любом порядке).
             */
            Circle(25);
            Console.ReadKey();
        }

        static void Circle(int n)
        {
            for (int i = -n; i <= n; i++)
            {
                for (int j = -n; j <= n; j++)
                {
                    if (i * i + j * j <= n * n)
                        Console.Write("0");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }
        }



    }
}
