using System.Collections.Generic;

class Program
{
    static void Main(string[]args)
    {
        // şnt tipinde liste
        List<int> sayiListesi = new List<int>();
        //Listeye eleman ekleme
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(5);
        sayiListesi.Add(91);
        sayiListesi.Add(45);

        //String tipinde liste 
        List<string> renkListesi = new List<string>();
        //Listeye eleman ekleme
        renkListesi.Add("Kırmızı");
        renkListesi.Add("Sarı");
        renkListesi.Add("Siyah");
        renkListesi.Add("Turuncu");


        //Count
        System.Console.WriteLine(renkListesi.Count);
        System.Console.WriteLine(sayiListesi.Count);
        //Listeleri ekrana yazdırmak
        foreach (var item in renkListesi)
        {
            System.Console.WriteLine(item);
        }
        foreach (var item in sayiListesi)
        {
            System.Console.WriteLine(item);
        }

        //Farklı tipte foreach yazımı ve liste elemanlarının ekrana yazdırılması

        sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
        renkListesi.ForEach(renk=> Console.WriteLine(renk));
        

        //Listeden eleman çıkartma

        sayiListesi.Remove(91);
        renkListesi.Remove("Turuncu");


        //İndex numarasıyla listeden eleman çıkartma

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(2);


        //Liste İçerisinde arama
        if(sayiListesi.Contains(10))
        {
            System.Console.WriteLine("10 Liste içerisinde bulundu!");
        }

        //Eleman İle index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Sarı"));

        //Diziyi listeye çevirme
        string[] hayvanlar = {"Kedi","Köpek","Tavşan","Sincap"};
        List<string> havlanlarList = new List<string>(hayvanlar);

        //Listeyi nasıl temizleriz??
        havlanlarList.Clear();

        //Liste içerisinde NEsne tutmak
        List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
        Kullanicilar kullanicilar1 = new Kullanicilar();
        kullanicilar1.Isım="Hakkı";
        kullanicilar1.Soyisim="Ayman";
        kullanicilar1.Yas=26;

        Kullanicilar kullanicilar2 = new Kullanicilar();
        kullanicilar2.Isım="Lina";
        kullanicilar2.Soyisim ="Ayman";
        kullanicilar2.Yas =2;

        kullaniciListesi.Add(kullanicilar1);
        kullaniciListesi.Add(kullanicilar2);

        List<Kullanicilar> yeniListe = new List<Kullanicilar>();
        yeniListe.Add(new Kullanicilar()
        {
            Isım="Deniz",
            Soyisim="Arda",
            Yas =25
        });
        
        //Kullanıcılar sınıfının içindeki elemanlara erişme
        foreach (var item in kullaniciListesi)
        {
            System.Console.WriteLine("Kullanıcı Adı: "+item.Isım);
            System.Console.WriteLine("Kullanıcı Soyisim: "+item.Soyisim);
            System.Console.WriteLine($"Kullanıcı Yaş: {item.Yas}");
        }
        
        //Kullanıcı Listesini temizlemek

        yeniListe.Clear();


    }
}

public class Kullanicilar
{
    string isim;
    string soyisim;
    int yas;

    public string Isım{get => isim; set => isim = value;}
    public string Soyisim{get=> soyisim; set  => soyisim = value;}
    public int Yas {get =>yas; set =>yas = value;}
}


// List<T> class
//System.Collections.Generic