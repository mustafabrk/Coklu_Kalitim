using System;
interface Karakter
{

    void changeHasar(int a);
    void changeDayaniklilik(int a);
    void changeCeviklik(int a);
    void printStates();
}

interface Zirh
{

    void changeDefans(int b);
    void printStates_1();
}

interface Silah
{

    void changeSaldiri(int c);
    void printStates_2();
}

class Savascı : Karakter
{
    int Dayaniklilik;
    int Hasar;
    int Ceviklik;

    public void changeHasar(int newHasar)
    {

        Hasar = newHasar;
    }

    public void changeDayaniklilik(int newDayaniklilik)
    {

        Dayaniklilik = newDayaniklilik;
    }

    public void changeCeviklik(int newCeviklik)
    {

        Ceviklik = newCeviklik;
    }

    public void printStates()
    {
        Console.WriteLine("Dayaniklilik Degeri: " + Dayaniklilik + " Hasar Degeri: " + Hasar + " Ceviklik Degeri: " + Ceviklik);
    }
}

class Kask : Zirh
{
    int Defans;

    public void changeDefans(int newDefans)
    {

        Defans = newDefans;
    }

    public void printStates_1()
    {
        Console.WriteLine("Zirhin Savunma Degeri: " + Defans);
    }
}

class Balta : Silah
{
    int Saldiri;

    public void changeSaldiri(int newSaldiri)
    {

        Saldiri = newSaldiri;
    }

    public void printStates_2()
    {
        Console.WriteLine("Silahin Hasar Degeri: " + Saldiri);
    }
}

class ARAYUZ
{

    public static void Main(String[] args)
    {
        Savascı savascı = new Savascı();
        Karakter krktr;
        krktr = savascı;
        krktr.changeHasar(4);
        krktr.changeDayaniklilik(5);
        krktr.changeCeviklik(8);
        Console.WriteLine("Karakter Ozellikleri:");
        krktr.printStates();

        Kask kask = new Kask();
        Zirh obj;
        obj = kask;
        obj.changeDefans(3);
        Console.WriteLine("Zirh Ozellikleri:");
        obj.printStates_1();

        Balta balta = new Balta();
        Silah obj1;
        obj1 = balta;
        obj1.changeSaldiri(4);
        Console.WriteLine("Silah Ozellikleri:");
        obj1.printStates_2();
    }
}
