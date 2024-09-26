using System;
using System.Collections.Generic;

// Kelas Hewan
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

// Kelas Mamalia yang mewarisi Hewan
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

// Kelas Reptil yang mewarisi Hewan
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

// Kelas Singa yang mewarisi Mamalia
public class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Singa mengaum!";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengaum!");
    }
}

// Kelas Gajah yang mewarisi Mamalia
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }

    public override string Suara()
    {
        return "Gajah menderum!";
    }
}

// Kelas Ular yang mewarisi Reptil
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Ular mendesis!";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap.");
    }
}

// Kelas Buaya yang mewarisi Reptil
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya menggeram!";
    }
}

// Kelas KebunBinatang
public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

// Program utama
public class Program
{
    public static void Main()
    {
        // Membuat objek KebunBinatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Membuat objek berbagai jenis hewan
        Singa singa = new Singa("Singa", 5);
        Gajah gajah = new Gajah("Gajah", 10);
        Ular ular = new Ular("Ular", 3, 2.5);
        Buaya buaya = new Buaya("Buaya", 7, 3.2);

        // Menambahkan hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Menampilkan daftar hewan
        kebunBinatang.DaftarHewan();

        // Demonstrasi polymorphism dengan method Suara
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        // Panggil method khusus seperti Mengaum untuk Singa dan Merayap untuk Ular
        singa.Mengaum();
        ular.Merayap();
    }
}
