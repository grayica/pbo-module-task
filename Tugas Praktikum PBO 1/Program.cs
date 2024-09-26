using System;
using System.Collections.Generic;

// Kelas Hewan
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    // Menggunakan this untuk kejelasan
    public Hewan(string nama, int umur)
    {
        this.Nama = nama;
        this.Umur = umur;
    }

    // Parafrase pada teks yang dikembalikan oleh Suara()
    public virtual string Suara()
    {
        return "Hewan ini memiliki suara";
    }

    // Menambahkan sedikit variasi dalam format InfoHewan()
    public virtual string InfoHewan()
    {
        return $"Nama hewan: {Nama}, Umur: {Umur} tahun";
    }
}

// Kelas Mamalia yang mewarisi Hewan
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    // Menggunakan this untuk properti
    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.JumlahKaki = jumlahKaki;
    }

    // Parafrase teks yang dikembalikan
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Kaki berjumlah: {JumlahKaki}";
    }
}


// Kelas Reptil yang mewarisi Hewan
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    // Penambahan this untuk penjelasan eksplisit
    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.PanjangTubuh = panjangTubuh;
    }

    // Parafrase informasi
    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang tubuh: {PanjangTubuh} meter";
    }
}


// Kelas Singa yang mewarisi Mamalia
public class Singa : Mamalia
{
    public Singa(string nama, int umur) : base(nama, umur, 4) { }

    // Teks suara diperjelas
    public override string Suara()
    {
        return "Singa mengeluarkan auman!";
    }

    // Parafrase Mengaum()
    public void Mengaum()
    {
        Console.WriteLine($"{Nama} sedang mengeluarkan auman keras!");
    }
}


// Kelas Gajah yang mewarisi Mamalia
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur) : base(nama, umur, 4) { }

    // Suara diperjelas
    public override string Suara()
    {
        return "Gajah mengeluarkan suara deruman!";
    }
}

// Kelas Ular yang mewarisi Reptil
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    // Suara Ular diperjelas
    public override string Suara()
    {
        return "Ular mengeluarkan desisan!";
    }

    // Parafrase pada Merayap()
    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang bergerak merayap.");
    }
}

// Kelas Buaya yang mewarisi Reptil
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    // Parafrase suara buaya
    public override string Suara()
    {
        return "Buaya menggeram keras!";
    }
}


// Kelas KebunBinatang
public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    // Parafrase untuk menambahkan hewan
    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    // Parafrase method untuk menampilkan daftar hewan
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
        // Buat objek KebunBinatang
        KebunBinatang kebunBinatang = new KebunBinatang();

        // Buat objek berbagai jenis hewan
        Singa singa = new Singa("Singa", 5);
        Gajah gajah = new Gajah("Gajah", 10);
        Ular ular = new Ular("Ular", 3, 2.5);
        Buaya buaya = new Buaya("Buaya", 7, 3.2);

        // Menambahkan hewan-hewan tersebut ke KebunBinatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Tampilkan daftar hewan
        kebunBinatang.DaftarHewan();

        // Polymorphism untuk suara
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        // Panggil method khusus
        singa.Mengaum();
        ular.Merayap();
    }
}
