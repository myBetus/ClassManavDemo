using System;
using System.Collections.Generic;
using System.Text;

namespace ClassManavDemo
{
    class MeyveManager
    {
        public void MeyveEkle(Meyve meyve)
        {
            Console.WriteLine("MEYVE EKLENDİ");
            Console.WriteLine("EKLENEN MEYVENİN ÖZELLİĞİ,ADI VE FİYATI : "+meyve.Ozellik+ " "+ meyve.MeyveAdi+" "+ meyve.Fiyat );
        }
        public void MeyveSil(Meyve meyve)
        {
            Console.WriteLine("MEYVE EKLENDİ");
            Console.WriteLine("SİLİNNEN MEYVENİN ÖZELLİĞİ,ADI VE FİYATI : " + meyve.Ozellik + " " + meyve.MeyveAdi + " " + meyve.Fiyat);
        }
        
       
        public void MeyveListele(Meyve [] meyves)
        {
            Console.WriteLine("MEYVELER LİSTELENİYOR...");
            foreach (var meyve in meyves)
            {

                Console.WriteLine(meyve.Ozellik + " " + meyve.MeyveAdi + " " + meyve.Fiyat);
            }
            
        }
    }
}
