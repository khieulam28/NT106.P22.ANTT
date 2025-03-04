using System;

class SinhVien
{
    protected string mssv;
    protected string hoten;
    protected float diemtb;

    public SinhVien()
    {
        mssv = "";
        hoten = "";
        diemtb = 0;
    }

    public virtual void Nhap()
    {
        Console.Write("Nhap MSSV: ");
        mssv = Console.ReadLine();
        Console.Write("Nhap ho va ten: ");
        hoten = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        diemtb = float.Parse(Console.ReadLine());
    }

    public virtual void Xuat()
    {
        Console.WriteLine($"MSSV: {mssv}\nHo va ten: {hoten}\nDiem trung binh: {diemtb}");
    }
}

class MMT : SinhVien
{
    private float mon_mmt;

    public MMT() : base()
    {
        mon_mmt = 0;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem mon MMT: ");
        mon_mmt = float.Parse(Console.ReadLine());
    }
    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Diem trung binh: {(diemtb * 2 + mon_mmt) / 4}");
    }
}

class ATTT : SinhVien
{
    private float mon_attt;

    public ATTT() : base()
    {
        mon_attt = 0;
    }

    public override void Nhap()
    {
        base.Nhap();
        Console.Write("Nhap diem mon ATTT: ");
        mon_attt = float.Parse(Console.ReadLine());
    }

    public override void Xuat()
    {
        base.Xuat();
        Console.WriteLine($"Diem mon ATTT: {(diemtb * 2 + mon_attt) / 4}");
    }
}

class Program
{
    static void Main()
    {
        SinhVien sv1, sv2;
        int nganh;

        Console.Write("Sinh vien 1 thuoc nganh nao?(1:MMT, 2:ATTT): ");
        nganh = int.Parse(Console.ReadLine());
        sv1 = (nganh == 1) ? new MMT() : new ATTT();
        sv1.Nhap();

        Console.Write("Sinh vien 2 thuoc nganh nao?(1:MMT, 2:ATTT): ");
        nganh = int.Parse(Console.ReadLine());
        sv2 = (nganh == 1) ? new MMT() : new ATTT();
        sv2.Nhap();

        Console.WriteLine("Sinh vien 1");
        sv1.Xuat();

        Console.WriteLine("Sinh vien 2");
        sv2.Xuat();
    }
}
