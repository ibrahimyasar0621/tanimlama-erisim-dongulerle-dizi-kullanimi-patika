namespace tanımlama_diziler_donguler;

class Program
{
    static void Main(string[] args)
    {
        // DİZİ TANIMLAMA
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi","köpek","kuş","maymun"};  //dizinin boyutu 4 ve hayvanlar adında string tipinde dizi tanımladım.

        int[] dizi;
        dizi= new int[5];               // dizinin boyutunu başta vermek zorunda değilim. burada diziyi sonradan 5 elemenlı olarak tanımladık


        // DİZİLERE DEĞER ATAMA VE ERİŞİM
        renkler[0] = "mavi";   // renkler dizisnin 0'ıncı elemanına mavi değerini atadık
        Console.WriteLine(hayvanlar[1]);  // hayvanlar dizisindeki 1'inci elemanı bana getir çıktı köpek olur
        dizi[3] = 10;
        Console.WriteLine(dizi[3]);     // Dizi dizisinin 3. elemanını getir
        Console.WriteLine(renkler[0]);   // çıktı= mavi olur.

        //DÖNGÜLERLE DİZİ KULLANIMI
        //Klavyeden giirlen N tane sayının ortalamasını veren program. Ben bir dizi oluşturacağım ve boyutunada konsoldan gelen vveri karar verecek. ve bu diziye atadığım değerlerin ortalamasını alayım.

        Console.WriteLine("Lütfen Dizinin Eleman sayısını girin :");
        int diziuzunlugu = int.Parse(Console.ReadLine());
        int [] sayıDizisi = new int[diziuzunlugu];  // Şuanda kosoldan girilen sayıya göre dizi aldım.

        for (int i = 0; i < diziuzunlugu; i++) // küçük eşit kullanmadık çünkü zaten mesela 5. eleman zaten 4. index oluyor. indexler 0 dan başlar.
        {
            Console.Write("Lütfen{0}. sayıyı giriniz :", i+1); // i+1 dedim çünkü kullanıcıya 0'ıncı sayıyı girin demek mantksız. kullanıcının ilk girdiği sayı onun için 1. sayıdır. o yüzden bunu ekrana 1 arttırıp yazdırıyoruz.
            sayıDizisi[i] = int.Parse(Console.ReadLine());
        }
        int toplam =0;
        foreach (var sayi in sayıDizisi)
            toplam += sayi;
        Console.WriteLine("Otalama :" + toplam/diziuzunlugu);    

    }
}
