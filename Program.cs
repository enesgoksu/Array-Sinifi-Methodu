class Program
{
    static void Main(string[] args)
    {
        // Sort 
        int[] sayiDizisi = {23,12,4,86,72,3,11,17};
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);  // sırasız dizi

        Console.WriteLine("***********************");

        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        
        Console.WriteLine("***********************");
            
        // Clear

        Array.Clear(sayiDizisi,2,2);  // sayiDizisinin 2.indeksinden başlayarak 2 elemanı 0'lar.
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
            
        Console.WriteLine("***********************");

        // Reverse

        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);

        Console.WriteLine("***********************");

        // IndexOf

        Array.IndexOf(sayiDizisi,23);      // 23 sayısı kaçıncı indekste diye sorduk.
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        Console.WriteLine("***********************");

        // Resize
        Array.Resize<int>(ref sayiDizisi,9);  // int tipindeki sayiDizisi dizisinin boyutunu 9 yap
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);


        
            
        
        

    }
}