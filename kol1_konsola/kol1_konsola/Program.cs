using System.Security.Cryptography;
class Program
{
    static void Main(string[] args)
    {
        static int[] RandTab(int n, int a, int b)
        {
            int[] tab = new int[n];
            Random rand = new Random();
            b++;

            for (int i = 0; i < n; i++){
                tab[i] = rand.Next(a, b);
            }

            return tab;
        }

        static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j];
                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;
                    }
                }
            }
        }

        static void InsertSort(int[] tab)
        {
            int temp;
            for (int i = 1; i < tab.Length; i++)
            {
                int j = i;
                while(j > 0 && tab[j - 1] > tab[j])
                {
                    temp = tab[j];
                    tab[j] = tab[j - 1];
                    tab[j - 1] = temp;
                    j--;
                }
            }
        }

        static void MergeSort(int[] tab, int l, int p)
        {
            if (l < p)
            {
                int mid = (l + p) / 2;
                MergeSort(tab, l, mid);
                MergeSort(tab, mid + 1, p);
                Merge(tab, l, p, mid);
            }
        }

        static void Merge(int[] tab, int l, int p, int mid)
        {
            int lIndex = l, pIndex = mid + 1, mIndex = 0;
            int[] merged = new int[p - l + 1];

            while (lIndex <= mid && pIndex <= p)
            {
                if (tab[lIndex] <= tab[pIndex])
                {
                    merged[mIndex++] = tab[lIndex++];
                }
                else
                {
                    merged[mIndex++] = tab[pIndex++];
                }
            }

            while (lIndex <= mid)
            {
                merged[mIndex++] = tab[lIndex++];
            }

            while (pIndex <= p)
            {
                merged[mIndex++] = tab[pIndex++];
            }

            for (int i = 0; i < merged.Length; i++)
            {
                tab[l + i] = merged[i];
            }
        }




        static void QuickSort(int[] tab, int l, int p)
        {
            if (l < p)
            {
                int pivot = tab[(l + p) / 2];
                int index = Divide(tab, l, p, pivot);

                QuickSort(tab, l, index - 1);
                QuickSort(tab, index, p);
            }
        }

        static int Divide(int[] tab, int l, int p, int pivot)
        {
            while(l <= p)
            {
                while (tab[l] < pivot)
                {
                    l++;
                }

                while (tab[p] > pivot)
                {
                    p--;
                }

                if(l <= p)
                {
                    int temp = tab[l];
                    tab[l] = tab[p];
                    tab[p] = temp;

                    l++;
                    p--;
                }
            }
            return l;
        }

        static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int[] tab2 = new int[max + 1];

            for (int i = 0; i < tab.Length; i++)
            {
                tab2[tab[i]]++;
            }

            for(int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i] > 0)
                {
                    tab[j] = i;
                    j++;
                    tab2[i]--;
                }
            }

        }

        static void PrintTab(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i] + "  ");
            }
            Console.WriteLine();
        }


        Console.WriteLine("Tab: ");
        int[] tab = RandTab(8, 1, 11);
        PrintTab(tab);

        Console.WriteLine("Bubble sort: ");
        int[] tabBS = (int[])tab.Clone();
        BubbleSort(tabBS);
        PrintTab(tabBS);

        Console.WriteLine("Insert sort: ");
        int[] tabIS = (int[])tab.Clone();
        InsertSort(tabIS);
        PrintTab(tabIS);

        Console.WriteLine("Merge sort");
        int[] tabMS = (int[])tab.Clone();
        MergeSort(tabMS, 0, tab.Length - 1);
        PrintTab(tabMS);

        Console.WriteLine("Quick sort: ");
        int[] tabQS = (int[])tab.Clone();
        QuickSort(tabQS, 0, tab.Length - 1);
        PrintTab(tabQS);

        Console.WriteLine("Counting sort: ");
        int[] tabCS = (int[])tab.Clone();
        CountingSort(tabCS);
        PrintTab(tabCS);

    }
}