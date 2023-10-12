using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Halo, dunia!");

        int angka = 10;
        double desimal = 20.0;
        string teks = "Ini adalah string";
        bool logika = true;

        Console.WriteLine("Angka: " + angka);
        Console.WriteLine("Desimal: " + desimal);
        Console.WriteLine("Teks: " + teks);
        Console.WriteLine("Logika: " + logika);

// Materi class
        Console.WriteLine("Halo, dunia!");

        MyClass objek = new MyClass();
        objek.SetAngka(10);
        int angka = objek.GetAngka();

        Console.WriteLine("Angka: " + angka);
// If
        if (angka > 5)
        {
            Console.WriteLine("Angka lebih besar dari 5");
        }
        else
        {
            Console.WriteLine("Angka tidak lebih besar dari 5");
        }
// perulangan
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }
    }
}

Tentu, berikut adalah contoh kode C# yang mencakup fungsi dan kelas:

```csharp
using System;


class MyClass
{
    private int angka;

    public void SetAngka(int angka)
    {
        this.angka = angka;
    }

    public int GetAngka()
    {
        return this.angka;
    }
}

