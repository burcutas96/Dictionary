﻿Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

Ogrenci.Add(134, "Tolga Demirer");
Ogrenci.Add(158, "Ümit Özkan");
Ogrenci.Add(115, "Kadir Aydemir");
Ogrenci.Add(174, "Cemal Çiftçi");

Console.Write("Öğrenci No Giriniz:");
int No = int.Parse(Console.ReadLine());

try
{
    //Eğer bu numarada kayıtlı öğrenci varsa o öğrencinin isim ve soyismi ekrana yazılır.
    Console.WriteLine(Ogrenci[No]);
}
catch
{
    Console.WriteLine("Öğrenci Bulunamadı.");
}



