using System;
/// <summary>
/// BÀI TẬP DIEM
/// </summary>
class Diem
{
    private double x;
    private double y;
    public Diem() { x = 0; y = 0; }
    public Diem(double x, double y)
    {
        this.x = x;
        this.y = y;
    }
    public void nhap()
    {
        Console.Write("Nhap toa do x:");
        x = double.Parse(Console.ReadLine());

        Console.Write("Nhap toa do y:");
        y = double.Parse(Console.ReadLine());
    }
    public void hienThi()
    {
        Console.WriteLine($"Toa do diem: ({x}, {y})");
    }

    public double khoangCach(Diem d2)
    {
        double khoangCach = Math.Sqrt(Math.Pow(x - d2.x, 2) + Math.Pow(y - d2.y, 2));
        return khoangCach;
    }
    public static void Bai1()
    {
        Console.WriteLine("Nhap toa do diem thu nhat: ");
        Diem diem1 = new Diem();
        diem1.nhap();
        diem1.hienThi();
       
        Console.WriteLine("Nhap toa do diem thu hai: ");
        Diem diem2 = new Diem();
        diem2.nhap();
        diem2.hienThi();
       
        double khoangCach = diem1.khoangCach(diem2);
        Console.WriteLine($"Khoang cach giua diem1 va diem2 la: {khoangCach}");
        Console.ReadLine();
    }
}
/// <summary>
/// BÀI TẬP EMPLOYEE
/// </summary>
public class Employee
{
    private int id;
    private string name;
    private int yearOfBirth;
    private double salaryLevel;
    private double basicSalary;
    public Employee(int id, string name, int yearOfBirth, double salaryLevel, double basicSalary)
    {
        this.id = id;
        this.name = name;
        this.yearOfBirth = yearOfBirth;
        this.salaryLevel = salaryLevel;
        this.basicSalary = basicSalary;
    }
    public int getId()
    {
        return id;
    }
    public string getName()
    {
        return name;
    }
    public int getYearOfBirth()
    {
        return yearOfBirth;
    }
    public double getIncome()
    {
        return salaryLevel * basicSalary;
    }
    public void display()
    {
        Console.WriteLine("Ma: " + getId());
        Console.WriteLine("Ho Ten: " + getName());
        Console.WriteLine("Nam sinh: " + getYearOfBirth());
        Console.WriteLine("Luong co ban: " + basicSalary);
        Console.WriteLine("Thu nhap: " + getIncome());
    }
    public void setSalaryLevel(double salaryLevel)
    {
        this.salaryLevel = salaryLevel;
    }
    public void setBasicSalary(double basicSalary)
    {
        this.basicSalary = basicSalary;
    }
    public static void Bai2()
    {
        Employee employee = new Employee(1, "Nguyen Luong bang", 2004, 5.0, 19100000.0);
        employee.display();
        employee.setSalaryLevel(6.0);
        Console.WriteLine("Thu nhap thuc: " + employee.getIncome());
    }
}
/// <summary>
/// BÀI TẬP MA TRẬN
/// </summary>
class MaTran
{
    private int hang, cot;
    private int[,] matran;
    public void nhap()
    {
        Console.Write("Nhap so hang: ");
        hang = int.Parse(Console.ReadLine());
        Console.Write("Nhap so cot: "); 
        cot = int.Parse(Console.ReadLine());
        matran = new int[hang, cot];
        
        Console.WriteLine("Nhap thong tin cho cac phan tu cua ma tran");
        for (int i = 0; i < hang; ++i)
            for (int j = 0; j < cot; ++j)
            {
                Console.Write("matran[{0},{1}]=", i, j);
                matran[i, j] = int.Parse(Console.ReadLine());
            }
    }
    public void print()
    {
        for (int i = 0; i < hang; ++i)
        {
            for (int j = 0; j < cot; ++j)
                Console.Write("{0}\t", matran[i, j]);
            Console.WriteLine();
        }
    }
    public MaTran Tong(MaTran t2)
    {
        if (this.hang == t2.hang && this.cot == t2.cot)
        {
            MaTran t = new MaTran();
            t.hang = this.hang;
            t.cot = this.cot;
            t.matran = new int[this.hang, this.cot];

            for (int i = 0; i < t.hang; ++i)
                for (int j = 0; j < t.cot; ++j)
                    t.matran[i, j] = this.matran[i, j] + t2.matran[i, j];
            return t;
        }
        else return null;
    }
    public MaTran Hieu(MaTran t2)
    {
        if (this.hang == t2.hang && this.cot == t2.cot)
        {
            MaTran t = new MaTran();
            t.hang = this.hang;
            t.cot = this.cot;
            t.matran = new int[this.hang, this.cot];

            for (int i = 0; i < t.hang; ++i)
                for (int j = 0; j < t.cot; ++j)
                    t.matran[i, j] = this.matran[i, j] - t2.matran[i, j];
            return t;
        }
        else return null;
    }
    public MaTran doiDau()
    {
        MaTran t = new MaTran();
        t.hang = this.hang;
        t.cot = this.cot;
        t.matran = new int[this.hang, this.cot];
        for (int i = 0; i < t.hang; ++i)
            for (int j = 0; j < t.cot; ++j)
                t.matran[i, j] = -this.matran[i, j];
        return t;
    }
    public MaTran chuyenVi()
    {
        MaTran t = new MaTran();
        t.hang = this.hang;
        t.cot = this.cot;
        t.matran = new int[this.hang, this.cot];
        for (int i = 0;i < t.hang; ++i)
            for(int j = 0;j < t.cot; ++j)
                t.matran[i, j] += this.matran[j, i];
        return t;
    }
    public MaTran Tich(MaTran t2)
    {
        if (this.hang == t2.cot)
        {
            MaTran t = new MaTran();
            t.hang = this.hang;
            t.cot = this.cot;
            t.matran = new int[this.hang, this.cot];
            for (int i = 0; i < t.hang; ++i)
                for (int j = 0; j < t.cot; ++j)
                    for (int k = 0; k < cot; ++k)
                        t.matran[i, j] += matran[i, k] * t2.matran[k, j];
            return t;
        }
        else return null;
    } 
    public  bool tuongThich(MaTran t2)
    {
        return this.cot == t2.hang;
    }
    public bool maTranVuong()
    {
        return hang == cot;
    }
    public static void Bai4()
    {
        Console.WriteLine("Nhap thong tin cho ma tran thu nhat");
        MaTran t1 = new MaTran();
        t1.nhap();

        Console.WriteLine("Nhap thong tin cho ma tran thu nhat");
        MaTran t2 = new MaTran();
        t2.nhap();

        MaTran t3 = t1.Tong(t2);

        if (t3 == null)
            Console.WriteLine("Hai ma tran co kich thuoc khac nhau, ko tinh tong dc");
        else
        {
            Console.WriteLine("---Thong tin cua ma tran tong---");
            t3.print();
        }
        Console.ReadKey();
        Console.Clear();
      
        MaTran t4 = t1.Hieu(t2);

        if (t4 == null)
            Console.WriteLine("Hai ma tran co kich thuoc khac nhau, ko tinh hieu dc");
        else
        {
            Console.WriteLine("---Thong tin cua ma tran hieu---");
            t4.print();
        }
        Console.ReadKey();
        Console.Clear();
       
        MaTran t5 = t1.Tich(t2);
        
        if (t5 == null)
        { Console.WriteLine("Hai ma tran kich thuoc khac nhau, khong tinh tich duoc"); }
        else
        {
            Console.WriteLine("---Thong tin cua ma tran tich---");
            t5.print();
        }
        Console.ReadKey();
        Console.Clear();
       
        MaTran t7 = t1.chuyenVi();
       
        Console.WriteLine("Ma tran t1 sau khi chuyen vi la: ");
        t7.print();
        Console.ReadKey();
        Console.Clear();
       
        MaTran t6 = t1.doiDau();
       
        Console.WriteLine("Ma tran t1 sau khi doi dau la: ");
        t6.print();
        Console.ReadKey();
        Console.Clear();
        
        Console.WriteLine("---Ktra su tuong thich giua 2 ma tran---");
        bool kt = t1.tuongThich(t2);
        if (!kt) Console.Write("Hai ma tran khong tuong thich");
        else Console.WriteLine("Hai ma tran hoan toan tuong thich");
       
        Console.WriteLine("---Ktra ma tran vuong---");
        if (t1.maTranVuong()) Console.Write("Ma tran t1 là ma tran vuong");
        else Console.Write("Ma tran t1 khong phai ma tran vuong");        
    }
}
/// <summary>
/// PHÂN SỐ
/// </summary>
class PhanSo
{
    private int ts;
    private int ms;
    public PhanSo() { ts = 0; ms = 1; }
    public PhanSo(int ts, int ms)
    {
        this.ts = ts;
        this.ms = ms;
    }
    public void nhap()
    {
        Console.Write("Nhap tu so:"); 
        ts = int.Parse(Console.ReadLine());
        Console.Write("Nhap mau so:");
        ms = int.Parse(Console.ReadLine());
    }
    public void print()
    {
        if (ms == 1) Console.WriteLine("{0}", ts);
        else Console.WriteLine("{0}/{1}", ts, ms);
    }
    public int ucln(int x, int y)
    {
        x = Math.Abs(x); y = Math.Abs(y);
        while (x != y)
        {
            if (x > y) x = x - y;
            if (y > x) y = y - x;
        }
        return x;
    }
    public PhanSo rutGon()
    {
        int uoc = ucln(this.ts, this.ms);
        this.ts = this.ts / uoc;
        this.ms = this.ms / uoc;
        return this;
    }
    public PhanSo Cong(PhanSo ps2)
    {
        PhanSo ps = new PhanSo();
        ps.ts = this.ts * ps2.ms + this.ms * ps2.ts;
        ps.ms = this.ms * ps2.ms;
        return ps.rutGon();

    }
    public PhanSo Tru(PhanSo ps2)
    {
        PhanSo ps = new PhanSo();
        ps.ts = this.ts * ps2.ms - this.ms * ps2.ts;
        ps.ms = this.ms * ps2.ms;
        return ps.rutGon();
    }
    public PhanSo congSoNguyen(int n)
    {
        PhanSo ps = new PhanSo(n, 1);
        return this.Cong(ps);
    }

    public PhanSo truSoNguyen(int n)
    {
        PhanSo ps = new PhanSo(n, 1);
        return this.Tru(ps);
    }
    public void Print()
    {
        Console.WriteLine($"{ts}/{ms}");
    }
    public static void Bai5()
    {
        Console.WriteLine("Nhap thong tin cho phan so thu nhat");
        PhanSo ps1 = new PhanSo();
        ps1.nhap();

        Console.WriteLine("Nhap thong tin cho phan so thu hai");
        PhanSo ps2 = new PhanSo();
        ps2.nhap();
        Console.Clear();

        Console.WriteLine("---Tong 2 phan so---");
        PhanSo ps3 = ps1.Cong(ps2);
        ps3.Print();

        Console.WriteLine("---Hieu 2 phan so---");
        PhanSo ps4 = ps1.Tru(ps2);
        ps4.Print();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("---Cong phan so voi so nguyen---");
        PhanSo ps5 = ps1.congSoNguyen(1);
        ps5.Print();

        Console.WriteLine("---Tru phan so voi so nguyen---");
        PhanSo ps6 = ps1.truSoNguyen(1);
        ps6.Print();
    }
}
/// <summary>
/// SỐ PHỨC
/// </summary>
class ComplexNumber
{
    private double pthuc, pao;
    public ComplexNumber()
    {
        pthuc = 0;
        pao = 0;
    }
    public ComplexNumber(double thuc, double ao)
    {
        this.pthuc = thuc;
        this.pao = ao;
    }
    public ComplexNumber(ComplexNumber sp2)
    {
        this.pthuc = sp2.pthuc;
        this.pao = sp2.pao;
    }
    public void nhap()
    {
        Console.Write("Nhap phan thuc:"); 
        pthuc = double.Parse(Console.ReadLine());
        Console.Write("Nhap phan ao:"); 
        pao = double.Parse(Console.ReadLine());
    }
    public void print()
    {
        string kq = pthuc + (pao >= 0 ? "+" : "") + pao + "*i";
        Console.WriteLine(kq);
    }
    public static ComplexNumber operator +(ComplexNumber sp1, ComplexNumber sp2)
    {
        ComplexNumber tmp = new ComplexNumber();
        tmp.pthuc = sp1.pthuc + sp2.pthuc;
        tmp.pao = sp1.pao + sp2.pao;
        return tmp;
    }
    public ComplexNumber Tong(ComplexNumber t2)
    {
        ComplexNumber tmp = new ComplexNumber();
        tmp.pthuc = this.pthuc + t2.pthuc;
        tmp.pao = this.pao + t2.pao;
        return tmp;
    }
    public static ComplexNumber operator -(ComplexNumber sp1, ComplexNumber sp2)
    {
        ComplexNumber tmp = new ComplexNumber();
        tmp.pthuc = sp1.pthuc - sp2.pthuc;
        tmp.pao = sp1.pao - sp2.pao;
        return tmp;
    }
    public ComplexNumber Tru(ComplexNumber t2)
    {
        ComplexNumber tmp = new ComplexNumber();
        tmp.pthuc = this.pthuc - t2.pthuc;
        tmp.pao = this.pao - t2.pao;
        return tmp;
    }
    public static void Bai3()
    {
        Console.WriteLine("Nhap thong tin cho so phuc thu nhat");
        ComplexNumber sp1 = new ComplexNumber();
        sp1.nhap();

        Console.WriteLine("Nhap thong tin cho phan so thu hai");
        ComplexNumber sp2 = new ComplexNumber();
        sp2.nhap();

        Console.WriteLine("So phuc thu nhat"); sp1.print();
        Console.WriteLine("So phuc thu hai"); sp2.print();

        ComplexNumber sp3 = sp1.Tong(sp2);
        Console.WriteLine("So phuc tong"); sp3.print();

        ComplexNumber sp4 = sp1.Tru(sp2);
        Console.WriteLine("So phuc hieu"); sp4.print();
        Console.ReadLine();
    }
}
class Program
{
    static void Main()
    {
        Console.Write("Chon bai tap 1 - 5: ");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1: Diem.Bai1(); break;
            case 2: Employee.Bai2(); break;
            case 3: ComplexNumber.Bai3(); break;
            case 4: MaTran.Bai4(); break;
            case 5: PhanSo.Bai5(); break;
        }
    }
}