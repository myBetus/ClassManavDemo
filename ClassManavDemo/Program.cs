using System;

namespace ClassManavDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Meyve meyve1 = new Meyve();
            meyve1.MeyveAdi = "Portakal";
            meyve1.Fiyat = 15;
            meyve1.Ozellik = "EKŞİ";

            Meyve meyve2 = new Meyve();
            meyve2.MeyveAdi = "Nar";
            meyve2.Fiyat = 20;
            meyve2.Ozellik = "KIPKIRMIZI";

            Meyve meyve3 = new Meyve();
            meyve3.MeyveAdi = "Elma";
            meyve3.Fiyat = 10;
            meyve3.Ozellik = "YEŞİL";

            Meyve[] meyveler = new Meyve[] { meyve1, meyve2, meyve3 };
            MeyveManager meyves =new  MeyveManager();
            meyves.MeyveEkle(meyve1);
            meyves.MeyveSil(meyve2);
            meyves.MeyveListele(meyveler);

        }
    }
}
