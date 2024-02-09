




using Business.Concrete;
using Entities.Concrete;

SelamVer(isim: "Doğukan"); ;
SelamVer(isim:"Ahmet");
SelamVer(isim:"Ayşe");
SelamVer();

Topla();
Person person1 = new Person();
person1.FirstName = "Doğukan";
person1.LastName = "Bozkır";
person1.DateOfBirthYear = 1996;
person1.NationalIdentity = 123;

Person person2 = new Person();
person2.FirstName = "Ahmet";




string[] ogrenciler = new string[3];
ogrenciler[0] = "Doğukan";
ogrenciler[1] = "Muhammed";
ogrenciler[2] = "Ahmet";

for (int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);

}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };


sehirler2 = sehirler1;
sehirler1[0] = "Adana";
Console.WriteLine(sehirler2[0]);


foreach (var sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

List<string> yeniSehirler1 = new List<string> { "Ankara1", "İzmir1", "İstanbul1" };
yeniSehirler1.Add(item: "Diyarbakır");

foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);

}


PTTManager pttManager = new PTTManager(new PersonManager());
pttManager.GiveMask(person1);


static void SelamVer(string isim = "İsimsiz")
{
    Console.WriteLine("Merhaba " + isim);
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine("Toplam : " + sonuc);
    return sonuc;
    

}

